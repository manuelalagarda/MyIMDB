using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyIMDB
{
    public sealed class ActoresRepository : BaseRepository
    {
        #region Singleton
        // Implementamos patrón Singleton con inicialización estática no multithreading
        // https://msdn.microsoft.com/en-us/library/ff650316.aspx
        private static readonly ActoresRepository instance = new ActoresRepository();
        public static ActoresRepository Instance
        {
            get
            {
                return instance;
            }
        }
        #endregion

        private IList<Actor> listaActores;

        private ActoresRepository()
        {
            listaActores = new List<Actor>();
        }

        public void AddActor(Actor actor)
        {
            listaActores.Add(actor);
        }
        public Actor GetActorPorId(long identificador)
        {
            return listaActores.Where<Actor>(actor => actor.Id == identificador).FirstOrDefault<Actor>();
        }
        public IEnumerable<Actor> ObtenerActoresPorFiltro(string filtro)
        {
            IEnumerable<Actor> actores;

            actores = (from actor in listaActores
                         where
                             (actor.Nombre.Contains(filtro))
                         select actor);

            return actores;
        }

    }
}
