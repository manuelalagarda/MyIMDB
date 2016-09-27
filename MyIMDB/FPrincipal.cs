using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace MyIMDB
{
    public partial class FPrincipal : Form
    {
        IList listaElementos;

        public FPrincipal()
        {
            InitializeComponent();
            listaElementos = new ArrayList();

            Elemento elemento = new Elemento();
            elemento.Id = DateTime.Now.Ticks;
            elemento.Tipo = "Peliculas";
            elemento.Campo1 = "Los siete magníficos";
            elemento.Campo2 = "2016";
            elemento.Campo3 = "Bla bla bla";
            listaElementos.Add(elemento);

            elemento = new Elemento();
            elemento.Id = DateTime.Now.Ticks;
            elemento.Tipo = "Peliculas";
            elemento.Campo1 = "Bridget Jones' baby";
            elemento.Campo2 = "2016";
            elemento.Campo3 = "Bla bla bla";
            listaElementos.Add(elemento);

            elemento = new Elemento();
            elemento.Id = DateTime.Now.Ticks;
            elemento.Tipo = "Peliculas";
            elemento.Campo1 = "El hombre de las mil caras";
            elemento.Campo2 = "2016";
            elemento.Campo3 = "Bla bla bla";
            listaElementos.Add(elemento);

            elemento = new Elemento();
            elemento.Id = DateTime.Now.Ticks;
            elemento.Tipo = "Peliculas";
            elemento.Campo1 = "Cuerpo de élite";
            elemento.Campo2 = "2016";
            elemento.Campo3 = "Bla bla bla";
            listaElementos.Add(elemento);

            elemento = new Elemento();
            elemento.Id = DateTime.Now.Ticks;
            elemento.Tipo = "Peliculas";
            elemento.Campo1 = "No respires";
            elemento.Campo2 = "2016";
            elemento.Campo3 = "Bla bla bla";
            listaElementos.Add(elemento);

            elemento = new Elemento();
            elemento.Id = DateTime.Now.Ticks;
            elemento.Tipo = "Peliculas";
            elemento.Campo1 = "Florence Foster Jenkins";
            elemento.Campo2 = "2016";
            elemento.Campo3 = "Bla bla bla";
            listaElementos.Add(elemento);

            elemento = new Elemento();
            elemento.Id = DateTime.Now.Ticks;
            elemento.Tipo = "Peliculas";
            elemento.Campo1 = "El hogar de Miss Peregrine para niños peculiares";
            elemento.Campo2 = "2016";
            elemento.Campo3 = "Bla bla bla";
            listaElementos.Add(elemento);
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            cmbTipoFiltro.SelectedIndex = 0;
        }

        private void cmdNuevaPelicula_Click(object sender, EventArgs e)
        {
            // Creamos formulario de peliculas
            FPelicula ventana = new FPelicula();
            // Mostramos formulario de peliculas
            ventana.ShowDialog();
            // Si tenemos datos de una nueva película
            if (ventana.titulo.Length >0)
            {
                // Creamos nuevo elemento
                Elemento pel = new Elemento();
                pel.Id = DateTime.Now.Ticks;
                pel.Tipo = "Peliculas";
                pel.Campo1 = ventana.titulo;
                pel.Campo2 = ventana.año;
                pel.Campo3 = ventana.argumento;
                // Lo añadimos a la lista
                listaElementos.Add(pel);
            }

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            IList lis = new ArrayList();

            if (cmbTipoFiltro.Text == "Todos")
            {
                foreach (Elemento elemento in listaElementos)
                {
                    if (elemento.Campo1.Contains(txtFiltro.Text))
                    {
                        lis.Add(elemento);
                    }
                }
            } else
            {
                if (cmbTipoFiltro.Text == "Peliculas")
                {
                    foreach (Elemento elemento in listaElementos)
                    {
                        if (elemento.Tipo == "Peliculas" && elemento.Campo1.Contains(txtFiltro.Text))
                        {
                            lis.Add(elemento);
                        }
                    }
                }

                if (cmbTipoFiltro.Text == "Series")
                {
                    foreach (Elemento elemento in listaElementos)
                    {
                        if (elemento.Tipo == "Series" && elemento.Campo1.Contains(txtFiltro.Text))
                        {
                            lis.Add(elemento);
                        }
                    }
                }

                if (cmbTipoFiltro.Text == "Actores")
                {
                    foreach (Elemento elemento in listaElementos)
                    {
                        if (elemento.Tipo == "Actores" && elemento.Campo1.Contains(txtFiltro.Text))
                        {
                            lis.Add(elemento);
                        }
                    }
                }
            }

            lstResultado.DataSource = lis;
        }

        private void cmdNuevoDirector_Click(object sender, EventArgs e)
        {
            // Creamos formulario de peliculas
            FSerie ventana = new FSerie();
            // Mostramos formulario de peliculas
            ventana.ShowDialog();
            // Si tenemos datos de una nueva película
            if (ventana.titulo.Length > 0)
            {
                // Creamos nuevo elemento
                Elemento dir = new Elemento();
                dir.Id = DateTime.Now.Ticks;
                dir.Tipo = "Series";
                dir.Campo1 = ventana.titulo;
                dir.Campo2 = ventana.fechaInicio;
                dir.Campo3 = ventana.fechaFin;
                dir.Campo4 = ventana.argumento;
                // Lo añadimos a la lista
                listaElementos.Add(dir);
            }
        }

        private void cmdNuevoActor_Click(object sender, EventArgs e)
        {
            // Creamos formulario de peliculas
            FActor ventana = new FActor();
            // Mostramos formulario de peliculas
            ventana.ShowDialog();
            // Si tenemos datos de una nueva película
            if (ventana.nombre.Length > 0)
            {
                // Creamos nuevo elemento
                Elemento dir = new Elemento();
                dir.Id = DateTime.Now.Ticks;
                dir.Tipo = "Actores";
                dir.Campo1 = ventana.nombre;
                dir.Campo2 = ventana.fechaNacimiento;
                dir.Campo3 = ventana.biografia;
                // Lo añadimos a la lista
                listaElementos.Add(dir);
            }
        }

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            long id = 0;
            DataGridViewSelectedRowCollection filas = lstResultado.SelectedRows; 
            if (filas.Count > 0)
            {
                // Obtenemos identificador del elemento seleccionado
                foreach (DataGridViewRow fila in filas)
                {
                    id = (long) fila.Cells[0].Value;
                    break;
                }
                // Obtenemos entidad asociada al identificador
                Elemento seleccionado = null;
                foreach (Elemento elemento in listaElementos)
                {
                    if (elemento.Id == id)
                    {
                        seleccionado = elemento;
                    }
                }
                // Creamos el formulario asociado
                switch (seleccionado.Tipo)
                {
                    case "Peliculas":
                        {
                            // Mostramos el formulario
                            FPelicula form = new FPelicula();
                            form.id = seleccionado.Id;
                            form.titulo = seleccionado.Campo1;
                            form.año = seleccionado.Campo2;
                            form.argumento = seleccionado.Campo3;
                            form.ShowDialog();
                            // Actualizamos los datos del objeto
                            seleccionado.Campo1 = form.titulo;
                            seleccionado.Campo2 = form.año;
                            seleccionado.Campo3 = form.argumento;
                            break;
                        }
                    case "Series":
                        {                            
                            // Mostramos el formulario
                            FSerie form = new FSerie();
                            form.id = seleccionado.Id;
                            form.titulo = seleccionado.Campo1;
                            form.fechaInicio = seleccionado.Campo2;
                            form.fechaFin = seleccionado.Campo3;
                            form.argumento = seleccionado.Campo4;
                            form.ShowDialog();
                            // Actualizamos los datos del objeto
                            seleccionado.Campo1 = form.titulo;
                            seleccionado.Campo2 = form.fechaInicio;
                            seleccionado.Campo3 = form.fechaFin;
                            seleccionado.Campo4 = form.argumento;
                            break;
                        }
                    case "Actores":
                        {
                            FActor form = new FActor();
                            form.id = seleccionado.Id;
                            form.nombre = seleccionado.Campo1;
                            form.fechaNacimiento = seleccionado.Campo2;
                            form.biografia = seleccionado.Campo3;
                            form.ShowDialog();
                            // Actualizamos los datos del objeto
                            seleccionado.Campo1 = form.nombre;
                            seleccionado.Campo2 = form.fechaNacimiento;
                            seleccionado.Campo3 = form.biografia;
                            break;
                        }
                }
            }
        }
    }
}
