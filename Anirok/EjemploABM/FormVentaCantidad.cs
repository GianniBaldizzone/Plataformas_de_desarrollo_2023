using EjemploABM.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public FormVentaCantidad()
        {
            InitializeComponent();
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            // Obtener la cantidad ingresada por el usuario desde el control NumericUpDown
            CantidadSeleccionada = (int)txtCantidad.Value;

            // Validar que se haya seleccionado al menos una unidad
            if (CantidadSeleccionada <= 0)
            {
                MessageBox.Show("Debe seleccionar al menos una unidad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Cerrar el formulario con DialogResult OK
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
