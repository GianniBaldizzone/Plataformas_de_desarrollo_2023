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
    public partial class FormCategorias : Form
    {
        string situacion;
        int id_editar;

        public FormCategorias()
        {
            InitializeComponent();

            combo_tipo.Items.Clear();

            combo_tipo.Items.Add("Activo");
            combo_tipo.Items.Add("No Activo");

            situacion = "creacion";

        }

        // SOBRECARGAR EL CONSTRUCTOR PARA INICIAR EL FORM CON LA INFO CARGADA, PARA EDITAR
        public FormCategorias(Categoria cat)
        {
            InitializeComponent();

            id_editar = cat.Id;


            txt_nombre.Text = cat.Nombre.ToString();

            combo_tipo.Items.Clear();
            combo_tipo.Items.Add("Activo");
            combo_tipo.Items.Add("No Activo");

            if (cat.IsActive == "Activo")
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
        }

        private void btn_crear_Click(object sender, EventArgs e)
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


        private void crear()
        {
            if (string.IsNullOrEmpty(txt_nombre.Text) || combo_tipo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione un rol antes de crear un usuario.", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tipo = "";
            if (combo_tipo.SelectedItem.ToString() == "Activo")
            {
                tipo = "Activa";
            }
            else if (combo_tipo.SelectedItem.ToString() == "No Activo")
            {
                tipo = "Desactivada";
            }

            Categoria cat = new Categoria(0, txt_nombre.Text, tipo.ToString());

            if (Categoria_Controller.crearCategoria(cat))
            {
                this.DialogResult = DialogResult.OK;
            }
        }
        private void editar()
        {
            if (string.IsNullOrEmpty(txt_nombre.Text) || combo_tipo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione un rol antes de crear un usuario.", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string tipo = "";
            if (combo_tipo.SelectedItem.ToString() == "Activo")
            {
                tipo = "Activa";
            }
            else if (combo_tipo.SelectedItem.ToString() == "No Activo")
            {
                tipo = "Desactivada";
            }

            Categoria cat = new Categoria(id_editar, txt_nombre.Text, tipo.ToString());

            if (Categoria_Controller.editarCategoria(cat))
            {
                this.DialogResult = DialogResult.OK;
            }
        }





        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

       


        private void combo_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
