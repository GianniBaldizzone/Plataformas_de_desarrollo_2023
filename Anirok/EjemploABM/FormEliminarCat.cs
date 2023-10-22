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
    public partial class FormEliminarCat : Form
    {
        int id_eliminar;
    

        private Categoria cat;
        public FormEliminarCat()
        {
            InitializeComponent();
        }


        public FormEliminarCat(Categoria cat_eliminar)
        {
            InitializeComponent();
            id_eliminar = cat_eliminar.Id;
            txt_id_cat.Text = id_eliminar.ToString();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_usuario_Click(object sender, EventArgs e)
        {

        }

        private void btn_noeliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_sieliminar_Click(object sender, EventArgs e)
        {
            if (Categoria_Controller.eliminarCategoria(id_eliminar))
            {
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

