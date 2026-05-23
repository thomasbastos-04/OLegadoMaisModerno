using System;
using System.Windows.Forms;
using OLegadoMaisModerno.WinForms.Forms;

namespace OLegadoMaisModerno.WinForms
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrincipal());
        }
    }
}