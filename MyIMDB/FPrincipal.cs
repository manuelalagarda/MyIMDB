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
        IList<Pelicula> listaPeliculas;
        IList<Serie> listaSeries;
        IList<Actor> listaActores;

        public FPrincipal()
        {
            InitializeComponent();
            listaPeliculas = new List<Pelicula>();
            listaSeries = new List<Serie>();
            listaActores = new List<Actor>();

            CargarPeliculasIniciales();

        }

        private void CargarPeliculasIniciales()
        {
            InsertarPelicula("Los siete magníficos", "2016", "Bla bla bla");
            InsertarPelicula("Bridget Jones' baby", "2016", "Bla bla bla");
            InsertarPelicula("El hombre de las mil caras", "2016", "Bla bla bla");
            InsertarPelicula("Cuerpo de élite", "2016", "Bla bla bla");
            InsertarPelicula("No respires", "2016", "Bla bla bla");
            InsertarPelicula("Florence Foster Jenkins", "2016", "Bla bla bla");
            InsertarPelicula("El hogar de Miss Peregrine para niños peculiares", "2016", "Bla bla bla");
        }

        private void InsertarPelicula(string titulo, string año, string argumento)
        {
            Pelicula pelicula = new Pelicula
            {
                Id= ObtenerSiguienteID(),
                Titulo = titulo,
                Año = año,
                Argumento = argumento
            };
            listaPeliculas.Add(pelicula);
        }

        private long ObtenerSiguienteID()
        {
            return DateTime.Now.Ticks;
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
                InsertarPelicula(ventana.titulo, ventana.año, ventana.argumento);               
            }

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            IList<ElementoListaDTO> elementosFiltrados = ObtenerListaFiltradaDeElementos(cmbTipoFiltro.Text, txtFiltro.Text);
            lstResultado.DataSource = elementosFiltrados;
        }

        private IList<ElementoListaDTO> ObtenerListaFiltradaDeElementos(string tipo, string filtro)
        {
            IEnumerable<ElementoListaDTO> elementosFiltrados = new List<ElementoListaDTO>();

            if (tipo == "Todos" || tipo == "Peliculas")
                elementosFiltrados = elementosFiltrados.Concat<ElementoListaDTO>(ObtenerPeliculasPorFiltro(filtro));
            if (tipo == "Todos" || tipo == "Series")
                elementosFiltrados = elementosFiltrados.Concat<ElementoListaDTO>(ObtenerSeriesPorFiltro(filtro));
            if (tipo == "Todos" || tipo == "Actores")
                elementosFiltrados = elementosFiltrados.Concat<ElementoListaDTO>(ObtenerActoresPorFiltro(filtro));

            return elementosFiltrados.OrderBy(elemento => elemento.Id).ToList<ElementoListaDTO>();

        }

        private IEnumerable<ElementoListaDTO> ObtenerPeliculasPorFiltro(string filtro)
        {
            IEnumerable<ElementoListaDTO> elementos;

            elementos = (from pelicula in listaPeliculas
                         where
                             (pelicula.Titulo.Contains(filtro))
                         select new ElementoListaDTO { Id = pelicula.Id, Tipo = "Peliculas", Campo1 = pelicula.Titulo });

            return elementos;
        }

        private IEnumerable<ElementoListaDTO> ObtenerSeriesPorFiltro(string filtro)
        {
            IEnumerable<ElementoListaDTO> elementos;

            elementos = (from serie in listaSeries
                         where
                             (serie.Titulo.Contains(filtro))
                         select new ElementoListaDTO { Id = serie.Id, Tipo = "Series", Campo1 = serie.Titulo });

            return elementos;
        }

        private IEnumerable<ElementoListaDTO> ObtenerActoresPorFiltro(string filtro)
        {
            IEnumerable<ElementoListaDTO> elementos;

            elementos = (from actor in listaActores
                         where
                             (actor.Nombre.Contains(filtro))
                         select new ElementoListaDTO { Id = actor.Id, Tipo = "Actores", Campo1 = actor.Nombre });

            return elementos;
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
                Actor dir = new Actor();
                dir.Id = DateTime.Now.Ticks;                
                dir.Nombre = ventana.nombre;
                dir.FechaNacimiento = ventana.fechaNacimiento;
                dir.Biografia = ventana.biografia;
                // Lo añadimos a la lista
                listaActores.Add(dir);
            }
        }

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            long id = 0;
            string tipo = "";
            DataGridViewSelectedRowCollection filas = lstResultado.SelectedRows;
            if (filas.Count > 0)
            {
                // Obtenemos identificador del elemento seleccionado
                foreach (DataGridViewRow fila in filas)
                {
                    id = (long)fila.Cells[0].Value;
                    tipo = (string)fila.Cells[2].Value;
                    break;
                }
                // Creamos el formulario asociado
                switch (tipo)
                {
                    case "Peliculas":
                        {
                            Pelicula peliculaSeleccionada = listaPeliculas.Where<Pelicula>(pelicula => pelicula.Id == id).FirstOrDefault<Pelicula>();
                            // Mostramos el formulario
                            FPelicula form = new FPelicula();
                            form.id = peliculaSeleccionada.Id;
                            form.titulo = peliculaSeleccionada.Titulo;
                            form.año = peliculaSeleccionada.Año;
                            form.argumento = peliculaSeleccionada.Argumento;
                            form.ShowDialog();
                            // Actualizamos los datos del objeto
                            peliculaSeleccionada.Titulo = form.titulo;
                            peliculaSeleccionada.Año = form.año;
                            peliculaSeleccionada.Argumento = form.argumento;
                            break;
                        }
                    case "Series":
                        {
                            Serie serieSeleccionada = listaSeries.Where<Serie>(serie => serie.Id == id).FirstOrDefault<Serie>();
                            // Mostramos el formulario
                            FSerie form = new FSerie();
                            form.id = serieSeleccionada.Id;
                            form.titulo = serieSeleccionada.Titulo;
                            form.fechaInicio = serieSeleccionada.FechaInicio;
                            form.fechaFin = serieSeleccionada.FechaFin;
                            form.argumento = serieSeleccionada.Argumento;
                            form.ShowDialog();
                            // Actualizamos los datos del objeto
                            serieSeleccionada.Titulo = form.titulo;
                            serieSeleccionada.FechaInicio = form.fechaInicio;
                            serieSeleccionada.FechaFin = form.fechaFin;
                            serieSeleccionada.Argumento = form.argumento;
                            break;
                        }
                    case "Actores":
                        {
                            Actor actorSeleccionado = listaActores.Where<Actor>(actor => actor.Id == id).FirstOrDefault<Actor>();
                            FActor form = new FActor();
                            form.id = actorSeleccionado.Id;
                            form.nombre = actorSeleccionado.Nombre;
                            form.fechaNacimiento = actorSeleccionado.FechaNacimiento;
                            form.biografia = actorSeleccionado.Biografia;
                            form.ShowDialog();
                            // Actualizamos los datos del objeto
                            actorSeleccionado.Nombre = form.nombre;
                            actorSeleccionado.FechaNacimiento = form.fechaNacimiento;
                            actorSeleccionado.Biografia = form.biografia;
                            break;
                        }
                }
            }
        }

        private void cmdNuevaSerie_Click(object sender, EventArgs e)
        {
            // Creamos formulario de peliculas
            FSerie ventana = new FSerie();
            // Mostramos formulario de peliculas
            ventana.ShowDialog();
            // Si tenemos datos de una nueva película
            if (ventana.titulo.Length > 0)
            {
                // Creamos nuevo elemento
                Serie serie = new Serie();
                serie.Id = DateTime.Now.Ticks;
                serie.Titulo = ventana.titulo;
                serie.FechaInicio = ventana.fechaInicio;
                serie.FechaFin = ventana.fechaFin;
                serie.Argumento = ventana.argumento;
                // Lo añadimos a la lista
                listaSeries.Add(serie);
            }
        }
    }
}
