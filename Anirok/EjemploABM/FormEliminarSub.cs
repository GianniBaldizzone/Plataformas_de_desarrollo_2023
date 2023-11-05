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
    public partial class FormEliminarSub : Form
    {

        int id_eliminar;


        private Subcategoria sub;
        public FormEliminarSub()
        {
            InitializeComponent();
        }

        public FormEliminarSub(Subcategoria sub_eliminar)
        {
            InitializeComponent();
            id_eliminar = sub_eliminar.Id;
            txt_id_sub.Text = id_eliminar.ToString();
        }
       

        private void btn_sieliminar_Click(object sender, EventArgs e)
        {
            if (Subcategoria_Controller.eliminarSubcategoria(id_eliminar))
            {
                this.DialogResult = DialogResult.OK;
                this.Hide();
            }
        }

        private void btn_noeliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
