﻿using EjemploABM.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Controladores
{
    class Subcategoria_Controller
    {
        public static bool crearSubcategoria(Subcategoria sub)
        {
            //Darlo de alta en la BBDD

            string query = "insert into dbo.subcategoria values" +
               "(@id, " +
               "@nombre, " +
               "@categoria_id," +
               "@esta_activo)"
               ;

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", obtenerMaxId() + 1);
            cmd.Parameters.AddWithValue("@nombre", sub.Nombre);
            cmd.Parameters.AddWithValue("@categoria_id", sub.categoria_id);
            cmd.Parameters.AddWithValue("@esta_activo", sub.IsActive);





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
            string query = "select max(id) from dbo.subcategoria;";

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

        public static List<Subcategoria> obtenerSubcategorias()
        {
            List<Subcategoria> list = new List<Subcategoria>();
            string query = "select * from dbo.subcategoria;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Subcategoria(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3)));

                    Trace.WriteLine("Subcategoria encontrada, nombre: " + reader.GetString(1));
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

        public static Subcategoria obtenerPorId(int id)
        {
            Subcategoria sub = new Subcategoria();
            string query = "select * from dbo.subcategoria where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    sub = new Subcategoria(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3));
                    Trace.WriteLine("Sub encontrada, nombre: " + reader.GetString(1));
                }

                reader.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return sub;
        }


        // EDIT / PUT

        public static bool editarSubcategoria(Subcategoria sub)
        {
            //Darlo de alta en la BBDD

            string query = "UPDATE dbo.subcategoria SET " +
                "nombre = @nombre, " +
                "esta_activo = @esta_activo, " +
                "categoria_id = @categoria_id " +
                "WHERE id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", sub.Id);
            cmd.Parameters.AddWithValue("@nombre", sub.Nombre);
            cmd.Parameters.AddWithValue("@categoria_id", sub.categoria_id);
            cmd.Parameters.AddWithValue("@esta_activo", sub.IsActive);



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

        public static bool eliminarSubcategoria(int id)
        {
            //Darlo de alta en la BBDD

            string query = "DELETE FROM subcategoria WHERE id = @id_eliminar;";

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



        public static List<Subcategoria> ObtenerSubcategoriasPorCategoria(int categoriaId)
        {
            List<Subcategoria> subcategorias = new List<Subcategoria>();

            // Realiza una consulta a la base de datos para obtener subcategorías de la categoría especificada.
            string query = "SELECT * FROM dbo.subcategoria WHERE categoria_id = @categoriaId";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@categoriaId", categoriaId);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string nombre = reader.GetString(1);
                    int categoria = reader.GetInt32(2);
                    string estaActivo = reader.GetString(3);

                    Subcategoria subcategoria = new Subcategoria(id, nombre, categoria, estaActivo);
                    subcategorias.Add(subcategoria);
                }

                reader.Close();
                DB_Controller.connection.Close();
                return subcategorias;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener subcategorías por categoría: " + ex.Message);
            }
        }

        public static string obtenerSubcategoriaPorId(int id)
        {
            //Darlo de alta en la BBDD
            string nombre = "";
            string query = "select nombre from subcategoria where id = @id_subcategoria ";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id_subcategoria", id);


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







