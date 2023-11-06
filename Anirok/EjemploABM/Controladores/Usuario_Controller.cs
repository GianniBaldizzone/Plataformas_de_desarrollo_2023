﻿using EjemploABM.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;

namespace EjemploABM.Controladores
{
    class Usuario_Controller
    {

        // GET ONE

        public static bool autenticar(string usr, string pass, bool hasheado)
        {
            Usuario user = null;

            string query = "select * from dbo.usuario where nombre = @usr and contraseña = @pass;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@usr", usr);
            if (hasheado)
            {
                cmd.Parameters.AddWithValue("@pass", pass);
            }
            else
            {
                //cmd.Parameters.AddWithValue("@pass", hc.PassHash(pass));
            }

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Trace.WriteLine("Usr encontrado, nombre: " + reader.GetString(1));
                    user = new Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetInt32(8));
                }

                reader.Close();
                DB_Controller.connection.Close();

                if (user != null)
                {
                    Program.logueado = user;
                    return true;
                }
                else
                {
                    // Si no se encontró un usuario, borra el contenido de los TextBox
                    
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
        }


        // POST

        public static bool crearUsuario(Usuario usr)
        {
            //Darlo de alta en la BBDD

            string query = "insert into dbo.usuario values" +
               "(@id, " +
               "@nombre, " +
               "@apellido, " +
               "@mail, " +
               "@telefono, " +
               "@direccion, " +
               "@dni, " +
               "@contraseña, " +
               "@rol);";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", obtenerMaxId() + 1);
            cmd.Parameters.AddWithValue("@nombre", usr.Nombre);
            cmd.Parameters.AddWithValue("@apellido", usr.Apellido);
            cmd.Parameters.AddWithValue("@mail", usr.Mail);
            cmd.Parameters.AddWithValue("@telefono", usr.Telefono);
            cmd.Parameters.AddWithValue("@direccion", usr.Direccion);
            cmd.Parameters.AddWithValue("@dni", usr.Dni);
            cmd.Parameters.AddWithValue("@contraseña", usr.Contraseña);
            cmd.Parameters.AddWithValue("@rol", usr.Rol);



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
            string query = "select max(id) from dbo.usuario;";

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

        public static List<Usuario> obtenerTodos()
        {
            List<Usuario> list = new List<Usuario>();
            string query = "select * from dbo.usuario;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetInt32(8)));
         
                    Trace.WriteLine("Usr encontrado, nombre: " + reader.GetString(1));
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

        public static Usuario obtenerPorId(int id)
        {
            Usuario usr = new Usuario();
            string query = "select * from dbo.usuario where id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    usr = new Usuario(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6), reader.GetString(7), reader.GetInt32(8));
                    Trace.WriteLine("Usr encontrado, nombre: " + reader.GetString(1));
                }

                reader.Close();
                DB_Controller.connection.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }

            return usr;
        }



        // EDIT / PUT

        public static bool editarUsuario(Usuario usr)
        {
            //Darlo de alta en la BBDD

            string query = "UPDATE dbo.usuario SET " +
                "nombre = @nombre, " +
                "apellido = @apellido, " +
                "mail = @mail, " +
                "telefono = @telefono, " +
                "direccion = @direccion," +
                " dni = @dni, " +
                "contraseña = @contraseña," +
                " rol = @rol " +
                "WHERE id = @id;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@id", usr.Id);
            cmd.Parameters.AddWithValue("@nombre", usr.Nombre);
            cmd.Parameters.AddWithValue("@apellido", usr.Apellido);
            cmd.Parameters.AddWithValue("@mail", usr.Mail);
            cmd.Parameters.AddWithValue("@telefono", usr.Telefono);
            cmd.Parameters.AddWithValue("@direccion", usr.Direccion);
            cmd.Parameters.AddWithValue("@dni", usr.Dni);
            cmd.Parameters.AddWithValue("@contraseña", usr.Contraseña);
            cmd.Parameters.AddWithValue("@rol", usr.Rol);

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


        public static bool eliminarUsuario(int id)
        {
            //Darlo de alta en la BBDD

            string query = "DELETE FROM usuario WHERE id = @id_eliminar;";

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


        // validar repeticion de la contraseña


        
public static bool existeContraseña(string contraseña)
        {
            string query = "SELECT COUNT(*) FROM dbo.usuario WHERE contraseña = @contraseña;";
            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@contraseña", contraseña);

            try
            {
                DB_Controller.connection.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0; // Si count > 0, significa que la contraseña ya está en uso
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
            finally
            {
                DB_Controller.connection.Close();
            }
        }


    }
}
