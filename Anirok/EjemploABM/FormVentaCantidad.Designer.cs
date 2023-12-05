namespace EjemploABM
{
    partial class FormVentaCantidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentaCantidad));
            this.txtCantidad = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCerrarVentana = new System.Windows.Forms.PictureBox();
            this.btn_confirmar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarVentana)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.Color.Transparent;
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCantidad.Location = new System.Drawing.Point(142, 110);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(114, 48);
            this.txtCantidad.TabIndex = 0;
            this.txtCantidad.UpDownButtonFillColor = System.Drawing.Color.Green;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 50);
            this.label2.TabIndex = 50;
            this.label2.Text = "Ingrese la cantidad que \r\n        desea llevar";
            // 
            // btnCerrarVentana
            // 
            this.btnCerrarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrarVentana.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarVentana.Image")));
            this.btnCerrarVentana.Location = new System.Drawing.Point(370, 0);
            this.btnCerrarVentana.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(33, 33);
            this.btnCerrarVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarVentana.TabIndex = 51;
            this.btnCerrarVentana.TabStop = false;
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click);
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
            this.btn_confirmar.Location = new System.Drawing.Point(113, 192);
            this.btn_confirmar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_confirmar.Name = "btn_confirmar";
            this.btn_confirmar.Size = new System.Drawing.Size(168, 53);
            this.btn_confirmar.TabIndex = 52;
            this.btn_confirmar.Text = "CONFIRMAR";
            this.btn_confirmar.Click += new System.EventHandler(this.btn_confirmar_Click);
            // 
            // FormVentaCantidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 267);
            this.Controls.Add(this.btn_confirmar);
            this.Controls.Add(this.btnCerrarVentana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantidad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVentaCantidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.txtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarVentana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2NumericUpDown txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnCerrarVentana;
        private Guna.UI2.WinForms.Guna2Button btn_confirmar;
    }
}