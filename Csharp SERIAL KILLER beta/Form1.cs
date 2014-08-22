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

        MMDeviceEnumerator DevEnum = new MMDeviceEnumerator();
        MMDevice device;

        public static SerialPort uart = new SerialPort(); //commands:     ping ;  off ;   rgb r,g,b;  out,bit,0/1;    sta,;   man ;/help ;    
        int r, g, b;
        int port1, port2;
        bool flag = true;
        public static bool connected = false;
        string s;

        ContextMenu cm = new ContextMenu();
        MenuItem open = new MenuItem("Open");
        MenuItem Leds = new MenuItem("Leds");
        MenuItem exit = new MenuItem("Exit");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            device = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia);

            enableforms(false);
            baudBox.Text = "9600";
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
                        resetnumbers();
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
            resetsliders.Enabled = b;
            btnRfr.Enabled = b;
            redupdown.Enabled = b;
            greenupdown.Enabled = b;
            blueupdown.Enabled = b;
            btnPorts.Enabled = b;
            colorpick.Enabled = b;
            resetled.Enabled = b;
            redbar.Enabled = b;
            bluebar.Enabled = b;
            greenbar.Enabled = b;
            rled.Enabled = b;
            gled.Enabled = b;
            bleds.Enabled = b;
            Leds.Enabled = b;
            idleToolStripMenuItem1.Enabled = b;
            resetToolStripMenuItem1.Enabled = b;
            onToolStripMenuItem.Enabled = b;                //normal mode
            offToolStripMenuItem.Enabled = b;               //normal mode
            preferencesToolStripMenuItem.Enabled = b;       //normal mode
            onToolStripMenuItem1.Enabled = b;              //sound mode
            offToolStripMenuItem1.Enabled = b;             //sound mode
            preferencesToolStripMenuItem1.Enabled = b;      //sound mode
            onToolStripMenuItem2.Enabled = b;              //temperature mode
            offToolStripMenuItem2.Enabled = b;             //temperature mode
            preferencesToolStripMenuItem2.Enabled = b;      //temperature mode
            onToolStripMenuItem3.Enabled = b;              //rainbow mode
            offToolStripMenuItem3.Enabled = b;              //rainbow mode
            onToolStripMenuItem4.Enabled = b;              //breathing mode
            offToolStripMenuItem4.Enabled = b;              //breathing mode
            preferencesToolStripMenuItem3.Enabled = b;      //breathing mode
        }
        private void resetnumbers()
        {
            r = 0;
            g = 0;
            b = 0;
            redbar.Value = 0;
            greenbar.Value = 0;
            bluebar.Value = 0;
            redupdown.Value = 0;
            greenupdown.Value = 0;
            blueupdown.Value = 0;
        }
        private void btntopmost_CheckedChanged(object sender, EventArgs e)
        {
            TopMost = btntopmost.Checked;
        }
        private void resetsliders_Click(object sender, EventArgs e)
        {
            redbar.Value = 0;
            greenbar.Value = 0;
            bluebar.Value = 0;
            redupdown.Value = 0;
            greenupdown.Value = 0;
            blueupdown.Value = 0;
        }

        private void rled_CheckedChanged(object sender, EventArgs e)
        {
            if (rled.Checked)
                uart.Write("bit " + 0 + "," + 1 + ";");
            else
                uart.Write("bit " + 0 + "," + 0 + ";");
        }
        private void gled_CheckedChanged(object sender, EventArgs e)
        {
            if (gled.Checked)
                uart.Write("bit " + 6 + "," + 1 + ";");
            else
                uart.Write("bit " + 6 + "," + 0 + ";");
        }
        private void bleds_Click(object sender, EventArgs e)
        {
            flag = !flag;

            if (flag)
            {
                uart.Write("bit " + 0 + "," + 1 + ";");
                uart.Write("bit " + 6 + "," + 1 + ";");
            }
            else
            {
                uart.Write("bit " + 0 + "," + 0 + ";");
                uart.Write("bit " + 6 + "," + 0 + ";");
            }
        }

        private void resetled_Click(object sender, EventArgs e)
        {
            resetrgbled();
        }
        private void resetrgbled()
        {
            uart.Write("rgb " + 0 + "," + 0 + "," + 0 + ";");
        }
        private void portstatus()
        {
            uart.Write("sta;");

            if (uart.BytesToRead == 2)
                port1 = uart.ReadByte();
            port2 = uart.ReadByte();

            //b1.Enabled = true;  b1.Text = Convert.ToString(port1, 2); //debugging
            //b2.Enabled = true;  b2.Text = Convert.ToString(port2, 2); //debugging

            txtPort1.Clear();
            txtPort2.Clear();

            txtPort1.Text = GetIntBinaryString(port1);
            txtPort2.Text = GetIntBinaryString(port2);
        }
        private void btnPorts_Click(object sender, EventArgs e)
        {
            if (btnPorts.Text == "Port status")
            {
                this.Width = this.Size.Width + panel1.Size.Width;
                panel1.Show();
                portstatus();
                btnPorts.Text = "Close";
            }
            else
            {
                this.Width = this.Size.Width - panel1.Size.Width;
                btnPorts.Text = "Port status";
            }
        }
        private void btnRfr_Click(object sender, EventArgs e)
        {
            portstatus();
        }
        string GetIntBinaryString(int n)
        {
            string b = ""; //must initialize string
            int pos = 7;
            int i = 0;

            while (i < 8)
            {
                if ((n & (1 << i)) != 0)
                {
                    b += "1        ";
                }
                else
                {
                    b += "0        ";
                }
                pos--;
                i++;
            }
            return b;
        }

        private void colorpick_Click(object sender, EventArgs e)
        {
            ColorDialog.ShowDialog();
            r = ColorDialog.Color.R;
            g = ColorDialog.Color.G;
            b = ColorDialog.Color.B;
            redupdown.Value = r;
            greenupdown.Value = g;
            blueupdown.Value = b;
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

        #region bars and numbers

        private void redbar_Scroll(object sender, EventArgs e)
        {
            redupdown.Value = redbar.Value;
            r = redbar.Value;
            uart.Write("rgb " + r + "," + g + "," + b + ";");
        }
        private void greenbar_Scroll(object sender, EventArgs e)
        {
            greenupdown.Value = greenbar.Value;
            g = greenbar.Value;
            uart.Write("rgb " + r + "," + g + "," + b + ";");
        }
        private void bluebar_Scroll(object sender, EventArgs e)
        {
            blueupdown.Value = bluebar.Value;
            b = bluebar.Value;
            uart.Write("rgb " + r + "," + g + "," + b + ";");
        }
        private void redupdown_ValueChanged(object sender, EventArgs e)
        {
            redbar.Value = int.Parse(redupdown.Value.ToString());
            r = int.Parse(redupdown.Value.ToString());
            uart.Write("rgb " + r + "," + g + "," + b + ";");
        }
        private void greenupdown_ValueChanged(object sender, EventArgs e)
        {
            greenbar.Value = int.Parse(greenupdown.Value.ToString());
            g = int.Parse(greenupdown.Value.ToString());
            uart.Write("rgb " + r + "," + g + "," + b + ";");
        }
        private void blueupdown_ValueChanged(object sender, EventArgs e)
        {
            bluebar.Value = int.Parse(blueupdown.Value.ToString());
            b = int.Parse(blueupdown.Value.ToString());
            uart.Write("rgb " + r + "," + g + "," + b + ";");
        }

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
        private void onToolStripMenuItem_Click(object sender, EventArgs e)                    //normal on
        {

        }
        private void offToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }               //normal off
        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            normalControl.ShowDialog();
        }        //normal prefs
        private void onToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            enableforms(false);
            offToolStripMenuItem3.Enabled = true;

            uart.Write("rgb " + 255 + "," + 0 + "," + 0 + ";");                 //r max 
            r = 255; g = 0; b = 0;

            while (!onToolStripMenuItem3.Enabled)
            {
                for (g = 0; g <= 254 && !onToolStripMenuItem3.Enabled; g++)                       //g to max
                {
                    uart.Write("rgb " + r + "," + g + "," + b + ";");
                    Application.DoEvents();
                }
                for (r = 255; r >= 1 && !onToolStripMenuItem3.Enabled; r--)                       //r to 0
                {
                    uart.Write("rgb " + r + "," + g + "," + b + ";");
                    Application.DoEvents();
                }
                for (b = 0; b <= 254 && !onToolStripMenuItem3.Enabled; b++)                       //b to max
                {
                    uart.Write("rgb " + r + "," + g + "," + b + ";");
                    Application.DoEvents();
                }
                for (g = 255; g >= 1 && !onToolStripMenuItem3.Enabled; g--)                       //g to 0
                {
                    uart.Write("rgb " + r + "," + g + "," + b + ";");
                    Application.DoEvents();
                }
                for (r = 0; r <= 254 && !onToolStripMenuItem3.Enabled; r++)                       //r to max
                {
                    uart.Write("rgb " + r + "," + g + "," + b + ";");
                    Application.DoEvents();
                }
                for (b = 255; b >= 1 && !onToolStripMenuItem3.Enabled; b--)                       //b to 0
                {
                    uart.Write("rgb " + r + "," + g + "," + b + ";");
                    Application.DoEvents();
                }
            }
        }                //rainbow on
        private void offToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            resetrgbled();
            enableforms(true);
        }               //rainbow off
        private void onToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            breathingControl.breathingModeStart(this, null);
            enableforms(false);
            offToolStripMenuItem4.Enabled = true;
        }                //breath on
        private void offToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            breathingControl.breathingModeStop(this, null);
            enableforms(true);
        }               //breath off
        private void preferencesToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            breathingControl.ShowDialog();
        }       //breath prefs
        private void onToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            soundControl.soundMode = true;
            soundControl.radioRed.Select();
            soundControl.soundModeStart(this, null);

            enableforms(false);
            offToolStripMenuItem1.Enabled = true;
        }                //sound on
        private void offToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            soundControl.soundMode = false;
            soundControl.soundModeStop(this, null);

            enableforms(true);
        }               //sound off
        private void preferencesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            soundControl.ShowDialog();
        }       //sound prefs

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
            }
        }


    }
}
