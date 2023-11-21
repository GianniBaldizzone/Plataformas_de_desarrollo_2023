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
        private decimal subtotal = 0;
        private decimal descuento = 0;

        public FormVenta()
        {
            InitializeComponent();
            CargarProductos();
            txtBusqueda.TextChanged += TxtBusqueda_TextChanged;
            productosEnCarrito = new List<Producto>();
            dataGridViewCarrito.CellContentClick += dataGridViewCarrito_CellClick;
            dataGridViewDisponibles.CellContentClick += dataGridViewDisponibles_CellContentClick_1;
            txt_descuento.TextChanged += txtDescuento_TextChanged;

            // Asegúrate de que estos controles estén creados en tu formulario
            txt_subtotal.Text = $"Subtotal: {subtotal:C}";
            txt_total.Text = $"Total: {subtotal:C}";
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

        private void dataGridViewCarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Verifica que se haya hecho clic en una celda válida
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Obtiene el valor de la celda "Id"
                    int id = Convert.ToInt32(dataGridViewCarrito.Rows[e.RowIndex].Cells[0].Value);

                    // Busca el producto en la lista del carrito
                    Producto producto = productosEnCarrito.FirstOrDefault(p => p.Id == id);

                    if (producto != null)
                    {
                        // Verifica si se hizo clic en el botón "Quitar"
                        if (dataGridViewCarrito.Columns[e.ColumnIndex].Name == "Quitar")
                        {
                            // Quitar el producto del carrito
                            QuitarProductoDelCarrito(producto);
                        }
                        

                        // Actualiza el DataGridView del carrito
                        CargarProductosEnCarrito();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al intentar quitar o ver el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void QuitarProductoDelCarrito(Producto producto)
        {
            // Crea una copia de la lista actual para evitar modificaciones concurrentes
            List<Producto> productosAEliminar = new List<Producto>(productosEnCarrito);

            // Encuentra y elimina el producto de la lista
            Producto productoAEliminar = productosAEliminar.FirstOrDefault(p => p.Id == producto.Id);

            if (productoAEliminar != null)
            {
                productosEnCarrito.Remove(productoAEliminar);

                // Actualiza el botón en el DataGridView de productos disponibles
                ActualizarBotonEnProductosDisponibles(producto.Id, "Agregar");

                // Actualiza el subtotal
                subtotal -= Convert.ToDecimal(producto.Precio);
                txt_subtotal.Text = $"Subtotal: {subtotal:C}";

                // Actualiza el total final teniendo en cuenta el descuento
                ActualizarTotalFinal();

                // Actualiza el DataGridView del carrito
                CargarProductosEnCarrito();
            }
        }

        private void CargarProductosEnCarrito()
        {
            // Limpia el DataGridView del carrito
            dataGridViewCarrito.Rows.Clear();

            // Agrega los productos actuales en el carrito al DataGridView
            foreach (Producto producto in productosEnCarrito)
            {
                int rowIndex = dataGridViewCarrito.Rows.Add();
                dataGridViewCarrito.Rows[rowIndex].Cells[0].Value = producto.Id.ToString();
                dataGridViewCarrito.Rows[rowIndex].Cells[1].Value = producto.Nombre.ToString();
                dataGridViewCarrito.Rows[rowIndex].Cells[2].Value = producto.Precio.ToString();
                dataGridViewCarrito.Rows[rowIndex].Cells[3].Value = "Ver";
                dataGridViewCarrito.Rows[rowIndex].Cells[4].Value = "Quitar";
            }
        }


        private void AgregarProductoAlCarrito(Producto producto)
        {
            productosEnCarrito.Add(producto);

            int rowIndex = dataGridViewCarrito.Rows.Add();

            dataGridViewCarrito.Rows[rowIndex].Cells[0].Value = producto.Id.ToString();
            dataGridViewCarrito.Rows[rowIndex].Cells[1].Value = producto.Nombre.ToString();
            dataGridViewCarrito.Rows[rowIndex].Cells[2].Value = producto.Precio.ToString();
            dataGridViewCarrito.Rows[rowIndex].Cells[3].Value = "Quitar";

            // Actualizar el botón en el DataGridView de productos disponibles
            ActualizarBotonEnProductosDisponibles(producto.Id, "Quitar");

            // Actualizar el subtotal
            subtotal += Convert.ToDecimal(producto.Precio);
            txt_subtotal.Text = $"Subtotal: {subtotal:C}";

            // Actualizar el total final teniendo en cuenta el descuento
            ActualizarTotalFinal();
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



        private void MostrarClienteEncontrado(Cliente cliente)
        {
            // Limpia los campos antes de mostrar el nuevo cliente
            LimpiarCampos();

            if (cliente != null)
            {
                // Actualiza los TextBox con la información del cliente
                txt_nombre.Text = cliente.Nombre;
                txt_apellido.Text = cliente.Apellido;
                txt_mail.Text = cliente.Mail;
                txt_telefono.Text = cliente.Telefono;
                txt_direccion.Text = cliente.Direccion;
                txt_dni_is.Text = cliente.Dni;
            }
            else
            {
                // Muestra un mensaje si el cliente no fue encontrado
                MessageBox.Show("No se encontró un cliente con ese DNI en la base de datos.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LimpiarCampos()
        {
            // Limpia todos los TextBox
            txt_nombre.Text = string.Empty;
            txt_apellido.Text = string.Empty;
            txt_mail.Text = string.Empty;
            txt_telefono.Text = string.Empty;
            txt_direccion.Text = string.Empty;
            txt_dni_is.Text = string.Empty;
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            // Manejador de eventos para el cambio en el descuento
            // Validar que el descuento ingresado sea un valor numérico
            if (decimal.TryParse(txt_descuento.Text, out decimal nuevoDescuento))
            {
                // Actualizar el descuento
                descuento = nuevoDescuento;

                // Actualizar el total final teniendo en cuenta el nuevo descuento
                ActualizarTotalFinal();
            }
            else
            {
                // Mostrar un mensaje de error si el descuento no es un valor numérico
                MessageBox.Show("Por favor, ingrese un valor numérico válido para el descuento.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarTotalFinal()
        {
            // Calcular el total final restando el descuento del subtotal
            decimal totalFinal = subtotal - descuento;

            // Actualizar el label del total final
            txt_total.Text = $"Total: {totalFinal:C}";
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtén la información ingresada por el usuario
                string nombre = txt_nombre.Text;
                string apellido = txt_apellido.Text;
                string mail = txt_mail.Text;
                string telefono = txt_telefono.Text;
                string direccion = txt_direccion.Text;
                string dni = txt_dni_is.Text;

                // Crea el cliente
                Cliente nuevoCliente = new Cliente(0, nombre, apellido, mail, telefono, direccion, dni);

                // Guarda el nuevo cliente en la base de datos
                Cliente_Controller.crearCliente(nuevoCliente);

                // Muestra un mensaje de éxito
                MessageBox.Show("Cliente creado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error si algo sale mal
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btn_noeliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Obtén el DNI ingresado por el usuario
                string dni = txtDni.Text;

                // Validar que el campo DNI no esté vacío
                if (string.IsNullOrWhiteSpace(dni))
                {
                    MessageBox.Show("Por favor, ingrese un DNI válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Busca el cliente por DNI
                Cliente clienteEncontrado = Cliente_Controller.buscarPorDni(dni);

                // Actualiza los controles de interfaz con la información del cliente encontrado
                MostrarClienteEncontrado(clienteEncontrado);
            }
            catch (Exception ex)
            {
                // Muestra un mensaje de error si algo sale mal
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

