﻿namespace EjemploABM
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
            this.btnCerrarVentana = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarVentana)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_id_cat
            // 
            this.txt_id_cat.AutoSize = true;
            this.txt_id_cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id_cat.ForeColor = System.Drawing.Color.Firebrick;
            this.txt_id_cat.Location = new System.Drawing.Point(339, 81);
            this.txt_id_cat.Name = "txt_id_cat";
            this.txt_id_cat.Size = new System.Drawing.Size(29, 24);
            this.txt_id_cat.TabIndex = 9;
            this.txt_id_cat.Text = "ID";
            this.txt_id_cat.Click += new System.EventHandler(this.txt_id_usuario_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(289, 112);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(127, 104);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "¿Desea eliminar la categoria seleccionada?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.btn_noeliminar.Location = new System.Drawing.Point(385, 262);
            this.btn_noeliminar.Name = "btn_noeliminar";
            this.btn_noeliminar.Size = new System.Drawing.Size(180, 45);
            this.btn_noeliminar.TabIndex = 6;
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
            this.btn_sieliminar.Location = new System.Drawing.Point(148, 262);
            this.btn_sieliminar.Name = "btn_sieliminar";
            this.btn_sieliminar.Size = new System.Drawing.Size(180, 45);
            this.btn_sieliminar.TabIndex = 5;
            this.btn_sieliminar.Text = "Eliminar";
            this.btn_sieliminar.Click += new System.EventHandler(this.btn_sieliminar_Click);
            // 
            // btnCerrarVentana
            // 
            this.btnCerrarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrarVentana.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarVentana.Image")));
            this.btnCerrarVentana.Location = new System.Drawing.Point(665, -2);
            this.btnCerrarVentana.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(46, 43);
            this.btnCerrarVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarVentana.TabIndex = 41;
            this.btnCerrarVentana.TabStop = false;
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click);
            // 
            // FormEliminarCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.btnCerrarVentana);
            this.Controls.Add(this.txt_id_cat);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_noeliminar);
            this.Controls.Add(this.btn_sieliminar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEliminarCat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEliminarCat";
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarVentana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_id_cat;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_noeliminar;
        private Guna.UI2.WinForms.Guna2Button btn_sieliminar;
        private System.Windows.Forms.PictureBox btnCerrarVentana;
    }
}