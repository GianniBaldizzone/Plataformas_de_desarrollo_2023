using EjemploABM.Controladores;
using EjemploABM.Modelo;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            if (string.IsNullOrEmpty(txt_nombre.Text) || string.IsNullOrEmpty(txt_descripcion.Text) || string.IsNullOrEmpty(txt_precio.Text) || string.IsNullOrEmpty(txt_codigo.Text) || string.IsNullOrEmpty(txt_cantidad.Text) || string.IsNullOrEmpty(txt_proveedor.Text) || comboBoxTalle.SelectedItem == null || nombrefoto == null)
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione un rol antes de crear un usuario.", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string talle = "";
            if (comboBoxTalle.SelectedItem.ToString() == "S")
            {
                talle = "S";
            }
            else if (comboBoxTalle.SelectedItem.ToString() == "M")
            {

                talle = "M";
            }
            else if (comboBoxTalle.SelectedItem.ToString() == "L")
            {
                talle = "L";
            }
            else if (comboBoxTalle.SelectedItem.ToString() == "XL")
            {
                talle = "XL";
            }
            else {
                talle = "No tiene";
            }

            int catId = (int)comboBoxCat.SelectedValue;
            if (catId == null || catId == 0)
            {
                MessageBox.Show("ID categoria: " + catId, "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            int subId = (int)comboBoxSub.SelectedValue;

            float precio;
            if (float.TryParse(txt_precio.Text, out precio))
            {
                // La conversión del precio fue exitosa.

                int cantidad;
                if (int.TryParse(txt_cantidad.Text, out cantidad))
                {
                    // La conversión de la cantidad fue exitosa, puedes crear el objeto Producto.
                    
                    Producto produ = new Producto(0, txt_nombre.Text, txt_descripcion.Text, precio, txt_codigo.Text, cantidad, nombrefoto, talle, txt_proveedor.Text, catId, subId);
                    if (Producto_Controller.crearProducto(produ))
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
                else
                {
                    // Manejar el caso en el que no se pudo realizar la conversión de cantidad.
                    MessageBox.Show("El valor de la cantidad no es válido.");
                }
            }
            else
            {
                // Manejar el caso en el que no se pudo realizar la conversión de precio.
                MessageBox.Show("El valor del precio no es válido.");
            }
            
            
            
            
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
            // Verificar si se ha seleccionado una imagen
            if (File == null)
            {
                MessageBox.Show("Debes seleccionar una imagen antes de guardarla.");
                return; // Salir de la función si no hay imagen seleccionada
            }

            int nombreProd;
            nombreProd = Producto_Controller.obtenerMaxId();
            string nombreProdStr = nombreProd.ToString();

            // Verificar si el nombre del producto es válido
            if (string.IsNullOrEmpty(nombreProdStr))
            {
                MessageBox.Show("El nombre del producto no es válido.");
                return; // Salir de la función si el nombre del producto no es válido
            }

            try
            {
                string filePath = @"C:\Users\Usuario\Documents\GitHub\Plataformas_de_desarrollo_2023\Anirok\EjemploABM\Recursos\img\" + nombreProdStr + ".jpg";

                // Asegurarse de que el directorio de destino exista
                if (!Directory.Exists(Path.GetDirectoryName(filePath)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(filePath));
                }

                // Guardar la imagen en el directorio de destino
                File.Save(filePath);

                MessageBox.Show("Imagen guardada con éxito.");
                nombrefoto = nombreProdStr + ".jpg";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar la imagen: " + ex.Message);
            }

            crear();
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
