using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyIMDB
{
    public sealed class SeriesRepository : BaseRepository
    {
        #region Singleton
        // Implementamos patrón Singleton con inicialización estática no multithreading
        // https://msdn.microsoft.com/en-us/library/ff650316.aspx
        private static readonly SeriesRepository instance = new SeriesRepository();
        public static SeriesRepository Instance
        {
            get
            {
                return instance;
            }
        }
        #endregion

        private IList<Serie> listaSeries;

        private SeriesRepository()
        {
            listaSeries = new List<Serie>();
        }

        public void AddSerie(Serie serie)
        {
            listaSeries.Add(serie);
        }
        public Serie GetSeriePorId(long identificador)
        {
            return listaSeries.Where<Serie>(serie => serie.Id == identificador).FirstOrDefault<Serie>();
        }
        public IEnumerable<Serie> ObtenerSeriesPorFiltro(string filtro)
        {
            IEnumerable<Serie> series;

            series = (from serie in listaSeries
                         where
                             (serie.Titulo.Contains(filtro))
                         select serie);

            return series;
        }

    }
}
