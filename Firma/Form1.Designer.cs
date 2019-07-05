namespace Firma_Digital
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnNuevoDoc = new MetroFramework.Controls.MetroButton();
            this.btnFirmar = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btnAdjuntarWord = new MetroFramework.Controls.MetroButton();
            this.gridDocs = new MetroFramework.Controls.MetroGrid();
            this.Accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNuevo = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDocs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoDoc
            // 
            this.btnNuevoDoc.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnNuevoDoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNuevoDoc.Location = new System.Drawing.Point(337, 234);
            this.btnNuevoDoc.Name = "btnNuevoDoc";
            this.btnNuevoDoc.Size = new System.Drawing.Size(121, 27);
            this.btnNuevoDoc.TabIndex = 0;
            this.btnNuevoDoc.Text = "Nuevo";
            this.btnNuevoDoc.UseSelectable = true;
            this.btnNuevoDoc.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // btnFirmar
            // 
            this.btnFirmar.Location = new System.Drawing.Point(94, 321);
            this.btnFirmar.Name = "btnFirmar";
            this.btnFirmar.Size = new System.Drawing.Size(75, 23);
            this.btnFirmar.TabIndex = 1;
            this.btnFirmar.Text = "Firmar";
            this.btnFirmar.UseSelectable = true;
            this.btnFirmar.Click += new System.EventHandler(this.MetroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(94, 350);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 4;
            this.metroButton1.Text = "Enviar";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(61, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(662, 145);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(297, 616);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(220, 19);
            this.metroLabel7.TabIndex = 62;
            this.metroLabel7.Text = "OFICINA DE INFORMÁTICA - CSJLL";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAdjuntarWord
            // 
            this.btnAdjuntarWord.Location = new System.Drawing.Point(628, 321);
            this.btnAdjuntarWord.Name = "btnAdjuntarWord";
            this.btnAdjuntarWord.Size = new System.Drawing.Size(75, 23);
            this.btnAdjuntarWord.TabIndex = 64;
            this.btnAdjuntarWord.Text = "Adjuntar";
            this.btnAdjuntarWord.UseSelectable = true;
            this.btnAdjuntarWord.Click += new System.EventHandler(this.BtnAdjuntarWord_Click);
            // 
            // gridDocs
            // 
            this.gridDocs.AllowUserToAddRows = false;
            this.gridDocs.AllowUserToDeleteRows = false;
            this.gridDocs.AllowUserToResizeColumns = false;
            this.gridDocs.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.gridDocs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDocs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDocs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDocs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridDocs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDocs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gridDocs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDocs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Accion,
            this.Documento});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDocs.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridDocs.EnableHeadersVisualStyles = false;
            this.gridDocs.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridDocs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridDocs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gridDocs.Location = new System.Drawing.Point(193, 289);
            this.gridDocs.Name = "gridDocs";
            this.gridDocs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDocs.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridDocs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.gridDocs.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gridDocs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDocs.Size = new System.Drawing.Size(417, 293);
            this.gridDocs.Style = MetroFramework.MetroColorStyle.Black;
            this.gridDocs.TabIndex = 63;
            this.gridDocs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDocs_CellContentClick);
            // 
            // Accion
            // 
            this.Accion.HeaderText = "Accion";
            this.Accion.Name = "Accion";
            this.Accion.Width = 50;
            // 
            // Documento
            // 
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            this.Documento.Width = 320;
            // 
            // txtNuevo
            // 
            // 
            // 
            // 
            this.txtNuevo.CustomButton.Image = null;
            this.txtNuevo.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.txtNuevo.CustomButton.Name = "";
            this.txtNuevo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNuevo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNuevo.CustomButton.TabIndex = 1;
            this.txtNuevo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNuevo.CustomButton.UseSelectable = true;
            this.txtNuevo.CustomButton.Visible = false;
            this.txtNuevo.Lines = new string[] {
        "metroTextBox1"};
            this.txtNuevo.Location = new System.Drawing.Point(474, 238);
            this.txtNuevo.MaxLength = 32767;
            this.txtNuevo.Name = "txtNuevo";
            this.txtNuevo.PasswordChar = '\0';
            this.txtNuevo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNuevo.SelectedText = "";
            this.txtNuevo.SelectionLength = 0;
            this.txtNuevo.SelectionStart = 0;
            this.txtNuevo.ShortcutsEnabled = true;
            this.txtNuevo.Size = new System.Drawing.Size(155, 23);
            this.txtNuevo.TabIndex = 65;
            this.txtNuevo.Text = "metroTextBox1";
            this.txtNuevo.UseSelectable = true;
            this.txtNuevo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNuevo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 655);
            this.Controls.Add(this.txtNuevo);
            this.Controls.Add(this.btnAdjuntarWord);
            this.Controls.Add(this.gridDocs);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.btnFirmar);
            this.Controls.Add(this.btnNuevoDoc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Firma Electrónica";
            this.Load += new System.EventHandler(this.Editor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDocs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnNuevoDoc;
        private MetroFramework.Controls.MetroButton btnFirmar;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton btnAdjuntarWord;
        private MetroFramework.Controls.MetroGrid gridDocs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private MetroFramework.Controls.MetroTextBox txtNuevo;
    }
}