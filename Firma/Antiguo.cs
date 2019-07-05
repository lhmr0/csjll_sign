using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Firma_Digital;
using iTextSharp.text.pdf;
using MetroFramework;
using MetroFramework.Forms;

namespace iTextSharpSign
{
    public partial class FirmaDigital : MetroForm
    {
        public FirmaDigital()
        {
            InitializeComponent();
        }


        private void debug(string txt)
        {
            DebugBox.AppendText(txt + System.Environment.NewLine);
        }


        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void SigVisible_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
      
        }

        private void MetroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel1_Click(object sender, EventArgs e)
        {

        }


        private void MetroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void MetroToggle1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnBuscarDoc_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFile;
            openFile = new System.Windows.Forms.OpenFileDialog();
            openFile.Filter = "Archivos PDF *.pdf|*.pdf";
            openFile.Title = "Seleccione un PDF";
            if (openFile.ShowDialog() != DialogResult.OK)
                return;

            txtDocumento.Text = openFile.FileName;


            PdfReader reader = new PdfReader(txtDocumento.Text);

            MetaData md = new MetaData();
            md.Info = reader.Info;

        }

        private void BtnBuscarImagen_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFile;
            openFile = new System.Windows.Forms.OpenFileDialog();
            openFile.Filter = "Imágenes (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            openFile.Title = "Seleccione la firma";
            if (openFile.ShowDialog() != DialogResult.OK)
                return;

            txtImagen.Text = openFile.FileName;
        }

        private void BtnBuscarCert_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFile;
            openFile = new System.Windows.Forms.OpenFileDialog();
            openFile.Filter = "Certficado *.pfx|*.pfx";
            openFile.Title = "Seleccione el certificado";
            if (openFile.ShowDialog() != DialogResult.OK)
                return;

            txtCertificado.Text = openFile.FileName;
        }

        private void BtnBuscarDocNuevo_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog saveFile;
            saveFile = new System.Windows.Forms.SaveFileDialog();
            saveFile.Filter = "Archivos PDF (*.pdf)|*.pdf";
            saveFile.Title = "Guardar PDF";
            if (saveFile.ShowDialog() != DialogResult.OK)
                return;
            txtDocumentoNuevo.Text = saveFile.FileName;

        }

        private void BtnFirmar_Click(object sender, EventArgs e)
        {
            debug("Inició!");
            debug("======================================");
            debug("Verificando certificado...");
            Cert myCert = null;
            try
            {
                myCert = new Cert(txtCertificado.Text, txtClave.Text);
                debug("El certificado es correcto");
            }
            catch (Exception ex)
            {
                debug("Error : Por favor ingrese certificado o contraseña correcta");
                debug("Exception : " + ex.ToString());
                return;
            }
            debug("Creando documento firmado");

            MetaData MyMD = new MetaData();
            debug("Firmando documento...");
            PDFSigner pdfs = new PDFSigner(txtDocumento.Text, txtDocumentoNuevo.Text, myCert, MyMD);
            pdfs.Sign(SigVisible.Checked, txtImagen.Text);
            debug("Se ha creado el documento!");
            debug(txtDocumentoNuevo.Text);
            string body = "le adjunto el documento firmado";

            var processInfo = new System.Diagnostics.ProcessStartInfo("cmd.exe", "/c" + "\"f:/gwsend.exe /t=lmarinr@pj.gob.pe /s=Documento_firmado /a=" + txtDocumentoNuevo.Text + " /m=\"" + body + "\" ");

            processInfo.CreateNoWindow = true;

            processInfo.UseShellExecute = false;

            processInfo.RedirectStandardError = true;
            processInfo.RedirectStandardOutput = true;

            var process = System.Diagnostics.Process.Start(processInfo);

            process.Start();

            process.WaitForExit();

            string output = process.StandardOutput.ReadToEnd();
            string error = process.StandardError.ReadToEnd();
            debug(output+error);

        }

        private void MetroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void TxtDocumento_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void EnvioCorreo_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void MetroContextMenu1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            Login f2 = new Login();
            //MetroMessageBox.Show(this, "Hola");
            f2.ShowDialog();
        }
    }
}