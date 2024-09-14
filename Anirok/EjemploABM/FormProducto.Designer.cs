namespace EjemploABM
{
    partial class FormProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducto));
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTalle = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_proveedor = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_confirmar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrarVentana = new System.Windows.Forms.PictureBox();
            this.txt_nombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_descripcion = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_precio = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_codigo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_cantidad = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txt_proveedor = new Guna.UI2.WinForms.Guna2TextBox();
            this.comboBoxCat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.comboBoxSub = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_cargar_img = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_nombre.Location = new System.Drawing.Point(60, 99);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(74, 20);
            this.lbl_nombre.TabIndex = 4;
            this.lbl_nombre.Text = "Nombre";
            this.lbl_nombre.Click += new System.EventHandler(this.lbl_nombre_Click);
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_descripcion.Location = new System.Drawing.Point(20, 153);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(116, 20);
            this.lbl_descripcion.TabIndex = 5;
            this.lbl_descripcion.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(60, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(65, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(60, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Codigo:";
            // 
            // comboBoxTalle
            // 
            this.comboBoxTalle.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxTalle.BorderColor = System.Drawing.Color.Black;
            this.comboBoxTalle.BorderRadius = 5;
            this.comboBoxTalle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxTalle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTalle.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxTalle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxTalle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxTalle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxTalle.ItemHeight = 30;
            this.comboBoxTalle.Location = new System.Drawing.Point(492, 144);
            this.comboBoxTalle.Name = "comboBoxTalle";
            this.comboBoxTalle.Size = new System.Drawing.Size(176, 36);
            this.comboBoxTalle.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(420, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Talle:";
            // 
            // lbl_proveedor
            // 
            this.lbl_proveedor.AutoSize = true;
            this.lbl_proveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_proveedor.Location = new System.Drawing.Point(379, 209);
            this.lbl_proveedor.Name = "lbl_proveedor";
            this.lbl_proveedor.Size = new System.Drawing.Size(100, 20);
            this.lbl_proveedor.TabIndex = 15;
            this.lbl_proveedor.Text = "Proveedor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(385, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Categoria:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(352, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Subcategoria:";
            // 
            // btn_confirmar
            // 
            this.btn_confirmar.BorderRadius = 10;
            this.btn_confirmar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_confirmar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_confirmar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_confirmar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_confirmar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirmar.ForeColor = System.Drawing.Color.White;
            this.btn_confirmar.Location = new System.Drawing.Point(423, 372);
            this.btn_confirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(168, 53);
            this.btn_confirmar.TabIndex = 47;
            this.btn_confirmar.Text = "CONFIRMAR";
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox1.BorderRadius = 20;
            this.guna2PictureBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(684, 90);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(300, 250);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 48;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 49;
            this.label2.Text = "Crear producto";
            // 
            // btnCerrarVentana
            // 
            this.btnCerrarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrarVentana.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarVentana.Image")));
            this.btnCerrarVentana.Location = new System.Drawing.Point(957, -1);
            this.btnCerrarVentana.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(46, 43);
            this.btnCerrarVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarVentana.TabIndex = 50;
            this.btnCerrarVentana.TabStop = false;
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click);
            // 
            // txt_nombre
            // 
            this.txt_nombre.BorderColor = System.Drawing.Color.Black;
            this.txt_nombre.BorderRadius = 5;
            this.txt_nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nombre.DefaultText = "";
            this.txt_nombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_nombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_nombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_nombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_nombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_nombre.Location = new System.Drawing.Point(146, 94);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PasswordChar = '\0';
            this.txt_nombre.PlaceholderText = "";
            this.txt_nombre.SelectedText = "";
            this.txt_nombre.Size = new System.Drawing.Size(176, 25);
            this.txt_nombre.TabIndex = 51;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.BorderColor = System.Drawing.Color.Black;
            this.txt_descripcion.BorderRadius = 5;
            this.txt_descripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_descripcion.DefaultText = "";
            this.txt_descripcion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_descripcion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_descripcion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_descripcion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_descripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_descripcion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_descripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_descripcion.Location = new System.Drawing.Point(146, 148);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.PasswordChar = '\0';
            this.txt_descripcion.PlaceholderText = "";
            this.txt_descripcion.SelectedText = "";
            this.txt_descripcion.Size = new System.Drawing.Size(176, 25);
            this.txt_descripcion.TabIndex = 52;
            // 
            // txt_precio
            // 
            this.txt_precio.BorderColor = System.Drawing.Color.Black;
            this.txt_precio.BorderRadius = 5;
            this.txt_precio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_precio.DefaultText = "";
            this.txt_precio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_precio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_precio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_precio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_precio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_precio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_precio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_precio.Location = new System.Drawing.Point(146, 205);
            this.txt_precio.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.PasswordChar = '\0';
            this.txt_precio.PlaceholderText = "";
            this.txt_precio.SelectedText = "";
            this.txt_precio.Size = new System.Drawing.Size(176, 25);
            this.txt_precio.TabIndex = 53;
            // 
            // txt_codigo
            // 
            this.txt_codigo.BorderColor = System.Drawing.Color.Black;
            this.txt_codigo.BorderRadius = 5;
            this.txt_codigo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_codigo.DefaultText = "";
            this.txt_codigo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_codigo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_codigo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_codigo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_codigo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_codigo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_codigo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_codigo.Location = new System.Drawing.Point(146, 262);
            this.txt_codigo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.PasswordChar = '\0';
            this.txt_codigo.PlaceholderText = "";
            this.txt_codigo.SelectedText = "";
            this.txt_codigo.Size = new System.Drawing.Size(176, 25);
            this.txt_codigo.TabIndex = 54;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.BackColor = System.Drawing.Color.Transparent;
            this.txt_cantidad.BorderColor = System.Drawing.Color.Black;
            this.txt_cantidad.BorderRadius = 5;
            this.txt_cantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_cantidad.Location = new System.Drawing.Point(146, 311);
            this.txt_cantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(176, 30);
            this.txt_cantidad.TabIndex = 55;
            this.txt_cantidad.UpDownButtonFillColor = System.Drawing.Color.Maroon;
            this.txt_cantidad.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // txt_proveedor
            // 
            this.txt_proveedor.BorderColor = System.Drawing.Color.Black;
            this.txt_proveedor.BorderRadius = 5;
            this.txt_proveedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_proveedor.DefaultText = "";
            this.txt_proveedor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_proveedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_proveedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_proveedor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_proveedor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_proveedor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_proveedor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_proveedor.Location = new System.Drawing.Point(492, 205);
            this.txt_proveedor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_proveedor.Name = "txt_proveedor";
            this.txt_proveedor.PasswordChar = '\0';
            this.txt_proveedor.PlaceholderText = "";
            this.txt_proveedor.SelectedText = "";
            this.txt_proveedor.Size = new System.Drawing.Size(176, 25);
            this.txt_proveedor.TabIndex = 56;
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxCat.BorderColor = System.Drawing.Color.Black;
            this.comboBoxCat.BorderRadius = 5;
            this.comboBoxCat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxCat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxCat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxCat.ItemHeight = 30;
            this.comboBoxCat.Location = new System.Drawing.Point(493, 258);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(176, 36);
            this.comboBoxCat.TabIndex = 57;
            // 
            // comboBoxSub
            // 
            this.comboBoxSub.BackColor = System.Drawing.Color.Transparent;
            this.comboBoxSub.BorderColor = System.Drawing.Color.Black;
            this.comboBoxSub.BorderRadius = 5;
            this.comboBoxSub.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxSub.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSub.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxSub.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboBoxSub.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBoxSub.ItemHeight = 30;
            this.comboBoxSub.Location = new System.Drawing.Point(493, 308);
            this.comboBoxSub.Name = "comboBoxSub";
            this.comboBoxSub.Size = new System.Drawing.Size(176, 36);
            this.comboBoxSub.TabIndex = 58;
            // 
            // btn_cargar_img
            // 
            this.btn_cargar_img.BorderRadius = 10;
            this.btn_cargar_img.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cargar_img.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cargar_img.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cargar_img.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cargar_img.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_cargar_img.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cargar_img.ForeColor = System.Drawing.Color.White;
            this.btn_cargar_img.Location = new System.Drawing.Point(428, 89);
            this.btn_cargar_img.Name = "btn_cargar_img";
            this.btn_cargar_img.Size = new System.Drawing.Size(196, 30);
            this.btn_cargar_img.TabIndex = 10;
            this.btn_cargar_img.Text = "Cargar imagen";
            this.btn_cargar_img.Click += new System.EventHandler(this.btn_cargar_img_Click);
            // 
            // FormProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1002, 451);
            this.Controls.Add(this.comboBoxSub);
            this.Controls.Add(this.comboBoxCat);
            this.Controls.Add(this.txt_proveedor);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.txt_precio);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.btnCerrarVentana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_proveedor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxTalle);
            this.Controls.Add(this.btn_cargar_img);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.lbl_nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxTalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_proveedor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_confirmar;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnCerrarVentana;
        private Guna.UI2.WinForms.Guna2TextBox txt_nombre;
        private Guna.UI2.WinForms.Guna2TextBox txt_descripcion;
        private Guna.UI2.WinForms.Guna2TextBox txt_precio;
        private Guna.UI2.WinForms.Guna2TextBox txt_codigo;
        private Guna.UI2.WinForms.Guna2NumericUpDown txt_cantidad;
        private Guna.UI2.WinForms.Guna2TextBox txt_proveedor;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxCat;
        private Guna.UI2.WinForms.Guna2ComboBox comboBoxSub;
        private Guna.UI2.WinForms.Guna2Button btn_cargar_img;
    }
}