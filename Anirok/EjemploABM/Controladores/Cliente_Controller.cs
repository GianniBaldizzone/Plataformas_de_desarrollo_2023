using EjemploABM.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Controladores
{
    internal class Cliente_Controller
    {
      
            // Método para obtener todos los clientes
            public static List<Cliente> obtenerTodos()
            {
                List<Cliente> listaClientes = new List<Cliente>();
                string query = "SELECT * FROM cliente;";

                SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

                try
                {
                    DB_Controller.connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listaClientes.Add(new Cliente(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6)));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la query: " + ex.Message);
                }
                finally
                {
                    DB_Controller.connection.Close();
                }

                return listaClientes;
            }

            // Método para obtener un cliente por su ID
            public static Cliente obtenerPorId(int id)
            {
                Cliente cliente = new Cliente();
                string query = "SELECT * FROM cliente WHERE id = @id;";

                SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    DB_Controller.connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cliente = new Cliente(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la query: " + ex.Message);
                }
                finally
                {
                    DB_Controller.connection.Close();
                }

                return cliente;
            }

            // Método para crear un nuevo cliente
            public static bool crearCliente(Cliente cliente)
            {
                string query = "INSERT INTO cliente VALUES (@id, @nombre, @apellido, @mail, @telefono, @direccion, @dni);";

                SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
                cmd.Parameters.AddWithValue("@id", obtenerMaxId() + 1);
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@mail", cliente.Mail);
                cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@dni", cliente.Dni);

                try
                {
                    DB_Controller.connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la query: " + ex.Message);
                }
                finally
                {
                    DB_Controller.connection.Close();
                }

                return true;
            }

            // Método para obtener el máximo ID de los clientes
            public static int obtenerMaxId()
            {
                int maxId = 0;
                string query = "SELECT MAX(id) FROM cliente;";

                SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);

                try
                {
                    DB_Controller.connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        if (!reader.IsDBNull(0))
                        {
                            maxId = reader.GetInt32(0);
                        }
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la query: " + ex.Message);
                }
                finally
                {
                    DB_Controller.connection.Close();
                }

                return maxId;
            }

            // Método para editar un cliente existente
            public static bool editarCliente(Cliente cliente)
            {
                string query = "UPDATE cliente SET nombre = @nombre, apellido = @apellido, mail = @mail, telefono = @telefono, direccion = @direccion, dni = @dni WHERE id = @id;";

                SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
                cmd.Parameters.AddWithValue("@id", cliente.Id);
                cmd.Parameters.AddWithValue("@nombre", cliente.Nombre);
                cmd.Parameters.AddWithValue("@apellido", cliente.Apellido);
                cmd.Parameters.AddWithValue("@mail", cliente.Mail);
                cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);
                cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@dni", cliente.Dni);

                try
                {
                    DB_Controller.connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la query: " + ex.Message);
                }
                finally
                {
                    DB_Controller.connection.Close();
                }

                return true;
            }

            // Método para eliminar un cliente
            public static bool eliminarCliente(int id)
            {
                string query = "DELETE FROM cliente WHERE id = @id;";

                SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    DB_Controller.connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Hay un error en la query: " + ex.Message);
                }
                finally
                {
                    DB_Controller.connection.Close();
                }

                return true;
            }



        public static Cliente buscarPorDni(string dni)
        {
            if (string.IsNullOrWhiteSpace(dni))
            {
                // Validación de campo no vacío
                throw new ArgumentException("El campo DNI no puede estar vacío.");
            }

            Cliente cliente = new Cliente();
            string query = "SELECT * FROM cliente WHERE dni = @dni;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@dni", dni);

            try
            {
                DB_Controller.connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cliente = new Cliente(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetString(6));
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Hay un error en la query: " + ex.Message);
            }
            finally
            {
                DB_Controller.connection.Close();
            }

            return cliente;
        }




        public static bool ExisteClienteConDNI(string dni)
        {
            string query = "SELECT COUNT(*) FROM cliente WHERE dni = @dni;";

            SqlCommand cmd = new SqlCommand(query, DB_Controller.connection);
            cmd.Parameters.AddWithValue("@dni", dni);

            try
            {
                DB_Controller.connection.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0; // Returns true if there is at least one client with the provided DNI
            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar la existencia del cliente: " + ex.Message);
            }
            finally
            {
                DB_Controller.connection.Close();
            }
        }
    }
    }


