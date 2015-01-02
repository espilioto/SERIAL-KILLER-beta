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
            CoreAudio.FindDevices();

            for (int i = 0; i < CoreAudio.devs.Count; i++)
                comboBox1.Items.Add(CoreAudio.devs[i].FriendlyName);

            comboBox1.SelectedIndex = 0;
            radioRed.Checked = true;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Form1.connected && soundMode)
            {
                soundLevel = (int)(CoreAudio.device.AudioMeterInformation.MasterPeakValue * trackBar1.Value);
                
                Application.DoEvents();
                
                if (radioRed.Checked)
                    Serial.uart.Write("rgb " + Gamma.correction[(soundLevel * 2)] + "," + 0 + "," + 0 + ";");
                else if (radioGreen.Checked)
                    Serial.uart.Write("rgb " + 0 + "," + Gamma.correction[(soundLevel * 2)] + "," + 0 + ";");
                else if (radioBlue.Checked)
                    Serial.uart.Write("rgb " + 0 + "," + 0 + "," + Gamma.correction[(soundLevel * 2)] + ";");
                else if (radioRG.Checked)
                    Serial.uart.Write("rgb " + Gamma.correction[(soundLevel * 2)] + "," + Gamma.correction[(soundLevel * 2)] + "," + 0 + ";");
                else if (radioRB.Checked)
                    Serial.uart.Write("rgb " + Gamma.correction[(soundLevel * 2)] + "," + 0 + "," + Gamma.correction[(soundLevel * 2)] + ";");
                else if (radioGB.Checked)
                    Serial.uart.Write("rgb " + 0 + "," + Gamma.correction[(soundLevel * 2)] + "," + Gamma.correction[(soundLevel * 2)] + ";");
                else
                    Serial.uart.Write("rgb " + Gamma.correction[(soundLevel * 2)] + "," + Gamma.correction[(soundLevel * 2)] + "," + Gamma.correction[(soundLevel * 2)] + ";");

                soundBar.Value = soundLevel;
            }
        }

        public void soundModeStart(object sender, EventArgs e)
        {
            if (CoreAudio.devs == null)
                CoreAudio.device = CoreAudio.DevEnum.GetDefaultAudioEndpoint(CoreAudioApi.EDataFlow.eRender, CoreAudioApi.ERole.eMultimedia);

            soundMode = true;
            timerSound.Start();
        }
        public void soundModeStop(object sender, EventArgs e)
        {
            soundMode = false;
            timerSound.Stop();

            Serial.RgbledOFF();
            
            soundBar.Value = 0;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CoreAudio.device = CoreAudio.devs[(int)comboBox1.SelectedIndex];
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label5.Text = trackBar1.Value.ToString();
        }
    }
}
