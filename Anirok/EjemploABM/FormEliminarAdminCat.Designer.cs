namespace EjemploABM
{
    partial class FormEliminarAdminCat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEliminarAdminCat));
            this.btn_desactivar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_eliminar = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrarVentana = new System.Windows.Forms.PictureBox();
            this.txt_id_cat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarVentana)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_desactivar
            // 
            this.btn_desactivar.BorderRadius = 10;
            this.btn_desactivar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_desactivar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_desactivar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_desactivar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_desactivar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_desactivar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_desactivar.ForeColor = System.Drawing.Color.White;
            this.btn_desactivar.Location = new System.Drawing.Point(148, 210);
            this.btn_desactivar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_desactivar.Name = "btn_desactivar";
            this.btn_desactivar.Size = new System.Drawing.Size(168, 53);
            this.btn_desactivar.TabIndex = 46;
            this.btn_desactivar.Text = "DESACTIVAR";
            this.btn_desactivar.Click += new System.EventHandler(this.btn_desactivar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BorderRadius = 10;
            this.btn_eliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_eliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_eliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_eliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_eliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_eliminar.Location = new System.Drawing.Point(366, 210);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(168, 53);
            this.btn_eliminar.TabIndex = 47;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(543, 25);
            this.label2.TabIndex = 48;
            this.label2.Text = "¿Desea desactivar logicamente o eliminar la categoria?";
            // 
            // btnCerrarVentana
            // 
            this.btnCerrarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrarVentana.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarVentana.Image")));
            this.btnCerrarVentana.Location = new System.Drawing.Point(671, 0);
            this.btnCerrarVentana.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(46, 43);
            this.btnCerrarVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarVentana.TabIndex = 49;
            this.btnCerrarVentana.TabStop = false;
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click);
            // 
            // txt_id_cat
            // 
            this.txt_id_cat.AutoSize = true;
            this.txt_id_cat.Location = new System.Drawing.Point(334, 139);
            this.txt_id_cat.Name = "txt_id_cat";
            this.txt_id_cat.Size = new System.Drawing.Size(20, 16);
            this.txt_id_cat.TabIndex = 50;
            this.txt_id_cat.Text = "ID";
            // 
            // FormEliminarAdminCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 349);
            this.Controls.Add(this.txt_id_cat);
            this.Controls.Add(this.btnCerrarVentana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_desactivar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEliminarAdminCat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormEliminarAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarVentana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btn_desactivar;
        private Guna.UI2.WinForms.Guna2Button btn_eliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnCerrarVentana;
        private System.Windows.Forms.Label txt_id_cat;
    }
}