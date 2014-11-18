using System;
using System.Windows.Forms;
using System.IO.Ports;
using CoreAudioApi;

namespace Csharp_SERIAL_KILLER_beta
{
    public partial class Form1 : Form
    {
        public normalControl normalControl = new normalControl();
        public soundControl soundControl = new soundControl();
        public breathingControl breathingControl = new breathingControl();
        public strobeControl strobeControl = new strobeControl();
        public tempControl tempControl = new tempControl();

        public static SerialPort uart = new SerialPort(); //commands:     ping ;  off ;   rgb r,g,b;  out,bit,0/1;    sta,;   man ;/help ;    
        public static bool connected = false;
        string s;

        ContextMenu cm = new ContextMenu();
        MenuItem open = new MenuItem("Open");
        MenuItem Leds = new MenuItem("Leds");
        MenuItem exit = new MenuItem("Exit");

        //gamma correction equation: 255 * ((color value) / 255) ^ gammaCorrection
        public static int[] gamma =   { 0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,
                                        0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  0,  1,  1,  1,  1,
                                        1,  1,  1,  1,  1,  1,  1,  1,  1,  2,  2,  2,  2,  2,  2,  2,
                                        2,  3,  3,  3,  3,  3,  3,  3,  4,  4,  4,  4,  4,  5,  5,  5,
                                        5,  6,  6,  6,  6,  7,  7,  7,  7,  8,  8,  8,  9,  9,  9,  10,
                                        10, 10, 11, 11, 11, 12, 12, 13, 13, 13, 14, 14, 15, 15, 16, 16,
                                        17, 17, 18, 18, 19, 19, 20, 20, 21, 21, 22, 22, 23, 24, 24, 25,
                                        25, 26, 27, 27, 28, 29, 29, 30, 31, 32, 32, 33, 34, 35, 35, 36,
                                        37, 38, 39, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 50,
                                        51, 52, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 66, 67, 68,
                                        69, 70, 72, 73, 74, 75, 77, 78, 79, 81, 82, 83, 85, 86, 87, 89,
                                        90, 92, 93, 95, 96, 98, 99,101,102,104,105,107,109,110,112,114,
                                        115,117,119,120,122,124,126,127,129,131,133,135,137,138,140,142,
                                        144,146,148,150,152,154,156,158,160,162,164,167,169,171,173,175,
                                        177,180,182,184,186,189,191,193,196,198,200,203,205,208,210,213,
                                        215,218,220,223,225,228,231,233,236,239,241,244,247,249,252,255 }; //gamma correction: 2.8

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            enableforms(false);
            baudBox.Text = "19200";
            foreach (string portname in SerialPort.GetPortNames())
            {
                portBox.Items.Add(portname);
                portBox.SelectedIndex = 0;
            }

            initMinimizeToTrayStuff();

        }
        private void openport_CheckedChanged(object sender, EventArgs e)
        {
            if (openport.Checked)
            {
                portBox.Enabled = false;
                baudBox.Enabled = false;
                openport.Text = "Close Port";

                try
                {
                    uart.PortName = portBox.Text;
                    uart.BaudRate = int.Parse(baudBox.Text);
                    uart.Open();
                    uart.Write("ping;");
                    s = uart.ReadTo("!");
                    if (s == "\n\r>pong")
                    {
                        MessageBox.Show("Connected to the SERIAL KILLER 3000!");
                        enableforms(true);
                        resetrgbled();
                        connected = true;
                    }
                    else
                    {
                        MessageBox.Show("Is the SERIAL KILLER 3000 connected in port " + uart.PortName + "?");
                        openport.Checked = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + '\n' + "Is the SERIAL KILLER 3000 connected in port " + uart.PortName + "?");
                    Application.Exit();
                }
            }
            else
            {
                uart.Close();
                enableforms(false);
                portBox.Enabled = true;
                baudBox.Enabled = true;
                openport.Text = "Open Port";
                connected = false;
            }
        }

        public void enableforms(bool b)
        {
            Leds.Enabled = b;
            //idleToolStripMenuItem1.Enabled = b;
            //resetToolStripMenuItem1.Enabled = b;
            btnNormal.Enabled = b;
            btnNormalPrefs.Enabled = b;
            btnRainbow.Enabled = b;
            //btnRainbowPrefs.Enabled = b;
            btnBreathing.Enabled = b;
            btnBreathingPrefs.Enabled = b;
            btnSound.Enabled = b;
            btnSoundPrefs.Enabled = b;
            btnStrobe.Enabled = b;
            btnStrobePrefs.Enabled = b;
            btnTemp.Enabled = b;
            btnTempPrefs.Enabled = b;
            onToolStripMenuItem.Enabled = b;                //normal mode
            offToolStripMenuItem.Enabled = b;               //normal mode
            preferencesToolStripMenuItem.Enabled = b;       //normal mode
            onToolStripMenuItem3.Enabled = b;              //rainbow mode
            offToolStripMenuItem3.Enabled = b;              //rainbow mode
            onToolStripMenuItem4.Enabled = b;              //breathing mode
            offToolStripMenuItem4.Enabled = b;              //breathing mode
            preferencesToolStripMenuItem3.Enabled = b;      //breathing mode
            onToolStripMenuItem1.Enabled = b;              //sound mode
            offToolStripMenuItem1.Enabled = b;             //sound mode
            preferencesToolStripMenuItem1.Enabled = b;      //sound mode
            onToolStripMenuItem2.Enabled = b;              //temperature mode
            offToolStripMenuItem2.Enabled = b;             //temperature mode
            preferencesToolStripMenuItem2.Enabled = b;      //temperature mode
            onToolStripMenuItem5.Enabled = b;               //flashing mode
            offToolStripMenuItem5.Enabled = b;              //flashing mode
            preferencesToolStripMenuItem4.Enabled = b;      //flashing mode
        }

        public static void resetrgbled()
        {
            uart.Write("off;");
        }

        #region minimize to tray stuff  //todo minimize menu stuff

        private void initMinimizeToTrayStuff()
        {
            open.Click += new System.EventHandler(this.open_Click);
            //Leds.Click += new System.EventHandler(this.LedsOn_Click);
            //Leds.Click += new System.EventHandler(this.LedsOff_Click);

            exit.Click += new System.EventHandler(this.exit_Click);

            cm.MenuItems.Add(open);
            cm.MenuItems.Add(Leds);
            cm.MenuItems.Add(exit);

            Leds.MenuItems.Add(new MenuItem("On"));
            Leds.MenuItems.Add(new MenuItem("Off"));




            taskbarIcon.Visible = false;
            taskbarIcon.ContextMenu = cm;
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.Hide();
                taskbarIcon.Visible = true;
                //taskbarIcon.BalloonTipText = "sup";
                //taskbarIcon.ShowBalloonTip(500);
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                taskbarIcon.Visible = false;
            }
        }
        private void taskbarIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            taskbarIcon.Visible = false;
        }
        private void open_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //private void LedsOn_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("derp");
        //}
        //private void LedsOff_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("derp");
        //}

        #endregion

        private void idleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            uart.Write("off;");
        }              //cmd off
        private void resetToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            uart.Write("rst;");
        }             //cmd rst
        private void commandListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\n\r>Hello and welcome to the SERIAL KILLER 3000 help menu!\n\n\r" +
            "\n\r>Available commands:" +
            "\n\r>off;\t\tIdle mode, all outputs go LOW, PWM to 0% duty cycle." +
            "\n\r>rst;\t\tSoft reset." +
            "\n\r>ping;\t\tThe SERIAL KILLER 3000 replies accordingly." +
            "\n\r>rgb r,g,b;\tRGB mode, acceptable values 0 - 255. \n\r\t\tMax load per chan: 3.5A(cont)/15A(pulsed)." +
            "\n\r>bit x,y;\t\tPort 1 GPIO control. x = pin number(0 - 7) y = pin state(0 - 1)\n\r\t\t[only bits 0 and 6 available on the Launchpad]." +
            "\n\r>sta;\t\tReturns Port 1 and Port 2 GPIO status (GUI only)." +
            "\n\r>man;/help ;\tPrints this screen.\n\n\r");
        }        //cmd list
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2bling4u");
        }              //about
        private void changelogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "\r•08/2014: beta3 - Semi-implemented sound mode (CoreAudio). Some UI changes." +
                "\r•05/2014: beta2 - Minor UI and stability improvements." +
                "\r•04/2014: beta1 - Main functionality achieved." +
                "\r•03/2014: Rewrote the entire core code for the uC, it now tokenizes and parses strings." +
                "\r•Early 2014: Rewrote in C#" +
                "\r•Even later: Minor improvements" +
                "\r•A bit later: It's alive!" +
                "\r•Winter 2013: Started the project in VB.net");
        }          //changelog 
        private void onToolStripMenuItem_Click(object sender, EventArgs e)
        {
            normalControl.normalMode = true;
            btnNormalPrefs.Enabled = true;
        }                 //normal on       MENU STRIP
        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {
            normalControl.normalMode = false;
        }                //normal off       MENU STRIP
        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            normalControl.ShowDialog();
        }        //normal prefs       MENU STRIP
        private void onToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            enableforms(false);
            offToolStripMenuItem3.Enabled = true;
            btnRainbow.Enabled = true;
            btnRainbow.Checked = true;
            //btnRainbowPrefs.Enabled = true;

            int r = 255, g = 0, b = 0;

            uart.Write("rgb " + 255 + "," + 0 + "," + 0 + ";");                 //r max 

            while (!onToolStripMenuItem3.Enabled)
            {
                for (g = 0; g < 255 && !onToolStripMenuItem3.Enabled; g++)                       //g to max
                {
                    uart.Write("rgb " + r + "," + gamma[g] + "," + b + ";");
                    Application.DoEvents();
                }
                for (r = 255; r >= 1 && !onToolStripMenuItem3.Enabled; r--)                       //r to 0
                {
                    uart.Write("rgb " + gamma[r] + "," + g + "," + b + ";");
                    Application.DoEvents();
                }
                for (b = 0; b < 255 && !onToolStripMenuItem3.Enabled; b++)                       //b to max
                {
                    uart.Write("rgb " + r + "," + g + "," + gamma[b] + ";");
                    Application.DoEvents();
                }
                for (g = 255; g >= 1 && !onToolStripMenuItem3.Enabled; g--)                       //g to 0
                {
                    uart.Write("rgb " + r + "," + gamma[g] + "," + b + ";");
                    Application.DoEvents();
                }
                for (r = 0; r < 255 && !onToolStripMenuItem3.Enabled; r++)                       //r to max
                {
                    uart.Write("rgb " + gamma[r] + "," + g + "," + b + ";");
                    Application.DoEvents();
                }
                for (b = 255; b >= 1 && !onToolStripMenuItem3.Enabled; b--)                       //b to 0
                {
                    uart.Write("rgb " + r + "," + g + "," + gamma[b] + ";");
                    Application.DoEvents();
                }
            }
        }                //rainbow on       MENU STRIP
        private void offToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            resetrgbled();
            enableforms(true);
            btnRainbow.Checked = false;
        }               //rainbow off       MENU STRIP
        private void onToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            breathingControl.breathingModeStart(this, null);

            enableforms(false);
            offToolStripMenuItem4.Enabled = true;
            preferencesToolStripMenuItem3.Enabled = true;
            btnBreathing.Enabled = true;
            btnBreathing.Checked = true;
            btnBreathingPrefs.Enabled = true;
        }                //breath on       MENU STRIP
        private void offToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            breathingControl.breathingModeStop(this, null);
            enableforms(true);
            btnBreathing.Checked = false;
        }               //breath off       MENU STRIP
        private void preferencesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            breathingControl.ShowDialog();
        }       //breath prefs       MENU STRIP
        private void onToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            soundControl.soundMode = true;
            soundControl.radioRed.Select();
            soundControl.soundModeStart(this, null);

            enableforms(false);
            offToolStripMenuItem1.Enabled = true;
            preferencesToolStripMenuItem1.Enabled = true;
            btnSound.Enabled = true;
            btnSound.Checked = true;
            btnSoundPrefs.Enabled = true;
        }                //sound on       MENU STRIP
        private void offToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            soundControl.soundMode = false;
            soundControl.soundModeStop(this, null);

            enableforms(true);
            btnSound.Checked = false;
        }               //sound off       MENU STRIP
        private void preferencesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            soundControl.ShowDialog();
        }       //sound prefs       MENU STRIP
        private void onToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            strobeControl.strobeMode = true;
            strobeControl.r = 255;
            strobeControl.strobeModeStart(this, null);

            enableforms(false);
            offToolStripMenuItem5.Enabled = true;
            preferencesToolStripMenuItem4.Enabled = true;
            btnStrobe.Enabled = true;
            btnStrobe.Checked = true;
            btnStrobePrefs.Enabled = true;
        }                //strobe on       MENU STRIP
        private void offToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            strobeControl.strobeMode = false;
            strobeControl.strobeModeStop(this, null);

            enableforms(true);
            btnStrobe.Checked = false;
        }               //strobe off       MENU STRIP
        private void preferencesToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            strobeControl.ShowDialog();
        }       //strobe prefs       MENU STRIP



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connected)
            {
                uart.Write("off;");
                uart.Close();
            }
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            if (breathingControl.breathingMode)
            {
                enableforms(false);
                offToolStripMenuItem4.Enabled = true;
            }
            else if (soundControl.soundMode)
            {
                enableforms(false);
                offToolStripMenuItem1.Enabled = true;
                preferencesToolStripMenuItem1.Enabled = true;
            }
        }

        private void btnNormal_CheckedChanged(object sender, EventArgs e)                       //normal BUTTON
        {
            if (btnNormal.Checked)
            {
                onToolStripMenuItem_Click(this, null);
            }
            else
            {
                offToolStripMenuItem_Click(this, null);
            }
        }
        private void btnNormalPrefs_Click(object sender, EventArgs e)                           //normal prefs BUTTON
        {
            normalControl.ShowDialog();
        }
        private void btnRainbow_CheckedChanged(object sender, EventArgs e)
        {
            if (btnRainbow.Checked)
            {
                onToolStripMenuItem3_Click(this, null);
            }
            else
            {
                offToolStripMenuItem3_Click(this, null);
            }
        }                   //rainbow BUTTON
        private void btnBreathing_CheckedChanged(object sender, EventArgs e)
        {
            if (btnBreathing.Checked)
            {
                onToolStripMenuItem4_Click(this, null);
            }
            else
            {
                offToolStripMenuItem4_Click(this, null);
            }
        }                   //breathing BUTTON
        private void btnBreathingPrefs_Click(object sender, EventArgs e)
        {
            breathingControl.ShowDialog();
        }                   //breathing prefs BUTTON
        private void btnSound_CheckedChanged(object sender, EventArgs e)
        {
            if (btnSound.Checked)
            {
                onToolStripMenuItem1_Click(this, null);
            }
            else
            {
                offToolStripMenuItem1_Click(this, null);
            }
        }                   //sound BUTTON
        private void btnSoundPrefs_Click(object sender, EventArgs e)
        {
            soundControl.ShowDialog();
        }                   //sound prefs  BUTTON
        private void btnTemp_CheckedChanged(object sender, EventArgs e)
        {

        }                     //temp  BUTTON
        private void btnTempPrefs_Click(object sender, EventArgs e)
        {
            tempControl.ShowDialog();
        }                           //temp prefs  BUTTON
        private void btnStrobe_CheckedChanged(object sender, EventArgs e)
        {
            if (btnStrobe.Checked)
            {
                onToolStripMenuItem5_Click(this, null);
            }
            else
            {
                offToolStripMenuItem5_Click(this, null);
            }
        }                    //strobe  BUTTON
        private void btnStrobePrefs_Click(object sender, EventArgs e)
        {
            strobeControl.ShowDialog();
        }                       //strobe prefs  BUTTON

    }
}