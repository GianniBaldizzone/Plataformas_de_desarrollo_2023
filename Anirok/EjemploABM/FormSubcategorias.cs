using EjemploABM.Controladores;
using EjemploABM.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploABM.ControlesDeUsuario
{
    public partial class FormSubcategorias : Form
    {
        string situacion;
        int id_editar;

        public FormSubcategorias()
        {
            InitializeComponent();

            combo_tipo.Items.Clear();

            combo_tipo.Items.Add("Activo");
            combo_tipo.Items.Add("No Activo");

            situacion = "creacion";

            CargarCategoriasEnComboBox();

        }

        // SOBRECARGAR EL CONSTRUCTOR PARA INICIAR EL FORM CON LA INFO CARGADA, PARA EDITAR
        public FormSubcategorias(Subcategoria sub)
        {
            InitializeComponent();

            id_editar = sub.Id;


            txt_nombre.Text = sub.Nombre.ToString();

            combo_tipo.Items.Clear();
            combo_tipo.Items.Add("Activo");
            combo_tipo.Items.Add("No Activo");

            


            if (sub.IsActive == "Activo")
            {
                combo_tipo.SelectedIndex = 0;
            }
            else
            {
                combo_tipo.SelectedIndex = 1;
            }

            situacion = "edicion";

            label2.Text = "Editar Categoria";
            btn_crear.Text = "Editar";
            CargarCategoriasEnComboBox();
        }

        //Maneja el combobox de categorias

        public void CargarCategoriasEnComboBox()
        {
            
            List<Categoria> categorias = Categoria_Controller.ObtenerCategorias();

            ComboBoxCat.DisplayMember = "Nombre"; // Establece la propiedad que se mostrará en el ComboBox
            ComboBoxCat.ValueMember = "Id"; // Establece la propiedad que se usará como valor interno
            ComboBoxCat.DataSource = categorias; // Asigna la lista de categorías al ComboBox
        }

      

        private void crear()
        {
            if (string.IsNullOrEmpty(txt_nombre.Text) || combo_tipo.SelectedItem == null || ComboBoxCat.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione una categoria antes de crear un usuario.", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            String tipo = "";
            if (combo_tipo.SelectedItem.ToString() == "Activo")
            {
                tipo = "Activa";
            }
            if (combo_tipo.SelectedItem.ToString() == "No Activo")
            {
                tipo = "Desactivada";
            }

            int catId = (int)ComboBoxCat.SelectedValue;
            MessageBox.Show("ID categoria: " +  catId, "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Subcategoria sub = new Subcategoria(0, txt_nombre.Text,catId ,tipo.ToString());

            if (Subcategoria_Controller.crearSubcategoria(sub))
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        private void editar()
        {
            if (string.IsNullOrEmpty(txt_nombre.Text) || combo_tipo.SelectedItem == null || ComboBoxCat.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione un Categoria antes de crear un usuario.", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            

            String tipo = "";
            if (combo_tipo.SelectedItem.ToString() == "Activo")
            {
                tipo = "Activa";
            }
            if (combo_tipo.SelectedItem.ToString() == "No Activo")
            {
                tipo = "Desactivada";
            }
            int catId = (int)ComboBoxCat.SelectedValue;
            Subcategoria sub = new Subcategoria(0, txt_nombre.Text, catId, tipo.ToString());

            if (Subcategoria_Controller.editarSubcategoria(sub))
            {
                this.DialogResult = DialogResult.OK;
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
                editar();
            }

        }
    }
}
