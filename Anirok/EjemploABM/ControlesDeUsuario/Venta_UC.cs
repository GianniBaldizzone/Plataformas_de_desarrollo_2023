using EjemploABM.Controladores;
using EjemploABM.Modelo;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace EjemploABM.ControlesDeUsuario
{
    public partial class Ventas_UC : UserControl
    {
        private const int ElementosPorPagina = 10;
        private int paginaActual = 1;
        private List<Venta> ventas;

        public Ventas_UC()
        {
            InitializeComponent();
            CargarVentas();
        }

        private void CargarVentas()
        {
            ventas = Venta_Controller.ObtenerVentas();
            ActualizarVista();
        }

        private void ActualizarVista()
        {
            guna2DataGridView1.Rows.Clear();

            int inicio = (paginaActual - 1) * ElementosPorPagina;
            int fin = Math.Min(inicio + ElementosPorPagina, ventas.Count);

            for (int i = inicio; i < fin; i++)
            {
                int rowIndex = guna2DataGridView1.Rows.Add();

                guna2DataGridView1.Rows[rowIndex].Cells[0].Value = ventas[i].Id.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[1].Value = ventas[i].PrecioTotal.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[2].Value = ventas[i].Fecha.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[3].Value = ventas[i].MetodoDePago.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[4].Value = ventas[i].Descuento.ToString();
                
                guna2DataGridView1.Rows[rowIndex].Cells[7].Value = "Ver";
                guna2DataGridView1.Rows[rowIndex].Cells[8].Value = "Eliminar";
            }

            int totalDePaginasFiltradas = CalcularTotalDePaginasFiltradas();
            lblPaginaActual.Text = $"Página {paginaActual} de {totalDePaginasFiltradas}";
        }

        private int CalcularTotalDePaginasFiltradas()
        {
            int totalDePaginasFiltradas = (int)Math.Ceiling((double)ventas.Count / ElementosPorPagina);
            return totalDePaginasFiltradas;
        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex].Name == "Ver")
            {
                int id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Venta venta_editar = Venta_Controller.ObtenerVentaPorId(id);

                // Lógica para editar la venta
                // Puedes abrir un formulario de edición similar al de categorías
                // y utilizar la lógica de actualización después de la edición.
            }
            else if (senderGrid.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Venta venta_eliminar = Venta_Controller.ObtenerVentaPorId(id);

                DialogResult eliminar = MessageBox.Show("¿Estás seguro de eliminar esta venta?",
                    "Confirmar Eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (eliminar == DialogResult.OK)
                {
                    // Lógica para eliminar la venta
                    // Puedes utilizar el método EliminarVenta del controlador
                    // y luego actualizar la vista llamando a CargarVentas().
                    bool eliminado = Venta_Controller.EliminarVenta(id);
                    if (eliminado)
                    {
                        MessageBox.Show("Venta eliminada exitosamente.", "Eliminación Exitosa",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarVentas();
                    }
                    else
                    {
                        MessageBox.Show("Error al intentar eliminar la venta.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            // Lógica para agregar una nueva venta
            // Puedes abrir un formulario de creación de ventas
            // y utilizar la lógica de actualización después de la creación.
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int totalPaginas = (int)Math.Ceiling((double)ventas.Count / ElementosPorPagina);
            if (paginaActual < totalPaginas)
            {
                paginaActual++;
                ActualizarVista();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                paginaActual--;
                ActualizarVista();
            }
        }

        
    }
}
