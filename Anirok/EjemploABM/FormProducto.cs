using EjemploABM.Controladores;
using EjemploABM.Modelo;
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

namespace EjemploABM
{
    public partial class FormProducto : Form
    {
        Image File;
        
        string situacion;
        int id_editar;

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


        //public void CargarSubcategoriasEnComboBoxCrear()
        //{


        //comboBoxSub.DisplayMember = "Nombre"; // Establece la propiedad que se mostrará en el ComboBox
        //comboBoxSub.ValueMember = "Id"; // Establece la propiedad que se usará como valor interno
        //comboBoxSub.DataSource = (); // Asigna la lista de subcategorías al ComboBox
        //comboBoxCat.SelectedIndex = -1; // Establece la selección actual en vacío (ningún elemento seleccionado)
        //}
    }
}
