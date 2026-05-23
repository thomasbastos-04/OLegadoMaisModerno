using OLegadoMaisModerno.WinForms.Forms;
using System;

namespace OLegadoMaisModerno.WinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmPrincipal());
        }
    }
}