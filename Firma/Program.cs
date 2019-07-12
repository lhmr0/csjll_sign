using Firma_Digital;
using System;
using System.Windows.Forms;

namespace Firma_Digital
{
    static class Globales
    {
        public static string connectionString;
        public static int id_empleado;
    }


    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Globales.connectionString = @"datasource = 172.41.158.33; port = 3306; username = ldfirmas; password = 123456; database = ldfirmas; ";


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}