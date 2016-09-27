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
    public partial class FPelicula : Form
    {
        public long id = 0;
        public String titulo;
        public String año;
        public String argumento;

        public FPelicula()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            txtTitulo.Text = titulo;
            txtAño.Text = año;
            txtArgumento.Text = argumento;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            titulo = txtTitulo.Text;
            año = txtAño.Text;
            argumento = txtArgumento.Text;
            this.Close();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                titulo = "";
                año = "";
                argumento = "";
            }
            this.Close();
        }
    }
}
