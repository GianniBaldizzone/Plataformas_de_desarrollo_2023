using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjemploABM.Controladores;

namespace EjemploABM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelError.Visible = false;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (Usuario_Controller.autenticar(textBox1.Text, textBox2.Text, true))
            {
                Index index = new Index();
                index.Show();
                this.Hide();
            }
            else
            {
                // Mostrar mensaje de error
                labelError.Visible = true;
                labelError.Text = "Usuario o contraseña incorrectos. Intente de nuevo.";
            }
        }

       
    }
}
