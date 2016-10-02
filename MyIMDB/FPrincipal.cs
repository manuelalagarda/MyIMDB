using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MyIMDB
{
    public partial class FPrincipal : Form
    {
       
        public FPrincipal()
        {
            InitializeComponent();
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            cmbTipoFiltro.SelectedIndex = 0;
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

            elementos = (from serie in PeliculasRepository.Instance.ObtenerPeliculasPorFiltro(filtro)
                         select new ElementoListaDTO { Id = serie.Id, Tipo = "Peliculas", Campo1 = serie.Titulo });

            return elementos;
        }

        private IEnumerable<ElementoListaDTO> ObtenerSeriesPorFiltro(string filtro)
        {
            IEnumerable<ElementoListaDTO> elementos;

            elementos = (from serie in SeriesRepository.Instance.ObtenerSeriesPorFiltro(filtro)
                         select new ElementoListaDTO { Id = serie.Id, Tipo = "Series", Campo1 = serie.Titulo });

            return elementos;
        }

        private IEnumerable<ElementoListaDTO> ObtenerActoresPorFiltro(string filtro)
        {
            IEnumerable<ElementoListaDTO> elementos;

            elementos = (from actor in ActoresRepository.Instance.ObtenerActoresPorFiltro(filtro)
                         select new ElementoListaDTO { Id = actor.Id, Tipo = "Actores", Campo1 = actor.Nombre });

            return elementos;
        }

        private void cmdNuevoActor_Click(object sender, EventArgs e)
        {
            FActor ventana = new FActor();
            ventana.CrearNuevoActor();
        }

        private void cmdNuevaSerie_Click(object sender, EventArgs e)
        {
            FSerie ventana = new FSerie();
            ventana.CrearNuevaSerie();
        }

        private void cmdNuevaPelicula_Click(object sender, EventArgs e)
        {
            FPelicula ventana = new FPelicula();
            ventana.CrearNuevaPelicula();
        }

        private void cmdEditar_Click(object sender, EventArgs e)
        {
            ElementoListaDTO elemento = ObtenerElementoSeleccionado();
            EditarElementoLista(elemento.Tipo, elemento.Id);
        }

        private ElementoListaDTO ObtenerElementoSeleccionado()
        {
            ElementoListaDTO elementoLista = null;
            DataGridViewSelectedRowCollection filas = lstResultado.SelectedRows;
            if (filas.Count > 0)
            {
                elementoLista = new ElementoListaDTO();
                foreach (DataGridViewRow fila in filas)
                {
                    elementoLista.Id = (long)fila.Cells[0].Value;
                    elementoLista.Tipo = (string)fila.Cells[2].Value;
                    break;
                }
            }

            return elementoLista;
        }

        private void EditarElementoLista(string tipo, long id)
        {
            switch (tipo)
            {
                case "Peliculas":
                    {
                        FPelicula form = new FPelicula();
                        form.Editar(id);
                        break;
                    }
                case "Series":
                    {
                        FSerie form = new FSerie();
                        form.Editar(id);
                        break;
                    }
                case "Actores":
                    {
                        FActor form = new FActor();
                        form.Editar(id);
                        break;
                    }
            }
        }

    }
}
