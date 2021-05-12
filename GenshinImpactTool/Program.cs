using System;
using System.Windows.Forms;

namespace GenshinImpactTool
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.SetData("APP_CONFIG_FILE", System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)+"/genshintool.config");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            
        }
    }
}
