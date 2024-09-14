namespace EjemploABM
{
    partial class FormSetearUrls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetearUrls));
            this.btnCerrarVentana = new System.Windows.Forms.PictureBox();
            this.txt_imgpath = new Guna.UI2.WinForms.Guna2TextBox();
            this.setearURL = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_documentospath = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarVentana)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCerrarVentana
            // 
            this.btnCerrarVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrarVentana.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrarVentana.Image")));
            this.btnCerrarVentana.Location = new System.Drawing.Point(755, -1);
            this.btnCerrarVentana.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarVentana.Name = "btnCerrarVentana";
            this.btnCerrarVentana.Size = new System.Drawing.Size(46, 43);
            this.btnCerrarVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrarVentana.TabIndex = 56;
            this.btnCerrarVentana.TabStop = false;
            this.btnCerrarVentana.Click += new System.EventHandler(this.btnCerrarVentana_Click);
            // 
            // txt_imgpath
            // 
            this.txt_imgpath.BorderColor = System.Drawing.Color.Black;
            this.txt_imgpath.BorderRadius = 5;
            this.txt_imgpath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_imgpath.DefaultText = "";
            this.txt_imgpath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_imgpath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_imgpath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_imgpath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_imgpath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_imgpath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_imgpath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_imgpath.Location = new System.Drawing.Point(138, 145);
            this.txt_imgpath.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_imgpath.Name = "txt_imgpath";
            this.txt_imgpath.PasswordChar = '\0';
            this.txt_imgpath.PlaceholderText = "";
            this.txt_imgpath.SelectedText = "";
            this.txt_imgpath.Size = new System.Drawing.Size(626, 25);
            this.txt_imgpath.TabIndex = 55;
            // 
            // setearURL
            // 
            this.setearURL.BorderRadius = 10;
            this.setearURL.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.setearURL.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.setearURL.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.setearURL.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.setearURL.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.setearURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setearURL.ForeColor = System.Drawing.Color.White;
            this.setearURL.Location = new System.Drawing.Point(318, 287);
            this.setearURL.Margin = new System.Windows.Forms.Padding(4);
            this.setearURL.Name = "setearURL";
            this.setearURL.Size = new System.Drawing.Size(168, 53);
            this.setearURL.TabIndex = 54;
            this.setearURL.Text = "SETEAR";
            this.setearURL.Click += new System.EventHandler(this.setearURL_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(40, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Imagenes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(343, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "Setear URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 214);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Documentos:";
            // 
            // txt_documentospath
            // 
            this.txt_documentospath.BorderColor = System.Drawing.Color.Black;
            this.txt_documentospath.BorderRadius = 5;
            this.txt_documentospath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_documentospath.DefaultText = "";
            this.txt_documentospath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_documentospath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_documentospath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_documentospath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_documentospath.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_documentospath.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_documentospath.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_documentospath.Location = new System.Drawing.Point(138, 214);
            this.txt_documentospath.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txt_documentospath.Name = "txt_documentospath";
            this.txt_documentospath.PasswordChar = '\0';
            this.txt_documentospath.PlaceholderText = "";
            this.txt_documentospath.SelectedText = "";
            this.txt_documentospath.Size = new System.Drawing.Size(626, 25);
            this.txt_documentospath.TabIndex = 58;
            // 
            // FormSetearUrls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 385);
            this.Controls.Add(this.txt_documentospath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrarVentana);
            this.Controls.Add(this.txt_imgpath);
            this.Controls.Add(this.setearURL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSetearUrls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrarVentana)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnCerrarVentana;
        private Guna.UI2.WinForms.Guna2TextBox txt_imgpath;
        private Guna.UI2.WinForms.Guna2Button setearURL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txt_documentospath;
    }
}