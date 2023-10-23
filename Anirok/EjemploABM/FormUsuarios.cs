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
            txt_telefono.Text = usr.Telefono.ToString();
            txt_direccion.Text = usr.Direccion.ToString();
            txt_contraseña.Text = usr.Contraseña.ToString();
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
            if (string.IsNullOrEmpty(txt_nombre.Text) || string.IsNullOrEmpty(txt_apellido.Text) || string.IsNullOrEmpty(txt_mail.Text) || string.IsNullOrEmpty(txt_telefono.Text) || string.IsNullOrEmpty(txt_direccion.Text) || string.IsNullOrEmpty(txt_dni.Text) || string.IsNullOrEmpty(txt_contraseña.Text) || combo_tipo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione un rol antes de crear un usuario.", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tipo = 2;
            if (combo_tipo.SelectedItem.ToString() == "Admin")
            {
                tipo = 1;
            }

            // Verificar si la contraseña ya está en uso
            if (Usuario_Controller.existeContraseña(txt_contraseña.Text))
            {
                MessageBox.Show("La contraseña ingresada ya está en uso. Por favor, elija otra contraseña.", "Contraseña repetida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Usuario usr = new Usuario(0, txt_nombre.Text, txt_apellido.Text, txt_mail.Text, txt_telefono.Text, txt_direccion.Text, txt_dni.Text, txt_contraseña.Text, tipo);

            if (Usuario_Controller.crearUsuario(usr))
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void editar()
        {
            if (string.IsNullOrEmpty(txt_nombre.Text) || string.IsNullOrEmpty(txt_apellido.Text) || string.IsNullOrEmpty(txt_mail.Text) || string.IsNullOrEmpty(txt_telefono.Text) || string.IsNullOrEmpty(txt_direccion.Text) || string.IsNullOrEmpty(txt_dni.Text) || string.IsNullOrEmpty(txt_contraseña.Text) || combo_tipo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos y seleccione un rol antes de crear un usuario.", "Campos faltantes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int tipo = 2;
            if (combo_tipo.SelectedItem.ToString() == "Admin")
            {
                tipo = 1;
            }

            Usuario usr = new Usuario(id_editar, txt_nombre.Text, txt_apellido.Text, txt_mail.Text, txt_telefono.Text , txt_direccion.Text , txt_dni.Text, txt_contraseña.Text, tipo);

            if (Usuario_Controller.editarUsuario(usr))
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //CIERRA VENTANA FORMUSUARIOS
        private void btnCerrarVentana_Click_1(object sender, EventArgs e)
        {
            this.Hide();
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt_direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void combo_tipo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
