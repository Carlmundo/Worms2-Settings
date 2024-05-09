namespace Worms2_Settings
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tblDesign = new System.Windows.Forms.TableLayoutPanel();
            this.flwDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.rbDisplayWindowed = new System.Windows.Forms.RadioButton();
            this.rbDisplayFullscreen = new System.Windows.Forms.RadioButton();
            this.rbDisplayBorderless = new System.Windows.Forms.RadioButton();
            this.lblApplications = new System.Windows.Forms.Label();
            this.flwRes = new System.Windows.Forms.FlowLayoutPanel();
            this.cbRecommended = new System.Windows.Forms.CheckBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblResolution = new System.Windows.Forms.Label();
            this.lblRenderer = new System.Windows.Forms.Label();
            this.flwRenderer = new System.Windows.Forms.FlowLayoutPanel();
            this.rbRenderWnd = new System.Windows.Forms.RadioButton();
            this.rbRenderCNC = new System.Windows.Forms.RadioButton();
            this.lblMode = new System.Windows.Forms.Label();
            this.lblVsync = new System.Windows.Forms.Label();
            this.lblZoom = new System.Windows.Forms.Label();
            this.flwZoom = new System.Windows.Forms.FlowLayoutPanel();
            this.cbZoomMouse = new System.Windows.Forms.CheckBox();
            this.cbZoomKeyboard = new System.Windows.Forms.CheckBox();
            this.cbZoomTouch = new System.Windows.Forms.CheckBox();
            this.lblHeadingDisplay = new System.Windows.Forms.Label();
            this.lblHeadingAudio = new System.Windows.Forms.Label();
            this.flwAudio = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVolume = new System.Windows.Forms.Button();
            this.btnSoundbank = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.flwVsync = new System.Windows.Forms.FlowLayoutPanel();
            this.cbVsync = new System.Windows.Forms.CheckBox();
            this.lblError = new System.Windows.Forms.Label();
            this.timerProcess = new System.Windows.Forms.Timer(this.components);
            this.tblDesign.SuspendLayout();
            this.flwDisplay.SuspendLayout();
            this.flwRes.SuspendLayout();
            this.flwRenderer.SuspendLayout();
            this.flwZoom.SuspendLayout();
            this.flwAudio.SuspendLayout();
            this.flwVsync.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblDesign
            // 
            this.tblDesign.AutoSize = true;
            this.tblDesign.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tblDesign.BackgroundImage")));
            this.tblDesign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tblDesign.ColumnCount = 2;
            this.tblDesign.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDesign.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblDesign.Controls.Add(this.flwDisplay, 1, 3);
            this.tblDesign.Controls.Add(this.lblApplications, 0, 8);
            this.tblDesign.Controls.Add(this.flwRes, 1, 2);
            this.tblDesign.Controls.Add(this.lblResolution, 0, 2);
            this.tblDesign.Controls.Add(this.lblRenderer, 0, 1);
            this.tblDesign.Controls.Add(this.flwRenderer, 1, 1);
            this.tblDesign.Controls.Add(this.lblMode, 0, 3);
            this.tblDesign.Controls.Add(this.lblVsync, 0, 4);
            this.tblDesign.Controls.Add(this.lblZoom, 0, 5);
            this.tblDesign.Controls.Add(this.flwZoom, 1, 5);
            this.tblDesign.Controls.Add(this.lblHeadingDisplay, 0, 0);
            this.tblDesign.Controls.Add(this.lblHeadingAudio, 0, 7);
            this.tblDesign.Controls.Add(this.flwAudio, 1, 8);
            this.tblDesign.Controls.Add(this.btnSave, 1, 6);
            this.tblDesign.Controls.Add(this.flwVsync, 1, 4);
            this.tblDesign.Controls.Add(this.lblError, 0, 9);
            this.tblDesign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDesign.Location = new System.Drawing.Point(0, 0);
            this.tblDesign.Name = "tblDesign";
            this.tblDesign.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tblDesign.RowCount = 10;
            this.tblDesign.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDesign.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDesign.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDesign.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDesign.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDesign.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDesign.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDesign.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDesign.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDesign.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDesign.Size = new System.Drawing.Size(671, 508);
            this.tblDesign.TabIndex = 1;
            // 
            // flwDisplay
            // 
            this.flwDisplay.AutoSize = true;
            this.flwDisplay.BackColor = System.Drawing.Color.Transparent;
            this.flwDisplay.Controls.Add(this.rbDisplayWindowed);
            this.flwDisplay.Controls.Add(this.rbDisplayFullscreen);
            this.flwDisplay.Controls.Add(this.rbDisplayBorderless);
            this.flwDisplay.Location = new System.Drawing.Point(199, 176);
            this.flwDisplay.Name = "flwDisplay";
            this.flwDisplay.Size = new System.Drawing.Size(316, 78);
            this.flwDisplay.TabIndex = 15;
            // 
            // rbDisplayWindowed
            // 
            this.rbDisplayWindowed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbDisplayWindowed.AutoSize = true;
            this.rbDisplayWindowed.Checked = true;
            this.rbDisplayWindowed.Location = new System.Drawing.Point(3, 3);
            this.rbDisplayWindowed.Name = "rbDisplayWindowed";
            this.rbDisplayWindowed.Size = new System.Drawing.Size(153, 33);
            this.rbDisplayWindowed.TabIndex = 16;
            this.rbDisplayWindowed.TabStop = true;
            this.rbDisplayWindowed.Text = "Windowed";
            this.rbDisplayWindowed.UseVisualStyleBackColor = true;
            this.rbDisplayWindowed.CheckedChanged += new System.EventHandler(this.controlChange);
            // 
            // rbDisplayFullscreen
            // 
            this.rbDisplayFullscreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbDisplayFullscreen.AutoSize = true;
            this.rbDisplayFullscreen.Location = new System.Drawing.Point(162, 3);
            this.rbDisplayFullscreen.Name = "rbDisplayFullscreen";
            this.rbDisplayFullscreen.Size = new System.Drawing.Size(151, 33);
            this.rbDisplayFullscreen.TabIndex = 17;
            this.rbDisplayFullscreen.Text = "Fullscreen";
            this.rbDisplayFullscreen.UseVisualStyleBackColor = true;
            this.rbDisplayFullscreen.CheckedChanged += new System.EventHandler(this.controlChange);
            // 
            // rbDisplayBorderless
            // 
            this.rbDisplayBorderless.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbDisplayBorderless.AutoSize = true;
            this.rbDisplayBorderless.Location = new System.Drawing.Point(3, 42);
            this.rbDisplayBorderless.Name = "rbDisplayBorderless";
            this.rbDisplayBorderless.Size = new System.Drawing.Size(249, 33);
            this.rbDisplayBorderless.TabIndex = 18;
            this.rbDisplayBorderless.Text = "Borderless Window";
            this.rbDisplayBorderless.UseVisualStyleBackColor = true;
            this.rbDisplayBorderless.CheckedChanged += new System.EventHandler(this.controlChange);
            // 
            // lblApplications
            // 
            this.lblApplications.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblApplications.AutoSize = true;
            this.lblApplications.BackColor = System.Drawing.Color.Transparent;
            this.lblApplications.Location = new System.Drawing.Point(49, 542);
            this.lblApplications.Margin = new System.Windows.Forms.Padding(3);
            this.lblApplications.Name = "lblApplications";
            this.lblApplications.Size = new System.Drawing.Size(144, 29);
            this.lblApplications.TabIndex = 29;
            this.lblApplications.Text = "Applications";
            this.lblApplications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flwRes
            // 
            this.flwRes.AutoSize = true;
            this.flwRes.BackColor = System.Drawing.Color.Transparent;
            this.flwRes.Controls.Add(this.cbRecommended);
            this.flwRes.Controls.Add(this.lblWidth);
            this.flwRes.Controls.Add(this.txtWidth);
            this.flwRes.Controls.Add(this.lblHeight);
            this.flwRes.Controls.Add(this.txtHeight);
            this.flwRes.Location = new System.Drawing.Point(199, 94);
            this.flwRes.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.flwRes.Name = "flwRes";
            this.flwRes.Size = new System.Drawing.Size(331, 79);
            this.flwRes.TabIndex = 8;
            // 
            // cbRecommended
            // 
            this.cbRecommended.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRecommended.AutoSize = true;
            this.flwRes.SetFlowBreak(this.cbRecommended, true);
            this.cbRecommended.Location = new System.Drawing.Point(3, 3);
            this.cbRecommended.Name = "cbRecommended";
            this.cbRecommended.Size = new System.Drawing.Size(245, 33);
            this.cbRecommended.TabIndex = 9;
            this.cbRecommended.Text = "Use recommended";
            this.cbRecommended.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbRecommended.UseVisualStyleBackColor = true;
            this.cbRecommended.CheckedChanged += new System.EventHandler(this.cbRecommended_CheckedChanged);
            // 
            // lblWidth
            // 
            this.lblWidth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(3, 44);
            this.lblWidth.Margin = new System.Windows.Forms.Padding(3);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(74, 29);
            this.lblWidth.TabIndex = 10;
            this.lblWidth.Text = "Width";
            // 
            // txtWidth
            // 
            this.txtWidth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWidth.Location = new System.Drawing.Point(83, 42);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(75, 34);
            this.txtWidth.TabIndex = 11;
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRes_KeyPress);
            // 
            // lblHeight
            // 
            this.lblHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(164, 44);
            this.lblHeight.Margin = new System.Windows.Forms.Padding(3);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(83, 29);
            this.lblHeight.TabIndex = 12;
            this.lblHeight.Text = "Height";
            // 
            // txtHeight
            // 
            this.txtHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHeight.Location = new System.Drawing.Point(253, 42);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(75, 34);
            this.txtHeight.TabIndex = 13;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRes_KeyPress);
            // 
            // lblResolution
            // 
            this.lblResolution.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResolution.AutoSize = true;
            this.lblResolution.BackColor = System.Drawing.Color.Transparent;
            this.lblResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResolution.Location = new System.Drawing.Point(55, 97);
            this.lblResolution.Margin = new System.Windows.Forms.Padding(3);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(138, 29);
            this.lblResolution.TabIndex = 7;
            this.lblResolution.Text = "Resolution";
            this.lblResolution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRenderer
            // 
            this.lblRenderer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblRenderer.AutoSize = true;
            this.lblRenderer.BackColor = System.Drawing.Color.Transparent;
            this.lblRenderer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRenderer.Location = new System.Drawing.Point(70, 57);
            this.lblRenderer.Margin = new System.Windows.Forms.Padding(3);
            this.lblRenderer.Name = "lblRenderer";
            this.lblRenderer.Size = new System.Drawing.Size(123, 29);
            this.lblRenderer.TabIndex = 3;
            this.lblRenderer.Text = "Renderer";
            // 
            // flwRenderer
            // 
            this.flwRenderer.AutoSize = true;
            this.flwRenderer.BackColor = System.Drawing.Color.Transparent;
            this.flwRenderer.Controls.Add(this.rbRenderCNC);
            this.flwRenderer.Controls.Add(this.rbRenderWnd);
            this.flwRenderer.Location = new System.Drawing.Point(199, 52);
            this.flwRenderer.Name = "flwRenderer";
            this.flwRenderer.Size = new System.Drawing.Size(307, 39);
            this.flwRenderer.TabIndex = 4;
            // 
            // rbRenderWnd
            // 
            this.rbRenderWnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbRenderWnd.AutoSize = true;
            this.rbRenderWnd.Location = new System.Drawing.Point(159, 3);
            this.rbRenderWnd.Name = "rbRenderWnd";
            this.rbRenderWnd.Size = new System.Drawing.Size(145, 33);
            this.rbRenderWnd.TabIndex = 6;
            this.rbRenderWnd.TabStop = true;
            this.rbRenderWnd.Text = "wndmode";
            this.rbRenderWnd.UseVisualStyleBackColor = true;
            this.rbRenderWnd.CheckedChanged += new System.EventHandler(this.rbRenderWnd_CheckedChanged);
            // 
            // rbRenderCNC
            // 
            this.rbRenderCNC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbRenderCNC.AutoSize = true;
            this.rbRenderCNC.Location = new System.Drawing.Point(3, 3);
            this.rbRenderCNC.Name = "rbRenderCNC";
            this.rbRenderCNC.Size = new System.Drawing.Size(150, 33);
            this.rbRenderCNC.TabIndex = 5;
            this.rbRenderCNC.TabStop = true;
            this.rbRenderCNC.Text = "cnc-ddraw";
            this.rbRenderCNC.UseVisualStyleBackColor = true;
            this.rbRenderCNC.CheckedChanged += new System.EventHandler(this.rbRenderCNC_CheckedChanged);
            // 
            // lblMode
            // 
            this.lblMode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMode.AutoSize = true;
            this.lblMode.BackColor = System.Drawing.Color.Transparent;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(114, 200);
            this.lblMode.Margin = new System.Windows.Forms.Padding(3);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(79, 29);
            this.lblMode.TabIndex = 14;
            this.lblMode.Text = "Mode";
            // 
            // lblVsync
            // 
            this.lblVsync.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVsync.AutoSize = true;
            this.lblVsync.BackColor = System.Drawing.Color.Transparent;
            this.lblVsync.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVsync.Location = new System.Drawing.Point(99, 258);
            this.lblVsync.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.lblVsync.Name = "lblVsync";
            this.lblVsync.Size = new System.Drawing.Size(94, 29);
            this.lblVsync.TabIndex = 19;
            this.lblVsync.Text = "V-Sync";
            // 
            // lblZoom
            // 
            this.lblZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZoom.AutoSize = true;
            this.lblZoom.BackColor = System.Drawing.Color.Transparent;
            this.lblZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoom.Location = new System.Drawing.Point(16, 295);
            this.lblZoom.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(177, 29);
            this.lblZoom.TabIndex = 22;
            this.lblZoom.Text = "Zoom Options";
            // 
            // flwZoom
            // 
            this.flwZoom.AutoSize = true;
            this.flwZoom.BackColor = System.Drawing.Color.Transparent;
            this.flwZoom.Controls.Add(this.cbZoomMouse);
            this.flwZoom.Controls.Add(this.cbZoomKeyboard);
            this.flwZoom.Controls.Add(this.cbZoomTouch);
            this.flwZoom.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwZoom.Location = new System.Drawing.Point(199, 290);
            this.flwZoom.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.flwZoom.Name = "flwZoom";
            this.flwZoom.Size = new System.Drawing.Size(253, 117);
            this.flwZoom.TabIndex = 23;
            // 
            // cbZoomMouse
            // 
            this.cbZoomMouse.AutoSize = true;
            this.cbZoomMouse.Location = new System.Drawing.Point(3, 3);
            this.cbZoomMouse.Name = "cbZoomMouse";
            this.cbZoomMouse.Size = new System.Drawing.Size(247, 33);
            this.cbZoomMouse.TabIndex = 24;
            this.cbZoomMouse.Text = "Mouse scroll wheel";
            this.cbZoomMouse.UseVisualStyleBackColor = true;
            this.cbZoomMouse.CheckedChanged += new System.EventHandler(this.controlChange);
            // 
            // cbZoomKeyboard
            // 
            this.cbZoomKeyboard.AutoSize = true;
            this.cbZoomKeyboard.Location = new System.Drawing.Point(3, 42);
            this.cbZoomKeyboard.Name = "cbZoomKeyboard";
            this.cbZoomKeyboard.Size = new System.Drawing.Size(194, 33);
            this.cbZoomKeyboard.TabIndex = 25;
            this.cbZoomKeyboard.Text = "Keyboard (+/-)";
            this.cbZoomKeyboard.UseVisualStyleBackColor = true;
            this.cbZoomKeyboard.CheckedChanged += new System.EventHandler(this.controlChange);
            // 
            // cbZoomTouch
            // 
            this.cbZoomTouch.AutoSize = true;
            this.cbZoomTouch.Location = new System.Drawing.Point(3, 81);
            this.cbZoomTouch.Name = "cbZoomTouch";
            this.cbZoomTouch.Size = new System.Drawing.Size(180, 33);
            this.cbZoomTouch.TabIndex = 26;
            this.cbZoomTouch.Text = "Touchscreen";
            this.cbZoomTouch.UseVisualStyleBackColor = true;
            this.cbZoomTouch.CheckedChanged += new System.EventHandler(this.controlChange);
            // 
            // lblHeadingDisplay
            // 
            this.lblHeadingDisplay.AutoSize = true;
            this.lblHeadingDisplay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeadingDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeadingDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeadingDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingDisplay.Location = new System.Drawing.Point(16, 15);
            this.lblHeadingDisplay.Margin = new System.Windows.Forms.Padding(3);
            this.lblHeadingDisplay.Name = "lblHeadingDisplay";
            this.lblHeadingDisplay.Size = new System.Drawing.Size(177, 31);
            this.lblHeadingDisplay.TabIndex = 2;
            this.lblHeadingDisplay.Text = "Display";
            this.lblHeadingDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHeadingAudio
            // 
            this.lblHeadingAudio.AutoSize = true;
            this.lblHeadingAudio.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeadingAudio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeadingAudio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeadingAudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingAudio.Location = new System.Drawing.Point(16, 475);
            this.lblHeadingAudio.Margin = new System.Windows.Forms.Padding(3);
            this.lblHeadingAudio.Name = "lblHeadingAudio";
            this.lblHeadingAudio.Size = new System.Drawing.Size(177, 31);
            this.lblHeadingAudio.TabIndex = 28;
            this.lblHeadingAudio.Text = "Audio";
            this.lblHeadingAudio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flwAudio
            // 
            this.flwAudio.AutoSize = true;
            this.flwAudio.BackColor = System.Drawing.Color.Transparent;
            this.flwAudio.Controls.Add(this.btnVolume);
            this.flwAudio.Controls.Add(this.btnSoundbank);
            this.flwAudio.Location = new System.Drawing.Point(199, 512);
            this.flwAudio.Name = "flwAudio";
            this.flwAudio.Size = new System.Drawing.Size(261, 90);
            this.flwAudio.TabIndex = 30;
            // 
            // btnVolume
            // 
            this.btnVolume.AutoSize = true;
            this.btnVolume.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVolume.BackColor = System.Drawing.SystemColors.Control;
            this.btnVolume.Image = ((System.Drawing.Image)(resources.GetObject("btnVolume.Image")));
            this.btnVolume.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVolume.Location = new System.Drawing.Point(3, 3);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(230, 39);
            this.btnVolume.TabIndex = 31;
            this.btnVolume.Text = "Volume Settings";
            this.btnVolume.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolume.UseVisualStyleBackColor = false;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // btnSoundbank
            // 
            this.btnSoundbank.AutoSize = true;
            this.btnSoundbank.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSoundbank.BackColor = System.Drawing.SystemColors.Control;
            this.btnSoundbank.Image = ((System.Drawing.Image)(resources.GetObject("btnSoundbank.Image")));
            this.btnSoundbank.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoundbank.Location = new System.Drawing.Point(3, 48);
            this.btnSoundbank.Name = "btnSoundbank";
            this.btnSoundbank.Size = new System.Drawing.Size(255, 39);
            this.btnSoundbank.TabIndex = 32;
            this.btnSoundbank.Text = "Sound Bank Editor";
            this.btnSoundbank.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSoundbank.UseVisualStyleBackColor = false;
            this.btnSoundbank.Click += new System.EventHandler(this.btnSoundbank_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSave.Location = new System.Drawing.Point(327, 410);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(10);
            this.btnSave.Size = new System.Drawing.Size(199, 59);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // flwVsync
            // 
            this.flwVsync.AutoSize = true;
            this.flwVsync.BackColor = System.Drawing.Color.Transparent;
            this.flwVsync.Controls.Add(this.cbVsync);
            this.flwVsync.Location = new System.Drawing.Point(199, 260);
            this.flwVsync.Name = "flwVsync";
            this.flwVsync.Size = new System.Drawing.Size(28, 27);
            this.flwVsync.TabIndex = 20;
            // 
            // cbVsync
            // 
            this.cbVsync.AutoSize = true;
            this.cbVsync.Location = new System.Drawing.Point(3, 3);
            this.cbVsync.Name = "cbVsync";
            this.cbVsync.Size = new System.Drawing.Size(22, 21);
            this.cbVsync.TabIndex = 21;
            this.cbVsync.UseVisualStyleBackColor = true;
            this.cbVsync.CheckedChanged += new System.EventHandler(this.controlChange);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.tblDesign.SetColumnSpan(this.lblError, 2);
            this.lblError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(16, 608);
            this.lblError.Margin = new System.Windows.Forms.Padding(3);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(639, 29);
            this.lblError.TabIndex = 33;
            this.lblError.Visible = false;
            // 
            // timerProcess
            // 
            this.timerProcess.Interval = 2000;
            this.timerProcess.Tick += new System.EventHandler(this.timerProcess_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(671, 508);
            this.Controls.Add(this.tblDesign);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Worms 2 Settings";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tblDesign.ResumeLayout(false);
            this.tblDesign.PerformLayout();
            this.flwDisplay.ResumeLayout(false);
            this.flwDisplay.PerformLayout();
            this.flwRes.ResumeLayout(false);
            this.flwRes.PerformLayout();
            this.flwRenderer.ResumeLayout(false);
            this.flwRenderer.PerformLayout();
            this.flwZoom.ResumeLayout(false);
            this.flwZoom.PerformLayout();
            this.flwAudio.ResumeLayout(false);
            this.flwAudio.PerformLayout();
            this.flwVsync.ResumeLayout(false);
            this.flwVsync.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDesign;
        private System.Windows.Forms.Label lblApplications;
        private System.Windows.Forms.Label lblResolution;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.FlowLayoutPanel flwRes;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblRenderer;
        private System.Windows.Forms.FlowLayoutPanel flwRenderer;
        private System.Windows.Forms.RadioButton rbRenderWnd;
        private System.Windows.Forms.RadioButton rbRenderCNC;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.CheckBox cbRecommended;
        private System.Windows.Forms.FlowLayoutPanel flwDisplay;
        private System.Windows.Forms.RadioButton rbDisplayWindowed;
        private System.Windows.Forms.RadioButton rbDisplayFullscreen;
        private System.Windows.Forms.CheckBox cbVsync;
        private System.Windows.Forms.RadioButton rbDisplayBorderless;
        private System.Windows.Forms.Label lblVsync;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.FlowLayoutPanel flwZoom;
        private System.Windows.Forms.CheckBox cbZoomMouse;
        private System.Windows.Forms.CheckBox cbZoomKeyboard;
        private System.Windows.Forms.CheckBox cbZoomTouch;
        private System.Windows.Forms.Label lblHeadingDisplay;
        private System.Windows.Forms.Label lblHeadingAudio;
        private System.Windows.Forms.Button btnSoundbank;
        private System.Windows.Forms.FlowLayoutPanel flwAudio;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.FlowLayoutPanel flwVsync;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Timer timerProcess;
    }
}

