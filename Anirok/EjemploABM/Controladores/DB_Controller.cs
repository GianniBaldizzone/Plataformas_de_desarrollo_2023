using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Controladores
{
    public static class DB_Controller
    {

        private static string connectionString = "";
        public static SqlConnection connection;

        public static void initialize()
        {
            var builder = new SqlConnectionStringBuilder();

            builder.DataSource = @"(localdb)\localdb"; //NOMBRE DEL SERVIDOR
            builder.InitialCatalog = "anirok2"; //NOMBRE DE LA BASE DE DATOS
            builder.IntegratedSecurity = true; //TIENE O NO SEGURIDAD INTEGRADA CON WINDOWS

            connectionString = builder.ToString();
            connection = new SqlConnection(connectionString);

            Trace.WriteLine("Conexion a la DB: " + connection);

        }

    }
}
