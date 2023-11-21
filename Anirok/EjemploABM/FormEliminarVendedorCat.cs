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
    public partial class FormEliminarVendedorCat : Form
    {
        int id_eliminar;


        private Categoria cat;
        public FormEliminarVendedorCat()
        {
            InitializeComponent();
        }


        public FormEliminarVendedorCat(Categoria cat_eliminar)
        {
            InitializeComponent();
            id_eliminar = cat_eliminar.Id;
            txt_id_cat.Text = id_eliminar.ToString();
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        

        private void btn_freezar_categoria_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            // Obtener el ID de la categoría que se va a desactivar
            int idCategoria = id_eliminar; // Debes implementar este método según cómo obtienes el ID de la categoría seleccionada

            // Verificar si se seleccionó una categoría
            if (idCategoria > 0)
            {
                try
                {
                    // Intentar desactivar la categoría
                    if (Categoria_Controller.DesactivarCategoria(idCategoria))
                    {
                        MessageBox.Show("Categoría desactivada correctamente.");
                        // Actualizar la lista de categorías en tu DataGridView u otra lógica de presentación
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Error al desactivar la categoría.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Selecciona una categoría antes de eliminar.");
            }
        }
    }
    }

