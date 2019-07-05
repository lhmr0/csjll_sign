namespace iTextSharpSign
{
    partial class FirmaDigital
    {
        /// <summary>
        /// RequiBlue designer variable.
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
        /// RequiBlue method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirmaDigital));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.txtDocumento = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnBuscarDoc = new MetroFramework.Controls.MetroButton();
            this.txtDocumentoNuevo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnBuscarDocNuevo = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtCertificado = new MetroFramework.Controls.MetroTextBox();
            this.btnBuscarCert = new MetroFramework.Controls.MetroButton();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtClave = new MetroFramework.Controls.MetroTextBox();
            this.btnFirmar = new MetroFramework.Controls.MetroButton();
            this.txtImagen = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.btnBuscarImagen = new MetroFramework.Controls.MetroButton();
            this.SigVisible = new MetroFramework.Controls.MetroToggle();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.DebugBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.envioCorreo = new MetroFramework.Controls.MetroCheckBox();
            this.txtCorreo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click_1);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeColumns = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle20;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            resources.ApplyResources(this.metroGrid1, "metroGrid1");
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroGrid1.UseStyleColors = true;
            // 
            // txtDocumento
            // 
            // 
            // 
            // 
            this.txtDocumento.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.txtDocumento.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode")));
            this.txtDocumento.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location")));
            this.txtDocumento.CustomButton.Name = "";
            this.txtDocumento.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size")));
            this.txtDocumento.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDocumento.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex")));
            this.txtDocumento.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDocumento.CustomButton.UseSelectable = true;
            this.txtDocumento.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible")));
            this.txtDocumento.Lines = new string[0];
            resources.ApplyResources(this.txtDocumento, "txtDocumento");
            this.txtDocumento.MaxLength = 32767;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.PasswordChar = '\0';
            this.txtDocumento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDocumento.SelectedText = "";
            this.txtDocumento.SelectionLength = 0;
            this.txtDocumento.SelectionStart = 0;
            this.txtDocumento.ShortcutsEnabled = true;
            this.txtDocumento.UseSelectable = true;
            this.txtDocumento.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDocumento.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDocumento.Click += new System.EventHandler(this.TxtDocumento_Click);
            // 
            // metroLabel1
            // 
            resources.ApplyResources(this.metroLabel1, "metroLabel1");
            this.metroLabel1.Name = "metroLabel1";
            // 
            // btnBuscarDoc
            // 
            resources.ApplyResources(this.btnBuscarDoc, "btnBuscarDoc");
            this.btnBuscarDoc.Name = "btnBuscarDoc";
            this.btnBuscarDoc.UseSelectable = true;
            this.btnBuscarDoc.Click += new System.EventHandler(this.BtnBuscarDoc_Click);
            // 
            // txtDocumentoNuevo
            // 
            // 
            // 
            // 
            this.txtDocumentoNuevo.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.txtDocumentoNuevo.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location1")));
            this.txtDocumentoNuevo.CustomButton.Name = "";
            this.txtDocumentoNuevo.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size1")));
            this.txtDocumentoNuevo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDocumentoNuevo.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex1")));
            this.txtDocumentoNuevo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDocumentoNuevo.CustomButton.UseSelectable = true;
            this.txtDocumentoNuevo.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible1")));
            this.txtDocumentoNuevo.Lines = new string[0];
            resources.ApplyResources(this.txtDocumentoNuevo, "txtDocumentoNuevo");
            this.txtDocumentoNuevo.MaxLength = 32767;
            this.txtDocumentoNuevo.Name = "txtDocumentoNuevo";
            this.txtDocumentoNuevo.PasswordChar = '\0';
            this.txtDocumentoNuevo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDocumentoNuevo.SelectedText = "";
            this.txtDocumentoNuevo.SelectionLength = 0;
            this.txtDocumentoNuevo.SelectionStart = 0;
            this.txtDocumentoNuevo.ShortcutsEnabled = true;
            this.txtDocumentoNuevo.UseSelectable = true;
            this.txtDocumentoNuevo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDocumentoNuevo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            resources.ApplyResources(this.metroLabel2, "metroLabel2");
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Click += new System.EventHandler(this.MetroLabel2_Click);
            // 
            // btnBuscarDocNuevo
            // 
            resources.ApplyResources(this.btnBuscarDocNuevo, "btnBuscarDocNuevo");
            this.btnBuscarDocNuevo.Name = "btnBuscarDocNuevo";
            this.btnBuscarDocNuevo.UseSelectable = true;
            this.btnBuscarDocNuevo.Click += new System.EventHandler(this.BtnBuscarDocNuevo_Click);
            // 
            // metroLabel3
            // 
            resources.ApplyResources(this.metroLabel3, "metroLabel3");
            this.metroLabel3.Name = "metroLabel3";
            // 
            // txtCertificado
            // 
            // 
            // 
            // 
            this.txtCertificado.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.txtCertificado.CustomButton.ImeMode = ((System.Windows.Forms.ImeMode)(resources.GetObject("resource.ImeMode1")));
            this.txtCertificado.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location2")));
            this.txtCertificado.CustomButton.Name = "";
            this.txtCertificado.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size2")));
            this.txtCertificado.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCertificado.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex2")));
            this.txtCertificado.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCertificado.CustomButton.UseSelectable = true;
            this.txtCertificado.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible2")));
            this.txtCertificado.Lines = new string[0];
            resources.ApplyResources(this.txtCertificado, "txtCertificado");
            this.txtCertificado.MaxLength = 32767;
            this.txtCertificado.Name = "txtCertificado";
            this.txtCertificado.PasswordChar = '\0';
            this.txtCertificado.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCertificado.SelectedText = "";
            this.txtCertificado.SelectionLength = 0;
            this.txtCertificado.SelectionStart = 0;
            this.txtCertificado.ShortcutsEnabled = true;
            this.txtCertificado.UseSelectable = true;
            this.txtCertificado.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCertificado.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnBuscarCert
            // 
            resources.ApplyResources(this.btnBuscarCert, "btnBuscarCert");
            this.btnBuscarCert.Name = "btnBuscarCert";
            this.btnBuscarCert.UseSelectable = true;
            this.btnBuscarCert.Click += new System.EventHandler(this.BtnBuscarCert_Click);
            // 
            // metroLabel4
            // 
            resources.ApplyResources(this.metroLabel4, "metroLabel4");
            this.metroLabel4.Name = "metroLabel4";
            // 
            // txtClave
            // 
            // 
            // 
            // 
            this.txtClave.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.txtClave.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location3")));
            this.txtClave.CustomButton.Name = "";
            this.txtClave.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size3")));
            this.txtClave.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtClave.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex3")));
            this.txtClave.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtClave.CustomButton.UseSelectable = true;
            this.txtClave.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible3")));
            this.txtClave.Lines = new string[0];
            resources.ApplyResources(this.txtClave, "txtClave");
            this.txtClave.MaxLength = 32767;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '●';
            this.txtClave.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtClave.SelectedText = "";
            this.txtClave.SelectionLength = 0;
            this.txtClave.SelectionStart = 0;
            this.txtClave.ShortcutsEnabled = true;
            this.txtClave.UseSelectable = true;
            this.txtClave.UseSystemPasswordChar = true;
            this.txtClave.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtClave.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnFirmar
            // 
            this.btnFirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnFirmar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.btnFirmar, "btnFirmar");
            this.btnFirmar.Name = "btnFirmar";
            this.btnFirmar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnFirmar.UseSelectable = true;
            this.btnFirmar.Click += new System.EventHandler(this.BtnFirmar_Click);
            // 
            // txtImagen
            // 
            // 
            // 
            // 
            this.txtImagen.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.txtImagen.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location4")));
            this.txtImagen.CustomButton.Name = "";
            this.txtImagen.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size4")));
            this.txtImagen.CustomButton.Style = MetroFramework.MetroColorStyle.Red;
            this.txtImagen.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex4")));
            this.txtImagen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtImagen.CustomButton.UseSelectable = true;
            this.txtImagen.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible4")));
            this.txtImagen.Lines = new string[0];
            resources.ApplyResources(this.txtImagen, "txtImagen");
            this.txtImagen.MaxLength = 32767;
            this.txtImagen.Name = "txtImagen";
            this.txtImagen.PasswordChar = '\0';
            this.txtImagen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtImagen.SelectedText = "";
            this.txtImagen.SelectionLength = 0;
            this.txtImagen.SelectionStart = 0;
            this.txtImagen.ShortcutsEnabled = true;
            this.txtImagen.UseSelectable = true;
            this.txtImagen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtImagen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            resources.ApplyResources(this.metroLabel5, "metroLabel5");
            this.metroLabel5.Name = "metroLabel5";
            // 
            // btnBuscarImagen
            // 
            resources.ApplyResources(this.btnBuscarImagen, "btnBuscarImagen");
            this.btnBuscarImagen.Name = "btnBuscarImagen";
            this.btnBuscarImagen.UseSelectable = true;
            this.btnBuscarImagen.Click += new System.EventHandler(this.BtnBuscarImagen_Click);
            // 
            // SigVisible
            // 
            resources.ApplyResources(this.SigVisible, "SigVisible");
            this.SigVisible.Name = "SigVisible";
            this.SigVisible.UseSelectable = true;
            this.SigVisible.CheckedChanged += new System.EventHandler(this.MetroToggle1_CheckedChanged);
            // 
            // metroLabel6
            // 
            resources.ApplyResources(this.metroLabel6, "metroLabel6");
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Click += new System.EventHandler(this.MetroLabel6_Click);
            // 
            // DebugBox
            // 
            // 
            // 
            // 
            this.DebugBox.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.DebugBox.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location5")));
            this.DebugBox.CustomButton.Name = "";
            this.DebugBox.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size5")));
            this.DebugBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DebugBox.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex5")));
            this.DebugBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DebugBox.CustomButton.UseSelectable = true;
            this.DebugBox.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible5")));
            this.DebugBox.Lines = new string[0];
            resources.ApplyResources(this.DebugBox, "DebugBox");
            this.DebugBox.MaxLength = 32767;
            this.DebugBox.Multiline = true;
            this.DebugBox.Name = "DebugBox";
            this.DebugBox.PasswordChar = '\0';
            this.DebugBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DebugBox.SelectedText = "";
            this.DebugBox.SelectionLength = 0;
            this.DebugBox.SelectionStart = 0;
            this.DebugBox.ShortcutsEnabled = true;
            this.DebugBox.UseSelectable = true;
            this.DebugBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DebugBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            resources.ApplyResources(this.metroLabel7, "metroLabel7");
            this.metroLabel7.Name = "metroLabel7";
            // 
            // metroLabel8
            // 
            resources.ApplyResources(this.metroLabel8, "metroLabel8");
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Click += new System.EventHandler(this.MetroLabel8_Click);
            // 
            // envioCorreo
            // 
            resources.ApplyResources(this.envioCorreo, "envioCorreo");
            this.envioCorreo.Name = "envioCorreo";
            this.envioCorreo.UseSelectable = true;
            this.envioCorreo.CheckedChanged += new System.EventHandler(this.EnvioCorreo_CheckedChanged);
            // 
            // txtCorreo
            // 
            // 
            // 
            // 
            this.txtCorreo.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.txtCorreo.CustomButton.Location = ((System.Drawing.Point)(resources.GetObject("resource.Location6")));
            this.txtCorreo.CustomButton.Name = "";
            this.txtCorreo.CustomButton.Size = ((System.Drawing.Size)(resources.GetObject("resource.Size6")));
            this.txtCorreo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCorreo.CustomButton.TabIndex = ((int)(resources.GetObject("resource.TabIndex6")));
            this.txtCorreo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCorreo.CustomButton.UseSelectable = true;
            this.txtCorreo.CustomButton.Visible = ((bool)(resources.GetObject("resource.Visible6")));
            this.txtCorreo.Lines = new string[0];
            resources.ApplyResources(this.txtCorreo, "txtCorreo");
            this.txtCorreo.MaxLength = 32767;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.PasswordChar = '\0';
            this.txtCorreo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCorreo.SelectedText = "";
            this.txtCorreo.SelectionLength = 0;
            this.txtCorreo.SelectionStart = 0;
            this.txtCorreo.ShortcutsEnabled = true;
            this.txtCorreo.UseSelectable = true;
            this.txtCorreo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCorreo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel9
            // 
            resources.ApplyResources(this.metroLabel9, "metroLabel9");
            this.metroLabel9.Name = "metroLabel9";
            // 
            // metroButton1
            // 
            resources.ApplyResources(this.metroButton1, "metroButton1");
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.MetroButton1_Click);
            // 
            // FirmaDigital
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AllowDrop = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.envioCorreo);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.DebugBox);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.SigVisible);
            this.Controls.Add(this.btnBuscarImagen);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtImagen);
            this.Controls.Add(this.btnFirmar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.btnBuscarCert);
            this.Controls.Add(this.txtCertificado);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.btnBuscarDocNuevo);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txtDocumentoNuevo);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnBuscarDoc);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FirmaDigital";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTextBox txtDocumento;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnBuscarDoc;
        private MetroFramework.Controls.MetroTextBox txtDocumentoNuevo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnBuscarDocNuevo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtCertificado;
        private MetroFramework.Controls.MetroButton btnBuscarCert;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtClave;
        private MetroFramework.Controls.MetroButton btnFirmar;
        private MetroFramework.Controls.MetroTextBox txtImagen;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroButton btnBuscarImagen;
        private MetroFramework.Controls.MetroToggle SigVisible;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox DebugBox;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroCheckBox envioCorreo;
        private MetroFramework.Controls.MetroTextBox txtCorreo;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

