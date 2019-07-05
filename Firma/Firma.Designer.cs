namespace Firma_Digital
{
    partial class Firma
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
            this.txtClave = new MetroFramework.Controls.MetroTextBox();
            this.btnAceptarFirma = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.recordarContra = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // txtClave
            // 
            // 
            // 
            // 
            this.txtClave.CustomButton.Image = null;
            this.txtClave.CustomButton.Location = new System.Drawing.Point(129, 1);
            this.txtClave.CustomButton.Name = "";
            this.txtClave.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtClave.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClave.CustomButton.TabIndex = 1;
            this.txtClave.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClave.CustomButton.UseSelectable = true;
            this.txtClave.CustomButton.Visible = false;
            this.txtClave.Lines = new string[0];
            this.txtClave.Location = new System.Drawing.Point(191, 72);
            this.txtClave.MaxLength = 32767;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '\0';
            this.txtClave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClave.SelectedText = "";
            this.txtClave.SelectionLength = 0;
            this.txtClave.SelectionStart = 0;
            this.txtClave.ShortcutsEnabled = true;
            this.txtClave.Size = new System.Drawing.Size(151, 23);
            this.txtClave.TabIndex = 0;
            this.txtClave.UseSelectable = true;
            this.txtClave.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClave.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAceptarFirma
            // 
            this.btnAceptarFirma.Location = new System.Drawing.Point(267, 133);
            this.btnAceptarFirma.Name = "btnAceptarFirma";
            this.btnAceptarFirma.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarFirma.TabIndex = 1;
            this.btnAceptarFirma.Text = "Aceptar";
            this.btnAceptarFirma.UseSelectable = true;
            this.btnAceptarFirma.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(39, 72);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(128, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Clave del certificado";
            // 
            // recordarContra
            // 
            this.recordarContra.AutoSize = true;
            this.recordarContra.Location = new System.Drawing.Point(191, 101);
            this.recordarContra.Name = "recordarContra";
            this.recordarContra.Size = new System.Drawing.Size(131, 15);
            this.recordarContra.TabIndex = 3;
            this.recordarContra.Text = "Recordar contraseña";
            this.recordarContra.UseSelectable = true;
            // 
            // Firma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 172);
            this.Controls.Add(this.recordarContra);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnAceptarFirma);
            this.Controls.Add(this.txtClave);
            this.MaximizeBox = false;
            this.Name = "Firma";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Firmando certificado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtClave;
        private MetroFramework.Controls.MetroButton btnAceptarFirma;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroCheckBox recordarContra;
    }
}