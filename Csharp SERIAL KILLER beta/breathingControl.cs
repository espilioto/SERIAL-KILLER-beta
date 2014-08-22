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

            timerPWM.Interval = (int)(((trackBar1.Value / 2.0) * 1000) / 255) / 2; 
            //yes, holy shit. (((trackBar / 2 (seconds)) * 1000 (miliseconds)) / pwm levels) / 2 (breath in + breath out)

            label5.Text = (trackBar1.Value / 2.0).ToString() + "s";
            label2.Text = "Interval = " + timerPWM.Interval.ToString();
        }

        private void timerPWM_Tick(object sender, EventArgs e)
        {

            if (Form1.connected && breathingMode)
            {
                if (pwm < 1)
                    rising = true;
                else if (pwm > 254)
                    rising = false;

                if (pwm < 255 && rising)
                    pwm++;
                else
                    pwm--;
                //if (pwm > 254)
                //    pwm--;
                //else if (pwm < 1)
                //    pwm++;

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

                label3.Text = "Color value = " + pwm.ToString();
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

            label5.Text = "0";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timerPWM.Interval = (int)(((trackBar1.Value / 2.0) * 1000) / 255) / 2; 

            label5.Text = (trackBar1.Value / 2.0).ToString() + "s";
            label2.Text = "Interval = " + timerPWM.Interval.ToString();
        }
    }
}
