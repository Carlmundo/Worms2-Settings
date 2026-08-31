using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using IniParser;
using IniParser.Model;

namespace Worms2_Settings
{
    public partial class Main : Form{

        public Main(){
            InitializeComponent();
        }

        public static class global{
            //Renderer
            //Ready var
            public static string Renderer = "";
            public static bool ready = false;
            //Set sound effects
            public static System.Media.SoundPlayer sndOption = new System.Media.SoundPlayer(@"Data\\Wav\\Effects\\CrossImpact.wav");
            public static System.Media.SoundPlayer sndSave = new System.Media.SoundPlayer(@"Data\\Wav\\Speech\\yessir.wav");
        }
        public static class screenRes
        {
            public static int width, height;
        }
        public static class dll{
            public static string Res = "wkReSolution.dll";
            public static string CNC = "ddraw.dll";
            public static string EO = "wkExtendedOptions.dll";
        }
        public static class ini{
            public static string Res = "ReSolution.ini";
            public static string CNC = "ddraw.ini";
            public static string EO = "ExtendedOptions.ini";
        }
        public static class data{
            public static IniData Res,CNC,EO;
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
            string langFile = "language.txt";
            string[] langArr = { "cs", "de", "en", "es", "es-419", "fr", "it", "nl", "pl", "pt", "pt-br", "ru", "sv", "zh-Hans" };
            string langVal;
            if (File.Exists(langFile)) {
                langVal = File.ReadAllText(langFile).Trim();
                if (!Array.Exists(langArr, element => element == langVal)) {
                    langVal = "en";
                }
            }
            else {
                langVal = "en";
            }
            
            //Translation variables
            string strSettings, strDisplay, strResolution, strRecommended, strOpen, strCavern, strWidth, strHeight, strMode, strModeWindowed, strModeFullscreen, strModeBorderless, strShader, strShaderSmooth, strShaderClassic, strVsync, strZoom, strMouseSW, strKeyboard, strTouchscreen, strSave, strAudio, strApplications, strVolume, strSoundbank, strGame, strExtendedChat, strBackflip, strBlood;
            strVsync = "V-Sync";
            strShader = "Shader";
            strSoundbank = "SoundBank";
            switch (langVal) {
                case "cs":
                    //Credit: JPEXS
                    strSettings = "Nastavení";
                    strDisplay = "Zobrazení";
                    strResolution = "Rozlišení";
                    strRecommended = "Použít doporučené";
                    strOpen = "Otevřený";
                    strCavern = "Jeskyně";
                    strWidth = "Šířka";
                    strHeight = "Výška";
                    strMode = "Režim";
                    strModeWindowed = "V okně";
                    strModeFullscreen = "Celá obrazovka";
                    strModeBorderless = "Bez rámečku";
                    strShaderSmooth = "Vyhlazený";
                    strShaderClassic = "Klasický";
                    strZoom = "Přiblížení";
                    strMouseSW = "Skrolováním kolečkem myši";
                    strKeyboard = "Klávesnicí";
                    strTouchscreen = "Dotykem obrazovky";
                    strSave = "Uložit změny";
                    strAudio = "Audio";
                    strApplications = "Aplikace";
                    strVolume = "Nastavení hlasitosti";
                    strSoundbank = "Editor zvukové banky";
                    strGame = "Hra";
                    strExtendedChat = "Rozšířená editace chatovacího okna";
                    strBackflip = "Salto vzad";
                    strBlood = "Krev";
                    break;
                case "de":
                    strSettings = "Einstellungen";
                    strDisplay = "Bildschirm";
                    strResolution = "Auflösung";
                    strRecommended = "Empfohlen";
                    strOpen = "Offen";
                    strCavern = "Höhle";
                    strWidth = "Breite";
                    strHeight = "Höhe";
                    strMode = "Betriebsart";
                    strModeWindowed = "Fenstermodus";
                    strModeFullscreen = "Vollbild";
                    strModeBorderless = "Fenster ohne Rand";
                    strShaderSmooth = "Geglättet";
                    strShaderClassic = "Klassisch";
                    strVsync = "Bildschirmsynchronisation";
                    strZoom = "Zoomen";
                    strMouseSW = "Mäusen mit Drehrad";
                    strKeyboard = "Tastatur";
                    strTouchscreen = "Berührungsbildschirm";
                    strSave = "Speichern";
                    strAudio = "Audio";
                    strApplications = "Anwendungen";
                    strVolume = "Lautstärke";
                    strSoundbank = "Stimmenbank";
                    strGame = "Spiel";
                    strExtendedChat = "Erweiterten Chat-Bereich bearbeiten";
                    strBackflip = "Backflip";
                    strBlood = "Blut";
                    break;
                case "es":
                    strSettings = "Configuraciones";
                    strDisplay = "Pantalla";
                    strResolution = "Resolución";
                    strRecommended = "Usar parámetros recomendados";
                    strOpen = "Abrir";
                    strCavern = "Cueva";
                    strWidth = "Anchura";
                    strHeight = "Altura";
                    strMode = "Modo";
                    strModeWindowed = "Ventana";
                    strModeFullscreen = "Pantalla completa";
                    strModeBorderless = "Ventana sin bordes";
                    strShaderSmooth = "Suavizado";
                    strShaderClassic = "Clásico";
                    strZoom = "Zoom";
                    strMouseSW = "Rueda de desplazamiento";
                    strKeyboard = "Teclado";
                    strTouchscreen = "Pantalla Táctil";
                    strSave = "Guardar Cambios";
                    strAudio = "Sonido";
                    strApplications = "Aplicaciones";
                    strVolume = "Volumen";
                    strSoundbank = "Banco de voces";
                    strGame = "Juego";
                    strExtendedChat = "Edición extendida chat box";
                    strBackflip = "Salto mortal hacia atrás";
                    strBlood = "Sangre";
                    break;
                case "es-419":
                    strSettings = "Ajustes";
                    strDisplay = "Pantalla";
                    strResolution = "Resolución";
                    strRecommended = "Usar parámetros recomendados";
                    strOpen = "Al aire libre";
                    strCavern = "Caverna";
                    strWidth = "Anchura";
                    strHeight = "Altura";
                    strMode = "Modo";
                    strModeWindowed = "Ventana";
                    strModeFullscreen = "Pantalla completa";
                    strModeBorderless = "Ventana sin bordes";
                    strShaderSmooth = "Suavizado";
                    strShaderClassic = "Clásico";
                    strZoom = "Zoom";
                    strMouseSW = "Rueda de desplazamiento";
                    strKeyboard = "Teclado";
                    strTouchscreen = "Pantalla Táctil";
                    strSave = "Guardar Cambios";
                    strAudio = "Sonido";
                    strApplications = "Aplicaciones";
                    strVolume = "Volumen";
                    strSoundbank = "Banco de voces";
                    strGame = "Juego";
                    strExtendedChat = "Edición ampliada del recuadro de charla";
                    strBackflip = "Salto mortal hacia atrás";
                    strBlood = "Sangre";
                    break;
                case "fr":
                    strSettings = "Paramètres";
                    strDisplay = "Écran";
                    strResolution = "Résolution";
                    strRecommended = "Recommander";
                    strOpen = "Ouvrir";
                    strCavern = "Souterrain";
                    strWidth = "Largeur";
                    strHeight = "Hauteur";
                    strMode = "Mode";
                    strModeWindowed = "Fenêtré";
                    strModeFullscreen = "Plein écran";
                    strModeBorderless = "Fenêtré sans bordure";
                    strShaderSmooth = "Lissé";
                    strShaderClassic = "Classique";
                    strZoom = "Zoom";
                    strMouseSW = "Molette de souris";
                    strKeyboard = "Clavier";
                    strTouchscreen = "Écran tactile";
                    strSave = "Sauvegarder les modifications";
                    strAudio = "Son";
                    strApplications = "Applications";
                    strVolume = "Volume";
                    strSoundbank = "Banque de sons";
                    strGame = "Jeu";
                    strExtendedChat = "Édition des boîtes de conversation";
                    strBackflip = "Salto arrière";
                    strBlood = "Sang";
                    break;
                case "it":
                    strSettings = "Impostazioni";
                    strDisplay = "Schermo";
                    strResolution = "Risoluzione";
                    strRecommended = "Consigliato";
                    strOpen = "Apri";
                    strCavern = "Caverna";
                    strWidth = "Larghezza";
                    strHeight = "Height";
                    strMode = "Modalità";
                    strModeWindowed = "A finestra";
                    strModeFullscreen = "Schermo intero";
                    strModeBorderless = "Borderless";
                    strShaderSmooth = "Smussato";
                    strShaderClassic = "Classico";
                    strZoom = "Zoom";
                    strMouseSW = "Rotella scorrimento mouse";
                    strKeyboard = "Tastiera";
                    strTouchscreen = "Touch screen";
                    strSave = "Salva";
                    strAudio = "Audio";
                    strApplications = "Applicazioni";
                    strVolume = "Volume";
                    strSoundbank = "Banca di voci";
                    strGame = "Gioco";
                    strExtendedChat = "Ingrandisci finestra conversazione";
                    strBackflip = "Salto mortale all'indietro";
                    strBlood = "Sangue";
                    break;
                case "nl":
                    strSettings = "Instellingen";
                    strDisplay = "Scherm";
                    strResolution = "Resolutie";
                    strRecommended = "Aanbevolen";
                    strOpen = "Open";
                    strCavern = "Grot";
                    strWidth = "Breedte";
                    strHeight = "Hoogte";
                    strMode = "Modus";
                    strModeWindowed = "Venster";
                    strModeFullscreen = "Volledig scherm";
                    strModeBorderless = "Randloos volledig scherm";
                    strShaderSmooth = "Vloeiend";
                    strShaderClassic = "Klassiek";
                    strZoom = "Zoom";
                    strMouseSW = "Scrollwieltje";
                    strKeyboard = "Toetsenbord";
                    strTouchscreen = "Aanraakscherm";
                    strSave = "Opslaan";
                    strAudio = "Geluid";
                    strApplications = "Applicaties";
                    strVolume = "Volume";
                    //strSoundbank = "SoundBank";
                    strGame = "Spel";
                    strExtendedChat = "Chat box editen";
                    strBackflip = "Achterwaartse salto";
                    strBlood = "Bloed";
                    break;
                case "pl":
                    //Credit: Dawid8
                    strSettings = "Ustawienia";
                    strDisplay = "Obraz";
                    strResolution = "Rozdzielczość";
                    strRecommended = "Użyj zalecane";
                    strOpen = "Otwarty";
                    strCavern = "Jaskinia";
                    strWidth = "Szerokość";
                    strHeight = "Wysokość";
                    strMode = "Tryb";
                    strModeWindowed = "Okno";
                    strModeFullscreen = "Pełny ekran";
                    strModeBorderless = "Pełny ekran bez obramowania";
                    strShaderSmooth = "Wygładzony";
                    strShaderClassic = "Klasyczny";
                    strZoom = "Przybliżenie";
                    strMouseSW = "Mouse scroll wheel";
                    strKeyboard = "Klawiatura";
                    strTouchscreen = "Ekran dotykowy";
                    strSave = "Zapisz";
                    strAudio = "Dźwiek";
                    strApplications = "Aplikacje";
                    strVolume = "Głośność";
                    strSoundbank = "Edytor SoundBanków";
                    strGame = "Gra";
                    strExtendedChat = "Rozszerzona edycja chatów";
                    strBackflip = "Salto w tył";
                    strBlood = "Krew";
                    break;
                case "pt":
                    //Credit: rubinho146
                    strSettings = "Opções";
                    strDisplay = "Ecrã";
                    strResolution = "Resolução";
                    strRecommended = "Utilizar recomendado";
                    strOpen = "Aberto";
                    strCavern = "Caverna";
                    strWidth = "Largura";
                    strHeight = "Altura";
                    strMode = "Modo";
                    strModeWindowed = "Janela";
                    strModeFullscreen = "Ecrã inteiro";
                    strModeBorderless = "Ecrã inteiro sem borda";
                    strShaderSmooth = "Suave";
                    strShaderClassic = "Clássico";
                    strZoom = "Zoom";
                    strMouseSW = "Roda do Rato";
                    strKeyboard = "Teclado";
                    strTouchscreen = "Ecrã tátil";
                    strSave = "Guardar";
                    strAudio = "Som";
                    strApplications = "Aplicações";
                    strVolume = "Volume";
                    strSoundbank = "Editor de Banco de Vozes";
                    strGame = "Jogo";
                    strExtendedChat = "Edição alargada da caixa de conversação";
                    strBackflip = "Mortal para trás";
                    strBlood = "Sangue";
                    break;
                case "pt-br":
                    //Credit: rubinho146
                    strSettings = "Opções";
                    strDisplay = "Tela";
                    strResolution = "Resolução";
                    strRecommended = "Usar recomendado";
                    strOpen = "Abrir";
                    strCavern = "Caverna";
                    strWidth = "Largura";
                    strHeight = "Altura";
                    strMode = "Modo";
                    strModeWindowed = "Janela";
                    strModeFullscreen = "Tela cheia";
                    strModeBorderless = "Tela cheia sem borda";
                    strShaderSmooth = "Suave";
                    strShaderClassic = "Clássico";
                    strZoom = "Zoom";
                    strMouseSW = "Roda do Mouse";
                    strKeyboard = "Teclado";
                    strTouchscreen = "Tela tátil";
                    strSave = "Salvar";
                    strAudio = "Som";
                    strApplications = "Aplicações";
                    strVolume = "Volume";
                    strSoundbank = "Editor de Banco de Vozes";
                    strGame = "Jogo";
                    strExtendedChat = "Edição de caixa de bate-papo estendida";
                    strBackflip = "Mortal para trás";
                    strBlood = "Sangue";
                    break;
                case "ru":
                    strSettings = "Настройки";
                    strDisplay = "Экран";
                    strResolution = "Разрешение экрана";
                    strRecommended = "сове́товать";
                    strOpen = "Открытый";
                    strCavern = "Пещера";
                    strWidth = "ширину";
                    strHeight = "высоту";
                    strMode = "режим";
                    strModeWindowed = "Оконный";
                    strModeFullscreen = "Во весь экран";
                    strModeBorderless = "оконный без рамки";
                    strShader = "Шейдер";
                    strShaderSmooth = "Сглаженный";
                    strShaderClassic = "Классический";
                    strVsync = "Вертикальная синхронизация";
                    strZoom = "давать крупный план";
                    strMouseSW = "колесом прокрутки";
                    strKeyboard = "Клавиатура";
                    strTouchscreen = "Сенсорный экран";
                    strSave = "Сохранить";
                    strAudio = "Звук";
                    strApplications = " программное обеспечение";
                    strVolume = "Громкость";
                    //strSoundbank = "SoundBank";
                    strGame = "Игра";
                    strExtendedChat = "Расширенные настройки окна чата";
                    strBackflip = "Сальто назад";
                    strBlood = "Кровь";
                    break;
                case "sv":
                    strSettings = "Inställningar";
                    strDisplay = "Skärm";
                    strResolution = "Upplösning";
                    strRecommended = "Rekommenderade";
                    strOpen = "Öppen";
                    strCavern = "Grotta";
                    strWidth = "Bredd";
                    strHeight = "Höjd";
                    strMode = "Läge";
                    strModeWindowed = "Fönster";
                    strModeFullscreen = "Fullskärm";
                    strModeBorderless = "Borderless";
                    strShaderSmooth = "Utjämnad";
                    strShaderClassic = "Klassisk";
                    strZoom = "Zoom";
                    strMouseSW = "Skrollhjul";
                    strKeyboard = "Tangentbord";
                    strTouchscreen = "Pekskärm";
                    strSave = "Spara";
                    strAudio = "Ljud";
                    strApplications = "Tillämpningsprogram";
                    strVolume = "Volym";
                    //strSoundbank = "SoundBank";
                    strGame = "Spel";
                    strExtendedChat = "Utökad chat box editering";
                    strBackflip = "Bakåtvolt";
                    strBlood = "Blod";
                    break;
                case "zh-Hans":
                    strSettings = "设置";
                    strDisplay = "显示";
                    strResolution = "分辨率";
                    strRecommended = "使用推荐设置";
                    strOpen = "打开";
                    strCavern = "洞穴";
                    strWidth = "宽度";
                    strHeight = "高度";
                    strMode = "模式";
                    strModeWindowed = "窗口化";
                    strModeFullscreen = "全屏";
                    strModeBorderless = "无边框";
                    strShader = "着色器";
                    strShaderSmooth = "平滑";
                    strShaderClassic = "经典";
                    strZoom = "缩放";
                    strMouseSW = "鼠标滚轮";
                    strKeyboard = "键盘";
                    strTouchscreen = "触摸屏";
                    strSave = "保存更改";
                    strAudio = "音频";
                    strApplications = "应用程序";
                    strVolume = "音量设置";
                    strSoundbank = "音效库编辑器";
                    strGame = "游戏";
                    strExtendedChat = "扩展聊天框编辑";
                    strBackflip = "后空翻";
                    strBlood = "血";
                    break;
                default:
                    strSettings = "Settings";
                    strDisplay = "Display";
                    strResolution = "Resolution";
                    strRecommended = "Use recommended";
                    strOpen = "Open";
                    strCavern = "Cavern";
                    strWidth = "Width";
                    strHeight = "Height";
                    strMode = "Mode";
                    strModeWindowed = "Windowed";
                    strModeFullscreen = "Fullscreen";
                    strModeBorderless = "Borderless";
                    strShader = "Shader";
                    strShaderSmooth = "Smooth";
                    strShaderClassic = "Original";
                    strZoom = "Zoom";
                    strMouseSW = "Mouse scroll wheel";
                    strKeyboard = "Keyboard";
                    strTouchscreen = "Touchscreen";
                    strSave = "Save Changes";
                    strAudio = "Audio";
                    strApplications = "Applications";
                    strVolume = "Volume Settings";
                    strSoundbank = "SoundBank Editor";
                    strGame = "Game";
                    strExtendedChat = "Extended chat box editing";
                    strBackflip = "Backflip";
                    strBlood = "Blood";
                    break;
            }

            //Apply language to controls
            this.Text = strSettings;
            lblHeadingDisplay.Text = strDisplay;
            lblResolution.Text = strResolution;
            cbRecommended.Text = strRecommended;
            lblResOpen.Text = strOpen;
            lblWidthOpen.Text = strWidth;
            lblHeightOpen.Text = strHeight;
            lblResCavern.Text = strCavern;
            lblWidthCavern.Text = strWidth;
            lblHeightCavern.Text = strHeight;
            lblMode.Text = strMode;
            rbDisplayWindowed.Text = strModeWindowed;
            rbDisplayFullscreen.Text = strModeFullscreen;
            rbDisplayBorderless.Text = strModeBorderless;
            lblShader.Text = strShader;
            rbShaderBC.Text = strShaderSmooth;
            rbShaderNN.Text = strShaderClassic;
            lblVsync.Text = strVsync;
            lblZoom.Text = strZoom;
            cbZoomMouse.Text = strMouseSW;
            cbZoomKeyboard.Text = strKeyboard;
            cbZoomTouch.Text = strTouchscreen;
            btnSave.Text = strSave;
            lblHeadingAudio.Text = strAudio;
            lblApplications.Text = strApplications;
            btnVolume.Text = strVolume;
            btnSoundbank.Text = strSoundbank;
            lblHeadingExtended.Text = strGame;
            cbExtChat.Text = strExtendedChat;
            cbExtBackflip.Text = strBackflip;
            cbExtBlood.Text = strBlood;

            //Populate
            populate();
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

        private void populate()
        {
            //Define Errors that may not be translated
            string errFilesMissing = "Error: files missing, please reinstall Worms 2 Plus.";

            //Populate current settings

            try {
                //Check for all required files
                if (File.Exists(dll.Res) && File.Exists(ini.Res) && File.Exists(dll.CNC) && File.Exists(ini.CNC)) {
                    global.Renderer = "cnc-ddraw";
                }
                if (global.Renderer == "") { //Show error if a renderer could not be established
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
                    txtWidthOpen.Text = settingWidth.ToString();
                    txtHeightOpen.Text = settingHeight.ToString();

                    if (global.Renderer == "cnc-ddraw") {
                        selectedCNC();

                        int settingWidthCavern = iniInt(data.Res["Resolution"]["CavernScreenWidth"]);
                        int settingHeightCavern = iniInt(data.Res["Resolution"]["CavernScreenHeight"]);
                        if (settingWidthCavern == 0) {
                            settingWidthCavern = settingWidth;
                        }
                        if (settingHeightCavern == 0) {
                            settingHeightCavern = settingHeight;
                        }
                        txtWidthCavern.Text = settingWidthCavern.ToString();
                        txtHeightCavern.Text = settingHeightCavern.ToString();

                        if (settingWidth == 1920 && settingHeight == 1080 && settingWidthCavern == 1518 && settingHeightCavern == 854) {
                            cbRecommended.Checked = true;
                        }
                        string settingFullscreen = iniStr(data.CNC["ddraw"]["fullscreen"]);
                        string settingWindowed = iniStr(data.CNC["ddraw"]["windowed"]);
                        string settingVsync = iniStr(data.CNC["ddraw"]["vsync"]);
                        string settingShader = iniStr(data.CNC["ddraw"]["shader"]);
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
                        if (settingShader == "Nearest neighbor") {
                            rbShaderNN.Checked = true;
                        }
                        else {
                            rbShaderBC.Checked = true;
                        }
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

                    if (!File.Exists(dll.EO)) {
                        lblHeadingExtended.Visible = false;
                        flwExtended.Visible = false;
                    }
                    else {
                        if (File.Exists(ini.EO)) {
                            data.EO = parser.ReadFile(ini.EO);
                            int settingExtendedChat = iniInt(data.EO["Settings"]["ExtendedChat"]);
                            int settingBackflip = iniInt(data.EO["Settings"]["Backflip"]);
                            int settingBlood = iniInt(data.EO["Settings"]["RedBlood"]);
                            if (settingExtendedChat == 1) { cbExtChat.Checked = true; }
                            if (settingBackflip == 1) { cbExtBackflip.Checked = true; }
                            if (settingBlood == 1) { cbExtBlood.Checked = true; }
                        }
                        else {
                            cbExtChat.Checked = true;
                            cbExtBackflip.Checked = true;
                            Encoding UTF8withoutBOM = new UTF8Encoding(false);
                            data.EO = new IniData();
                            data.EO["Settings"]["ExtendedChat"] = "1";
                            data.EO["Settings"]["Backflip"] = "1";
                            data.EO["Settings"]["RedBlood"] = "0";
                            parser.WriteFile(ini.EO, data.EO, UTF8withoutBOM);
                        }
                    }
                    processCheck();
                    this.ActiveControl = lblHeadingDisplay;
                    global.ready = true;
                    timerProcess.Enabled = true;
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        private void selectedCNC()
        {
            if (global.ready) {
                global.ready = false;
                if (cbRecommended.Checked) {
                    cbRecommended.Checked = false;
                    cbRecommended.Checked = true;
                }
                else if (txtWidthOpen.Text == "1920" && txtHeightOpen.Text == "1080" && txtWidthCavern.Text == "1518" && txtHeightCavern.Text == "854") {
                    cbRecommended.Checked = true;
                }
                else if (txtWidthCavern.Text == "" && txtHeightCavern.Text == "") {
                    //Prevent blank entries for cavern resolution after switching
                    string curWidthOpen = txtWidthOpen.Text;
                    string curHeightOpen = txtHeightOpen.Text;
                    cbRecommended.Checked = true;
                    txtWidthOpen.Text = curWidthOpen;
                    txtHeightOpen.Text = curHeightOpen;
                    cbRecommended.Checked = false;
                }
                rbShaderBC.Checked = true; //Default shader
                global.ready = true;
            }
        }

        private void cbRecommended_CheckedChanged(object sender, EventArgs e)
        {
            if (cbRecommended.Checked) {
                if (global.Renderer == "cnc-ddraw") {
                    if (screenRes.height >= 1080) {
                        txtHeightOpen.Text = "1080";
                        float numMultiplier = (float)screenRes.height / 1080f;
                        //Calculate width to match an upscaled height of 1080 (rounds down any decimals)
                        int intWidth = (int)(screenRes.width / numMultiplier);
                        txtWidthOpen.Text = intWidth.ToString();
                    }
                    else {
                        txtWidthOpen.Text = screenRes.width.ToString();
                        txtHeightOpen.Text = screenRes.height.ToString();
                    }
                    if (screenRes.height >= 854) {
                        float numMultiplier = (float)screenRes.height / 854f;
                        //Calculate width to match an upscaled height of 854 (rounds down any decimals)
                        int intWidth = (int)(screenRes.width / numMultiplier);
                        if (intWidth > 1916) { //Prevent width exceeding 1916
                            int intHeight = (int)(854f / intWidth * 1916f);
                            txtWidthCavern.Text = "1916";
                            txtHeightCavern.Text = intHeight.ToString();
                        }
                        else {
                            txtWidthCavern.Text = intWidth.ToString();
                            txtHeightCavern.Text = "854";
                        }
                    }
                    else {
                        txtWidthCavern.Text = screenRes.width.ToString();
                        txtHeightCavern.Text = screenRes.height.ToString();
                    }
                }
                else {
                    txtWidthOpen.Text = screenRes.width.ToString();
                    txtHeightOpen.Text = screenRes.height.ToString();
                }
                txtWidthOpen.Enabled = false;
                txtHeightOpen.Enabled = false;
                txtWidthCavern.Enabled = false;
                txtHeightCavern.Enabled = false;
                rbDisplayBorderless.Checked = true;
            }
            else {
                txtWidthOpen.Enabled = true;
                txtHeightOpen.Enabled = true;
                txtWidthCavern.Enabled = true;
                txtHeightCavern.Enabled = true;
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
            ProcessStartInfo _processStartInfo = new ProcessStartInfo();
            _processStartInfo.WorkingDirectory = Path.Combine(Environment.CurrentDirectory, "Data\\Wav");
            _processStartInfo.FileName = Path.Combine(Environment.CurrentDirectory, "Data\\Wav\\BankEditor.exe");
            Process myProcess = Process.Start(_processStartInfo);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {            
            try {
                //Write files as UTF-8 without BOM
                Encoding UTF8withoutBOM = new UTF8Encoding(false);

                //Clean up Resolution input
                removeLeadingZeroes(txtWidthOpen);
                removeLeadingZeroes(txtHeightOpen);
                txtWidthOpen.Text = txtWidthOpen.Text.Trim();
                txtHeightOpen.Text = txtHeightOpen.Text.Trim();

                //Use recommended resolution if either value is not a number
                if (!int.TryParse(txtWidthOpen.Text, out _) || !int.TryParse(txtHeightOpen.Text, out _)) {
                    global.ready = false;
                    cbRecommended.Checked = false;
                    cbRecommended.Checked = true;
                    global.ready = true;
                }

                if (flwResCavern.Visible) {
                    removeLeadingZeroes(txtWidthCavern);
                    removeLeadingZeroes(txtHeightCavern);
                    txtWidthCavern.Text = txtWidthCavern.Text.Trim();
                    txtHeightCavern.Text = txtHeightCavern.Text.Trim();
                    //Use recommended resolution if either value is not a number
                    if (!int.TryParse(txtWidthCavern.Text, out _) || !int.TryParse(txtHeightCavern.Text, out _)) {
                        global.ready = false;
                        cbRecommended.Checked = false;
                        cbRecommended.Checked = true;
                        global.ready = true;
                    }
                }

                string setCheckbox(bool value) => value ? "1" : "0";
                var parser = new FileIniDataParser();
                //ReSolution.ini
                //[Resolution]
                data.Res["Resolution"]["ScreenWidth"] = txtWidthOpen.Text;
                data.Res["Resolution"]["ScreenHeight"] = txtHeightOpen.Text;
                data.Res["Resolution"]["CavernScreenWidth"] = txtWidthCavern.Text;
                data.Res["Resolution"]["CavernScreenHeight"] = txtHeightCavern.Text;
                
                //[Resizing]
                data.Res["Resizing"]["ProgressiveUpdate"] = "0";

                if (global.Renderer == "cnc-ddraw") {
                    //[Resizing]
                    data.Res["Resizing"]["Enable"] = "0";
                    data.Res["Resizing"]["AltEnter"] = "0";

                    //ddraw.ini
                    if (rbDisplayWindowed.Checked) {
                        data.CNC["ddraw"]["fullscreen"] = "false";
                        data.CNC["ddraw"]["windowed"] = "true";
                        data.CNC["ddraw"]["toggle_borderless"] = "true";
                        data.CNC["ddraw"]["toggle_upscaled"] = "false";
                    }
                    else if (rbDisplayFullscreen.Checked) {
                        data.CNC["ddraw"]["fullscreen"] = "true";
                        data.CNC["ddraw"]["windowed"] = "false";
                        data.CNC["ddraw"]["toggle_borderless"] = "false";
                        data.CNC["ddraw"]["toggle_upscaled"] = "true";
                    }
                    else if (rbDisplayBorderless.Checked) {
                        data.CNC["ddraw"]["fullscreen"] = "true";
                        data.CNC["ddraw"]["windowed"] = "true";
                        data.CNC["ddraw"]["toggle_borderless"] = "true";
                        data.CNC["ddraw"]["toggle_upscaled"] = "false";
                    }
                    if (cbVsync.Checked) {
                        data.CNC["ddraw"]["vsync"] = "true";
                    }
                    else {
                        data.CNC["ddraw"]["vsync"] = "false";
                    }
                    if (rbShaderNN.Checked) {
                        data.CNC["ddraw"]["shader"] = "Nearest neighbor";
                    }
                    else {
                        data.CNC["ddraw"]["shader"] = "Bicubic";
                    }
                    parser.WriteFile(ini.CNC, data.CNC, UTF8withoutBOM);
                }
                
                //[Zooming]
                if (!cbZoomMouse.Checked && !cbZoomKeyboard.Checked && !cbZoomTouch.Checked) {
                    data.Res["Zooming"]["Enable"] = "0";
                    data.Res["Zooming"]["UseMouseWheel"] = "0";
                    data.Res["Zooming"]["UseKeyboardZoom"] = "0";
                    data.Res["Zooming"]["UseTouchscreenZoom"] = "0";
                }
                else {
                    data.Res["Zooming"]["Enable"] = "1";
                    data.Res["Zooming"]["UseMouseWheel"] = setCheckbox(cbZoomMouse.Checked);
                    data.Res["Zooming"]["UseKeyboardZoom"] = setCheckbox(cbZoomKeyboard.Checked);
                    data.Res["Zooming"]["UseTouchscreenZoom"] = setCheckbox(cbZoomTouch.Checked);
                }
                parser.WriteFile(ini.Res, data.Res, UTF8withoutBOM);

                //ExtendedOptions.ini
                if (flwExtended.Visible) {
                    //[Settings]
                    data.EO["Settings"]["ExtendedChat"] = setCheckbox(cbExtChat.Checked);
                    data.EO["Settings"]["Backflip"] = setCheckbox(cbExtBackflip.Checked);
                    data.EO["Settings"]["RedBlood"] = setCheckbox(cbExtBlood.Checked);
                    parser.WriteFile(ini.EO, data.EO, UTF8withoutBOM);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message,"Error");
            }
            try { global.sndSave.Play(); }
            catch { }
        }
        private void controlChange(object sender, EventArgs e)
        {
            if (global.ready) {
                if (sender is RadioButton) {
                    if ((sender as RadioButton).Checked) {
                        try {global.sndOption.Play();}
                        catch { }
                    }
                }
                else if (sender is CheckBox) {
                    try { global.sndOption.Play(); }
                    catch { }
                }
            }
        }

        private void txtRes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void removeLeadingZeroes(object sender)
        {
            string resVal = (sender as TextBox).Text;
            if (resVal[0].ToString() == "0") {
                (sender as TextBox).Text = resVal.TrimStart(new Char[] { '0' });
            }
        }
    }
}
