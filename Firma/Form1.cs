using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharpSign;
using MetroFramework;
using MetroFramework.Forms;
using Microsoft.Office.Interop.Word;

namespace Firma_Digital
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

      

       public Microsoft.Office.Interop.Word.Document wordDocument { get; set; }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            string a = CalculateMD5Hash(txtNuevo.Text);
            txtNuevo.Text = a;
        }

        private string CalculateMD5Hash(string input)
        {
            // hashing
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();

        }

        private void MetroListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Editor_Load(object sender, EventArgs e)
        {
            string folderPath = "c:/";
            string[] files = System.IO.Directory.GetFiles(folderPath, "*.docx");

            for (int x = 0; x < files.Length; x++)
            {               
                gridDocs.Rows.Add("",files[x]);
            }
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {
            //Microsoft.Office.Interop.Word.Application appWord = new Microsoft.Office.Interop.Word.Application();
            //wordDocument = appWord.Documents.Open(@"F:\a.docx");
            //wordDocument.ExportAsFixedFormat(@"F:\jejej.pdf", WdExportFormat.wdExportFormatPDF);
            //Debug.WriteLine(lstDocs.Items.IndexOf(lstDocs.SelectedItems[0]));
            Firma f2 = new Firma();
            //MetroMessageBox.Show(this, "Hola");
            f2.ShowDialog();
        }

        private void MetroButton1_Click_1(object sender, EventArgs e)
        {
            Mensaje f2 = new Mensaje();
            f2.ShowDialog();
        }

        private void GridDocs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnAdjuntarWord_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFile;
            openFile = new System.Windows.Forms.OpenFileDialog();
            openFile.Filter = "Archivos PDF *.pdf|*.pdf";
            openFile.Title = "Seleccione un PDF";
            if (openFile.ShowDialog() != DialogResult.OK)
                return;

            ;
            
            PdfReader reader = new PdfReader(openFile.FileName);

            MetaData md = new MetaData();
            md.Info = reader.Info;
        }
    }
}
