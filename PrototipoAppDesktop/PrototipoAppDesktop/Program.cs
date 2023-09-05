using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoAppDesktop
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            var builder = SqlConnectionStringBuilder();
            builder.DataSource = "DESKTOP-CGPE47L\\MSSQLSERVER01";// NOMBRE DEL SERVIDOR;
            builder.InitialCatalog = "prueba";//NOMBRE DE LA BD
            builder.IntegratedSecurity = true;

            string conectionString = builder.ToString();
            SqlConnection concection = new SqlConnection(conectionString);
            Trace.WriteLine("Conexión a la BD: " + concection);

            try
            {
                concection.Open();
                concection.Close();
                Trace.WriteLine("Conexion creada con exito");
            }
            catch (Exception e)
            {
                Trace("Hubo algun error en al conexión" + e.Message);
            }
            Application.Run(new Form1());
        }
    }
}
