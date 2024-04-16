using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;

namespace Worms2_Settings
{
    public partial class Main : Form{
        //Unique App Identifier
        static Mutex mutex = new Mutex(true, "Worms 2 Plus Settings");
        public Main(){
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                mutex.ReleaseMutex();
                InitializeComponent();
            }
            else
            {
                Close();
            }
        }

        public static class global{
            public static bool ready = false;
        }
        public static class screenRes
        {
            public static int width, height;
        }
        public static class dll{
            public static string Res = "wkReSolution.dll";
            public static string Wnd = "wkWndMode.dll";
            public static string Wnd2 = "wndmode.dll";
            public static string CNC = "ddraw.dll";
        }
        public static class ini{
            public static string Res = "ReSolution.ini";
            public static string Wnd = "wndmode.ini";
            public static string CNC = "ddraw.ini";
        }
        public static class data{
            public static IniData Res,Wnd,CNC;
        }

        #region DisplayResolution
        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int GetDeviceCaps(IntPtr hDC, int nIndex);

        public enum DeviceCap
        {
            VERTRES = 10,
            DESKTOPVERTRES = 117
        }

        public static double GetWindowsScreenScalingFactor(bool percentage = true)
        {
            //Create Graphics object from the current windows handle
            Graphics GraphicsObject = Graphics.FromHwnd(IntPtr.Zero);
            //Get Handle to the device context associated with this Graphics object
            IntPtr DeviceContextHandle = GraphicsObject.GetHdc();
            //Call GetDeviceCaps with the Handle to retrieve the Screen Height
            int LogicalScreenHeight = GetDeviceCaps(DeviceContextHandle, (int)DeviceCap.VERTRES);
            int PhysicalScreenHeight = GetDeviceCaps(DeviceContextHandle, (int)DeviceCap.DESKTOPVERTRES);
            //Divide the Screen Heights to get the scaling factor and round it to two decimals
            double ScreenScalingFactor = Math.Round(PhysicalScreenHeight / (double)LogicalScreenHeight, 2);
            //If requested as percentage - convert it
            if (percentage) {
                ScreenScalingFactor *= 100.0;
            }
            //Release the Handle and Dispose of the GraphicsObject object
            GraphicsObject.ReleaseHdc(DeviceContextHandle);
            GraphicsObject.Dispose();
            //Return the Scaling Factor
            return ScreenScalingFactor;
        }

        public static Size GetDisplayResolution()
        {
            var sf = GetWindowsScreenScalingFactor(false);
            var screenWidth = Screen.PrimaryScreen.Bounds.Width * sf;
            var screenHeight = Screen.PrimaryScreen.Bounds.Height * sf;
            return new Size((int)screenWidth, (int)screenHeight);
        }

        #endregion

        private void showError(string error, bool disableControls, bool showAudio){
            if (disableControls) {
                foreach (Control c in tblDesign.Controls) {
                    c.Enabled = false;
                }
                if (showAudio) {
                    lblHeadingAudio.Enabled = true;
                    lblApplications.Enabled = true;
                    flwAudio.Enabled = true;
                }
            }
            lblError.Enabled = true;
            lblError.Visible = true;
            lblError.Text = error;
        }

        private void hideError(){
            foreach (Control c in tblDesign.Controls) {
                c.Enabled = true;
            }
            lblError.Visible = false;
            lblError.Text = "";
        }

        private void processCheck() {
            Process[] ProcessW2 = Process.GetProcessesByName("worms2");
            if (ProcessW2.Length > 0) {
                if (!lblError.Visible) {
                    showError("Display settings can not be changed while the game is running.", true, true);
                }
            }
            else {
                if (lblError.Visible) {
                    hideError();
                }
            }
        }

        private void Main_Load(object sender, EventArgs e){
            //Fix flickering
            typeof(Panel).InvokeMember("DoubleBuffered",
            BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            null, tblDesign, new object[] { true });

            //Check Language
            string langIni = "language.ini";
            string[] langArr = { "de", "en", "es", "es-419", "fr", "it", "nl", "pl", "pt", "pt-br", "ru", "sv" };
            string langVal;
            if (File.Exists(langIni)) {
                langVal = File.ReadAllText(langIni).Trim();
                if (!Array.Exists(langArr, element => element == langVal)) {
                    langVal = "en";
                }
            }
            else {
                langVal = "en";
            }
            
            //Translation variables
            string strSettings, strDisplay, strResolution, strRecommended, strWidth, strHeight, strMode, strZoom, strMouseSW, strKeyboard, strTouchscreen, strSave, strAudio, strApplications, strVolume, strSoundbank;
            strSoundbank = "Sound Bank";
            switch (langVal) {
                case "de":
                    strSettings = "Einstellungen";
                    strDisplay = "Bildschirm";
                    strResolution = "Auflösung";
                    strRecommended = "Empfohlen";
                    strWidth = "Breite";
                    strHeight = "Höhe";
                    strMode = "Betriebsart";
                    strZoom = "Zoomen";
                    strMouseSW = "Mäusen mit Drehrad";
                    strKeyboard = "Tastatur";
                    strTouchscreen = "Berührungsbildschirm";
                    strSave = "Speichern";
                    strAudio = "Audio";
                    strApplications = "Anwendung";
                    strVolume = "Lautstärke";
                    break;
                case "es":
                case "es-419":
                    strSettings = "Ajustes";
                    strDisplay = "Pantalla";
                    strResolution = "Resolución";
                    strRecommended = "Usar parámetros recomendados";
                    strWidth = "Anchura";
                    strHeight = "Altura";
                    strMode = "Modo";
                    strZoom = "Zoom";
                    strMouseSW = "Rueda de desplazamiento";
                    strKeyboard = "Teclado ";
                    strTouchscreen = "Pantalla Táctil";
                    strSave = "Guardar Cambios";
                    strAudio = "Sonido";
                    strApplications = "Aplicación";
                    strVolume = "Volumen";
                    strSoundbank = "Editor de Sonido";
                    break;
                //https://es.wikipedia.org/wiki/Resoluci%C3%B3n_de_pantalla
                default:
                    strSettings = "Settings";
                    strDisplay = "Display";
                    strResolution = "Resolution";
                    strRecommended = "Use recommended";
                    strWidth = "Width";
                    strHeight = "Height";
                    strMode = "Mode";
                    strZoom = "Zoom";
                    strMouseSW = "Mouse scroll wheel";
                    strKeyboard = "Keyboard";
                    strTouchscreen = "Touchscreen";
                    strSave = "Save Changes";
                    strAudio = "Audio";
                    strApplications = "Applications";
                    strVolume = "Volume Settings";
                    strSoundbank = "Sound Bank Editor";
                    break;
            }

            //Apply language to controls
            this.Text = strSettings;
            lblHeadingDisplay.Text = strDisplay;
            lblResolution.Text = strResolution;
            cbRecommended.Text = strRecommended;
            lblWidth.Text = strWidth;
            lblHeight.Text = strHeight;
            lblMode.Text = strMode;
            lblZoom.Text = strZoom;
            cbZoomMouse.Text = strMouseSW;
            cbZoomKeyboard.Text = strKeyboard;
            cbZoomTouch.Text = strTouchscreen;
            btnSave.Text = strSave;
            lblHeadingAudio.Text = strAudio;
            lblApplications.Text = strApplications;
            btnVolume.Text = strVolume;
            btnSoundbank.Text = strSoundbank;

            populate(true);
            if (!global.ready) {
                populate(false);
            }
        }

        private int iniInt(string input)
        {
            try {
                var result = Int32.Parse(input);
                return result;
            }
            catch {
                return 0;
            }
        }

        private string iniStr(string input, string failString="false")
        {
            try {
                var result = input;
                return result;
            }
            catch {
                return failString;
            }
        }



        private void populate(bool firstAttempt)
        {
            //Define Errors that may not be translated
            string errFilesMissing = "Error: files missing, please reinstall Worms 2 Plus.";

            //Populate current settings
            //Renderer
            string Renderer = "";
            if (File.Exists(dll.Res) && File.Exists(ini.Res)) { //Check for ReSolution, required by both renderers
                if (File.Exists(dll.Wnd) && File.Exists(dll.CNC)) { //Check for conflict with both being enabled

                    File.Move(dll.CNC, "_" + dll.CNC);
                    if (firstAttempt) {
                        return;
                    }
                    else {
                        //Renderer = "";
                    }
                }
                else if (File.Exists(dll.Wnd) && File.Exists(dll.Wnd2) && File.Exists(ini.Wnd)) { //Check for all WndMode files
                    rbRenderWnd.Checked = true;
                    Renderer = "WndMode";
                }
                else if (File.Exists(dll.CNC) && File.Exists(ini.CNC)) { //Check for all cnc-ddraw files
                    rbRenderCNC.Checked = true;
                    Renderer = "cnc-ddraw";
                }
            }
            if (Renderer == "") { //Show error if a renderer could not be established
                showError(errFilesMissing, true, false);
            }
            else {
                //Get Resolutions
                var screen = GetDisplayResolution();
                screenRes.width = screen.Width;
                screenRes.height = screen.Height;

                //Parse INI data
                var parser = new FileIniDataParser();
                IniParser.Model.Configuration.IniParserConfiguration config = parser.Parser.Configuration;
                config.CommentString = ";";
                config.SkipInvalidLines = true;
                config.AllowDuplicateKeys = true;
                config.AllowDuplicateSections = true;
                data.Res = parser.ReadFile(ini.Res);
                data.Wnd = parser.ReadFile(ini.Wnd);
                data.CNC = parser.ReadFile(ini.CNC);

                //Get current values
                int settingWidth = iniInt(data.Res["Resolution"]["ScreenWidth"]);
                int settingHeight = iniInt(data.Res["Resolution"]["ScreenHeight"]);
                if (settingWidth == 0) {
                    settingWidth = screenRes.width;
                }
                if (settingHeight == 0) {
                    settingHeight = screenRes.height;
                }
                txtWidth.Text = settingWidth.ToString();
                txtHeight.Text = settingHeight.ToString();

                if (Renderer == "WndMode") {
                    rbRenderWnd.Checked = true;
                    rbDisplayFullscreen.Enabled = false;
                    if (settingWidth == screenRes.width && settingHeight == screenRes.height) {
                        cbRecommended.Checked = true;
                        rbDisplayBorderless.Checked = true;
                    }
                    int settingVsync = iniInt(data.Wnd["WINDOWMODE"]["VerticalSync"]);
                    int settingBorder = iniInt(data.Wnd["WINDOWMODE"]["Border"]);
                    if (settingVsync == 1) {
                        cbVsync.Checked = true;
                    }
                    if (settingBorder == 1 && !rbDisplayBorderless.Checked) {
                        rbDisplayWindowed.Checked = true;
                    }
                    int settingZoomEnable = iniInt(data.Res["Zooming"]["Enable"]);
                    if (settingZoomEnable == 1) {
                        int settingZoomMouse = iniInt(data.Res["Zooming"]["UseMouseWheel"]);
                        int settingZoomKeyboard = iniInt(data.Res["Zooming"]["UseKeyboardZoom"]);
                        int settingZoomTouch = iniInt(data.Res["Zooming"]["UseTouchscreenZoom"]);
                        if (settingZoomMouse == 1) { cbZoomMouse.Checked = true; }
                        if (settingZoomKeyboard == 1) { cbZoomKeyboard.Checked = true; }
                        if (settingZoomTouch == 1) { cbZoomTouch.Checked = true; }
                    }
                }
                else if (Renderer == "cnc-ddraw") {
                    rbRenderCNC.Checked = true;
                    if (settingWidth == 1920 && settingHeight == 1080) {
                        cbRecommended.Checked = true;
                    }
                    string settingFullscreen = iniStr(data.CNC["ddraw"]["fullscreen"]);
                    string settingWindowed = iniStr(data.CNC["ddraw"]["windowed"]);
                    string settingVsync = iniStr(data.CNC["ddraw"]["vsync"]);
                    if (settingFullscreen == "true") {
                        if (settingWindowed == "true") {
                            rbDisplayBorderless.Checked = true;
                        }
                        else {
                            rbDisplayFullscreen.Checked = true;
                        }
                    }
                    else {
                        rbDisplayWindowed.Checked = true;
                    }
                    if (settingVsync == "true") {
                        cbVsync.Checked = true;
                    }
                    lblZoom.Enabled = false;
                    flwZoom.Enabled = false;
                }
                processCheck();
                this.ActiveControl = lblHeadingDisplay;
                global.ready = true;
                timerProcess.Enabled = true;
            }
        }
        private void rbRenderWnd_CheckedChanged(object sender, EventArgs e){
            if (global.ready && rbRenderWnd.Checked){
                if (cbRecommended.Checked) {
                    cbRecommended.Checked = false;
                    cbRecommended.Checked = true;
                }
                if (rbDisplayFullscreen.Enabled) {
                    rbDisplayFullscreen.Checked = false;
                    rbDisplayWindowed.Checked = true;
                }
                rbDisplayFullscreen.Enabled = false;
                lblZoom.Enabled = true;
                flwZoom.Enabled = true;
            }
        }

        private void rbRenderCNC_CheckedChanged(object sender, EventArgs e)
        {
            if (global.ready && rbRenderCNC.Checked) {
                if (cbRecommended.Checked) {
                    cbRecommended.Checked = false;
                    cbRecommended.Checked = true;
                }
                else if (txtWidth.Text == "1920" && txtHeight.Text == "1080") {
                    cbRecommended.Checked = true;
                }
                rbDisplayFullscreen.Enabled = true;
                lblZoom.Enabled = false;
                flwZoom.Enabled = false;
                cbZoomMouse.Checked = false;
                cbZoomKeyboard.Checked = false;
                cbZoomTouch.Checked = false;
            }
        }

        private void cbRecommended_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRecommended.Checked) {
                if (rbRenderCNC.Checked) {
                    txtWidth.Text = "1920";
                    txtHeight.Text = "1080";
                }
                else {
                    txtWidth.Text = screenRes.width.ToString();
                    txtHeight.Text = screenRes.height.ToString();
                }
                txtWidth.Enabled = false;
                txtHeight.Enabled = false;
            }
            else {
                txtWidth.Enabled = true;
                txtHeight.Enabled = true;
            }
        }

        private void timerProcess_Tick(object sender, EventArgs e)
        {
            processCheck();
        }
        private void btnVolume_Click(object sender, EventArgs e)
        {
            Process.Start("volume.exe");
        }
        private void btnSoundbank_Click(object sender, EventArgs e)
        {
            Process.Start("Data\\Wav\\BankEditor.exe");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                var parser = new FileIniDataParser();
                //ReSolution.ini
                //[Resolution]
                data.Res["Resolution"]["ScreenWidth"] = txtWidth.Text;
                data.Res["Resolution"]["ScreenHeight"] = txtHeight.Text;
                if (rbRenderWnd.Checked) {
                    //[Resizing]
                    data.Res["Resizing"]["Enable"] = "1";
                    data.Res["Resizing"]["ProgressiveUpdate"] = "1";
                    data.Res["Resizing"]["AltEnter"] = "1";
                    //[Zooming]
                    if (!cbZoomMouse.Checked && !cbZoomKeyboard.Checked && !cbZoomTouch.Checked) {
                        data.Res["Zooming"]["Enable"] = "0";
                    }
                    else {
                        data.Res["Zooming"]["Enable"] = "1";
                        if (cbZoomMouse.Checked) {
                            data.Res["Zooming"]["UseMouseWheel"] = "1";
                        }
                        else {
                            data.Res["Zooming"]["UseMouseWheel"] = "0";
                        }
                        if (cbZoomKeyboard.Checked) {
                            data.Res["Zooming"]["UseKeyboardZoom"] = "1";
                        }
                        else {
                            data.Res["Zooming"]["UseKeyboardZoom"] = "0";
                        }
                        if (cbZoomTouch.Checked) {
                            data.Res["Zooming"]["UseTouchscreenZoom"] = "1";
                        }
                        else {
                            data.Res["Zooming"]["UseTouchscreenZoom"] = "0";
                        }
                    }
                    if (File.Exists(dll.CNC)) {
                        File.Move(dll.CNC, "_" + dll.CNC);
                    }
                    if (File.Exists("_" + dll.Wnd)) {
                        File.Move("_" + dll.Wnd, dll.Wnd);
                    }
                    //wndmode.ini
                    if (rbDisplayBorderless.Checked) {
                        data.Wnd["WINDOWMODE"]["Border"] = "0";
                    }
                    else {
                        data.Wnd["WINDOWMODE"]["Border"] = "1";
                    }
                    if (cbVsync.Checked) {
                        data.Wnd["WINDOWMODE"]["VerticalSync"] = "1";
                    }
                    else {
                        data.Wnd["WINDOWMODE"]["VerticalSync"] = "0";
                    }
                    parser.WriteFile(ini.Wnd, data.Wnd);
                }
                else if (rbRenderCNC.Checked) {
                    //[Resizing]
                    data.Res["Resizing"]["Enable"] = "0";
                    //[Zooming]
                    data.Res["Zooming"]["Enable"] = "0";
                    if (File.Exists(dll.Wnd)) {
                        File.Move(dll.Wnd, "_" + dll.Wnd);
                    }
                    if (File.Exists("_" + dll.CNC)) {
                        File.Move("_" + dll.CNC, dll.CNC);
                    }
                    //ddraw.ini
                    if (rbDisplayWindowed.Checked) {
                        data.CNC["ddraw"]["fullscreen"] = "false";
                        data.CNC["ddraw"]["windowed"] = "true";
                    }
                    else if (rbDisplayFullscreen.Checked) {
                        data.CNC["ddraw"]["fullscreen"] = "true";
                        data.CNC["ddraw"]["windowed"] = "false";
                    }
                    else if (rbDisplayBorderless.Checked) {
                        data.CNC["ddraw"]["fullscreen"] = "true";
                        data.CNC["ddraw"]["windowed"] = "true";
                    }
                    if (cbVsync.Checked) {
                        data.CNC["ddraw"]["vsync"] = "true";
                    }
                    else {
                        data.CNC["ddraw"]["vsync"] = "false";
                    }
                    parser.WriteFile(ini.CNC, data.CNC);
                }
                parser.WriteFile(ini.Res, data.Res);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message,"Error");
            }
        }
    }
}
