using iTextSharpSign;
using MetroFramework;
using MetroFramework.Forms;
using Microsoft.Office.Interop.Word;
using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Firma_Digital
{
    public partial class Form1 : MetroForm
    {
        System.Windows.Forms.OpenFileDialog openFile;
        MySqlConnection con = new MySqlConnection("datasource=172.41.158.33;port=3306;username=ldfirmas;password=123456;database=ldfirmas;");
        DataGridViewButtonColumn btnFirmar;
        string lastWord = "";
        string destinationFile = "";
        string newPdf = "";
        string pdf = "";
        string pdfRemove = "";
        public Form1()
        {
            InitializeComponent();


            /******CARGAR COLUMNAS******/

            gridDocs.Columns.Clear();

            btnFirmar = new DataGridViewButtonColumn();
            btnFirmar.Text = "Firmar";
            btnFirmar.Name = "Accion";
            btnFirmar.UseColumnTextForButtonValue = true;
            gridDocs.Columns.Add(btnFirmar);


            /* DataGridViewButtonColumn btnEnviar = new DataGridViewButtonColumn();
             btnEnviar.Text = "Enviar";
             btnEnviar.Name = "Accion";
             btnEnviar.UseColumnTextForButtonValue = true;
             gridDocs.Columns.Add(btnEnviar);*/

            gridDocs.Columns.Add("Nombre", "Nombre");
            gridDocs.Columns.Add("Fecha", "Fecha");
            gridDocs.Columns.Add("Id Documento", "Id Documento");
            gridDocs.Columns.Add("Estado", "Estado");


            cargarDocumentos();
            InitializeComponent();
        }

        public void cargarDocumentos()
        {

            con.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT id_documento_digital,nombre,fecha , estado FROM documento_digital where estado>=1", con);
            MySqlDataReader datos = cmd.ExecuteReader();

            while (datos.Read())
            {
                Console.WriteLine(datos.GetString(0));

                string[] row = new string[6];
                row[0] = "";
                row[1] = datos.GetString(1);
                row[2] = datos.GetString(2);
                row[3] = datos.GetString(0);
                row[4] = datos.GetString(3);



                gridDocs.Rows.Add(row);


                //DataGridViewButtonCell btn = (DataGridViewButtonCell)gridDocs.Rows[0].Cells[0];

                //btn.Value = "diego flores";
                //int estado = datos.GetInt32(3);

                //gridDocs.Rows[0].Cells[0].Value = "Lavado";


                /*
                DataGridViewButtonColumn btnEnviar = new DataGridViewButtonColumn();
                btnEnviar.Text = "estado";
                btnEnviar.Name = "Accion";
                btnEnviar.UseColumnTextForButtonValue = true;*/

                //gridDocs.Rows[0].Cells[0] = btn;


            }
            con.Close();
        }

        public void cambiarEstado(int id_documento, int estado)
        {

            con.Open();
            MySqlCommand cmd = new MySqlCommand("update documento_digital set estado= " + estado + " where id_documento_digital=" + id_documento, con);

            cmd.ExecuteNonQuery();
            con.Close();
        }



        public Microsoft.Office.Interop.Word.Document wordDocument { get; set; }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
           
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
            spnArchivo.Visible = false;

            string folderPath = "c:/";
            string[] files = System.IO.Directory.GetFiles(folderPath, "*.docx");


            for (int x = 0; x < files.Length; x++)
            {
                gridDocs.Rows.Add("", files[x]);
            }
        }

        private void MetroButton2_Click(object sender, EventArgs e)
        {

            Cert myCert = null;
            try
            {
                //firmando pdf
                string pathCert = "D:/serviciodigitalFINAL_11102018/serviciodigitalFINAL_11102018/serviciodigitalFINAL.pfx";
                string keyCert = "eWgJu5TY6s7xav6q";
                myCert = new Cert(pathCert, keyCert);
                MetaData MyMD = new MetaData();
                newPdf = "D:/docs_firmados/" + lastWord + "_firmado.pdf";
                string signedPdf = destinationFile + "_firmado.pdf";
                PDFSigner pdfs = new PDFSigner(pdf, signedPdf, myCert, MyMD);
                Console.WriteLine(newPdf);
                string pathImage = "D:/serviciodigitalFINAL_11102018/serviciodigitalFINAL_11102018/firma.png";
                pdfs.Sign(true, pathImage);

                //eliminamos la el docs convertido a pdf
                System.IO.File.Delete(@"" + pdfRemove + "");
                Console.WriteLine(pdfRemove);

                //copiando pdf firmado del servidor 
                string sourceFile = System.IO.Path.Combine(signedPdf);
                string destFile = System.IO.Path.Combine(newPdf);
                System.IO.Directory.CreateDirectory("C:/docs_firmados");
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            catch (Exception ex)
            {

                MetroMessageBox.Show(this, ex.Message, "ERROR");
                return;
            }




            Firma f2 = new Firma();
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

            openFile = new System.Windows.Forms.OpenFileDialog();
            openFile.Filter = "Documentos *.doc|*.docx|PDF (*.pdf)|*.pdf";
            //openFile.Filter = "PDF |*.pdf";
            openFile.Title = "Seleccione un documento";
            if (openFile.ShowDialog() != DialogResult.OK)
                return;

            ;

            Console.WriteLine(openFile.FileName);
            string path = openFile.FileName;
            lastWord = path.Split('\\').Last();
            Console.WriteLine(lastWord);
            string doc = lastWord.Split('.').Last();
            Console.WriteLine(doc);
            string uploadDoc = "";
            bool soloPdf = false;
            if (doc != "pdf")
            {
                Microsoft.Office.Interop.Word.Application appWord = new Microsoft.Office.Interop.Word.Application();
                wordDocument = appWord.Documents.Open(@"" + openFile.FileName + "");
                pdf = openFile.FileName + ".pdf";
                //newPdf = openFile.FileName + "_firmado.pdf";
                wordDocument.ExportAsFixedFormat(@"" + pdf + "", WdExportFormat.wdExportFormatPDF);
                spnArchivo.Visible = true;
                destinationFile = @"\\172.41.158.33\publico\archivos\" + lastWord;
                uploadDoc = destinationFile + ".pdf";
                soloPdf = false;
            }
            else
            {
                pdf = openFile.FileName;
                destinationFile = @"\\172.41.158.33\publico\archivos\" + lastWord;
                soloPdf = true;
            }


            
            pdfRemove = destinationFile + ".pdf";


            if (openFile.FileName != "")
            {
                if(soloPdf == true)
                {
                    try
                    {
                        System.IO.File.Copy(openFile.FileName, destinationFile);
                        spnArchivo.Visible = false;
                        MetroMessageBox.Show(this, "Archivo PDF subido correctamente", "Documento");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        MetroMessageBox.Show(this, ex.Message, "ERROR");
                    }
                }
                else
                {
                    try
                    {
                        System.IO.File.Copy(openFile.FileName, destinationFile);
                        System.IO.File.Copy(pdf, uploadDoc);
                        spnArchivo.Visible = false;
                        MetroMessageBox.Show(this, "Archivo DOC subido correctamente", "Documento");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        MetroMessageBox.Show(this, ex.Message, "ERROR");
                    }
                }
              
            }

        }
    }
}
