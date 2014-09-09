using System;
using System.Drawing;
using System.Windows.Forms;
using CoreAudioApi;

namespace Csharp_SERIAL_KILLER_beta
{
    public partial class soundControl : Form
    {
        public soundControl()
        {
            InitializeComponent();
        }
        public static bool soundMode = false;

        MMDeviceEnumerator DevEnum = new MMDeviceEnumerator();
        MMDevice device;
        MMDeviceCollection devs;
        int soundLevel;

        private void SoundControl_Load(object sender, EventArgs e)
        {
            devs = DevEnum.EnumerateAudioEndPoints(EDataFlow.eAll, EDeviceState.DEVICE_STATE_ACTIVE);

            for (int i = 0; i < devs.Count; i++)
                comboBox1.Items.Add(devs[i].FriendlyName);

            comboBox1.SelectedIndex = 0;
            radioRed.Checked = true;

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Form1.connected && soundMode)
            {
                soundLevel = (int)(device.AudioMeterInformation.MasterPeakValue * trackBar1.Value);
                
                Application.DoEvents();
                
                if (radioRed.Checked)
                    Form1.uart.Write("rgb " + (soundLevel * 2) + "," + 0 + "," + 0 + ";");
                else if (radioGreen.Checked)
                    Form1.uart.Write("rgb " + 0 + "," + (soundLevel * 2) + "," + 0 + ";");
                else if (radioBlue.Checked)
                    Form1.uart.Write("rgb " + 0 + "," + 0 + "," + (soundLevel * 2) + ";");
                else if (radioRG.Checked)
                    Form1.uart.Write("rgb " + (soundLevel * 2) + "," + (soundLevel * 2) + "," + 0 + ";");
                else if (radioRB.Checked)
                    Form1.uart.Write("rgb " + (soundLevel * 2) + "," + 0 + "," + (soundLevel * 2) + ";");
                else if (radioGB.Checked)
                    Form1.uart.Write("rgb " + 0 + "," + (soundLevel * 2) + "," + (soundLevel * 2) + ";");
                else
                    Form1.uart.Write("rgb " + (soundLevel * 2) + "," + (soundLevel * 2) + "," + (soundLevel * 2) + ";");

                soundBar.Value = soundLevel;
                label4.Text = soundLevel.ToString("0");
            }
        }

        public void soundModeStart(object sender, EventArgs e)
        {
            if (devs == null)
                device = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia);

            soundMode = true;
            timerSound.Start();
        }
        public void soundModeStop(object sender, EventArgs e)
        {
            soundMode = false;
            timerSound.Stop();

            Form1.uart.Write("off;");
            
            soundBar.Value = 0;
            label4.Text = "0";
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            device = devs[(int)comboBox1.SelectedIndex];
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label5.Text = trackBar1.Value.ToString();
        }
    }
}
