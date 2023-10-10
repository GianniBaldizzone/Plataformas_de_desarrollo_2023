
namespace EjemploABM
{
    partial class Index
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
            this.btn_prods = new System.Windows.Forms.Button();
            this.btn_cats = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_users = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_nombre_logueado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_prods
            // 
            this.btn_prods.Location = new System.Drawing.Point(0, 0);
            this.btn_prods.Margin = new System.Windows.Forms.Padding(4);
            this.btn_prods.Name = "btn_prods";
            this.btn_prods.Size = new System.Drawing.Size(100, 28);
            this.btn_prods.TabIndex = 0;
            this.btn_prods.Text = "Productos";
            this.btn_prods.UseVisualStyleBackColor = true;
            this.btn_prods.Click += new System.EventHandler(this.btn_prods_Click);
            // 
            // btn_cats
            // 
            this.btn_cats.Location = new System.Drawing.Point(120, 0);
            this.btn_cats.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cats.Name = "btn_cats";
            this.btn_cats.Size = new System.Drawing.Size(100, 28);
            this.btn_cats.TabIndex = 1;
            this.btn_cats.Text = "Categorias";
            this.btn_cats.UseVisualStyleBackColor = true;
            this.btn_cats.Click += new System.EventHandler(this.btn_cats_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(785, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido: ";
            // 
            // btn_users
            // 
            this.btn_users.Location = new System.Drawing.Point(240, 0);
            this.btn_users.Margin = new System.Windows.Forms.Padding(4);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(100, 28);
            this.btn_users.TabIndex = 3;
            this.btn_users.Text = "Usuarios";
            this.btn_users.UseVisualStyleBackColor = true;
            this.btn_users.Click += new System.EventHandler(this.btn_users_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1065, 518);
            this.panel1.TabIndex = 4;
            // 
            // lb_nombre_logueado
            // 
            this.lb_nombre_logueado.AutoSize = true;
            this.lb_nombre_logueado.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_nombre_logueado.Location = new System.Drawing.Point(873, 12);
            this.lb_nombre_logueado.Name = "lb_nombre_logueado";
            this.lb_nombre_logueado.Size = new System.Drawing.Size(44, 16);
            this.lb_nombre_logueado.TabIndex = 5;
            this.lb_nombre_logueado.Text = "label2";
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lb_nombre_logueado);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_users);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cats);
            this.Controls.Add(this.btn_prods);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Index";
            this.Text = "Index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_prods;
        private System.Windows.Forms.Button btn_cats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_users;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_nombre_logueado;
    }
}