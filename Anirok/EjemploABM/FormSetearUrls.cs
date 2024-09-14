using EjemploABM.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploABM
{
    public partial class FormSetearUrls : Form
    {
        public FormSetearUrls()
        {
            InitializeComponent();
        }

        private void setearURL_Click(object sender, EventArgs e)
        {
            // Obtener el ID del usuario en sesión
            int userId = Program.logueado.Id;

            // Obtener las URLs de los campos de texto
            string urlImg = txt_imgpath.Text.Trim();
            string urlPdf = txt_documentospath.Text.Trim();

            try
            {
                // Actualizar las URLs usando el método del controlador
                bool resultado = Usuario_Controller.ActualizarUrls(userId, urlImg, urlPdf);

                if (resultado)
                {
                    MessageBox.Show("URLs actualizadas exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.URLimg = urlImg;
                    Program.URLpdf = urlPdf;
                }
            }
            catch (ArgumentException ex)
            {
                // Mostrar mensaje si las URLs no son válidas
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Mostrar mensaje si ocurre algún error al guardar las URLs
                MessageBox.Show("Error al guardar las URLs: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Ocultar el formulario después de guardar
            this.Hide();
        }




        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
