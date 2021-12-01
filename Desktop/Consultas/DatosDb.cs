using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JLCS.SB.Sistema_de_Informacion_Bibliotecario;

namespace Desktop.Consultas
{
    public class DatosDb
    {
        public Configuration Configuration { get; }
        public SerializeJson SerializeJson = new();
        private static string Pasante;
        public DatosDb()
        {
            Pasante = SerializeJson.StringConnectionFile();
            Pasante = SerializeJson.DeSerializeStringConnectionFile(Pasante);
        }
        public string StringConnection = Pasante;
        private SqlConnection Connection;

        public SqlConnection Conectar()
        {
            this.Connection = new SqlConnection("Data Source=SQL5080.site4now.net;Initial Catalog=db_a7ce2d_libreria;User Id=db_a7ce2d_libreria_admin;Password=eLPELUCASAPE1.");
            return this.Connection;
        }

        public bool DatosSinRetorno(String _Consulta)
        {
            try
            {
                SqlCommand Consulta = new();
                Consulta.CommandText = _Consulta;
                Consulta.Connection = this.Conectar();
                Connection.Open();
                Consulta.ExecuteNonQuery();
                Connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataSet DatosConRetorno(SqlCommand _Query)
        {
            DataSet Datos = new();
            SqlDataAdapter Adaptador = new();
            try
            {
                SqlCommand Query = new();
                Query = _Query;
                Query.Connection = this.Conectar();
                Adaptador.SelectCommand = Query;
                Query.Connection.Open();
                Adaptador.Fill(Datos);
                Query.Connection.Close();
                return Datos;
            }
            catch
            {
                return Datos;
            }
        }
        // - 
        private readonly string _consulta = "SELECT IdLibro,Titulo,AutorNombre,AutorApellido FROM Libro AS L JOIN Autor AS A ON L.IdAutor=A.IdAutor";
        public DataSet MostrarLibros()
        {
            SqlCommand Consulta = new(_consulta);
            return DatosConRetorno(Consulta);
        }
    }
}