using System;
using System.Windows.Forms;

namespace MyIMDB
{
    public partial class FSerie : Form
    {

        private Boolean esAlta = false;
        private Serie serie = null;

        public FSerie()
        {
            InitializeComponent();
        }

        public void CrearNuevaSerie()
        {
            esAlta = true;
            serie = new Serie()
            {
                Id = DateTime.Now.Ticks,
            };
            ShowDialog();
        }

        public void Editar(long id)
        {
            serie = SeriesRepository.Instance.GetSeriePorId(id);
            MostrarDatos(serie);
            ShowDialog();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (EstanDatosObligatoriosRellenados())
            {
                ActualizarDatos(serie);
                if (esAlta)
                    SeriesRepository.Instance.AddSerie(serie);
            }

            this.Close();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool EstanDatosObligatoriosRellenados()
        {
            return txtTitulo.Text.Trim().Length > 0;
        }

        private void ActualizarDatos(Serie serie)
        {
            serie.Titulo = txtTitulo.Text;
            serie.FechaInicio = txtFechaInicio.Text;
            serie.FechaFin = txtFechaFin.Text;
            serie.Argumento = txtArgumento.Text;
        }

        private void MostrarDatos(Serie serie)
        {
            txtTitulo.Text = serie.Titulo;
            txtFechaInicio.Text = serie.FechaInicio;
            txtFechaFin.Text = serie.FechaFin;
            txtArgumento.Text = serie.Argumento;
        }

    }
}
