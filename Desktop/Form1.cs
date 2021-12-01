using Desktop.Consultas;
using JLCS.SB.CapaDatos;
using JLCS.SB.CapaEntidad;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class Form1 : Form
    {
        public List<LibroEntidad> Libros;
        public DatosDb c;
        public Form1(/*ApplicationDbContext context*/)
        {
            InitializeComponent();
            c = new DatosDb();
        }


        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            
                try
                {

                    dataGridView1.DataSource = c.MostrarLibros().Tables[0];
                }
                catch{
                    this.Update();
                }
            
        }
    }
}
