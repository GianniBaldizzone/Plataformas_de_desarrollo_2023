using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Modelo
{
    public class Usuario
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Mail { get; set; }
        public String Telefono { get; set; }
        public String Direccion { get; set; }
        public String Dni { get; set; }
        public String Contraseña { get; set; }
        public int Rol { get; set; }

        public Usuario(int id, string nombre, string apellido, string mail, string telefono, String direccion, String dni, String contraseña, int rol)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Mail = mail;
            Telefono = telefono;
            Direccion = direccion;
            Dni = dni;
            Contraseña = contraseña;
            Rol = rol;
        }
        public Usuario()
        {

        }
    }
}
