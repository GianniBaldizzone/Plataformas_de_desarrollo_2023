using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using EjemploABM.Controladores;
using EjemploABM.Modelo;
using Guna.UI2.WinForms;

namespace EjemploABM
{
    public partial class FormVenta : Form
    {
        private List<Producto> productosDisponibles;
        private List<Producto> productosEnCarrito;
        private int elementosPorPagina = 7;
        private int paginaActual = 1;
        private int totalDePaginas;

        public FormVenta()
        {
            InitializeComponent();
            CargarProductos();
            txtBusqueda.TextChanged += TxtBusqueda_TextChanged;
            productosEnCarrito = new List<Producto>();
            dataGridViewCarrito.CellContentClick += dataGridViewCarrito_CellContentClick;
            dataGridViewDisponibles.CellContentClick += dataGridViewDisponibles_CellContentClick_1;
        }

        private void TxtBusqueda_TextChanged(object sender, EventArgs e)
        {
            FiltrarProductosPorNombre(txtBusqueda.Text);
        }

        private void FiltrarProductosPorNombre(string nombre)
        {
            if (productosDisponibles != null)
            {
                List<Producto> productosFiltrados = productosDisponibles
                    .Where(prod => prod.Nombre.ToLower().Contains(nombre.ToLower()))
                    .ToList();

                int totalDePaginasFiltradas = (int)Math.Ceiling((double)productosFiltrados.Count / elementosPorPagina);
                int inicio = (paginaActual - 1) * elementosPorPagina;
                int fin = Math.Min(inicio + elementosPorPagina, productosFiltrados.Count);

                dataGridViewDisponibles.Rows.Clear();

                for (int i = inicio; i < fin; i++)
                {
                    Producto prod = productosFiltrados[i];
                    int rowIndex = dataGridViewDisponibles.Rows.Add();

                    dataGridViewDisponibles.Rows[rowIndex].Cells[0].Value = prod.Id.ToString();
                    dataGridViewDisponibles.Rows[rowIndex].Cells[1].Value = prod.Nombre.ToString();
                    dataGridViewDisponibles.Rows[rowIndex].Cells[2].Value = prod.Precio.ToString();

                    // Verificar si el producto ya está en el carrito y cambiar el botón en consecuencia
                    if (productosEnCarrito.Any(p => p.Id == prod.Id))
                    {
                        dataGridViewDisponibles.Rows[rowIndex].Cells[4].Value = "Quitar";
                    }
                    else
                    {
                        dataGridViewDisponibles.Rows[rowIndex].Cells[4].Value = "Agregar";
                    }
                }

                lblPaginaActual.Text = $"Página {paginaActual} de {totalDePaginasFiltradas}";
            }
        }

        private void CargarProductos()
        {
            productosDisponibles = Producto_Controller.obtenerProductos();

            if (productosDisponibles != null)
            {
                totalDePaginas = (int)Math.Ceiling((double)productosDisponibles.Count / elementosPorPagina);
                int inicio = (paginaActual - 1) * elementosPorPagina;
                int fin = Math.Min(inicio + elementosPorPagina, productosDisponibles.Count);

                dataGridViewDisponibles.Rows.Clear();

                for (int i = inicio; i < fin; i++)
                {
                    Producto prod = productosDisponibles[i];
                    int rowIndex = dataGridViewDisponibles.Rows.Add();

                    dataGridViewDisponibles.Rows[rowIndex].Cells[0].Value = prod.Id.ToString();
                    dataGridViewDisponibles.Rows[rowIndex].Cells[1].Value = prod.Nombre.ToString();
                    dataGridViewDisponibles.Rows[rowIndex].Cells[2].Value = prod.Precio.ToString();
                    dataGridViewDisponibles.Rows[rowIndex].Cells[3].Value = "Ver";
                    dataGridViewDisponibles.Rows[rowIndex].Cells[4].Value = "Agregar";
                }

                lblPaginaActual.Text = $"Página {paginaActual} de {totalDePaginas}";
            }
            else
            {
                MessageBox.Show("No se pudieron cargar los productos. La lista es nula.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_anterior_Click_1(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                paginaActual--;
                CargarProductos();
            }
        }

        private void btn_siguiente_Click_1(object sender, EventArgs e)
        {
            if ((paginaActual * elementosPorPagina) < productosDisponibles.Count)
            {
                paginaActual++;
                CargarProductos();
            }
        }

        private void dataGridViewDisponibles_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewDisponibles.Columns["Agregar"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridViewDisponibles.Rows[e.RowIndex].Cells["Id"].Value);
                Producto producto = Producto_Controller.obtenerPorId(id);

                // Verificar si el producto ya está en el carrito
                if (!productosEnCarrito.Any(p => p.Id == producto.Id))
                {
                    // Agregar el producto al carrito
                    AgregarProductoAlCarrito(producto);

                    // Actualizar la vista de productos disponibles
                    CargarProductos();
                }
            }

            else if (e.ColumnIndex == dataGridViewDisponibles.Columns["Ver"].Index && e.RowIndex >= 0)
                {
                    int id2 = int.Parse(dataGridViewDisponibles.Rows[e.RowIndex].Cells[0].Value.ToString());
                    Trace.WriteLine("el id es: " + id2);
                    Producto prod_elim = Producto_Controller.obtenerPorId(id2);
                    FormVerProd formverprod = new FormVerProd(prod_elim);
                    DialogResult ver = formverprod.ShowDialog();
                }
            }


        private void dataGridViewCarrito_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewCarrito.Columns["Quitar"].Index && e.RowIndex >= 0)
            {
                int id = Convert.ToInt32(dataGridViewCarrito.Rows[e.RowIndex].Cells[0].Value);
                Producto producto = productosEnCarrito.FirstOrDefault(p => p.Id == id);

                if (producto != null)
                {
                    // Quitar el producto del carrito
                    QuitarProductoDelCarrito(producto);
                }
            }
        }

        private void AgregarProductoAlCarrito(Producto producto)
        {
            productosEnCarrito.Add(producto);

            int rowIndex = dataGridViewCarrito.Rows.Add();

            dataGridViewCarrito.Rows[rowIndex].Cells[0].Value = producto.Id.ToString();
            dataGridViewCarrito.Rows[rowIndex].Cells[1].Value = producto.Nombre.ToString();
            dataGridViewCarrito.Rows[rowIndex].Cells[2].Value = producto.Precio.ToString();
            dataGridViewCarrito.Rows[rowIndex].Cells[3].Value = "Ver";
            dataGridViewCarrito.Rows[rowIndex].Cells[4].Value = "Quitar";

            // Actualizar el botón en el DataGridView de productos disponibles
            ActualizarBotonEnProductosDisponibles(producto.Id, "Quitar");
        }

        private void QuitarProductoDelCarrito(Producto producto)
        {
            productosEnCarrito.Remove(producto);

            // Puedes implementar la lógica para quitar la fila del DataGridView del carrito.
            // Aquí estoy simplemente removiendo la primera fila que coincide con el Id del producto.
            var row = dataGridViewCarrito.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(r => Convert.ToInt32(r.Cells[0].Value) == producto.Id);

            if (row != null)
            {
                dataGridViewCarrito.Rows.Remove(row);
            }

            // Actualizar el botón en el DataGridView de productos disponibles
            ActualizarBotonEnProductosDisponibles(producto.Id, "Agregar");
        }

        private void ActualizarBotonEnProductosDisponibles(int productId, string buttonText)
        {
            var row = dataGridViewDisponibles.Rows.Cast<DataGridViewRow>()
                .FirstOrDefault(r => Convert.ToInt32(r.Cells["Id"].Value) == productId);

            if (row != null)
            {
                row.Cells["Agregar"].Value = buttonText;
            }
        }
    }
}