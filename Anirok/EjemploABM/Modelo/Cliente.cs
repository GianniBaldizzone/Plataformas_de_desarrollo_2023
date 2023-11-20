using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Modelo
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Dni { get; set; }

        public Cliente(int id, string nombre, string apellido, string mail, string telefono, string direccion, string dni)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            Mail = mail;
            Telefono = telefono;
            Direccion = direccion;
            Dni = dni;
        }

        public Cliente()
        {
        }

    }
}
