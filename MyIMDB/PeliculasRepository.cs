using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyIMDB
{
    public sealed class PeliculasRepository:BaseRepository
    {
        #region Singleton
        // Implementamos patrón Singleton con inicialización estática no multithreading
        // https://msdn.microsoft.com/en-us/library/ff650316.aspx
        private static readonly PeliculasRepository instance = new PeliculasRepository();
        public static PeliculasRepository Instance
        {
            get
            {
                return instance;
            }
        }
        #endregion

        private IList<Pelicula> listaPeliculas;

        private PeliculasRepository() {
            listaPeliculas = new List<Pelicula>();
            CargarPeliculasIniciales();
        }

        public void AddPelicula(Pelicula pelicula)
        {
            listaPeliculas.Add(pelicula);
        }
        public Pelicula GetPeliculaPorId(long identificador)
        {
            return listaPeliculas.Where<Pelicula>(pelicula => pelicula.Id == identificador).FirstOrDefault<Pelicula>();
        }
        public IEnumerable<Pelicula> ObtenerPeliculasPorFiltro(string filtro)
        {
            IEnumerable<Pelicula> peliculas;

            peliculas = (from pelicula in listaPeliculas
                         where
                             (pelicula.Titulo.Contains(filtro))
                         select pelicula);

            return peliculas;
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
                Id = ObtenerSiguienteID(),
                Titulo = titulo,
                Año = año,
                Argumento = argumento
            };
            AddPelicula(pelicula);
        }


    }
}
