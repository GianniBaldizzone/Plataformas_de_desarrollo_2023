using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Modelo
{
    class Subcategoria
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String IsActive { get; set; }

        public int categoria_id { get; set; }

        public Subcategoria(int id, string name, string isActive, int categoria_id)
        {
            Id = id;
            Nombre = name;
            IsActive = isActive;
            categoria_id = categoria_id;


        }

        public Subcategoria()
        {
        }
    }
}
