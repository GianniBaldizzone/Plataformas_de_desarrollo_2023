using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Modelo
{
    public class Producto
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public string codigo { get; set; }
        public int Stock { get; set; }
        public string Img { get; set; }

        public string Talle { get; set; }

        public string Proveedor { get; set; }

        public int CategoriaId { get; set; }

        public int SubcategoriaId { get; set; }

        
        
        


        public Producto(int id, string name, string desc, double precio, string cod,int stock, string img, string talle, string proveedor, int categoriaid, int subcategoriaid)
        {
            Id = id;
            Nombre = name;
            Descripcion = desc;
            Precio = precio;
            codigo = cod;
            Stock = stock;
            Img = img;
            Talle = talle;
            Proveedor = proveedor;
            CategoriaId = categoriaid;
            SubcategoriaId = subcategoriaid;
            
        }

        public Producto()
        {
        }


    }
}
