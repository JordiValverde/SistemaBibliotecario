using Desktop.Consultas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop
{
    public class SerializeJson
    {
        public string _path = @"C:\Users\jorka\Source\Workspaces\SB\JLCS.SB\Desktop\config.json";
        public ConnectionStrings CadenaConexion { get; set; }
        public string StringConnectionFile()
        {
            string StringConnection;
            using (var reader = new StreamReader(_path))
            {
                StringConnection = reader.ReadToEnd();
            }
            return StringConnection;
        }
        public static string DeSerializeStringConnectionFile(string _StringConnection)
        {
            var stringconection = JsonConvert.DeserializeObject<ConnectionStrings>(_StringConnection);
            string cadena = string.Format("{0}",stringconection.DefaultConnection);
            return cadena;
        }

    }
}
