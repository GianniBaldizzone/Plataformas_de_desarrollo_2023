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
    public partial class Productos_UC : UserControl
    {

        List<Producto> productos;
        int elementosPorPagina = 7;
        int paginaActual = 1;
        int totalDePaginas;
        public Productos_UC()
        {
            InitializeComponent();
            cargarProductos();
        }

        /*private void cargarProductos()
        {
            productos = Producto_Controller.obtenerProductos();
            guna2DataGridView1.Rows.Clear();
            foreach (Producto prod in productos)
            {
                int rowIndex = guna2DataGridView1.Rows.Add();

                guna2DataGridView1.Rows[rowIndex].Cells[0].Value = prod.Id.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[1].Value = prod.Nombre.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[2].Value = prod.Descripcion.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[3].Value = prod.Precio.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[4].Value = prod.codigo.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[5].Value = prod.Stock.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[6].Value = prod.Img.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[7].Value = prod.Talle.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[8].Value = prod.Proveedor.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[9].Value = prod.CategoriaId.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[10].Value = prod.SubcategoriaId.ToString();


                guna2DataGridView1.Rows[rowIndex].Cells[11].Value = "Ver";
                guna2DataGridView1.Rows[rowIndex].Cells[12].Value = "Editar";
                guna2DataGridView1.Rows[rowIndex].Cells[13].Value = "Eliminar";

            }
        }*/

        private void btn_add_cat_Click(object sender, EventArgs e)
        {
            FormProducto frmProd = new FormProducto();
            DialogResult dr = frmProd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Trace.WriteLine("OK - se creo");
                //ACTUALIZAR LA LISTA
                cargarProductos();

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

                Producto prod_editar = Producto_Controller.obtenerPorId(id);

                FormProducto formprod = new FormProducto(prod_editar);

                DialogResult dr = formprod.ShowDialog();

                if (dr == DialogResult.OK)
                {
                    Trace.WriteLine("OK - se edito");
                    //ACTUALIZAR LA LISTA
                    cargarProductos();

                }
            }
            else if (senderGrid.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                Debug.WriteLine("Valor de la celda: " + guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                int id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Trace.WriteLine("el id es: " + id);
                Producto prod_elim = Producto_Controller.obtenerPorId(id);
                FormEliminarProd formeliminarprod = new FormEliminarProd(prod_elim);
                DialogResult eliminar = formeliminarprod.ShowDialog();
                if (eliminar == DialogResult.OK)
                {
                    Trace.WriteLine("OK - se creo form eliminar");
                    cargarProductos();

                }
            }
            else if (senderGrid.Columns[e.ColumnIndex].Name == "Ver")
            {
                Debug.WriteLine("Valor de la celda: " + guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                int id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                Trace.WriteLine("el id es: " + id);
                Producto prod_elim = Producto_Controller.obtenerPorId(id);
                FormVerProd formverprod = new FormVerProd(prod_elim);
                DialogResult ver = formverprod.ShowDialog();
                if (ver == DialogResult.OK)
                {
                    Trace.WriteLine("OK - se creo form eliminar");
                    cargarProductos();

                }
            }


        }






        private void cargarProductos()
        {
            productos = Producto_Controller.obtenerProductos();

            int totalDePaginas = (int)Math.Ceiling((double)productos.Count / elementosPorPagina);
            int inicio = (paginaActual - 1) * elementosPorPagina;
            int fin = Math.Min(inicio + elementosPorPagina, productos.Count);

            
            guna2DataGridView1.Rows.Clear();

            for (int i = inicio; i < fin; i++)
            {
                Producto prod = productos[i];
                int rowIndex = guna2DataGridView1.Rows.Add();

                guna2DataGridView1.Rows[rowIndex].Cells[0].Value = prod.Id.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[1].Value = prod.Nombre.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[2].Value = prod.Descripcion.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[3].Value = prod.Precio.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[4].Value = prod.codigo.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[5].Value = prod.Stock.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[6].Value = prod.Img.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[7].Value = prod.Talle.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[8].Value = prod.Proveedor.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[9].Value = prod.CategoriaId.ToString();
                guna2DataGridView1.Rows[rowIndex].Cells[10].Value = prod.SubcategoriaId.ToString();

                guna2DataGridView1.Rows[rowIndex].Cells[11].Value = "Ver";
                guna2DataGridView1.Rows[rowIndex].Cells[12].Value = "Editar";
                guna2DataGridView1.Rows[rowIndex].Cells[13].Value = "Eliminar";
            }

            // Mostrar la información de la paginación en el label
            lblPaginaActual.Text = $"Página {paginaActual} de {totalDePaginas}";
        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                paginaActual--;
                cargarProductos();
            }
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            if ((paginaActual * elementosPorPagina) < productos.Count)
            {
                paginaActual++;
                cargarProductos();
            }
        }
    }

}

