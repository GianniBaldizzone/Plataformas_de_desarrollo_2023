using System;
using System.Windows.Forms;

namespace EjemploABM
{
    public partial class FormVentaCantidad : Form
    {
        public int CantidadSeleccionada { get; private set; }

        // Propiedad para establecer el máximo de cantidad permitida
        public int MaxCantidad
        {
            set
            {
                txtCantidad.Maximum = value;
            }
        }

        // Agregar una propiedad para almacenar el stock del producto
        public int StockProducto { get; private set; }

        // Modificar el constructor para recibir el stock del producto
        public FormVentaCantidad(int stockProducto)
        {
            InitializeComponent();

            // Almacena el stock del producto
            StockProducto = stockProducto;

            // Establece el máximo del control NumericUpDown basado en el stock del producto
            txtCantidad.Maximum = stockProducto;
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            // Obtener la cantidad ingresada por el usuario desde el control NumericUpDown
            CantidadSeleccionada = (int)txtCantidad.Value;

            // Validar que la cantidad sea mayor a cero y no supere el stock del producto
            if (CantidadSeleccionada <= 0 || CantidadSeleccionada > StockProducto)
            {
                MessageBox.Show("Debe seleccionar una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cerrar el formulario con DialogResult OK
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}