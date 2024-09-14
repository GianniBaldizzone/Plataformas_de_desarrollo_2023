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
    public partial class FormSetearUrls : Form
    {
        public FormSetearUrls()
        {
            InitializeComponent();
        }

        private void setearURL_Click(object sender, EventArgs e)
        {
            Program.URLimg = txt_imgpath.Text;
            Program.URLpdf = txt_documentospath.Text;
            this.Hide();
        }

        private void btnCerrarVentana_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
