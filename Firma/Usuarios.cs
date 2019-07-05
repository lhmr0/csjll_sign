using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
