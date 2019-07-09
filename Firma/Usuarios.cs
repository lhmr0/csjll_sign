using MetroFramework.Forms;
using System;

namespace Firma_Digital
{
    public partial class Usuarios : MetroForm
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            Form2 fAdm = new Form2();
            fAdm.ShowDialog();
        }

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            Form2 fAdm = new Form2();
            fAdm.ShowDialog();
        }
    }
}
