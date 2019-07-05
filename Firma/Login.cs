using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;

namespace Firma_Digital
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void MetroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void MetroLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            //MetroMessageBox.Show(this, "Usuario o clave incorrectos, intente nuevamente","Incorrecto");
            if (txtUsuario.Text == "" || txtPassword.Text == "")
            {
                MetroMessageBox.Show(this, "Complete los campos", "Error");
            }
            else if (txtUsuario.Text == "admin" && txtPassword.Text == "admin")
            {
                Usuarios fAdm = new Usuarios();
                fAdm.ShowDialog();
            }
            else
            {
                Form1 f2 = new Form1();
                //string pass = CalculateMD5Hash(txtPassword.Text);
                //txtPassword.Text = pass;
                f2.ShowDialog();
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
    }
}
