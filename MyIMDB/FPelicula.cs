using System;
using System.Windows.Forms;

namespace MyIMDB
{
    public partial class FPelicula : Form
    {

        private Boolean esAlta = false;
        private Pelicula pelicula = null;

        public FPelicula()
        {
            InitializeComponent();
        }

        public void CrearNuevaPelicula()
        {
            esAlta = true;
            pelicula = new Pelicula
            {
                Id = DateTime.Now.Ticks,
            };
            ShowDialog();
        }

        public void Editar(long id)
        {
            pelicula = PeliculasRepository.Instance.GetPeliculaPorId(id);
            MostrarDatos(pelicula);
            ShowDialog();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (EstanDatosObligatoriosRellenados())
            {
                ActualizarDatos(pelicula);
                if (esAlta)
                    PeliculasRepository.Instance.AddPelicula(pelicula);
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

        private void ActualizarDatos(Pelicula pelicula)
        {
            pelicula.Titulo = txtTitulo.Text;
            pelicula.Año = txtAño.Text;
            pelicula.Argumento = txtArgumento.Text;
        }

        private void MostrarDatos(Pelicula pelicula)
        {
            txtTitulo.Text = pelicula.Titulo;
            txtAño.Text = pelicula.Año;
            txtArgumento.Text = pelicula.Argumento;
        }
    }
}
