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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.btnAdjuntarWord = new MetroFramework.Controls.MetroButton();
            this.gridDocs = new MetroFramework.Controls.MetroGrid();
            this.Accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSubiendo = new MetroFramework.Controls.MetroLabel();
            this.btnActualizar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDocs)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevoDoc
            // 
            this.btnNuevoDoc.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnNuevoDoc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNuevoDoc.Location = new System.Drawing.Point(363, 238);
            this.btnNuevoDoc.Name = "btnNuevoDoc";
            this.btnNuevoDoc.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoDoc.TabIndex = 0;
            this.btnNuevoDoc.Text = "Nuevo";
            this.btnNuevoDoc.UseSelectable = true;
            this.btnNuevoDoc.Click += new System.EventHandler(this.MetroButton1_Click);
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
            this.btnAdjuntarWord.Location = new System.Drawing.Point(520, 238);
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
            this.gridDocs.Location = new System.Drawing.Point(109, 288);
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
            this.gridDocs.Size = new System.Drawing.Size(578, 293);
            this.gridDocs.Style = MetroFramework.MetroColorStyle.Black;
            this.gridDocs.TabIndex = 63;
            this.gridDocs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDocs_CellContentClick);
            this.gridDocs.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridDocs_CellFormatting_1);
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
            // lblSubiendo
            // 
            this.lblSubiendo.AutoSize = true;
            this.lblSubiendo.Location = new System.Drawing.Point(39, 562);
            this.lblSubiendo.Name = "lblSubiendo";
            this.lblSubiendo.Size = new System.Drawing.Size(0, 0);
            this.lblSubiendo.TabIndex = 65;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(206, 238);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 66;
            this.btnActualizar.Text = "Cargar";
            this.btnActualizar.UseSelectable = true;
            this.btnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 655);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.lblSubiendo);
            this.Controls.Add(this.btnAdjuntarWord);
            this.Controls.Add(this.gridDocs);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.pictureBox1);
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton btnAdjuntarWord;
        private MetroFramework.Controls.MetroGrid gridDocs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Accion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private MetroFramework.Controls.MetroLabel lblSubiendo;
        private MetroFramework.Controls.MetroButton btnActualizar;
    }
}