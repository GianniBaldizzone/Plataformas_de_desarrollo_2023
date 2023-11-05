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
    }
}
