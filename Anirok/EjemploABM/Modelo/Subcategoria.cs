using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Modelo
{
    public class Subcategoria
    {
        public int Id { get; set; }
        public String Nombre { get; set; }

        public int categoria_id { get; set; }
        public String IsActive { get; set; }

        

        public Subcategoria(int id, string name, int categoria_id, string isActive )
        {
            Id = id;
            Nombre = name;
            categoria_id = categoria_id;
            IsActive = isActive;
            


        }

        public Subcategoria()
        {
        }
    }
}
