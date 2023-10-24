using EjemploABM.Controladores;
using EjemploABM.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploABM.ControlesDeUsuario
{
    public partial class Subcategoria_UC : UserControl
    {
        List<Subcategoria> subcategorias;
        public Subcategoria_UC()
        {
            InitializeComponent();
            cargarSubcategorias();
        }

        private void cargarSubcategorias()
        {
            subcategorias = Subcategoria_Controller.obtenerSubcategorias();
            guna2DataGridView1.Rows.Clear();
            foreach (Subcategoria sub in subcategorias)
            {
                int rowIndex = guna2DataGridView1.Rows.Add();

                guna2DataGridView1.Rows[rowIndex].Cells[0].Value = sub.Id.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[1].Value = sub.Nombre.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[2].Value = sub.categoria_id.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[3].Value = sub.IsActive.ToString();
                



                guna2DataGridView1.Rows[rowIndex].Cells[4].Value = "Editar";
                guna2DataGridView1.Rows[rowIndex].Cells[5].Value = "Eliminar";

            }
        }

        private void btn_add_cat_Click_1(object sender, EventArgs e)
        {
            FormSubcategorias formsub = new FormSubcategorias();
            DialogResult dr = formsub.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Trace.WriteLine("OK - se creo");
                //ACTUALIZAR LA LISTA
                cargarSubcategorias();

            }
        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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

                Subcategoria sub_editar = Subcategoria_Controller.obtenerPorId(id);

                FormSubcategorias frmCat = new FormSubcategorias(sub_editar);

                DialogResult dr = frmCat.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    Trace.WriteLine("OK - se edito");
                    //ACTUALIZAR LA LISTA
                    cargarSubcategorias();

                }
            }
            else if (senderGrid.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                Debug.WriteLine("Valor de la celda: " + guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                int id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Trace.WriteLine("el id es: " + id);
                Subcategoria sub_eliminar = Subcategoria_Controller.obtenerPorId(id);
                FormEliminarSub formeliminarsub = new FormEliminarSub(sub_eliminar);
                DialogResult eliminar = formeliminarsub.ShowDialog();
                if (eliminar == DialogResult.OK)
                {
                    Trace.WriteLine("OK - se creo form eliminar");
                    cargarSubcategorias();

                }
            }


        }
    }
}
