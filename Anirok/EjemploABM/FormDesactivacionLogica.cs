using EjemploABM.Controladores;
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
    public partial class FormDesactivacionLogica : Form
    {
        Categoria cat;
        int id_editar;
        public FormDesactivacionLogica(Categoria cat)
        {
            InitializeComponent();

            id_editar = cat.Id;
            CargarCategoriasEnComboBoxCrear();
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            Categoria_Controller.DesactivarCategoria(id_editar);
            int catId = (int)ComboBoxCat.SelectedValue;

            int idAnteriorCategoria = 1;  // Reemplaza con el ID de la categoría anterior
            int idCategoriaPosterior = 2; // Reemplaza con el ID de la categoría posterior

            try
            {
                bool cambioExitoso = Producto_Controller.CambiarCategoriaDeProductos(idAnteriorCategoria, idCategoriaPosterior);

                if (cambioExitoso)
                {
                    Console.WriteLine("Cambio de categoría exitoso.");
                }
                else
                {
                    Console.WriteLine("No se realizó ningún cambio en la categoría.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cambiar la categoría de los productos: " + ex.Message);
            }

        }

        public void CargarCategoriasEnComboBoxCrear()
        {
            List<Categoria> categorias = Categoria_Controller.ObtenerCategoriasActivas();

            ComboBoxCat.DisplayMember = "Nombre"; // Establece la propiedad que se mostrará en el ComboBox
            ComboBoxCat.ValueMember = "Id"; // Establece la propiedad que se usará como valor interno
            ComboBoxCat.DataSource = categorias; // Asigna la lista de categorías al ComboBox
        }
    }
}
