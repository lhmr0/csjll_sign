using MetroFramework;
using MetroFramework.Forms;
using Microsoft.Office.Interop.Word;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Firma_Digital
{
    public partial class Form1 : MetroForm
    {
        System.Windows.Forms.OpenFileDialog openFile;
        MySqlConnection con = new MySqlConnection(Globales.connectionString);
        DataGridViewButtonColumn btnFirmar;
        string lastWord = "";
        string destinationFile = "";
        string newPdf = "";
        string pdf = "";
        string pdfRemove = "";

        int id_ruta_documento =0;
        string ruta_documento = "";


        int id_ruta_certificado = 0;
        string ruta_certificado = "";

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

            this.obtenerRutaDocumento();


            this.cargarDocumentos();

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


        public void obtenerRutaDocumento()
        {

            con.Open();
            MySqlCommand cmd = new MySqlCommand("select r.id_ruta,r.carpeta,r.servidor from ruta r where tipo_ruta='D' and r.estado=1 limit 1", con);
            MySqlDataReader datos = cmd.ExecuteReader();

            while (datos.Read())
            {
                Console.WriteLine(datos.GetString(0));

                this.id_ruta_documento= datos.GetInt32(0);
                this.ruta_documento =@"\\"+datos.GetString(2) + "\\" + datos.GetString(1)+"\\";
 

                Console.WriteLine("id_ruta_documento: " + id_ruta_documento);
                Console.WriteLine("ruta_documento: " + ruta_documento);
            }
            con.Close();
        }


        public string obtenerRutaCertificadoByEmpleado(int id_empleado)
        {
            string ruta_certificado = "";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(@"SELECT f.nombre,f.clave,f.id_empleado,r.id_ruta,r.carpeta,r.servidor FROM firma_digital f
                                                inner join ruta r on r.id_ruta = f.id_ruta
                                                where f.tipo_firma='C' and f.estado = 1 and f.id_empleado = "+ id_empleado, con);
            MySqlDataReader datos = cmd.ExecuteReader();

            while (datos.Read())
            {
                Console.WriteLine(datos.GetString(0));

                //this.id_ruta_certificado = datos.GetInt32(0);
                //his.ruta_certificado = @"\\" + datos.GetString(2) + "\\" + datos.GetString(1) + "\\";
                ruta_certificado= @"\\" + datos.GetString(5) + "\\" + datos.GetString(4) + "\\" + datos.GetString(0);

                Console.WriteLine("id_ruta_certificado: " + this.id_ruta_certificado);
                Console.WriteLine("ruta_certificado: " + ruta_certificado);
            }
            con.Close();

            return ruta_certificado;
        }


        public string obtenerRutaImagenFirmaByEmpleado(int id_empleado)
        {
            string ruta_certificado = "";
            con.Open();
            MySqlCommand cmd = new MySqlCommand(@"SELECT f.nombre,f.clave,f.id_empleado,r.id_ruta,r.carpeta,r.servidor FROM firma_digital f
                                                inner join ruta r on r.id_ruta = f.id_ruta
                                                where f.tipo_firma='I' and f.estado = 1 and f.id_empleado = " + id_empleado, con);
            MySqlDataReader datos = cmd.ExecuteReader();

            while (datos.Read())
            {
                Console.WriteLine(datos.GetString(0));

                //this.id_ruta_certificado = datos.GetInt32(0);
                //his.ruta_certificado = @"\\" + datos.GetString(2) + "\\" + datos.GetString(1) + "\\";
                ruta_certificado = @"\\" + datos.GetString(5) + "\\" + datos.GetString(4) + "\\" + datos.GetString(0);

                Console.WriteLine("id_ruta_certificado: " + this.id_ruta_certificado);
                Console.WriteLine("ruta_certificado: " + this.ruta_certificado);
            }
            con.Close();

            return ruta_certificado;
        }


        public void cambiarEstado(int id_documento, int estado)
		{

			con.Open();
			MySqlCommand cmd = new MySqlCommand("update documento_digital set estado= " + estado + " where id_documento_digital=" + id_documento, con);

			cmd.ExecuteNonQuery();
			con.Close();
		}




        public void insertarArchivoSubido(string nombre, string extension, int id_empleado, int id_ruta, int estado)
        {

            con.Open();
            MySqlCommand cmd = new MySqlCommand("insert into documento_digital(nombre,fecha,extension,id_empleado, id_ruta, estado) values(@nombre,now(),@extension,@id_empleado,@id_ruta,@estado)", con);
            cmd.Parameters.AddWithValue("@nombre", nombre);
            cmd.Parameters.AddWithValue("@extension", extension);
            cmd.Parameters.AddWithValue("@id_empleado", id_empleado);
            cmd.Parameters.AddWithValue("@id_rutao",id_ruta);
            cmd.Parameters.AddWithValue("@estado", estado);

            int nroFilas =cmd.ExecuteNonQuery();
            int ultimoIdInsertado = 0;
            cmd.CommandText = "select LAST_INSERT_ID() as lastid";
            MySqlDataReader datos = cmd.ExecuteReader();

            if (datos.Read()) {
                ultimoIdInsertado = datos.GetInt32(0);
            }

            Console.WriteLine("nro filas afectadas: " + nroFilas);
            Console.WriteLine("ultimo id insertado: " + ultimoIdInsertado);
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
            //string folderPath = "c:/";
			//string[] files = System.IO.Directory.GetFiles(folderPath, "*.docx");


			//for (int x = 0; x < files.Length; x++)
			//{
				//gridDocs.Rows.Add("", files[x]);
			//}
		}

		private void MetroButton2_Click(object sender, EventArgs e)
		{
			



			Firma f2 = new Firma();
			f2.ShowDialog();
		}


        public void firmarDocumento(string nombre_doc, string ruta_documento_documento,string ruta_documento_certificado,string clave_certificado,string ruta_documento_imagen_firma,string
            ruta_documento_almacenamiento_firmado){
            Cert myCert = null;
            try
            {
                //firmando pdf
                //string pathCert = "D:/serviciodigitalFINAL_11102018/serviciodigitalFINAL_11102018/serviciodigitalFINAL.pfx";

                string pathCert = ruta_documento_certificado;//ruta_documento_certificado;
                //string keyCert = "eWgJu5TY6s7xav6q";
                string keyCert=clave_certificado;
                Console.WriteLine("pathCert: "+ pathCert);
                myCert = new Cert(pathCert, keyCert);
                MetaData MyMD = new MetaData();
                //newPdf = "D:/docs_firmados/" + lastWord + "_firmado.pdf";
                newPdf = ruta_documento_documento+ "_firmado.pdf";
                string signedPdf = ruta_documento_documento + "_firmado.pdf";
                pdf = ruta_documento_documento + nombre_doc + ".pdf";
                Console.WriteLine("pdf firma: "+pdf);
                Console.WriteLine("signedPdf firma: " + signedPdf);
                PDFSigner pdfs = new PDFSigner(pdf, signedPdf, myCert, MyMD);
                Console.WriteLine("newPdf: "+newPdf);
                //string pathImage = "D:/serviciodigitalFINAL_11102018/serviciodigitalFINAL_11102018/firma.png";
                string pathImage = ruta_documento_imagen_firma;
                pdfs.Sign(true, pathImage);

                //eliminamos la el docs convertido a pdf
                /*System.IO.File.Delete(@"" + pdfRemove + "");
                Console.WriteLine(pdfRemove);*/

                Console.WriteLine("documento firmado: "+ signedPdf);
                Console.WriteLine("new firmado: " + newPdf);
                //copiando pdf firmado del servidor 
                string sourceFile = System.IO.Path.Combine(signedPdf);
                string destFile = System.IO.Path.Combine(newPdf);
                //System.IO.Directory.CreateDirectory("C:/docs_firmados");

                System.IO.Directory.CreateDirectory(ruta_documento_almacenamiento_firmado);
                
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "ERROR");
                return;
            }
        }
		private void MetroButton1_Click_1(object sender, EventArgs e)
		{




			Mensaje f2 = new Mensaje();
			f2.ShowDialog();
		}

		private void GridDocs_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                Console.WriteLine("ha hecho click aqui: " + e.RowIndex);


                Int32 id_documento = Int32.Parse(gridDocs.Rows[e.RowIndex].Cells[3].Value.ToString());
                Int32 estado = Int32.Parse(gridDocs.Rows[e.RowIndex].Cells[4].Value.ToString());
                string nombreDoc = gridDocs.Rows[e.RowIndex].Cells[1].Value.ToString();
                Console.WriteLine("id_documento: " + id_documento);
                Console.WriteLine("estado: " + estado);
                firmar_enviar(id_documento, estado, nombreDoc);
            }
        }


        private void firmar_enviar(int id_documento, int estado,string nombre_documento)
        {

            if (estado == 1)
            {
                /***********FIRMAR DOCUMENTO***********/
                Console.WriteLine("VAS A FIRMAR EL DOCUMENTO");
                cambiarEstado(id_documento, 2);
                //firmarDocumento(id_documento);

                firmarDocumento(
                    nombre_documento,
                    this.ruta_documento,
                    this.obtenerRutaCertificadoByEmpleado(Globales.id_empleado),
                    "eWgJu5TY6s7xav6q",
                    this.obtenerRutaImagenFirmaByEmpleado(Globales.id_empleado),
                    this.ruta_documento); ;
            }

            if (estado == 2)
            {
                /***********ENVIAR DOCUMENTO CORREO***********/
                Console.WriteLine("ESTAS ENVIANDO EL DOCUMENTO");
                cambiarEstado(id_documento, 3);
            }

        }

        private void BtnAdjuntarWord_Click(object sender, EventArgs e)
		{

            this.adjuntarArchivo();

		}


        public void adjuntarArchivo() {

            openFile = new System.Windows.Forms.OpenFileDialog();
            openFile.Filter = "Documentos *.doc|*.docx|PDF (*.pdf)|*.pdf";
            //openFile.Filter = "PDF |*.pdf";
            openFile.Title = "Seleccione un documento";
            if (openFile.ShowDialog() != DialogResult.OK)
                return;

            ;

            lblSubiendo.Text = "Subiendo documento...";
            Console.WriteLine(openFile.FileName);
            string path = openFile.FileName;
            lastWord = path.Split('\\').Last();
            Console.WriteLine(lastWord);
            string doc = lastWord.Split('.').Last();
            string nombre_doc = lastWord.Split('.').First();
            Console.WriteLine(doc);

            Console.WriteLine("extension: "+ doc);
            Console.WriteLine("nombre_doc: " + nombre_doc);
            string uploadDoc = "";
                bool soloPdf = false;
            if (doc != "pdf")
            {
                Microsoft.Office.Interop.Word.Application appWord = new Microsoft.Office.Interop.Word.Application();
                wordDocument = appWord.Documents.Open(@"" + openFile.FileName + "");
                pdf = openFile.FileName + ".pdf";
                //newPdf = openFile.FileName + "_firmado.pdf";
                wordDocument.ExportAsFixedFormat(@"" + pdf + "", WdExportFormat.wdExportFormatPDF);

                //Cursor = Cursors.WaitCursor;
                //destinationFile = @"\\172.41.158.33\publico\archivos\" + lastWord;
                destinationFile =this.ruta_documento + nombre_doc;

                uploadDoc = destinationFile + ".pdf";
                soloPdf = false;
            }
            else
            {
                pdf = openFile.FileName;
                destinationFile = this.ruta_documento + lastWord;
                soloPdf = true;
            }



            pdfRemove = destinationFile + ".pdf";


            if (openFile.FileName != "")
            {
                if (soloPdf == true)
                {
                    try
                    {
                        System.IO.File.Copy(openFile.FileName, destinationFile);
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
                        MetroMessageBox.Show(this, "Archivo DOC subido correctamente", "Documento");


                        this.insertarArchivoSubido(nombre_doc, doc, Globales.id_empleado, this.id_ruta_documento, 1);

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        MetroMessageBox.Show(this, ex.Message, "ERROR");
                    }
                }
                Cursor = Cursors.Default;
                lblSubiendo.Text = "";


            }
        }





        private void GridDocs_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //// Si esta es una fila de encabezado o una fila nueva, no haga nada
            if (e.RowIndex < 0 || e.RowIndex == this.gridDocs.NewRowIndex)
                return;

            // Si formatea su columna deseada, establezca el valor
            // if (e.ColumnIndex = this.gridDocs.Columns["clean"].Index)
            //{
            //Puedes poner tu lógica dinámica aquí
            //y usa diferentes valores basados en otros valores de celda,
            //por ejemplo celda "clean"
            //Console.WriteLine("indicia fila: " + e.RowIndex);

            string valor = gridDocs.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (valor.Equals("1"))
            {
                btnFirmar.Text = "Firmar";
                btnFirmar.FlatStyle = FlatStyle.Flat;
                btnFirmar.DefaultCellStyle.ForeColor = Color.Blue;
                btnFirmar.DefaultCellStyle.BackColor = Color.Red;
            }
            else if (valor.Equals("2"))
            {
                btnFirmar.Text = "Enviar";
                btnFirmar.FlatStyle = FlatStyle.Flat;
                btnFirmar.DefaultCellStyle.ForeColor = Color.Blue;
                btnFirmar.DefaultCellStyle.BackColor = Color.FromArgb(255, 163, 68);
            }
            else if (valor.Equals("3"))
            {
                btnFirmar.Text = "Enviado y Firmado";
                btnFirmar.FlatStyle = FlatStyle.Flat;
                btnFirmar.DefaultCellStyle.ForeColor = Color.Blue;
                btnFirmar.DefaultCellStyle.BackColor = Color.FromArgb(36, 236, 36);
            }
        }
    }
}
