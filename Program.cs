using System;
using System.Threading;
using System.Windows.Forms;

namespace Worms2_Settings
{
    internal static class Program
    {
        private static Mutex mutex = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            const string appName = "Worms 2 Settings";
            bool createdNew;

            mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew) {
                //app is already running! Exiting the application
                return;
            }

            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
