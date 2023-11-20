using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploABM.Modelo
{
    internal class Venta
    {
        
            public int Id { get; set; }
            public float PrecioTotal { get; set; }
            public DateTime Fecha { get; set; }
            public string MetodoDePago { get; set; }
            public float Descuento { get; set; }
            public int ClienteId { get; set; }
            public int UsuarioId { get; set; }

            public Venta()
            {
                // Constructor vacío
            }

            public Venta(int id, float precioTotal, DateTime fecha, string metodoDePago, float descuento, int clienteId, int usuarioId)
            {
                Id = id;
                PrecioTotal = precioTotal;
                Fecha = fecha;
                MetodoDePago = metodoDePago;
                Descuento = descuento;
                ClienteId = clienteId;
                UsuarioId = usuarioId;
            }
        }

}
