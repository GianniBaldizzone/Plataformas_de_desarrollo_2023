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
    public partial class FormProducto : Form
    {
        Image File;
        public FormProducto()
        {
            InitializeComponent();
        }

        private void btn_cargar_img_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
                
                ofd.Filter = "*JPG(*.JPG)|*.jpg";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    File = Image.FromFile(ofd.FileName);
                guna2PictureBox1.Image = File;
                }
            
        }
    }
}
