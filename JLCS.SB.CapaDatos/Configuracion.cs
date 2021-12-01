using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace JLCS.SB.CapaDatos
{
    public class Configuracion
    {
        protected static Configuracion _configuracion;
        private Configuracion()
        {

        }

        public Configuracion InstanciaConfiguracion()
        {
            if (_configuracion == null)
            {
                _configuracion = new Configuracion();
            }
            return _configuracion;
        } 

        public string StringConnection()
        {
            string CadenaConexion;
            var constructor = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfiguration configuracion = constructor.Build();
            CadenaConexion = configuracion["DefaultConnection"];
            return CadenaConexion;
        }


    }
}
