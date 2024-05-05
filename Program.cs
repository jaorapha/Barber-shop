using System;
using System.Windows.Forms;

namespace interdisciplinar2
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzI1NDAxM0AzMjM1MmUzMDJlMzBFOUFHMmloSEhBNHU0SzFRQjVUdmZLUjdXd3lrVFNldFp4d2xOY1FMU0VNPQ==");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
        }
    }
}