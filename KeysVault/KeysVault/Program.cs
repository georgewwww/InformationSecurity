using KeysVault.Forms;
using System;
using System.Windows.Forms;

namespace KeysVault
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

            //setting DatabaseConnectionString from app.config file.
            Globals.DatabaseConnection.Instance().SetValue(Properties.Settings.Default["KeysVaultDBConnection"].ToString());

            Application.Run(new Dashboard());
        }
    }
}
