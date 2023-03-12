using System; //Fundamental namespace in the .NET Framework, data types, and input/output operations
using System.Collections.Generic; // classes and interfaces which use to manipulate methods
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms; //namespace provides classes for working with Windows Forms 

namespace RemoteWatch
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new F2_MainWindow());
        }

        private static void ShowingAppIconInSystemTray()
        {
            NotifyIcon remoteWatchNotifyIcon = new NotifyIcon();
            remoteWatchNotifyIcon.Visible = true;


            remoteWatchNotifyIcon.Icon = SystemIcons.Application;
           
        }
    }
}
