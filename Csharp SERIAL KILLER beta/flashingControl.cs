﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_SERIAL_KILLER_beta
{
    public partial class flashingControl : Form
    {
        public flashingControl()
        {
            InitializeComponent();
        }

        public static int r = 0, g = 0, b = 0;
        public static bool flashMode = false;
        bool on = false;

        private void flashingControl_Load(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
            label2.Text = (trackBar1.Value * 10 + "ms").ToString();

            redbar.Value = r;
            redupdown.Value = r;
            greenbar.Value = g;
            greenupdown.Value = g;
            bluebar.Value = b;
            blueupdown.Value = b;
        }

        #region bars and number stuff

        private void redbar_Scroll(object sender, EventArgs e)
        {
            redupdown.Value = redbar.Value;
            r = redbar.Value;
        }
        private void greenbar_Scroll(object sender, EventArgs e)
        {
            greenupdown.Value = greenbar.Value;
            g = greenbar.Value;
        }
        private void bluebar_Scroll(object sender, EventArgs e)
        {
            blueupdown.Value = bluebar.Value;
            b = bluebar.Value;
        }
        private void redupdown_ValueChanged(object sender, EventArgs e)
        {
            redbar.Value = int.Parse(redupdown.Value.ToString());
            r = int.Parse(redupdown.Value.ToString());
        }
        private void greenupdown_ValueChanged(object sender, EventArgs e)
        {
            greenbar.Value = int.Parse(greenupdown.Value.ToString());
            g = int.Parse(greenupdown.Value.ToString());
        }
        private void blueupdown_ValueChanged(object sender, EventArgs e)
        {
            bluebar.Value = int.Parse(blueupdown.Value.ToString());
            b = int.Parse(blueupdown.Value.ToString());
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            r = (int)colorDialog1.Color.R;
            g = (int)colorDialog1.Color.G;
            b = (int)colorDialog1.Color.B;

            redupdown.Value = r;
            greenupdown.Value = g;
            blueupdown.Value = b;
        }


        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = trackBar1.Value * 10;
            label2.Text = (trackBar1.Value * 10 + "ms").ToString();
        }
        
        public void flashModeStart(object sender, EventArgs e)
        {
            flashMode = true;

            timer1.Start();
        }
        public void flashModeStop(object sender, EventArgs e)
        {
            flashMode = false;

            timer1.Stop();
            Form1.uart.Write("off;");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Form1.connected && flashMode) 
            { 
                if (!on)
                {
                    Form1.uart.Write("rgb " + r + "," + g + "," + b + ";");
                    on = !on;
                }
                else
                {
                    Form1.uart.Write("rgb " + 0 + "," + 0 + "," + 0 + ";");
                    on = !on;
                }
            }
        }

    }
}
