namespace EjemploABM
{
    partial class FormVerProd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVerProd));
            this.pictureBoxVer = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lb_nombre = new System.Windows.Forms.Label();
            this.lb_descripcion = new System.Windows.Forms.Label();
            this.lb_precio = new System.Windows.Forms.Label();
            this.lb_codigo = new System.Windows.Forms.Label();
            this.lb_proveedor = new System.Windows.Forms.Label();
            this.lb_subcategoria = new System.Windows.Forms.Label();
            this.lb_categoria = new System.Windows.Forms.Label();
            this.lb_talle = new System.Windows.Forms.Label();
            this.lb_stock = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.btnCerrarVentana = new System.Windows.Forms.PictureBox();
            this.txt_id = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.Label();
            this.txt_precio = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.Label();
            this.txt_proveedor = new System.Windows.Forms.Label();
            this.txt_talle = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.Label();
            this.txt_subcategoria = new System.Windows.Forms.Label();
            this.txt_categoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarVentana)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxVer
            // 
            this.pictureBoxVer.BackColor = System.Drawing.Color.White;
            this.pictureBoxVer.BorderRadius = 20;
            this.pictureBoxVer.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBoxVer.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxVer.ImageRotate = 0F;
            this.pictureBoxVer.Location = new System.Drawing.Point(37, 88);
            this.pictureBoxVer.Name = "pictureBoxVer";
            this.pictureBoxVer.Size = new System.Drawing.Size(300, 250);
            this.pictureBoxVer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVer.TabIndex = 49;
            this.pictureBoxVer.TabStop = false;
            // 
            // lb_nombre
            // 
            this.lb_nombre.AutoSize = true;
            this.lb_nombre.Location = new System.Drawing.Point(376, 88);
            this.lb_nombre.Name = "lb_nombre";
            this.lb_nombre.Size = new System.Drawing.Size(62, 16);
            this.lb_nombre.TabIndex = 50;
            this.lb_nombre.Text = "Nombre: ";
            // 
            // lb_descripcion
            // 
            this.lb_descripcion.AutoSize = true;
            this.lb_descripcion.Location = new System.Drawing.Point(376, 120);
            this.lb_descripcion.Name = "lb_descripcion";
            this.lb_descripcion.Size = new System.Drawing.Size(85, 16);
            this.lb_descripcion.TabIndex = 51;
            this.lb_descripcion.Text = "Descripción: ";
            // 
            // lb_precio
            // 
            this.lb_precio.AutoSize = true;
            this.lb_precio.Location = new System.Drawing.Point(376, 155);
            this.lb_precio.Name = "lb_precio";
            this.lb_precio.Size = new System.Drawing.Size(52, 16);
            this.lb_precio.TabIndex = 52;
            this.lb_precio.Text = "Precio: ";
            // 
            // lb_codigo
            // 
            this.lb_codigo.AutoSize = true;
            this.lb_codigo.Location = new System.Drawing.Point(376, 191);
            this.lb_codigo.Name = "lb_codigo";
            this.lb_codigo.Size = new System.Drawing.Size(54, 16);
            this.lb_codigo.TabIndex = 53;
            this.lb_codigo.Text = "Codigo:";
            // 
            // lb_proveedor
            // 
            this.lb_proveedor.AutoSize = true;
            this.lb_proveedor.Location = new System.Drawing.Point(376, 227);
            this.lb_proveedor.Name = "lb_proveedor";
            this.lb_proveedor.Size = new System.Drawing.Size(74, 16);
            this.lb_proveedor.TabIndex = 54;
            this.lb_proveedor.Text = "Proveedor:";
            // 
            // lb_subcategoria
            // 
            this.lb_subcategoria.AutoSize = true;
            this.lb_subcategoria.Location = new System.Drawing.Point(376, 331);
            this.lb_subcategoria.Name = "lb_subcategoria";
            this.lb_subcategoria.Size = new System.Drawing.Size(94, 16);
            this.lb_subcategoria.TabIndex = 55;
            this.lb_subcategoria.Text = "Subcategoria: ";
            // 
            // lb_categoria
            // 
            this.lb_categoria.AutoSize = true;
            this.lb_categoria.Location = new System.Drawing.Point(376, 366);
            this.lb_categoria.Name = "lb_categoria";
            this.lb_categoria.Size = new System.Drawing.Size(72, 16);
            this.lb_categoria.TabIndex = 56;
            this.lb_categoria.Text = "Categoria: ";
            // 
            // lb_talle
            // 
            this.lb_talle.AutoSize = true;
            this.lb_talle.Location = new System.Drawing.Point(376, 262);
            this.lb_talle.Name = "lb_talle";
            this.lb_talle.Size = new System.Drawing.Size(41, 16);
            this.lb_talle.TabIndex = 57;
            this.lb_talle.Text = "Talle:";
            // 
            // lb_stock
            // 
            this.lb_stock.AutoSize = true;
            this.lb_stock.Location = new System.Drawing.Point(376, 296);
            this.lb_stock.Name = "lb_stock";
            this.lb_stock.Size = new System.Drawing.Size(44, 16);
            this.lb_stock.TabIndex = 58;
            this.lb_stock.Text = "Stock:";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Location = new System.Drawing.Point(34, 38);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(26, 16);
            this.lb_id.TabIndex = 59;
            this.lb_id.Text = "ID: ";
            // 
            // btnCerrarVentana
            // 
            this.btnCerrarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrarVentana.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarVentana.Image")));
            this.btnCerrarVentana.Location = new System.Drawing.Point(755, 0);
            this.btnCerrarVentana.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(46, 43);
            this.btnCerrarVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarVentana.TabIndex = 60;
            this.btnCerrarVentana.TabStop = false;
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click);
            // 
            // txt_id
            // 
            this.txt_id.AutoSize = true;
            this.txt_id.Location = new System.Drawing.Point(66, 38);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(20, 16);
            this.txt_id.TabIndex = 61;
            this.txt_id.Text = "ID";
            // 
            // txt_nombre
            // 
            this.txt_nombre.AutoSize = true;
            this.txt_nombre.Location = new System.Drawing.Point(444, 88);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(53, 16);
            this.txt_nombre.TabIndex = 62;
            this.txt_nombre.Text = "nombre";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.AutoSize = true;
            this.txt_descripcion.Location = new System.Drawing.Point(467, 120);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(77, 16);
            this.txt_descripcion.TabIndex = 63;
            this.txt_descripcion.Text = "descripcion";
            // 
            // txt_precio
            // 
            this.txt_precio.AutoSize = true;
            this.txt_precio.Location = new System.Drawing.Point(434, 155);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(45, 16);
            this.txt_precio.TabIndex = 64;
            this.txt_precio.Text = "precio";
            // 
            // txt_codigo
            // 
            this.txt_codigo.AutoSize = true;
            this.txt_codigo.Location = new System.Drawing.Point(434, 191);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(49, 16);
            this.txt_codigo.TabIndex = 65;
            this.txt_codigo.Text = "codigo";
            // 
            // txt_proveedor
            // 
            this.txt_proveedor.AutoSize = true;
            this.txt_proveedor.Location = new System.Drawing.Point(456, 227);
            this.txt_proveedor.Name = "txt_proveedor";
            this.txt_proveedor.Size = new System.Drawing.Size(70, 16);
            this.txt_proveedor.TabIndex = 66;
            this.txt_proveedor.Text = "proveedor";
            // 
            // txt_talle
            // 
            this.txt_talle.AutoSize = true;
            this.txt_talle.Location = new System.Drawing.Point(423, 262);
            this.txt_talle.Name = "txt_talle";
            this.txt_talle.Size = new System.Drawing.Size(32, 16);
            this.txt_talle.TabIndex = 67;
            this.txt_talle.Text = "talle";
            // 
            // txt_stock
            // 
            this.txt_stock.AutoSize = true;
            this.txt_stock.Location = new System.Drawing.Point(423, 296);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(39, 16);
            this.txt_stock.TabIndex = 68;
            this.txt_stock.Text = "stock";
            // 
            // txt_subcategoria
            // 
            this.txt_subcategoria.AutoSize = true;
            this.txt_subcategoria.Location = new System.Drawing.Point(467, 331);
            this.txt_subcategoria.Name = "txt_subcategoria";
            this.txt_subcategoria.Size = new System.Drawing.Size(86, 16);
            this.txt_subcategoria.TabIndex = 69;
            this.txt_subcategoria.Text = "subcategoria";
            // 
            // txt_categoria
            // 
            this.txt_categoria.AutoSize = true;
            this.txt_categoria.Location = new System.Drawing.Point(454, 366);
            this.txt_categoria.Name = "txt_categoria";
            this.txt_categoria.Size = new System.Drawing.Size(64, 16);
            this.txt_categoria.TabIndex = 70;
            this.txt_categoria.Text = "categoria";
            // 
            // FormVerProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_categoria);
            this.Controls.Add(this.txt_subcategoria);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.txt_talle);
            this.Controls.Add(this.txt_proveedor);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.btnCerrarVentana);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.lb_stock);
            this.Controls.Add(this.lb_talle);
            this.Controls.Add(this.lb_categoria);
            this.Controls.Add(this.lb_subcategoria);
            this.Controls.Add(this.lb_proveedor);
            this.Controls.Add(this.lb_codigo);
            this.Controls.Add(this.lb_precio);
            this.Controls.Add(this.lb_descripcion);
            this.Controls.Add(this.lb_nombre);
            this.Controls.Add(this.pictureBoxVer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVerProd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarVentana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxVer;
        private System.Windows.Forms.Label lb_nombre;
        private System.Windows.Forms.Label lb_descripcion;
        private System.Windows.Forms.Label lb_precio;
        private System.Windows.Forms.Label lb_codigo;
        private System.Windows.Forms.Label lb_proveedor;
        private System.Windows.Forms.Label lb_subcategoria;
        private System.Windows.Forms.Label lb_categoria;
        private System.Windows.Forms.Label lb_talle;
        private System.Windows.Forms.Label lb_stock;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.PictureBox btnCerrarVentana;
        private System.Windows.Forms.Label txt_id;
        private System.Windows.Forms.Label txt_nombre;
        private System.Windows.Forms.Label txt_descripcion;
        private System.Windows.Forms.Label txt_precio;
        private System.Windows.Forms.Label txt_codigo;
        private System.Windows.Forms.Label txt_proveedor;
        private System.Windows.Forms.Label txt_talle;
        private System.Windows.Forms.Label txt_stock;
        private System.Windows.Forms.Label txt_subcategoria;
        private System.Windows.Forms.Label txt_categoria;
    }
}