using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandInterface
{
    public abstract class SolicitudesReciver
    {
        protected bool registrar;
        protected bool sancionar;
        protected bool quitarsancion;

        public bool Registrar
        {
            get { return registrar; }
        }

        public bool Sancionar
        {
            get { return sancionar;  }
        }

        public bool QuitarSancion
        {
            get { return quitarsancion;  }
        }
    }
}
