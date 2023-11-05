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


        private void btn_cambiar_Click(object sender, EventArgs e)
        {
            Categoria cat_eliminar = Categoria_Controller.obtenerPorId(id_eliminar);
            FormDesactivacionLogica formdesactivar = new FormDesactivacionLogica(cat_eliminar);
            //this.Hide();
            DialogResult eliminar;
            eliminar = formdesactivar.ShowDialog();

            if (eliminar == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
            }
            this.Close();
        }
    }
    }

