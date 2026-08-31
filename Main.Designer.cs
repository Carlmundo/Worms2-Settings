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
            this.lblResolution = new System.Windows.Forms.Label();
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
            this.flwVsync = new System.Windows.Forms.FlowLayoutPanel();
            this.cbVsync = new System.Windows.Forms.CheckBox();
            this.lblError = new System.Windows.Forms.Label();
            this.flwResOpen = new System.Windows.Forms.FlowLayoutPanel();
            this.lblWidthOpen = new System.Windows.Forms.Label();
            this.txtWidthOpen = new System.Windows.Forms.TextBox();
            this.lblHeightOpen = new System.Windows.Forms.Label();
            this.txtHeightOpen = new System.Windows.Forms.TextBox();
            this.flwResCavern = new System.Windows.Forms.FlowLayoutPanel();
            this.lblWidthCavern = new System.Windows.Forms.Label();
            this.txtWidthCavern = new System.Windows.Forms.TextBox();
            this.lblHeightCavern = new System.Windows.Forms.Label();
            this.txtHeightCavern = new System.Windows.Forms.TextBox();
            this.lblResOpen = new System.Windows.Forms.Label();
            this.lblResCavern = new System.Windows.Forms.Label();
            this.flwRes = new System.Windows.Forms.FlowLayoutPanel();
            this.cbRecommended = new System.Windows.Forms.CheckBox();
            this.lblShader = new System.Windows.Forms.Label();
            this.flwShader = new System.Windows.Forms.FlowLayoutPanel();
            this.rbShaderBC = new System.Windows.Forms.RadioButton();
            this.rbShaderNN = new System.Windows.Forms.RadioButton();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblHeadingExtended = new System.Windows.Forms.Label();
            this.flwExtended = new System.Windows.Forms.FlowLayoutPanel();
            this.cbExtChat = new System.Windows.Forms.CheckBox();
            this.cbExtBlood = new System.Windows.Forms.CheckBox();
            this.timerProcess = new System.Windows.Forms.Timer(this.components);
            this.cbExtBackflip = new System.Windows.Forms.CheckBox();
            this.tblDesign.SuspendLayout();
            this.flwDisplay.SuspendLayout();
            this.flwZoom.SuspendLayout();
            this.flwAudio.SuspendLayout();
            this.flwVsync.SuspendLayout();
            this.flwResOpen.SuspendLayout();
            this.flwResCavern.SuspendLayout();
            this.flwRes.SuspendLayout();
            this.flwShader.SuspendLayout();
            this.flwExtended.SuspendLayout();
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
            this.tblDesign.Controls.Add(this.flwDisplay, 1, 4);
            this.tblDesign.Controls.Add(this.lblApplications, 0, 12);
            this.tblDesign.Controls.Add(this.lblResolution, 0, 1);
            this.tblDesign.Controls.Add(this.lblMode, 0, 4);
            this.tblDesign.Controls.Add(this.lblVsync, 0, 5);
            this.tblDesign.Controls.Add(this.lblZoom, 0, 7);
            this.tblDesign.Controls.Add(this.flwZoom, 1, 7);
            this.tblDesign.Controls.Add(this.lblHeadingDisplay, 0, 0);
            this.tblDesign.Controls.Add(this.lblHeadingAudio, 0, 11);
            this.tblDesign.Controls.Add(this.flwAudio, 1, 12);
            this.tblDesign.Controls.Add(this.flwVsync, 1, 5);
            this.tblDesign.Controls.Add(this.lblError, 0, 13);
            this.tblDesign.Controls.Add(this.flwResOpen, 1, 2);
            this.tblDesign.Controls.Add(this.flwResCavern, 1, 3);
            this.tblDesign.Controls.Add(this.lblResOpen, 0, 2);
            this.tblDesign.Controls.Add(this.lblResCavern, 0, 3);
            this.tblDesign.Controls.Add(this.flwRes, 1, 1);
            this.tblDesign.Controls.Add(this.lblShader, 0, 6);
            this.tblDesign.Controls.Add(this.flwShader, 1, 6);
            this.tblDesign.Controls.Add(this.btnSave, 0, 10);
            this.tblDesign.Controls.Add(this.lblHeadingExtended, 0, 8);
            this.tblDesign.Controls.Add(this.flwExtended, 1, 9);
            this.tblDesign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDesign.Location = new System.Drawing.Point(0, 0);
            this.tblDesign.Name = "tblDesign";
            this.tblDesign.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tblDesign.RowCount = 14;
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
            this.tblDesign.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDesign.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDesign.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDesign.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblDesign.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblDesign.Size = new System.Drawing.Size(684, 788);
            this.tblDesign.TabIndex = 1;
            // 
            // flwDisplay
            // 
            this.flwDisplay.AutoSize = true;
            this.flwDisplay.BackColor = System.Drawing.Color.Transparent;
            this.flwDisplay.Controls.Add(this.rbDisplayWindowed);
            this.flwDisplay.Controls.Add(this.rbDisplayFullscreen);
            this.flwDisplay.Controls.Add(this.rbDisplayBorderless);
            this.flwDisplay.Location = new System.Drawing.Point(183, 183);
            this.flwDisplay.Name = "flwDisplay";
            this.flwDisplay.Size = new System.Drawing.Size(354, 82);
            this.flwDisplay.TabIndex = 11;
            // 
            // rbDisplayWindowed
            // 
            this.rbDisplayWindowed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbDisplayWindowed.AutoSize = true;
            this.rbDisplayWindowed.Checked = true;
            this.rbDisplayWindowed.Location = new System.Drawing.Point(3, 3);
            this.rbDisplayWindowed.Name = "rbDisplayWindowed";
            this.rbDisplayWindowed.Size = new System.Drawing.Size(171, 35);
            this.rbDisplayWindowed.TabIndex = 1;
            this.rbDisplayWindowed.TabStop = true;
            this.rbDisplayWindowed.Text = "Windowed";
            this.rbDisplayWindowed.UseVisualStyleBackColor = true;
            this.rbDisplayWindowed.CheckedChanged += new System.EventHandler(this.controlChange);
            // 
            // rbDisplayFullscreen
            // 
            this.rbDisplayFullscreen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbDisplayFullscreen.AutoSize = true;
            this.rbDisplayFullscreen.Location = new System.Drawing.Point(180, 3);
            this.rbDisplayFullscreen.Name = "rbDisplayFullscreen";
            this.rbDisplayFullscreen.Size = new System.Drawing.Size(171, 35);
            this.rbDisplayFullscreen.TabIndex = 1;
            this.rbDisplayFullscreen.Text = "Fullscreen";
            this.rbDisplayFullscreen.UseVisualStyleBackColor = true;
            this.rbDisplayFullscreen.CheckedChanged += new System.EventHandler(this.controlChange);
            // 
            // rbDisplayBorderless
            // 
            this.rbDisplayBorderless.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbDisplayBorderless.AutoSize = true;
            this.rbDisplayBorderless.Location = new System.Drawing.Point(3, 44);
            this.rbDisplayBorderless.Name = "rbDisplayBorderless";
            this.rbDisplayBorderless.Size = new System.Drawing.Size(278, 35);
            this.rbDisplayBorderless.TabIndex = 1;
            this.rbDisplayBorderless.Text = "Borderless Window";
            this.rbDisplayBorderless.UseVisualStyleBackColor = true;
            this.rbDisplayBorderless.CheckedChanged += new System.EventHandler(this.controlChange);
            // 
            // lblApplications
            // 
            this.lblApplications.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblApplications.AutoSize = true;
            this.lblApplications.BackColor = System.Drawing.Color.Transparent;
            this.lblApplications.Location = new System.Drawing.Point(16, 791);
            this.lblApplications.Margin = new System.Windows.Forms.Padding(3);
            this.lblApplications.Name = "lblApplications";
            this.lblApplications.Size = new System.Drawing.Size(161, 31);
            this.lblApplications.TabIndex = 19;
            this.lblApplications.Text = "Applications";
            this.lblApplications.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResolution
            // 
            this.lblResolution.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblResolution.AutoSize = true;
            this.lblResolution.BackColor = System.Drawing.Color.Transparent;
            this.lblResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResolution.Location = new System.Drawing.Point(24, 56);
            this.lblResolution.Margin = new System.Windows.Forms.Padding(3);
            this.lblResolution.Name = "lblResolution";
            this.lblResolution.Size = new System.Drawing.Size(153, 31);
            this.lblResolution.TabIndex = 4;
            this.lblResolution.Text = "Resolution";
            this.lblResolution.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMode
            // 
            this.lblMode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMode.AutoSize = true;
            this.lblMode.BackColor = System.Drawing.Color.Transparent;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(92, 208);
            this.lblMode.Margin = new System.Windows.Forms.Padding(3);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(85, 31);
            this.lblMode.TabIndex = 10;
            this.lblMode.Text = "Mode";
            // 
            // lblVsync
            // 
            this.lblVsync.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVsync.AutoSize = true;
            this.lblVsync.BackColor = System.Drawing.Color.Transparent;
            this.lblVsync.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVsync.Location = new System.Drawing.Point(69, 271);
            this.lblVsync.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.lblVsync.Name = "lblVsync";
            this.lblVsync.Size = new System.Drawing.Size(108, 31);
            this.lblVsync.TabIndex = 12;
            this.lblVsync.Text = "V-Sync";
            // 
            // lblZoom
            // 
            this.lblZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZoom.AutoSize = true;
            this.lblZoom.BackColor = System.Drawing.Color.Transparent;
            this.lblZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoom.Location = new System.Drawing.Point(90, 359);
            this.lblZoom.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(87, 31);
            this.lblZoom.TabIndex = 15;
            this.lblZoom.Text = "Zoom";
            // 
            // flwZoom
            // 
            this.flwZoom.AutoSize = true;
            this.flwZoom.BackColor = System.Drawing.Color.Transparent;
            this.flwZoom.Controls.Add(this.cbZoomMouse);
            this.flwZoom.Controls.Add(this.cbZoomKeyboard);
            this.flwZoom.Controls.Add(this.cbZoomTouch);
            this.flwZoom.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwZoom.Location = new System.Drawing.Point(183, 354);
            this.flwZoom.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.flwZoom.Name = "flwZoom";
            this.flwZoom.Size = new System.Drawing.Size(282, 123);
            this.flwZoom.TabIndex = 16;
            // 
            // cbZoomMouse
            // 
            this.cbZoomMouse.AutoSize = true;
            this.cbZoomMouse.Location = new System.Drawing.Point(3, 3);
            this.cbZoomMouse.Name = "cbZoomMouse";
            this.cbZoomMouse.Size = new System.Drawing.Size(276, 35);
            this.cbZoomMouse.TabIndex = 1;
            this.cbZoomMouse.Text = "Mouse scroll wheel";
            this.cbZoomMouse.UseVisualStyleBackColor = true;
            this.cbZoomMouse.CheckedChanged += new System.EventHandler(this.controlChange);
            // 
            // cbZoomKeyboard
            // 
            this.cbZoomKeyboard.AutoSize = true;
            this.cbZoomKeyboard.Location = new System.Drawing.Point(3, 44);
            this.cbZoomKeyboard.Name = "cbZoomKeyboard";
            this.cbZoomKeyboard.Size = new System.Drawing.Size(220, 35);
            this.cbZoomKeyboard.TabIndex = 2;
            this.cbZoomKeyboard.Text = "Keyboard (+/-)";
            this.cbZoomKeyboard.UseVisualStyleBackColor = true;
            this.cbZoomKeyboard.CheckedChanged += new System.EventHandler(this.controlChange);
            // 
            // cbZoomTouch
            // 
            this.cbZoomTouch.AutoSize = true;
            this.cbZoomTouch.Location = new System.Drawing.Point(3, 85);
            this.cbZoomTouch.Name = "cbZoomTouch";
            this.cbZoomTouch.Size = new System.Drawing.Size(204, 35);
            this.cbZoomTouch.TabIndex = 3;
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
            this.lblHeadingDisplay.Size = new System.Drawing.Size(161, 33);
            this.lblHeadingDisplay.TabIndex = 1;
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
            this.lblHeadingAudio.Location = new System.Drawing.Point(16, 721);
            this.lblHeadingAudio.Margin = new System.Windows.Forms.Padding(3);
            this.lblHeadingAudio.Name = "lblHeadingAudio";
            this.lblHeadingAudio.Size = new System.Drawing.Size(161, 33);
            this.lblHeadingAudio.TabIndex = 18;
            this.lblHeadingAudio.Text = "Audio";
            this.lblHeadingAudio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flwAudio
            // 
            this.flwAudio.AutoSize = true;
            this.flwAudio.BackColor = System.Drawing.Color.Transparent;
            this.flwAudio.Controls.Add(this.btnVolume);
            this.flwAudio.Controls.Add(this.btnSoundbank);
            this.flwAudio.Location = new System.Drawing.Point(183, 760);
            this.flwAudio.Name = "flwAudio";
            this.flwAudio.Size = new System.Drawing.Size(287, 94);
            this.flwAudio.TabIndex = 20;
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
            this.btnVolume.Size = new System.Drawing.Size(253, 41);
            this.btnVolume.TabIndex = 1;
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
            this.btnSoundbank.Location = new System.Drawing.Point(3, 50);
            this.btnSoundbank.Name = "btnSoundbank";
            this.btnSoundbank.Size = new System.Drawing.Size(281, 41);
            this.btnSoundbank.TabIndex = 2;
            this.btnSoundbank.Text = "Sound Bank Editor";
            this.btnSoundbank.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSoundbank.UseVisualStyleBackColor = false;
            this.btnSoundbank.Click += new System.EventHandler(this.btnSoundbank_Click);
            // 
            // flwVsync
            // 
            this.flwVsync.AutoSize = true;
            this.flwVsync.BackColor = System.Drawing.Color.Transparent;
            this.flwVsync.Controls.Add(this.cbVsync);
            this.flwVsync.Location = new System.Drawing.Point(183, 271);
            this.flwVsync.Name = "flwVsync";
            this.flwVsync.Size = new System.Drawing.Size(34, 33);
            this.flwVsync.TabIndex = 13;
            // 
            // cbVsync
            // 
            this.cbVsync.AutoSize = true;
            this.cbVsync.Location = new System.Drawing.Point(3, 3);
            this.cbVsync.Name = "cbVsync";
            this.cbVsync.Size = new System.Drawing.Size(28, 27);
            this.cbVsync.TabIndex = 0;
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
            this.lblError.Location = new System.Drawing.Point(16, 860);
            this.lblError.Margin = new System.Windows.Forms.Padding(3);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(652, 31);
            this.lblError.TabIndex = 0;
            this.lblError.Visible = false;
            // 
            // flwResOpen
            // 
            this.flwResOpen.AutoSize = true;
            this.flwResOpen.BackColor = System.Drawing.Color.Transparent;
            this.flwResOpen.Controls.Add(this.lblWidthOpen);
            this.flwResOpen.Controls.Add(this.txtWidthOpen);
            this.flwResOpen.Controls.Add(this.lblHeightOpen);
            this.flwResOpen.Controls.Add(this.txtHeightOpen);
            this.flwResOpen.Location = new System.Drawing.Point(183, 92);
            this.flwResOpen.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.flwResOpen.Name = "flwResOpen";
            this.flwResOpen.Size = new System.Drawing.Size(350, 44);
            this.flwResOpen.TabIndex = 7;
            // 
            // lblWidthOpen
            // 
            this.lblWidthOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWidthOpen.AutoSize = true;
            this.lblWidthOpen.Location = new System.Drawing.Point(3, 6);
            this.lblWidthOpen.Margin = new System.Windows.Forms.Padding(3);
            this.lblWidthOpen.Name = "lblWidthOpen";
            this.lblWidthOpen.Size = new System.Drawing.Size(83, 31);
            this.lblWidthOpen.TabIndex = 1;
            this.lblWidthOpen.Text = "Width";
            // 
            // txtWidthOpen
            // 
            this.txtWidthOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWidthOpen.Location = new System.Drawing.Point(92, 3);
            this.txtWidthOpen.Name = "txtWidthOpen";
            this.txtWidthOpen.Size = new System.Drawing.Size(75, 38);
            this.txtWidthOpen.TabIndex = 2;
            this.txtWidthOpen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWidthOpen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRes_KeyPress);
            // 
            // lblHeightOpen
            // 
            this.lblHeightOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeightOpen.AutoSize = true;
            this.lblHeightOpen.Location = new System.Drawing.Point(173, 6);
            this.lblHeightOpen.Margin = new System.Windows.Forms.Padding(3);
            this.lblHeightOpen.Name = "lblHeightOpen";
            this.lblHeightOpen.Size = new System.Drawing.Size(93, 31);
            this.lblHeightOpen.TabIndex = 3;
            this.lblHeightOpen.Text = "Height";
            // 
            // txtHeightOpen
            // 
            this.txtHeightOpen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHeightOpen.Location = new System.Drawing.Point(272, 3);
            this.txtHeightOpen.Name = "txtHeightOpen";
            this.txtHeightOpen.Size = new System.Drawing.Size(75, 38);
            this.txtHeightOpen.TabIndex = 4;
            this.txtHeightOpen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHeightOpen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRes_KeyPress);
            // 
            // flwResCavern
            // 
            this.flwResCavern.AutoSize = true;
            this.flwResCavern.BackColor = System.Drawing.Color.Transparent;
            this.flwResCavern.Controls.Add(this.lblWidthCavern);
            this.flwResCavern.Controls.Add(this.txtWidthCavern);
            this.flwResCavern.Controls.Add(this.lblHeightCavern);
            this.flwResCavern.Controls.Add(this.txtHeightCavern);
            this.flwResCavern.Location = new System.Drawing.Point(183, 136);
            this.flwResCavern.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.flwResCavern.Name = "flwResCavern";
            this.flwResCavern.Size = new System.Drawing.Size(350, 44);
            this.flwResCavern.TabIndex = 9;
            // 
            // lblWidthCavern
            // 
            this.lblWidthCavern.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWidthCavern.AutoSize = true;
            this.lblWidthCavern.Location = new System.Drawing.Point(3, 6);
            this.lblWidthCavern.Margin = new System.Windows.Forms.Padding(3);
            this.lblWidthCavern.Name = "lblWidthCavern";
            this.lblWidthCavern.Size = new System.Drawing.Size(83, 31);
            this.lblWidthCavern.TabIndex = 1;
            this.lblWidthCavern.Text = "Width";
            // 
            // txtWidthCavern
            // 
            this.txtWidthCavern.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtWidthCavern.Location = new System.Drawing.Point(92, 3);
            this.txtWidthCavern.Name = "txtWidthCavern";
            this.txtWidthCavern.Size = new System.Drawing.Size(75, 38);
            this.txtWidthCavern.TabIndex = 2;
            this.txtWidthCavern.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblHeightCavern
            // 
            this.lblHeightCavern.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeightCavern.AutoSize = true;
            this.lblHeightCavern.Location = new System.Drawing.Point(173, 6);
            this.lblHeightCavern.Margin = new System.Windows.Forms.Padding(3);
            this.lblHeightCavern.Name = "lblHeightCavern";
            this.lblHeightCavern.Size = new System.Drawing.Size(93, 31);
            this.lblHeightCavern.TabIndex = 3;
            this.lblHeightCavern.Text = "Height";
            // 
            // txtHeightCavern
            // 
            this.txtHeightCavern.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHeightCavern.Location = new System.Drawing.Point(272, 3);
            this.txtHeightCavern.Name = "txtHeightCavern";
            this.txtHeightCavern.Size = new System.Drawing.Size(75, 38);
            this.txtHeightCavern.TabIndex = 4;
            this.txtHeightCavern.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblResOpen
            // 
            this.lblResOpen.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblResOpen.AutoSize = true;
            this.lblResOpen.BackColor = System.Drawing.Color.Transparent;
            this.lblResOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResOpen.Location = new System.Drawing.Point(97, 98);
            this.lblResOpen.Margin = new System.Windows.Forms.Padding(3);
            this.lblResOpen.Name = "lblResOpen";
            this.lblResOpen.Size = new System.Drawing.Size(80, 31);
            this.lblResOpen.TabIndex = 6;
            this.lblResOpen.Text = "Open";
            this.lblResOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResCavern
            // 
            this.lblResCavern.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblResCavern.AutoSize = true;
            this.lblResCavern.BackColor = System.Drawing.Color.Transparent;
            this.lblResCavern.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResCavern.Location = new System.Drawing.Point(75, 142);
            this.lblResCavern.Margin = new System.Windows.Forms.Padding(3);
            this.lblResCavern.Name = "lblResCavern";
            this.lblResCavern.Size = new System.Drawing.Size(102, 31);
            this.lblResCavern.TabIndex = 8;
            this.lblResCavern.Text = "Cavern";
            this.lblResCavern.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flwRes
            // 
            this.flwRes.AutoSize = true;
            this.flwRes.BackColor = System.Drawing.Color.Transparent;
            this.flwRes.Controls.Add(this.cbRecommended);
            this.flwRes.Location = new System.Drawing.Point(183, 51);
            this.flwRes.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.flwRes.Name = "flwRes";
            this.flwRes.Size = new System.Drawing.Size(280, 41);
            this.flwRes.TabIndex = 5;
            // 
            // cbRecommended
            // 
            this.cbRecommended.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbRecommended.AutoSize = true;
            this.cbRecommended.Location = new System.Drawing.Point(3, 3);
            this.cbRecommended.Name = "cbRecommended";
            this.cbRecommended.Size = new System.Drawing.Size(274, 35);
            this.cbRecommended.TabIndex = 1;
            this.cbRecommended.Text = "Use recommended";
            this.cbRecommended.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.cbRecommended.UseVisualStyleBackColor = true;
            this.cbRecommended.CheckedChanged += new System.EventHandler(this.cbRecommended_CheckedChanged);
            // 
            // lblShader
            // 
            this.lblShader.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblShader.AutoSize = true;
            this.lblShader.BackColor = System.Drawing.Color.Transparent;
            this.lblShader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShader.Location = new System.Drawing.Point(70, 314);
            this.lblShader.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
            this.lblShader.Name = "lblShader";
            this.lblShader.Size = new System.Drawing.Size(107, 31);
            this.lblShader.TabIndex = 13;
            this.lblShader.Text = "Shader";
            // 
            // flwShader
            // 
            this.flwShader.AutoSize = true;
            this.flwShader.BackColor = System.Drawing.Color.Transparent;
            this.flwShader.Controls.Add(this.rbShaderBC);
            this.flwShader.Controls.Add(this.rbShaderNN);
            this.flwShader.Location = new System.Drawing.Point(183, 310);
            this.flwShader.Name = "flwShader";
            this.flwShader.Size = new System.Drawing.Size(284, 41);
            this.flwShader.TabIndex = 14;
            // 
            // rbShaderBC
            // 
            this.rbShaderBC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbShaderBC.AutoSize = true;
            this.rbShaderBC.Location = new System.Drawing.Point(3, 3);
            this.rbShaderBC.Name = "rbShaderBC";
            this.rbShaderBC.Size = new System.Drawing.Size(138, 35);
            this.rbShaderBC.TabIndex = 1;
            this.rbShaderBC.TabStop = true;
            this.rbShaderBC.Text = "Smooth";
            this.rbShaderBC.UseVisualStyleBackColor = true;
            // 
            // rbShaderNN
            // 
            this.rbShaderNN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbShaderNN.AutoSize = true;
            this.rbShaderNN.Location = new System.Drawing.Point(147, 3);
            this.rbShaderNN.Name = "rbShaderNN";
            this.rbShaderNN.Size = new System.Drawing.Size(134, 35);
            this.rbShaderNN.TabIndex = 1;
            this.rbShaderNN.TabStop = true;
            this.rbShaderNN.Text = "Classic";
            this.rbShaderNN.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.AutoSize = true;
            this.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblDesign.SetColumnSpan(this.btnSave, 2);
            this.btnSave.Location = new System.Drawing.Point(231, 654);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(10);
            this.btnSave.Size = new System.Drawing.Size(222, 61);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblHeadingExtended
            // 
            this.lblHeadingExtended.AutoSize = true;
            this.lblHeadingExtended.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblHeadingExtended.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeadingExtended.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeadingExtended.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeadingExtended.Location = new System.Drawing.Point(16, 480);
            this.lblHeadingExtended.Margin = new System.Windows.Forms.Padding(3);
            this.lblHeadingExtended.Name = "lblHeadingExtended";
            this.lblHeadingExtended.Size = new System.Drawing.Size(161, 33);
            this.lblHeadingExtended.TabIndex = 23;
            this.lblHeadingExtended.Text = "Game";
            this.lblHeadingExtended.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flwExtended
            // 
            this.flwExtended.AutoSize = true;
            this.flwExtended.BackColor = System.Drawing.Color.Transparent;
            this.flwExtended.Controls.Add(this.cbExtChat);
            this.flwExtended.Controls.Add(this.cbExtBackflip);
            this.flwExtended.Controls.Add(this.cbExtBlood);
            this.flwExtended.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwExtended.Location = new System.Drawing.Point(183, 516);
            this.flwExtended.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.flwExtended.Name = "flwExtended";
            this.flwExtended.Size = new System.Drawing.Size(362, 123);
            this.flwExtended.TabIndex = 22;
            // 
            // cbExtChat
            // 
            this.cbExtChat.AutoSize = true;
            this.cbExtChat.Location = new System.Drawing.Point(3, 3);
            this.cbExtChat.Name = "cbExtChat";
            this.cbExtChat.Size = new System.Drawing.Size(356, 35);
            this.cbExtChat.TabIndex = 1;
            this.cbExtChat.Text = "Extended chat box editing";
            this.cbExtChat.UseVisualStyleBackColor = true;
            // 
            // cbExtBlood
            // 
            this.cbExtBlood.AutoSize = true;
            this.cbExtBlood.Location = new System.Drawing.Point(3, 85);
            this.cbExtBlood.Name = "cbExtBlood";
            this.cbExtBlood.Size = new System.Drawing.Size(115, 35);
            this.cbExtBlood.TabIndex = 3;
            this.cbExtBlood.Text = "Blood";
            this.cbExtBlood.UseVisualStyleBackColor = true;
            // 
            // timerProcess
            // 
            this.timerProcess.Interval = 2000;
            this.timerProcess.Tick += new System.EventHandler(this.timerProcess_Tick);
            // 
            // cbExtBackflip
            // 
            this.cbExtBackflip.AutoSize = true;
            this.cbExtBackflip.Location = new System.Drawing.Point(3, 44);
            this.cbExtBackflip.Name = "cbExtBackflip";
            this.cbExtBackflip.Size = new System.Drawing.Size(142, 35);
            this.cbExtBackflip.TabIndex = 4;
            this.cbExtBackflip.Text = "Backflip";
            this.cbExtBackflip.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(684, 788);
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
            this.flwZoom.ResumeLayout(false);
            this.flwZoom.PerformLayout();
            this.flwAudio.ResumeLayout(false);
            this.flwAudio.PerformLayout();
            this.flwVsync.ResumeLayout(false);
            this.flwVsync.PerformLayout();
            this.flwResOpen.ResumeLayout(false);
            this.flwResOpen.PerformLayout();
            this.flwResCavern.ResumeLayout(false);
            this.flwResCavern.PerformLayout();
            this.flwRes.ResumeLayout(false);
            this.flwRes.PerformLayout();
            this.flwShader.ResumeLayout(false);
            this.flwShader.PerformLayout();
            this.flwExtended.ResumeLayout(false);
            this.flwExtended.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDesign;
        private System.Windows.Forms.Label lblApplications;
        private System.Windows.Forms.Label lblResolution;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.FlowLayoutPanel flwRes;
        private System.Windows.Forms.Label lblWidthOpen;
        private System.Windows.Forms.TextBox txtWidthOpen;
        private System.Windows.Forms.Label lblHeightOpen;
        private System.Windows.Forms.TextBox txtHeightOpen;
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
        private System.Windows.Forms.FlowLayoutPanel flwResOpen;
        private System.Windows.Forms.FlowLayoutPanel flwResCavern;
        private System.Windows.Forms.Label lblWidthCavern;
        private System.Windows.Forms.TextBox txtWidthCavern;
        private System.Windows.Forms.Label lblHeightCavern;
        private System.Windows.Forms.TextBox txtHeightCavern;
        private System.Windows.Forms.Label lblResOpen;
        private System.Windows.Forms.Label lblResCavern;
        private System.Windows.Forms.Label lblShader;
        private System.Windows.Forms.FlowLayoutPanel flwShader;
        private System.Windows.Forms.RadioButton rbShaderBC;
        private System.Windows.Forms.RadioButton rbShaderNN;
        private System.Windows.Forms.FlowLayoutPanel flwExtended;
        private System.Windows.Forms.CheckBox cbExtChat;
        private System.Windows.Forms.CheckBox cbExtBlood;
        private System.Windows.Forms.Label lblHeadingExtended;
        private System.Windows.Forms.CheckBox cbExtBackflip;
    }
}

