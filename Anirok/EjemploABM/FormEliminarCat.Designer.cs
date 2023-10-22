namespace EjemploABM
{
    partial class FormEliminarCat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEliminarCat));
            this.txt_id_cat = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_noeliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_sieliminar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id_cat
            // 
            this.txt_id_cat.AutoSize = true;
            this.txt_id_cat.Location = new System.Drawing.Point(562, 67);
            this.txt_id_cat.Name = "txt_id_cat";
            this.txt_id_cat.Size = new System.Drawing.Size(26, 20);
            this.txt_id_cat.TabIndex = 9;
            this.txt_id_cat.Text = "ID";
            this.txt_id_cat.Click += new System.EventHandler(this.txt_id_usuario_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(325, 140);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(143, 130);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "¿Desea eliminar la categoria seleccionada?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_noeliminar
            // 
            this.btn_noeliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_noeliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_noeliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_noeliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_noeliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_noeliminar.ForeColor = System.Drawing.Color.White;
            this.btn_noeliminar.Location = new System.Drawing.Point(433, 328);
            this.btn_noeliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_noeliminar.Name = "btn_noeliminar";
            this.btn_noeliminar.Size = new System.Drawing.Size(202, 56);
            this.btn_noeliminar.TabIndex = 6;
            this.btn_noeliminar.Text = "No";
            this.btn_noeliminar.Click += new System.EventHandler(this.btn_noeliminar_Click);
            // 
            // btn_sieliminar
            // 
            this.btn_sieliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_sieliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_sieliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_sieliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_sieliminar.FillColor = System.Drawing.Color.Red;
            this.btn_sieliminar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_sieliminar.ForeColor = System.Drawing.Color.White;
            this.btn_sieliminar.Location = new System.Drawing.Point(166, 328);
            this.btn_sieliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_sieliminar.Name = "btn_sieliminar";
            this.btn_sieliminar.Size = new System.Drawing.Size(202, 56);
            this.btn_sieliminar.TabIndex = 5;
            this.btn_sieliminar.Text = "Eliminar";
            this.btn_sieliminar.Click += new System.EventHandler(this.btn_sieliminar_Click);
            // 
            // FormEliminarCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_id_cat);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_noeliminar);
            this.Controls.Add(this.btn_sieliminar);
            this.Name = "FormEliminarCat";
            this.Text = "FormEliminarCat";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_id_cat;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_noeliminar;
        private Guna.UI2.WinForms.Guna2Button btn_sieliminar;
    }
}