using PrototipoAppDesktop.UsuarioControlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrototipoAppDesktop
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ABM_UC abm_uc = new ABM_UC();
            agregarControlDeUsuario(abm_uc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ventas_UC ventas_uc = new Ventas_UC();
            agregarControlDeUsuario(ventas_uc);
        }

        private void agregarControlDeUsuario(UserControl uc) {
            uc.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(uc);
            uc.BringToFront();
        }
    }

}
