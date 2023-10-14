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
using MaterialSkin;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                textBox1.Text = "";
                textBox2.Text = "";
                labelError.Visible = true;
                labelError.Text = "Usuario o contraseña incorrectos. Intente de nuevo.";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configura el SkinManager para tu formulario
            MaterialSkinManager manager = MaterialSkinManager.Instance;


            // Cambia el color de fondo del botón
            manager.ColorScheme = new ColorScheme(
                Primary.Red900, // Cambiar el color de fondo del botón
                Primary.Red500, // Cambiar el color de acento del botón
                Primary.Red500, // Cambiar el color de la barra de título del formulario
                Accent.Orange200,
                TextShade.WHITE
            );

        }

        
        

        private void btn_log_Click(object sender, EventArgs e)
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
                textBox1.Text = "";
                textBox2.Text = "";
                labelError.Visible = true;
                labelError.Text = "Usuario o contraseña incorrectos. Intente de nuevo.";
            }

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Usuario")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.LightGray;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "") {
                textBox1.Text = "Usuario";
                textBox1.ForeColor = Color.LightGray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Contraseña")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.LightGray;
                //para que se oculten los caracteres
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Contraseña";
                textBox2.ForeColor = Color.LightGray;
                
                textBox2.UseSystemPasswordChar = false;

            }
        }

        //CERRAR Y MINIMIZAR 

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
