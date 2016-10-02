using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyIMDB
{
    public class BaseRepository
    {
        protected long ObtenerSiguienteID()
        {
            return DateTime.Now.Ticks;
        }
    }
}
