namespace PrototipoAppDesktop
{
    partial class index
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
            this.btn_abm = new System.Windows.Forms.Button();
            this.btn_ventas = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btn_abm
            // 
            this.btn_abm.Location = new System.Drawing.Point(439, 89);
            this.btn_abm.Name = "btn_abm";
            this.btn_abm.Size = new System.Drawing.Size(183, 71);
            this.btn_abm.TabIndex = 0;
            this.btn_abm.Text = "ABM";
            this.btn_abm.UseVisualStyleBackColor = true;
            this.btn_abm.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ventas
            // 
            this.btn_ventas.Location = new System.Drawing.Point(670, 89);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(188, 70);
            this.btn_ventas.TabIndex = 1;
            this.btn_ventas.Text = "Ventas";
            this.btn_ventas.UseVisualStyleBackColor = true;
            this.btn_ventas.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(70, 228);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 501);
            this.panel1.TabIndex = 2;
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1396, 782);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_ventas);
            this.Controls.Add(this.btn_abm);
            this.Name = "index";
            this.Text = "index";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_abm;
        private System.Windows.Forms.Button btn_ventas;
        private System.Windows.Forms.Panel panel1;
    }
}