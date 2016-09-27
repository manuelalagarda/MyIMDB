using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyIMDB
{
    public partial class FSerie : Form
    {
        public long id = 0;
        public string titulo;
        public string fechaInicio;
        public string fechaFin;
        public string argumento;       

        public FSerie()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            txtTitulo.Text = titulo;
            txtFechaInicio.Text = fechaInicio;
            txtFechaFin.Text = fechaFin;
            txtArgumento.Text = argumento;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            titulo = txtTitulo.Text;
            fechaInicio = txtFechaInicio.Text;
            fechaFin = txtFechaFin.Text;
            argumento = txtArgumento.Text;

            this.Close();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                titulo = "";
                fechaInicio = "";
                fechaFin = "";
                argumento = "";
            }
            this.Close();
        }

    }
}
