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
        private int elementosPorPagina = 7;
        private int paginaActual = 1;
        private int totalDePaginas;

        public FormVenta()
        {
            InitializeComponent();
            CargarProductos();
            txtBusqueda.TextChanged += TxtBusqueda_TextChanged;
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
                    dataGridViewDisponibles.Rows[rowIndex].Cells[3].Value = "Ver";
                    dataGridViewDisponibles.Rows[rowIndex].Cells[4].Value = "Agregar";
                }

                lblPaginaActual.Text = $"Página {paginaActual} de {totalDePaginasFiltradas}";
            }
        }

        private void CargarProductos()
        {
            productosDisponibles = Producto_Controller.obtenerProductos();

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

       

        private void dataGridViewDisponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Trace.WriteLine("estoy andando");
            Debug.WriteLine("Celda seleccionada: " + e.ColumnIndex + ", " + e.RowIndex);

            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex].Name == "Ver")
            {
                int id = int.Parse(dataGridViewDisponibles.Rows[e.RowIndex].Cells[0].Value.ToString());
                Trace.WriteLine("el id es: " + id);

                Producto prod_editar = Producto_Controller.obtenerPorId(id);

                FormVerProd formver = new FormVerProd(prod_editar);

                DialogResult dr = formver.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    Trace.WriteLine("OK - se edito");
                    CargarProductos();
                }
            }
            else if (senderGrid.Columns[e.ColumnIndex].Name == "Agregar")
            {
                int id = int.Parse(dataGridViewDisponibles.Rows[e.RowIndex].Cells[0].Value.ToString());
                Trace.WriteLine("el id es: " + id);

                Producto prod_agregar = Producto_Controller.obtenerPorId(id);

                // Agregar el producto al DataGridView del carrito
                AgregarProductoAlCarrito(prod_agregar);
            }
        }

        private void AgregarProductoAlCarrito(Producto producto)
        {
            int rowIndex = dataGridViewCarrito.Rows.Add();

            dataGridViewDisponibles.Rows[rowIndex].Cells[0].Value = producto.Id.ToString();
            dataGridViewDisponibles.Rows[rowIndex].Cells[1].Value = producto.Nombre.ToString();
            dataGridViewDisponibles.Rows[rowIndex].Cells[2].Value = producto.Precio.ToString();
            dataGridViewDisponibles.Rows[rowIndex].Cells[3].Value = "Ver";
            dataGridViewDisponibles.Rows[rowIndex].Cells[4].Value = "Quitar";
        }

       
    }
}

