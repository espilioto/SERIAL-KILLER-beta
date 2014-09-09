using System;
using System.Windows.Forms;


namespace Csharp_SERIAL_KILLER_beta
{
    public partial class breathingControl : Form
    {
        public breathingControl()
        {
            InitializeComponent();
        }

        public static bool breathingMode = false;
        bool rising;
        int pwm = 0;

        private void breathingControl_Load(object sender, EventArgs e)
        {
            breathRed.Select();

            timerPWM.Interval = 20;
        }

        private void timerPWM_Tick(object sender, EventArgs e)
        {

            if (Form1.connected && breathingMode)
            {

                if (pwm < 15)        //this looks better than turning the led off
                    rising = true;
                else if (pwm > 179)
                    rising = false;

                if (pwm < 180 && rising)
                    if (trackBar1.Value == 1)
                    {
                        pwm++;
                    }
                    else if (trackBar1.Value == 2)
                    {
                        pwm += 2;
                    }
                    else if (trackBar1.Value == 3)
                    {
                        pwm += 3;
                    }
                    else if (trackBar1.Value == 4)
                    {
                        pwm += 4;
                    }
                    else
                    {
                        pwm += 5;
                    }
                else
                    if (trackBar1.Value == 1)
                        pwm--;
                    else if (trackBar1.Value == 2)
                        pwm -= 2;
                    else if (trackBar1.Value == 3)
                        pwm -= 3;
                    else if (trackBar1.Value == 4)
                        pwm -= 4;
                    else
                        pwm -= 5;

                if (breathRed.Checked)
                    Form1.uart.Write("rgb " + pwm + "," + 0 + "," + 0 + ";");
                else if (breathGreen.Checked)
                    Form1.uart.Write("rgb " + 0 + "," + pwm + "," + 0 + ";");
                else if (breathBlue.Checked)
                    Form1.uart.Write("rgb " + 0 + "," + 0 + "," + pwm + ";");
                else if (breathRG.Checked)
                    Form1.uart.Write("rgb " + pwm + "," + pwm + "," + 0 + ";");
                else if (breathRB.Checked)
                    Form1.uart.Write("rgb " + pwm + "," + 0 + "," + pwm + ";");
                else if (breathGB.Checked)
                    Form1.uart.Write("rgb " + 0 + "," + pwm + "," + pwm + ";");
                else
                    Form1.uart.Write("rgb " + pwm + "," + pwm + "," + pwm + ";");
            }
        }

        public void breathingModeStart(object sender, EventArgs e)
        {
            breathingMode = true;
            timerPWM.Start();
        }

        public void breathingModeStop(object sender, EventArgs e)
        {
            breathingMode = false;
            timerPWM.Stop();
            Form1.uart.Write("off;");
            pwm = 0;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value == 1)
            {
                label2.Text = "Very slow";
            }
            else if (trackBar1.Value == 2)
            {
                label2.Text = "Slow";
            }
            else if (trackBar1.Value == 3)
            {
                label2.Text = "Normal";
            }
            else if (trackBar1.Value == 4)
            {
                label2.Text = "Fast";
            }
            else
            {
                label2.Text = "Very fast";
            }
        }
    }
}
