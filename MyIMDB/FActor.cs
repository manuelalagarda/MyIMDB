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
    public partial class FActor : Form
    {

        public long id = 0;
        public string nombre;
        public string fechaNacimiento;
        public string biografia;

        public FActor()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            txtNombre.Text = nombre;
            txtFechaNacimiento.Text = fechaNacimiento;
            txtBiografia.Text = biografia;
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
            fechaNacimiento = txtFechaNacimiento.Text;
            biografia = txtBiografia.Text;

            this.Close();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                nombre = "";
                fechaNacimiento = "";
                biografia = "";
            }

            this.Close();
        }

    }


}
