namespace EjemploABM
{
    partial class FormEliminarProd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEliminarProd));
            this.txt_id_prod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_noeliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_sieliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCerrarVentana = new System.Windows.Forms.PictureBox();
            this.pictureBoxEliminar = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id_prod
            // 
            this.txt_id_prod.AutoSize = true;
            this.txt_id_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_prod.ForeColor = System.Drawing.Color.Firebrick;
            this.txt_id_prod.Location = new System.Drawing.Point(558, 148);
            this.txt_id_prod.Name = "txt_id_prod";
            this.txt_id_prod.Size = new System.Drawing.Size(29, 24);
            this.txt_id_prod.TabIndex = 14;
            this.txt_id_prod.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(362, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "¿Desea eliminar el producto seleccionado?";
            // 
            // btn_noeliminar
            // 
            this.btn_noeliminar.BorderRadius = 10;
            this.btn_noeliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_noeliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_noeliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_noeliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_noeliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_noeliminar.ForeColor = System.Drawing.Color.White;
            this.btn_noeliminar.Location = new System.Drawing.Point(608, 298);
            this.btn_noeliminar.Name = "btn_noeliminar";
            this.btn_noeliminar.Size = new System.Drawing.Size(180, 45);
            this.btn_noeliminar.TabIndex = 11;
            this.btn_noeliminar.Text = "No";
            this.btn_noeliminar.Click += new System.EventHandler(this.btn_noeliminar_Click);
            // 
            // btn_sieliminar
            // 
            this.btn_sieliminar.BorderRadius = 10;
            this.btn_sieliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_sieliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_sieliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sieliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_sieliminar.FillColor = System.Drawing.Color.Red;
            this.btn_sieliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sieliminar.ForeColor = System.Drawing.Color.White;
            this.btn_sieliminar.Location = new System.Drawing.Point(356, 298);
            this.btn_sieliminar.Name = "btn_sieliminar";
            this.btn_sieliminar.Size = new System.Drawing.Size(180, 45);
            this.btn_sieliminar.TabIndex = 10;
            this.btn_sieliminar.Text = "Eliminar";
            this.btn_sieliminar.Click += new System.EventHandler(this.btn_sieliminar_Click);
            // 
            // btnCerrarVentana
            // 
            this.btnCerrarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrarVentana.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarVentana.Image")));
            this.btnCerrarVentana.Location = new System.Drawing.Point(756, -1);
            this.btnCerrarVentana.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(46, 43);
            this.btnCerrarVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarVentana.TabIndex = 42;
            this.btnCerrarVentana.TabStop = false;
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click);
            // 
            // pictureBoxEliminar
            // 
            this.pictureBoxEliminar.BackColor = System.Drawing.Color.White;
            this.pictureBoxEliminar.BorderRadius = 20;
            this.pictureBoxEliminar.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBoxEliminar.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxEliminar.ImageRotate = 0F;
            this.pictureBoxEliminar.Location = new System.Drawing.Point(32, 106);
            this.pictureBoxEliminar.Name = "pictureBoxEliminar";
            this.pictureBoxEliminar.Size = new System.Drawing.Size(274, 216);
            this.pictureBoxEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEliminar.TabIndex = 49;
            this.pictureBoxEliminar.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(533, 194);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(72, 85);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 50;
            this.guna2PictureBox2.TabStop = false;
            // 
            // FormEliminarProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.pictureBoxEliminar);
            this.Controls.Add(this.btnCerrarVentana);
            this.Controls.Add(this.txt_id_prod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_noeliminar);
            this.Controls.Add(this.btn_sieliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormEliminarProd";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_id_prod;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_noeliminar;
        private Guna.UI2.WinForms.Guna2Button btn_sieliminar;
        private System.Windows.Forms.PictureBox btnCerrarVentana;
        private Guna.UI2.WinForms.Guna2PictureBox pictureBoxEliminar;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
    }
}