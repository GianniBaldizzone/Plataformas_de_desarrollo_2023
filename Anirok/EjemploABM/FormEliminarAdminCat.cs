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

namespace EjemploABM
{
    public partial class FormEliminarAdminCat : Form
    {
        int id_eliminar;


        private Categoria cat;
        public FormEliminarAdminCat()
        {
            InitializeComponent();
        }


        public FormEliminarAdminCat(Categoria cat_eliminar)
        {
            InitializeComponent();
            id_eliminar = cat_eliminar.Id;
            txt_id_cat.Text = id_eliminar.ToString();
        }



        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            Categoria cat_eliminar = Categoria_Controller.obtenerPorId(id_eliminar);
            FormEliminarCat formeliminarcat = new FormEliminarCat(cat_eliminar);
            //this.Hide();
            DialogResult eliminar;
            eliminar = formeliminarcat.ShowDialog();
            
            if (eliminar == DialogResult.OK){
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
            
            
        }

        private void btn_desactivar_Click(object sender, EventArgs e)
        {
            Categoria cat_eliminar = Categoria_Controller.obtenerPorId(id_eliminar);
            FormEliminarVendedorCat formeliminarcat = new FormEliminarVendedorCat(cat_eliminar);
            //this.Hide();
            DialogResult eliminar;
            eliminar = formeliminarcat.ShowDialog();

            if (eliminar == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void FormEliminarAdmin_Load(object sender, EventArgs e)
        {

        }

        
    }
}
