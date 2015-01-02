using System;
using System.Drawing;
using System.Windows.Forms;

namespace Csharp_SERIAL_KILLER_beta
{
    public partial class soundControl : Form
    {
        public soundControl()
        {
            InitializeComponent();
        }

        public static bool soundMode = false;
        int soundLevel;
        
        private void SoundControl_Load(object sender, EventArgs e)
        {
            coreAudio.findDevices();

            for (int i = 0; i < coreAudio.devs.Count; i++)
                comboBox1.Items.Add(coreAudio.devs[i].FriendlyName);

            comboBox1.SelectedIndex = 0;
            radioRed.Checked = true;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Form1.connected && soundMode)
            {
                soundLevel = (int)(coreAudio.device.AudioMeterInformation.MasterPeakValue * trackBar1.Value);
                
                Application.DoEvents();
                
                if (radioRed.Checked)
                    serial.uart.Write("rgb " + gamma.correction[(soundLevel * 2)] + "," + 0 + "," + 0 + ";");
                else if (radioGreen.Checked)
                    serial.uart.Write("rgb " + 0 + "," + gamma.correction[(soundLevel * 2)] + "," + 0 + ";");
                else if (radioBlue.Checked)
                    serial.uart.Write("rgb " + 0 + "," + 0 + "," + gamma.correction[(soundLevel * 2)] + ";");
                else if (radioRG.Checked)
                    serial.uart.Write("rgb " + gamma.correction[(soundLevel * 2)] + "," + gamma.correction[(soundLevel * 2)] + "," + 0 + ";");
                else if (radioRB.Checked)
                    serial.uart.Write("rgb " + gamma.correction[(soundLevel * 2)] + "," + 0 + "," + gamma.correction[(soundLevel * 2)] + ";");
                else if (radioGB.Checked)
                    serial.uart.Write("rgb " + 0 + "," + gamma.correction[(soundLevel * 2)] + "," + gamma.correction[(soundLevel * 2)] + ";");
                else
                    serial.uart.Write("rgb " + gamma.correction[(soundLevel * 2)] + "," + gamma.correction[(soundLevel * 2)] + "," + gamma.correction[(soundLevel * 2)] + ";");

                soundBar.Value = soundLevel;
            }
        }

        public void soundModeStart(object sender, EventArgs e)
        {
            if (coreAudio.devs == null)
                coreAudio.device = coreAudio.DevEnum.GetDefaultAudioEndpoint(CoreAudioApi.EDataFlow.eRender, CoreAudioApi.ERole.eMultimedia);

            soundMode = true;
            timerSound.Start();
        }
        public void soundModeStop(object sender, EventArgs e)
        {
            soundMode = false;
            timerSound.Stop();

            serial.rgbledOFF();
            
            soundBar.Value = 0;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            coreAudio.device = coreAudio.devs[(int)comboBox1.SelectedIndex];
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label5.Text = trackBar1.Value.ToString();
        }
    }
}
