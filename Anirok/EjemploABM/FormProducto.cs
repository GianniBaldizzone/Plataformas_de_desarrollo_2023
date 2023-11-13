using EjemploABM.Controladores;
using EjemploABM.ControlesDeUsuario;
using EjemploABM.Modelo;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Resources.ResXFileRef;

namespace EjemploABM
{
    public partial class FormProducto : Form
    {
        Image File;
        
        string situacion;
        int id_editar;
        string nombrefoto;

        public FormProducto()
        {
            InitializeComponent();

            comboBoxTalle.Items.Clear();

            comboBoxTalle.Items.Add("S");
            comboBoxTalle.Items.Add("M");
            comboBoxTalle.Items.Add("L");
            comboBoxTalle.Items.Add("XL");
            comboBoxTalle.Items.Add("No tiene");
            CargarCategoriasEnComboBoxCrear();
            comboBoxCat.SelectedIndexChanged += ComboBoxCat_SelectedIndexChanged;
            situacion = "creacion";
        }


        // SOBRECARGAR EL CONSTRUCTOR PARA INICIAR EL FORM CON LA INFO CARGADA, PARA EDITAR
        
        private void btn_cargar_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
                
                ofd.Filter = "*JPG(*.JPG)|*.jpg";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    File = Image.FromFile(ofd.FileName);
                guna2PictureBox1.Image = File;
                }
            
        }


        private void btn_crear_Click_1(object sender, EventArgs e)
        {
            if (situacion == "creacion")
            {
                crear();
            }
            if (situacion == "edicion")
            {
                
            }

        }



        private void crear()
        {
            if (string.IsNullOrWhiteSpace(txt_nombre.Text) ||
                string.IsNullOrWhiteSpace(txt_descripcion.Text) ||
                string.IsNullOrWhiteSpace(txt_precio.Text) ||
                string.IsNullOrWhiteSpace(txt_codigo.Text) ||
                string.IsNullOrWhiteSpace(txt_cantidad.Text) ||
                string.IsNullOrWhiteSpace(txt_proveedor.Text) ||
                comboBoxTalle.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione un rol antes de crear un usuario.", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string talle = comboBoxTalle.SelectedItem?.ToString() ?? "No tiene";

            int catId;
            if (!int.TryParse(comboBoxCat.SelectedValue?.ToString(), out catId) || catId == 0)
            {
                MessageBox.Show("ID categoría no válido.", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int subId;
            if (!int.TryParse(comboBoxSub.SelectedValue?.ToString(), out subId))
            {
                MessageBox.Show("ID subcategoría nulo debido a que no existen subcategorias de esa categoria", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            float precio;
            if (float.TryParse(txt_precio.Text, out precio))
            {
                int cantidad;
                if (int.TryParse(txt_cantidad.Text, out cantidad))
                {
                    try
                    {
                        // Asignar el nombre de la foto antes de intentar crear el producto
                        int nombreProdStr = Producto_Controller.obtenerMaxId();
                        nombrefoto = (nombreProdStr+1) + ".jpg";

                        Producto produ = new Producto(0, txt_nombre.Text, txt_descripcion.Text, precio, txt_codigo.Text, nombrefoto, txt_proveedor.Text, subId, catId, talle, cantidad);

                        // Intentar crear el producto
                        if (Producto_Controller.crearProducto(produ))
                        {

                            this.DialogResult = DialogResult.OK;
                            // Guardar la imagen solo si el producto se ha creado con éxito
                            string filePath = @"C:\Users\Usuario\Documents\GitHub\Plataformas_de_desarrollo_2023\Anirok\EjemploABM\Recursos\img" + nombrefoto;

                            // Asegurarse de que el directorio de destino exista
                            if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                            {
                                Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                            }

                            // Guardar la imagen en el directorio de destino
                            File.Save(filePath);

                            MessageBox.Show("Producto y imagen guardados con éxito.");
                        }
                        else
                        {
                            MessageBox.Show("Error al crear el producto.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al crear el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El valor de la cantidad no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El valor del precio no es válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarDetallesProducto(Producto producto)
        {
            MessageBox.Show(
                "Nombre: " + producto.Nombre +
                "\nDescripción: " + producto.Descripcion +
                "\nPrecio: " + producto.Precio +
                "\nCódigo: " + producto.codigo +
                "\nCantidad: " + producto.Stock +
                "\nFoto: " + producto.Img +
                "\nTalle: " + producto.Talle +
                "\nProveedor: " + producto.Proveedor +
                "\nCategoría ID: " + producto.CategoriaId +
                "\nSubcategoría ID: " + producto.SubcategoriaId
            );
        }

        public void CargarCategoriasEnComboBoxCrear()
        {
                comboBoxCat.DisplayMember = "Nombre"; // Establece la propiedad que se mostrará en el ComboBox
                comboBoxCat.ValueMember = "Id"; // Establece la propiedad que se usará como valor interno
                comboBoxCat.DataSource = Categoria_Controller.ObtenerCategoriasActivas(); // Asigna la lista de categorías al ComboBox
                comboBoxCat.SelectedIndex = -1; // Establece la selección actual en vacío (ningún elemento seleccionado)
            }

        private void ComboBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxCat.SelectedIndex != -1)
            {
                int categoriaId = (int)comboBoxCat.SelectedValue; // Obtenemos el Id de la categoría seleccionada
                CargarSubcategoriasEnComboBoxCrear(categoriaId);
                comboBoxSub.Visible = true;
            }
            else
            {
                comboBoxSub.Visible = false; // Ocultar el ComboBox de subcategorías si no hay categoría seleccionada
            }
        }

        public void CargarSubcategoriasEnComboBoxCrear(int categoriaId)
        {
            comboBoxSub.DisplayMember = "Nombre"; // Establece la propiedad que se mostrará en el ComboBox
            comboBoxSub.ValueMember = "Id"; // Establece la propiedad que se usará como valor interno
            comboBoxSub.DataSource = Subcategoria_Controller.ObtenerSubcategoriasPorCategoria(categoriaId); // Asigna las subcategorías filtradas por categoría al ComboBox
            comboBoxSub.SelectedIndex = -1; // Establece la selección actual en vacío (ningún elemento seleccionado)
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            crear();
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lbl_nombre_Click(object sender, EventArgs e)
        {

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_precio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCat_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }




        //public void CargarSubcategoriasEnComboBoxCrear()
        //{


        //comboBoxSub.DisplayMember = "Nombre"; // Establece la propiedad que se mostrará en el ComboBox
        //comboBoxSub.ValueMember = "Id"; // Establece la propiedad que se usará como valor interno
        //comboBoxSub.DataSource = (); // Asigna la lista de subcategorías al ComboBox
        //comboBoxCat.SelectedIndex = -1; // Establece la selección actual en vacío (ningún elemento seleccionado)
        //}
    }
}
