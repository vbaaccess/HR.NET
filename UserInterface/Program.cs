using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.DataAccessLayer;
using SystemHR.UserInterface.Forms;

namespace UserInterface
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConnectionType appConfigConnectionTypeKey = GlobalConfig.AppConfigConnectionTypeKey;
            GlobalConfig.InitializeConnection(appConfigConnectionTypeKey);

            Application.Run(new MainForm());
        }
    }
}
