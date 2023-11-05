using EjemploABM.Controladores;
using EjemploABM.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploABM.ControlesDeUsuario
{
    public partial class Categorias_UC : UserControl
    {
        List<Categoria> categorias;

        public Categorias_UC()
        {
            InitializeComponent();
            cargarCategorias();

        }


        private void cargarCategorias()
        {
            categorias = Categoria_Controller.obtenerCategorias();
            guna2DataGridView1.Rows.Clear();
            foreach (Categoria cat in categorias)
            {
                int rowIndex = guna2DataGridView1.Rows.Add();

                guna2DataGridView1.Rows[rowIndex].Cells[0].Value = cat.Id.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[1].Value = cat.Nombre.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[2].Value = cat.IsActive.ToString();
               


                guna2DataGridView1.Rows[rowIndex].Cells[3].Value = "Editar";
                guna2DataGridView1.Rows[rowIndex].Cells[4].Value = "Eliminar";

            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Trace.WriteLine("estoy andando");
            Debug.WriteLine("Celda seleccionada: " + e.ColumnIndex + ", " + e.RowIndex);

            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex].Name == "Editar")
            {
                //EDITAMOS
                Debug.WriteLine("Valor de la celda: " + guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                int id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Trace.WriteLine("el id es: " + id);

                Categoria cat_editar = Categoria_Controller.obtenerPorId(id);

                FormCategorias frmCat = new FormCategorias(cat_editar);

                DialogResult dr = frmCat.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    Trace.WriteLine("OK - se edito");
                    //ACTUALIZAR LA LISTA
                    cargarCategorias();

                }
            }
            else if (senderGrid.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                Debug.WriteLine("Valor de la celda: " + guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                int id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Trace.WriteLine("el id es: " + id);
                Categoria cat_eliminar = Categoria_Controller.obtenerPorId(id);

                DialogResult eliminar;
                if (Program.logueado.Rol == 1)
                {
                    FormEliminarAdminCat formeliminarcat = new FormEliminarAdminCat(cat_eliminar);
                    eliminar = formeliminarcat.ShowDialog();
                }
                else if (Program.logueado.Rol == 2)
                {
                    FormEliminarVendedorCat formeliminarcat = new FormEliminarVendedorCat(cat_eliminar);
                    eliminar = formeliminarcat.ShowDialog();
                }
                else
                {
                    // En caso de otro valor de logueado.Rol, puedes manejarlo según tus necesidades.
                    eliminar = DialogResult.Cancel;
                }

                if (eliminar == DialogResult.OK)
                {
                    Trace.WriteLine("OK - se creó el formulario para eliminar");
                    cargarCategorias();
                }
            }

        }


        //CREAR CATEGORIA

        private void btn_add_cat_Click(object sender, EventArgs e)
        {
            FormCategorias frmCat = new FormCategorias();
            DialogResult dr = frmCat.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Trace.WriteLine("OK - se creo");
                //ACTUALIZAR LA LISTA
                cargarCategorias();

            }
        }

        private void Categorias_UC_Load(object sender, EventArgs e)
        {

        }
    }
}
