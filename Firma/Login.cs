using MetroFramework;
using MetroFramework.Forms;
using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using iTextSharpSign;



namespace Firma_Digital
{
    public partial class Login : MetroForm
    {
        MySqlConnection con = new MySqlConnection(Globales.connectionString);

        public Login()
        {
            InitializeComponent();

        }

        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                BtnLogin_Click(this, new EventArgs());
            }
        }

        private void MetroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            //string pass = CalculateMD5Hash(txtPassword.Text);
            try
            {            
            con.Open();
            MySqlCommand cmd = new MySqlCommand(@"SELECT u.id_usuario,u.ulogin, e.id_empleado,p.id_persona, p.nombres, p.apellido_paterno,p.apellido_materno FROM usuario u 
                                                  inner join empleado e on e.id_empleado = u.id_empleado
                                                  inner join persona p on p.id_persona = e.id_persona 
                                                  WHERE ulogin='" + txtUsuario.Text + "'AND clave=md5('" + txtPassword.Text + "')", con);


            MySqlDataReader leer = cmd.ExecuteReader();

            if (leer.Read())
            {
                string estado = leer[3].ToString();
                if (estado == "1")
                {
                        Globales.id_empleado= leer.GetInt32(2);
                        /*string[] row = new string[7];
                        row[0] = leer.GetString(0);
                        row[1] = leer.GetString(1);
                        row[2] = leer.GetString(2);
                        row[3] = leer.GetString(3);
                        row[4] = leer.GetString(4);
                        row[5] = leer.GetString(5);
                        row[6] = leer.GetString(6);

                        Console.WriteLine("sesion: ");
                        Console.WriteLine(row);*/


                        this.Hide();
                    Form1 f2 = new Form1();
                    f2.Show();
                }
                else
                {
                    MetroMessageBox.Show(this, "USUARIO DESACTIVADO, CONTACTE CON SOPORTE", "ERROR");
                }


            }
            else
                MetroMessageBox.Show(this, "Usuario o clave incorrectos, intente nuevamente", "ERROR");

            con.Close();
            }
            catch(Exception ex) 
            {
                MetroMessageBox.Show(this, ex.Message, "ERROR");
            }




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
        private void MetroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {


        }
        public void RemoveText(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Ingrese usuario")
            {
                txtUsuario.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                txtUsuario.Text = "Ingrese usuario";
        }

        private void TxtPassword_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {

        }

        private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnLogin_Click(this, new EventArgs());
            }
        }
    }
}
