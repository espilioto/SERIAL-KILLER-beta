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
            System.Diagnostics.Stopwatch watch = new System.Diagnostics.Stopwatch();

        private void breathingControl_Load(object sender, EventArgs e)
        {
            breathRed.Select();
            comboBox1.SelectedIndex = 1;

            timerPWM.Interval = 20;
            
        }

        private void timerPWM_Tick(object sender, EventArgs e)
        {

            if (Form1.connected && breathingMode)
            {

                if (pwm < 1)
                    rising = true;
                else if (pwm > 179)
                    rising = false;

                if (pwm < 180 && rising)
                    if (comboBox1.SelectedIndex == 0)
                        pwm++;
                    else if (comboBox1.SelectedIndex == 1)
                        pwm += 2;
                    else
                        pwm += 3;
                else
                    if (comboBox1.SelectedIndex == 0)
                        pwm--;
                    else if (comboBox1.SelectedIndex == 1)
                        pwm -= 2;
                    else
                        pwm -= 3;

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

                label2.Text = "Interval = " + timerPWM.Interval.ToString();
                label3.Text = "Color value = " + pwm.ToString();
            }
        }

        public void breathingModeStart(object sender, EventArgs e)
        {
            breathingMode = true;
            timerPWM.Start();
            watch.Start();
        }

        public void breathingModeStop(object sender, EventArgs e)
        {
            breathingMode = false;
            timerPWM.Stop();
            Form1.uart.Write("off;");
            pwm = 0;

            watch.Stop();
            label5.Text = watch.ElapsedMilliseconds.ToString();
            watch.Reset();

            label3.Text = "0";
        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    switch (comboBox1.SelectedIndex)
        //    {
        //        case 0:
        //            timerPWM.Interval = 9;
        //            break;
        //        case 1:
        //            timerPWM.Interval = 5;
        //            break;
        //        case 2:
        //            timerPWM.Interval = 1;
        //            break;
        //    }
        //}


    }
}
