
using ReyfiBurguer.UI;
using ReyfiBurguer.UI.Consultas;
using ReyfiBurguer.UI.Registros;
using System;
using System.Windows.Forms;

namespace ReyfiBurguer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InisioSesion());
        }
    }
}
