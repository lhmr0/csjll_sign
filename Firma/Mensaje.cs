using MetroFramework.Forms;
using System;

namespace Firma_Digital
{
    public partial class Mensaje : MetroForm
    {
        public Mensaje()
        {
            InitializeComponent();
        }

        private void MetroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            Globales.destinatario = txtDestinatario.Text;
            Globales.asunto = txtAsunto.Text;
            Globales.mensaje = txtMensaje.Text;
            this.Hide();
        }
    }
}
