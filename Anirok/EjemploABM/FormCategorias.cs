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
        }
        public FormCategorias(Categoria cat)
        {
            InitializeComponent();

            id_editar = cat.Id;


            txt_nombre.Text = cat.Nombre.ToString();
            combo_tipo.Items.Clear();
            combo_tipo.Items.Add("Activo");
            combo_tipo.Items.Add("No Activo");


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

        private void btn_crear_Click(object sender, EventArgs e)
        {
            if (situacion == "creacion")
            {
                crear();
            }
          
        }

        private void crear()
        {
            if (string.IsNullOrEmpty(txt_nombre.Text)|| combo_tipo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione un rol antes de crear un usuario.", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tipo = 2;
            if (combo_tipo.SelectedItem.ToString() == "Admin")
            {
                tipo = 1;
            }

            Categoria cat = new Categoria(0, txt_nombre.Text, combo_tipo.Text);

            if (Categoria_Controller.crearCategoria(cat))
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void combo_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}
