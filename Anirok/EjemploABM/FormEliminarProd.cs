using EjemploABM.Controladores;
using EjemploABM.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploABM
{
    public partial class FormEliminarProd : Form
    {
        int id_eliminar;





        private Producto prod;
        public FormEliminarProd()
        {
            InitializeComponent();
        }


        public FormEliminarProd(Producto prod_eliminar)
        {
            InitializeComponent();
            id_eliminar = prod_eliminar.Id;
            txt_id_prod.Text = id_eliminar.ToString();
            string nombreImagen = (prod_eliminar.Id.ToString() + ".jpg");

            // Construir la ruta completa de la imagen
            string rutaImagen = Path.Combine(@"C:\Users\Usuario\Documents\GitHub\Plataformas_de_desarrollo_2023\Anirok\EjemploABM\Recursos\img\", nombreImagen);

            // Verificar si el archivo de la imagen existe antes de asignarlo
            if (File.Exists(rutaImagen))
            {
                // Asignar la imagen al PictureBox
                pictureBoxEliminar.Image = Image.FromFile(rutaImagen);
            }
            else
            {
                MessageBox.Show("La imagen no se encuentra en la ruta especificada.");
            }
        }

        private void btn_sieliminar_Click(object sender, EventArgs e)
        {
            ConfirmarEliminacion();
        }

        private void btn_noeliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        

        private void ConfirmarEliminacion()
        {
            // Realiza la eliminación de la categoría aquí...
            if (Producto_Controller.eliminarProducto(id_eliminar))
            {
                // Elimina el archivo correspondiente al producto
                string rutaArchivo = ObtenerRutaArchivo(id_eliminar);
                if (File.Exists(rutaArchivo))
                {
                    File.Delete(rutaArchivo);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private string ObtenerRutaArchivo(int id)
        {
            // Suponiendo que el archivo tiene la extensión .jpg y está en una carpeta específica
            string nombreArchivo = $"{id}.jpg";
            string rutaCarpeta = @"C:\Users\Usuario\Documents\GitHub\Plataformas_de_desarrollo_2023\Anirok\EjemploABM\Recursos\img";
            string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);
            return rutaCompleta;
        }
    }
}
