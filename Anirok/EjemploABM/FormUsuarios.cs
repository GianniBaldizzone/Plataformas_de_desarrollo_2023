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
using EjemploABM.Modelo;

namespace EjemploABM
{
    public partial class FormUsuarios : Form
    {
        string situacion;
        int id_editar;

        public FormUsuarios()
        {
            InitializeComponent();

            combo_tipo.Items.Clear();

            combo_tipo.Items.Add("Admin");
            combo_tipo.Items.Add("Vendedor");

            situacion = "creacion";
        }


        // SOBRECARGAR EL CONSTRUCTOR PARA INICIAR EL FORM CON LA INFO CARGADA, PARA EDITAR
        public FormUsuarios(Usuario usr)
        {
            InitializeComponent();

            id_editar = usr.Id;


            txt_nombre.Text = usr.Nombre.ToString();
            txt_apellido.Text = usr.Apellido.ToString();
            txt_mail.Text = usr.Mail.ToString();
            txt_direccion.Text = usr.Direccion.ToString();
            txt_telefono.Text = usr.Telefono.ToString();
            txt_dni.Text = usr.Dni.ToString();
            
            



            combo_tipo.Items.Clear();
            combo_tipo.Items.Add("Admin");
            combo_tipo.Items.Add("Vendedor");

            if (usr.Rol == 1)
            {
                combo_tipo.SelectedIndex = 0;
            }
            else
            {
                combo_tipo.SelectedIndex = 1;
            }

            situacion = "edicion";

            label2.Text = "Editar Usuario";
            btn_crear.Text = "Editar";


        }

        private void btn_crear_Click_1(object sender, EventArgs e)
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
            int tipo = 2;
            if (combo_tipo.SelectedItem.ToString() == "Admin")
            {
                tipo = 1;
            }

            Usuario usr = new Usuario(0, txt_nombre.Text, txt_apellido.Text, txt_mail.Text, txt_direccion.Text, txt_telefono.Text, txt_dni.Text, txt_contraseña.Text, tipo);

            if (Usuario_Controller.crearUsuario(usr))
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void editar()
        {
            int tipo = 2;
            if (combo_tipo.SelectedItem.ToString() == "Admin")
            {
                tipo = 1;
            }

            //Usuario usr = new Usuario(id_editar, txt_usuario.Text, txt_contraseña.Text, txt_nombre.Text, txt_apellido.Text, tipo);

            //if (Usuario_Controller.editarUsuario(usr))
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void combo_tipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
