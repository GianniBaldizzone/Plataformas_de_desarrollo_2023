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

namespace PrototipoAppDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_error.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bnt_ingresar_Click(object sender, EventArgs e){
            validarUsuario(txt_usuario.Text, txt_contraseña.Text);


            //index index = new index();
            //index.Show();
            //this.Hide();
        }

        private void validarUsuario(String usuario, String contraseña){

            Trace.WriteLine(usuario + "" + contraseña);

            if (string.IsNullOrEmpty(txt_usuario.Text))
            {
                lbl_error = "Debes ingresar un usuario";
                lbl_error.Visible=true
            }
           
            //Validar que ambos textos no esten vacios
            //Validar que exista en la base de datos un usuario
            //obtener el id de ese usuario
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
