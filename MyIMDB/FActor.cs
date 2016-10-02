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

        private Boolean esAlta = false;
        private Actor actor = null;

        public FActor()
        {
            InitializeComponent();
        }

        public void CrearNuevoActor()
        {
            esAlta = true;
            actor = new Actor
            {
                Id = DateTime.Now.Ticks,
            };
            ShowDialog();
        }

        public void Editar(long id)
        {
            actor = ActoresRepository.Instance.GetActorPorId(id);
            MostrarDatos(actor);
            ShowDialog();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (EstanDatosObligatoriosRellenados())
            {
                ActualizarDatos(actor);
                if (esAlta)
                    ActoresRepository.Instance.AddActor(actor);
            }

            this.Close();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool EstanDatosObligatoriosRellenados()
        {
            return txtNombre.Text.Trim().Length > 0;
        }

        private void ActualizarDatos(Actor actor)
        {
            actor.Nombre = txtNombre.Text;
            actor.FechaNacimiento = txtFechaNacimiento.Text;
            actor.Biografia = txtBiografia.Text;
        }

        private void MostrarDatos(Actor actor)
        {
            txtNombre.Text = actor.Nombre;
            txtFechaNacimiento.Text = actor.FechaNacimiento;
            txtBiografia.Text = actor.Biografia;                
        }


    }


}
