namespace EjemploABM
{
    partial class FormEliminarVendedorCat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEliminarVendedorCat));
            this.txt_id_cat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_freezar_categoria = new Guna.UI2.WinForms.Guna2Button();
            this.btnCerrarVentana = new System.Windows.Forms.PictureBox();
            this.btn_cambiar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarVentana)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id_cat
            // 
            this.txt_id_cat.AutoSize = true;
            this.txt_id_cat.Location = new System.Drawing.Point(391, 147);
            this.txt_id_cat.Name = "txt_id_cat";
            this.txt_id_cat.Size = new System.Drawing.Size(20, 16);
            this.txt_id_cat.TabIndex = 58;
            this.txt_id_cat.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(396, 25);
            this.label2.TabIndex = 57;
            this.label2.Text = "Se desactivara logicamente la categoria";
            // 
            // btn_freezar_categoria
            // 
            this.btn_freezar_categoria.BorderRadius = 10;
            this.btn_freezar_categoria.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_freezar_categoria.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_freezar_categoria.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_freezar_categoria.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_freezar_categoria.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_freezar_categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_freezar_categoria.ForeColor = System.Drawing.Color.White;
            this.btn_freezar_categoria.Location = new System.Drawing.Point(428, 239);
            this.btn_freezar_categoria.Margin = new System.Windows.Forms.Padding(4);
            this.btn_freezar_categoria.Name = "btn_freezar_categoria";
            this.btn_freezar_categoria.Size = new System.Drawing.Size(168, 53);
            this.btn_freezar_categoria.TabIndex = 55;
            this.btn_freezar_categoria.Text = "Freezar categoria";
            // 
            // btnCerrarVentana
            // 
            this.btnCerrarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrarVentana.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarVentana.Image")));
            this.btnCerrarVentana.Location = new System.Drawing.Point(754, 0);
            this.btnCerrarVentana.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(46, 43);
            this.btnCerrarVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarVentana.TabIndex = 59;
            this.btnCerrarVentana.TabStop = false;
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click);
            // 
            // btn_cambiar
            // 
            this.btn_cambiar.BorderRadius = 10;
            this.btn_cambiar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cambiar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cambiar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cambiar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cambiar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_cambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cambiar.ForeColor = System.Drawing.Color.White;
            this.btn_cambiar.Location = new System.Drawing.Point(205, 239);
            this.btn_cambiar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cambiar.Name = "btn_cambiar";
            this.btn_cambiar.Size = new System.Drawing.Size(168, 53);
            this.btn_cambiar.TabIndex = 60;
            this.btn_cambiar.Text = "Cambiar categoria";
            this.btn_cambiar.Click += new System.EventHandler(this.btn_cambiar_Click);
            // 
            // FormEliminarVendedorCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cambiar);
            this.Controls.Add(this.btnCerrarVentana);
            this.Controls.Add(this.txt_id_cat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_freezar_categoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEliminarVendedorCat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarVentana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_id_cat;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btn_freezar_categoria;
        private System.Windows.Forms.PictureBox btnCerrarVentana;
        private Guna.UI2.WinForms.Guna2Button btn_cambiar;
    }
}