using IniParser;
using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static Worms2_Settings.Main;

namespace Worms2_Settings
{
    internal static class Program
    {
        private static Mutex mutex = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
         static void Main(string[] args)
        {
            const string appName = "Worms 2 Settings";
            bool createdNew;

            mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew) {
                //app is already running! Exiting the application
                return;
            }
            if (args.Length > 0 && args[0] == "/setrec") {
                int setWidth, setHeight, setWidthCavern, setHeightCavern;
                var screen = GetDisplayResolution();
                screenRes.width = screen.Width;
                screenRes.height = screen.Height;
                
                if (screenRes.height >= 1080) {
                    setHeight = 1080;
                    float numMultiplier = (float)screenRes.height / 1080f;
                    //Calculate width to match an upscaled height of 1080 (rounds down any decimals)
                    setWidth = (int)(screenRes.width / numMultiplier);
                }
                else {
                    setWidth = screenRes.width;
                    setHeight = screenRes.height;
                }
                if (screenRes.height >= 854) {
                    setHeightCavern = 854;
                    float numMultiplier = (float)screenRes.height / 854f;
                    //Calculate width to match an upscaled height of 854 (rounds down any decimals)
                    setWidthCavern = (int)(screenRes.width / numMultiplier);
                }
                else {
                    setWidthCavern = screenRes.width;
                    setHeightCavern = screenRes.height;
                }

                //Create files
                Encoding UTF8withoutBOM = new UTF8Encoding(false);
                var parser = new FileIniDataParser();
                data.Res = parser.ReadFile(ini.Res);
                data.Res["Resolution"]["ScreenWidth"] = setWidth.ToString();
                data.Res["Resolution"]["ScreenHeight"] = setHeight.ToString();
                data.Res["Resolution"]["CavernScreenWidth"] = setWidthCavern.ToString();
                data.Res["Resolution"]["CavernScreenHeight"] = setHeightCavern.ToString();
                parser.WriteFile(ini.Res, data.Res, UTF8withoutBOM);
                return;
            }

            //Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
