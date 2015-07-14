namespace Csharp_SERIAL_KILLER_beta
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openport = new System.Windows.Forms.CheckBox();
            this.portBox = new System.Windows.Forms.ComboBox();
            this.taskbarIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.baudBox = new System.Windows.Forms.NumericUpDown();
            this.btnNormal = new System.Windows.Forms.CheckBox();
            this.btnRainbow = new System.Windows.Forms.CheckBox();
            this.btnBreathing = new System.Windows.Forms.CheckBox();
            this.btnSound = new System.Windows.Forms.CheckBox();
            this.btnStrobe = new System.Windows.Forms.CheckBox();
            this.btnTemp = new System.Windows.Forms.CheckBox();
            this.btnTempPrefs = new System.Windows.Forms.Button();
            this.btnStrobePrefs = new System.Windows.Forms.Button();
            this.btnSoundPrefs = new System.Windows.Forms.Button();
            this.btnBreathingPrefs = new System.Windows.Forms.Button();
            this.btnRainbowPrefs = new System.Windows.Forms.Button();
            this.btnNormalPrefs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rainbowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.breathingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.flashToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.soundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.offToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.preferencesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.commandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.commandListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baudBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openport
            // 
            this.openport.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.openport.Appearance = System.Windows.Forms.Appearance.Button;
            this.openport.AutoSize = true;
            this.openport.Location = new System.Drawing.Point(195, 357);
            this.openport.Name = "openport";
            this.openport.Size = new System.Drawing.Size(65, 23);
            this.openport.TabIndex = 0;
            this.openport.Text = "Open Port";
            this.openport.UseVisualStyleBackColor = true;
            this.openport.CheckedChanged += new System.EventHandler(this.openport_CheckedChanged);
            // 
            // portBox
            // 
            this.portBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.portBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.portBox.FormattingEnabled = true;
            this.portBox.Location = new System.Drawing.Point(33, 359);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(75, 21);
            this.portBox.TabIndex = 61;
            // 
            // taskbarIcon
            // 
            this.taskbarIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("taskbarIcon.Icon")));
            this.taskbarIcon.Text = "Serial Killer";
            this.taskbarIcon.Visible = true;
            this.taskbarIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.taskbarIcon_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.commandsToolStripMenuItem,
            this.modeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 87;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // baudBox
            // 
            this.baudBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.baudBox.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.baudBox.Location = new System.Drawing.Point(114, 359);
            this.baudBox.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.baudBox.Name = "baudBox";
            this.baudBox.Size = new System.Drawing.Size(75, 21);
            this.baudBox.TabIndex = 62;
            this.baudBox.Value = new decimal(new int[] {
            19200,
            0,
            0,
            0});
            // 
            // btnNormal
            // 
            this.btnNormal.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnNormal.Location = new System.Drawing.Point(54, 66);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(89, 46);
            this.btnNormal.TabIndex = 88;
            this.btnNormal.Text = "Normal ";
            this.btnNormal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.CheckedChanged += new System.EventHandler(this.btnNormal_CheckedChanged);
            // 
            // btnRainbow
            // 
            this.btnRainbow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRainbow.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnRainbow.Location = new System.Drawing.Point(149, 66);
            this.btnRainbow.Name = "btnRainbow";
            this.btnRainbow.Size = new System.Drawing.Size(89, 46);
            this.btnRainbow.TabIndex = 89;
            this.btnRainbow.Text = "Rainbow ";
            this.btnRainbow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRainbow.UseVisualStyleBackColor = true;
            this.btnRainbow.CheckedChanged += new System.EventHandler(this.btnRainbow_CheckedChanged);
            // 
            // btnBreathing
            // 
            this.btnBreathing.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnBreathing.Location = new System.Drawing.Point(54, 118);
            this.btnBreathing.Name = "btnBreathing";
            this.btnBreathing.Size = new System.Drawing.Size(89, 46);
            this.btnBreathing.TabIndex = 90;
            this.btnBreathing.Text = "Breathing";
            this.btnBreathing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBreathing.UseVisualStyleBackColor = true;
            this.btnBreathing.CheckedChanged += new System.EventHandler(this.btnBreathing_CheckedChanged);
            // 
            // btnSound
            // 
            this.btnSound.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnSound.Location = new System.Drawing.Point(54, 170);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(89, 46);
            this.btnSound.TabIndex = 91;
            this.btnSound.Text = "Sound";
            this.btnSound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSound.UseVisualStyleBackColor = true;
            this.btnSound.CheckedChanged += new System.EventHandler(this.btnSound_CheckedChanged);
            // 
            // btnStrobe
            // 
            this.btnStrobe.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnStrobe.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnStrobe.Location = new System.Drawing.Point(149, 170);
            this.btnStrobe.Name = "btnStrobe";
            this.btnStrobe.Size = new System.Drawing.Size(89, 46);
            this.btnStrobe.TabIndex = 92;
            this.btnStrobe.Text = "Strobe";
            this.btnStrobe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStrobe.UseVisualStyleBackColor = true;
            this.btnStrobe.CheckedChanged += new System.EventHandler(this.btnStrobe_CheckedChanged);
            // 
            // btnTemp
            // 
            this.btnTemp.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTemp.Appearance = System.Windows.Forms.Appearance.Button;
            this.btnTemp.Location = new System.Drawing.Point(149, 222);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(89, 46);
            this.btnTemp.TabIndex = 93;
            this.btnTemp.Text = "Temperature";
            this.btnTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTemp.UseVisualStyleBackColor = true;
            this.btnTemp.CheckedChanged += new System.EventHandler(this.btnTemp_CheckedChanged);
            // 
            // btnTempPrefs
            // 
            this.btnTempPrefs.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnTempPrefs.Image = global::Csharp_SERIAL_KILLER_beta.Properties.Resources.gear;
            this.btnTempPrefs.Location = new System.Drawing.Point(237, 222);
            this.btnTempPrefs.Name = "btnTempPrefs";
            this.btnTempPrefs.Size = new System.Drawing.Size(28, 46);
            this.btnTempPrefs.TabIndex = 99;
            this.btnTempPrefs.UseVisualStyleBackColor = true;
            this.btnTempPrefs.Click += new System.EventHandler(this.btnTempPrefs_Click);
            // 
            // btnStrobePrefs
            // 
            this.btnStrobePrefs.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnStrobePrefs.Image = global::Csharp_SERIAL_KILLER_beta.Properties.Resources.gear;
            this.btnStrobePrefs.Location = new System.Drawing.Point(237, 170);
            this.btnStrobePrefs.Name = "btnStrobePrefs";
            this.btnStrobePrefs.Size = new System.Drawing.Size(28, 46);
            this.btnStrobePrefs.TabIndex = 98;
            this.btnStrobePrefs.UseVisualStyleBackColor = true;
            this.btnStrobePrefs.Click += new System.EventHandler(this.btnStrobePrefs_Click);
            // 
            // btnSoundPrefs
            // 
            this.btnSoundPrefs.Image = global::Csharp_SERIAL_KILLER_beta.Properties.Resources.gear;
            this.btnSoundPrefs.Location = new System.Drawing.Point(27, 170);
            this.btnSoundPrefs.Name = "btnSoundPrefs";
            this.btnSoundPrefs.Size = new System.Drawing.Size(28, 46);
            this.btnSoundPrefs.TabIndex = 97;
            this.btnSoundPrefs.UseVisualStyleBackColor = true;
            this.btnSoundPrefs.Click += new System.EventHandler(this.btnSoundPrefs_Click);
            // 
            // btnBreathingPrefs
            // 
            this.btnBreathingPrefs.Image = global::Csharp_SERIAL_KILLER_beta.Properties.Resources.gear;
            this.btnBreathingPrefs.Location = new System.Drawing.Point(27, 118);
            this.btnBreathingPrefs.Name = "btnBreathingPrefs";
            this.btnBreathingPrefs.Size = new System.Drawing.Size(28, 46);
            this.btnBreathingPrefs.TabIndex = 96;
            this.btnBreathingPrefs.UseVisualStyleBackColor = true;
            this.btnBreathingPrefs.Click += new System.EventHandler(this.btnBreathingPrefs_Click);
            // 
            // btnRainbowPrefs
            // 
            this.btnRainbowPrefs.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRainbowPrefs.Enabled = false;
            this.btnRainbowPrefs.Image = global::Csharp_SERIAL_KILLER_beta.Properties.Resources.gear;
            this.btnRainbowPrefs.Location = new System.Drawing.Point(237, 66);
            this.btnRainbowPrefs.Name = "btnRainbowPrefs";
            this.btnRainbowPrefs.Size = new System.Drawing.Size(28, 46);
            this.btnRainbowPrefs.TabIndex = 95;
            this.btnRainbowPrefs.UseVisualStyleBackColor = true;
            // 
            // btnNormalPrefs
            // 
            this.btnNormalPrefs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNormalPrefs.Image = global::Csharp_SERIAL_KILLER_beta.Properties.Resources.gear;
            this.btnNormalPrefs.Location = new System.Drawing.Point(27, 66);
            this.btnNormalPrefs.Name = "btnNormalPrefs";
            this.btnNormalPrefs.Size = new System.Drawing.Size(28, 46);
            this.btnNormalPrefs.TabIndex = 94;
            this.btnNormalPrefs.UseVisualStyleBackColor = true;
            this.btnNormalPrefs.Click += new System.EventHandler(this.btnNormalPrefs_Click);
            // 
            // button1
            // 
            this.button1.Image = global::Csharp_SERIAL_KILLER_beta.Properties.Resources.gear;
            this.button1.Location = new System.Drawing.Point(27, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 46);
            this.button1.TabIndex = 101;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.Location = new System.Drawing.Point(54, 222);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(89, 46);
            this.checkBox1.TabIndex = 100;
            this.checkBox1.Text = "SOON(TM)";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button2.Image = global::Csharp_SERIAL_KILLER_beta.Properties.Resources.gear;
            this.button2.Location = new System.Drawing.Point(237, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 46);
            this.button2.TabIndex = 103;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox2.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox2.Location = new System.Drawing.Point(149, 274);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(89, 46);
            this.checkBox2.TabIndex = 102;
            this.checkBox2.Text = "SOON(TM)";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button3.Image = global::Csharp_SERIAL_KILLER_beta.Properties.Resources.gear;
            this.button3.Location = new System.Drawing.Point(237, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 46);
            this.button3.TabIndex = 105;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBox3.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox3.Location = new System.Drawing.Point(149, 118);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(89, 46);
            this.checkBox3.TabIndex = 104;
            this.checkBox3.Text = " Dual Breathing";
            this.checkBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Image = global::Csharp_SERIAL_KILLER_beta.Properties.Resources.gear;
            this.button4.Location = new System.Drawing.Point(27, 274);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 46);
            this.button4.TabIndex = 107;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox4.Location = new System.Drawing.Point(54, 274);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(89, 46);
            this.checkBox4.TabIndex = 106;
            this.checkBox4.Text = "SOON(TM)";
            this.checkBox4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // changelogToolStripMenuItem
            // 
            this.changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
            this.changelogToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.changelogToolStripMenuItem.Text = "Changelog";
            this.changelogToolStripMenuItem.Click += new System.EventHandler(this.changelogToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.modeToolStripMenuItem.Text = "&Mode";
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.normalToolStripMenuItem.Text = "&Normal";
            // 
            // onToolStripMenuItem
            // 
            this.onToolStripMenuItem.Name = "onToolStripMenuItem";
            this.onToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.onToolStripMenuItem.Text = "&On";
            this.onToolStripMenuItem.Click += new System.EventHandler(this.onToolStripMenuItem_Click);
            // 
            // offToolStripMenuItem
            // 
            this.offToolStripMenuItem.Name = "offToolStripMenuItem";
            this.offToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.offToolStripMenuItem.Text = "&Off";
            this.offToolStripMenuItem.Click += new System.EventHandler(this.offToolStripMenuItem_Click);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem.Text = "&Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // rainbowToolStripMenuItem
            // 
            this.rainbowToolStripMenuItem.Name = "rainbowToolStripMenuItem";
            this.rainbowToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.rainbowToolStripMenuItem.Text = "&Rainbow";
            // 
            // onToolStripMenuItem3
            // 
            this.onToolStripMenuItem3.Name = "onToolStripMenuItem3";
            this.onToolStripMenuItem3.Size = new System.Drawing.Size(91, 22);
            this.onToolStripMenuItem3.Text = "&On";
            this.onToolStripMenuItem3.Click += new System.EventHandler(this.onToolStripMenuItem3_Click);
            // 
            // offToolStripMenuItem3
            // 
            this.offToolStripMenuItem3.Name = "offToolStripMenuItem3";
            this.offToolStripMenuItem3.Size = new System.Drawing.Size(91, 22);
            this.offToolStripMenuItem3.Text = "&Off";
            this.offToolStripMenuItem3.Click += new System.EventHandler(this.offToolStripMenuItem3_Click);
            // 
            // breathingToolStripMenuItem
            // 
            this.breathingToolStripMenuItem.Name = "breathingToolStripMenuItem";
            this.breathingToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.breathingToolStripMenuItem.Text = "&Breathing";
            // 
            // onToolStripMenuItem4
            // 
            this.onToolStripMenuItem4.Name = "onToolStripMenuItem4";
            this.onToolStripMenuItem4.Size = new System.Drawing.Size(135, 22);
            this.onToolStripMenuItem4.Text = "&On";
            this.onToolStripMenuItem4.Click += new System.EventHandler(this.onToolStripMenuItem4_Click);
            // 
            // offToolStripMenuItem4
            // 
            this.offToolStripMenuItem4.Name = "offToolStripMenuItem4";
            this.offToolStripMenuItem4.Size = new System.Drawing.Size(135, 22);
            this.offToolStripMenuItem4.Text = "&Off";
            this.offToolStripMenuItem4.Click += new System.EventHandler(this.offToolStripMenuItem4_Click);
            // 
            // preferencesToolStripMenuItem3
            // 
            this.preferencesToolStripMenuItem3.Name = "preferencesToolStripMenuItem3";
            this.preferencesToolStripMenuItem3.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem3.Text = "&Preferences";
            this.preferencesToolStripMenuItem3.Click += new System.EventHandler(this.preferencesToolStripMenuItem3_Click);
            // 
            // flashToolStripMenuItem
            // 
            this.flashToolStripMenuItem.Name = "flashToolStripMenuItem";
            this.flashToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.flashToolStripMenuItem.Text = "Str&obe";
            // 
            // onToolStripMenuItem5
            // 
            this.onToolStripMenuItem5.Name = "onToolStripMenuItem5";
            this.onToolStripMenuItem5.Size = new System.Drawing.Size(135, 22);
            this.onToolStripMenuItem5.Text = "&On";
            this.onToolStripMenuItem5.Click += new System.EventHandler(this.onToolStripMenuItem5_Click);
            // 
            // offToolStripMenuItem5
            // 
            this.offToolStripMenuItem5.Name = "offToolStripMenuItem5";
            this.offToolStripMenuItem5.Size = new System.Drawing.Size(135, 22);
            this.offToolStripMenuItem5.Text = "&Off";
            this.offToolStripMenuItem5.Click += new System.EventHandler(this.offToolStripMenuItem5_Click);
            // 
            // preferencesToolStripMenuItem4
            // 
            this.preferencesToolStripMenuItem4.Name = "preferencesToolStripMenuItem4";
            this.preferencesToolStripMenuItem4.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem4.Text = "&Preferences";
            this.preferencesToolStripMenuItem4.Click += new System.EventHandler(this.preferencesToolStripMenuItem4_Click);
            // 
            // temperatureToolStripMenuItem
            // 
            this.temperatureToolStripMenuItem.Name = "temperatureToolStripMenuItem";
            this.temperatureToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.temperatureToolStripMenuItem.Text = "&Temperature";
            // 
            // onToolStripMenuItem2
            // 
            this.onToolStripMenuItem2.Name = "onToolStripMenuItem2";
            this.onToolStripMenuItem2.Size = new System.Drawing.Size(135, 22);
            this.onToolStripMenuItem2.Text = "&On";
            // 
            // offToolStripMenuItem2
            // 
            this.offToolStripMenuItem2.Name = "offToolStripMenuItem2";
            this.offToolStripMenuItem2.Size = new System.Drawing.Size(135, 22);
            this.offToolStripMenuItem2.Text = "&Off";
            // 
            // preferencesToolStripMenuItem2
            // 
            this.preferencesToolStripMenuItem2.Name = "preferencesToolStripMenuItem2";
            this.preferencesToolStripMenuItem2.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem2.Text = "&Preferences";
            // 
            // soundToolStripMenuItem
            // 
            this.soundToolStripMenuItem.Name = "soundToolStripMenuItem";
            this.soundToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.soundToolStripMenuItem.Text = "&Sound";
            // 
            // onToolStripMenuItem1
            // 
            this.onToolStripMenuItem1.Name = "onToolStripMenuItem1";
            this.onToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.onToolStripMenuItem1.Text = "&On";
            this.onToolStripMenuItem1.Click += new System.EventHandler(this.onToolStripMenuItem1_Click);
            // 
            // offToolStripMenuItem1
            // 
            this.offToolStripMenuItem1.Name = "offToolStripMenuItem1";
            this.offToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.offToolStripMenuItem1.Text = "&Off";
            this.offToolStripMenuItem1.Click += new System.EventHandler(this.offToolStripMenuItem1_Click);
            // 
            // preferencesToolStripMenuItem1
            // 
            this.preferencesToolStripMenuItem1.Name = "preferencesToolStripMenuItem1";
            this.preferencesToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.preferencesToolStripMenuItem1.Text = "&Preferences";
            this.preferencesToolStripMenuItem1.Click += new System.EventHandler(this.preferencesToolStripMenuItem1_Click);
            // 
            // commandsToolStripMenuItem
            // 
            this.commandsToolStripMenuItem.Name = "commandsToolStripMenuItem";
            this.commandsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.commandsToolStripMenuItem.Text = "&Commands";
            // 
            // idleToolStripMenuItem1
            // 
            this.idleToolStripMenuItem1.Name = "idleToolStripMenuItem1";
            this.idleToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.idleToolStripMenuItem1.Text = "&Idle";
            this.idleToolStripMenuItem1.Click += new System.EventHandler(this.idleToolStripMenuItem1_Click);
            // 
            // resetToolStripMenuItem1
            // 
            this.resetToolStripMenuItem1.Name = "resetToolStripMenuItem1";
            this.resetToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.resetToolStripMenuItem1.Text = "&Reset";
            this.resetToolStripMenuItem1.Click += new System.EventHandler(this.resetToolStripMenuItem1_Click);
            // 
            // commandListToolStripMenuItem
            // 
            this.commandListToolStripMenuItem.Name = "commandListToolStripMenuItem";
            this.commandListToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.commandListToolStripMenuItem.Text = "&Command list";
            this.commandListToolStripMenuItem.Click += new System.EventHandler(this.commandListToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "&Window";
            // 
            // minimizeToolStripMenuItem
            // 
            this.minimizeToolStripMenuItem.Name = "minimizeToolStripMenuItem";
            this.minimizeToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.minimizeToolStripMenuItem.Text = "&Minimize";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(292, 386);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnTempPrefs);
            this.Controls.Add(this.btnStrobePrefs);
            this.Controls.Add(this.btnSoundPrefs);
            this.Controls.Add(this.btnBreathingPrefs);
            this.Controls.Add(this.btnRainbowPrefs);
            this.Controls.Add(this.btnNormalPrefs);
            this.Controls.Add(this.btnTemp);
            this.Controls.Add(this.btnStrobe);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.btnBreathing);
            this.Controls.Add(this.btnRainbow);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.openport);
            this.Controls.Add(this.portBox);
            this.Controls.Add(this.baudBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SERIAL KILLER beta3";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.baudBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.CheckBox openport;
        private System.Windows.Forms.ComboBox portBox;
        private System.Windows.Forms.NotifyIcon taskbarIcon;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.NumericUpDown baudBox;
        private System.Windows.Forms.CheckBox btnNormal;
        private System.Windows.Forms.CheckBox btnRainbow;
        private System.Windows.Forms.CheckBox btnBreathing;
        private System.Windows.Forms.CheckBox btnSound;
        private System.Windows.Forms.CheckBox btnStrobe;
        private System.Windows.Forms.CheckBox btnTemp;
        private System.Windows.Forms.Button btnNormalPrefs;
        private System.Windows.Forms.Button btnRainbowPrefs;
        private System.Windows.Forms.Button btnBreathingPrefs;
        private System.Windows.Forms.Button btnSoundPrefs;
        private System.Windows.Forms.Button btnStrobePrefs;
        private System.Windows.Forms.Button btnTempPrefs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changelogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rainbowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem breathingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem flashToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem temperatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem soundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem offToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem idleToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem commandListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

    }
}

