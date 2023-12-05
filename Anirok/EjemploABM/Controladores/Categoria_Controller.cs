using EjemploABM.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Controladores
{
    internal class Categoria_Controller
    {
        // POST

        public static bool crearCategoria(Categoria cat)
        {
            //Darlo de alta en la BBDD

            string query = "insert into dbo.categoria values" +
               "(@id, " +
               "@nombre, " +
               "@esta_activo)";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", obtenerMaxId() + 1);
            cmd.Parameters.AddWithValue("@nombre", cat.Nombre);
            cmd.Parameters.AddWithValue("@esta_activo", cat.IsActive);



            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

        }

        // OBTENER EL MAX ID

        public static int obtenerMaxId()
        {
            int MaxId = 0;
            string query = "select max(id) from dbo.categoria;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    MaxId = reader.GetInt32(0);
                }

                reader.Close();
                DB_Controller.connection.Close();
                return MaxId;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
        }


        // GET ALL

        public static List<Categoria> obtenerCategorias()
        {
            List<Categoria> list = new List<Categoria>();
            string query = "select * from dbo.categoria;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Categoria(reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));

                    Trace.WriteLine("Categoria encontrada, nombre: " + reader.GetString(1));
                }

                reader.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return list;
        }


        // GET ONE BY ID

        public static Categoria obtenerPorId(int id)
        {
            Categoria cat = new Categoria();
            string query = "select * from dbo.categoria where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cat = new Categoria(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                    Trace.WriteLine("Cat encontrada, nombre: " + reader.GetString(1));
                }

                reader.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return cat;
        }


        // EDIT / PUT

        public static bool editarCategoria(Categoria cat)
        {
            //Darlo de alta en la BBDD

            string query = "UPDATE dbo.categoria SET " +
                "nombre = @nombre, " +
                "esta_activo = @esta_activo " +
                "WHERE id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", cat.Id);
            cmd.Parameters.AddWithValue("@nombre", cat.Nombre);
            cmd.Parameters.AddWithValue("@esta_activo", cat.IsActive);


            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

        }

        public static bool eliminarCategoria(int id)
        {
            //Darlo de alta en la BBDD

            string query = "DELETE FROM categoria WHERE id = @id_eliminar;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id_eliminar", id);


            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                DB_Controller.connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

        }

        public static List<Categoria> ObtenerCategorias()
        {
            List<Categoria> listaCategorias = new List<Categoria>();
            string query = "SELECT * FROM dbo.categoria;";

            using (SqlCommand cmd = new SqlCommand(query, DB_Controller.connection))
            {
                try
                {
                    DB_Controller.connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Categoria categoria = new Categoria(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                        listaCategorias.Add(categoria);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener las categorías: " + ex.Message);
                }
                finally
                {
                    DB_Controller.connection.Close();
                }
            }

            return listaCategorias;
        }

        public static List<Categoria> ObtenerCategoriasActivas()
        {
            List<Categoria> listaCategorias = new List<Categoria>();
            string query = "SELECT * FROM dbo.categoria WHERE esta_activo = 'Activa';";


            using (SqlCommand cmd = new SqlCommand(query, DB_Controller.connection))
            {
                try
                {
                    DB_Controller.connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Categoria categoria = new Categoria(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                        listaCategorias.Add(categoria);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener las categorías: " + ex.Message);
                }
                finally
                {
                    DB_Controller.connection.Close();
                }
            }

            return listaCategorias;
        }



        


        public static bool DesactivarCategoria(int idCategoria)
        {
            string query = "UPDATE dbo.categoria SET " +
                           "esta_activo = @esta_activo " +
                           "WHERE id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", idCategoria);
            cmd.Parameters.AddWithValue("@esta_activo", "Desactivada"); // Establecer el valor a "Desactivada"

            try
            {
                DB_Controller.connection.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al desactivar la categoría: " + ex.Message);
            }
            finally
            {
                DB_Controller.connection.Close();
            }
        }

        public static string obtenerCategoriaPorId(int id)
        {
            //Darlo de alta en la BBDD
            string nombre = "";
            string query = "select nombre from categoria where id = @id_categoria ";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id_categoria", id);


            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    nombre = reader.GetString(0);
                }

                reader.Close();
                DB_Controller.connection.Close();
                return nombre;
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

        }


    }




}
