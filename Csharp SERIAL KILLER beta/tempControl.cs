using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;
using OpenHardwareMonitor.Hardware;

namespace Csharp_SERIAL_KILLER_beta
{
    public partial class tempControl : Form
    {
        public tempControl() // °C
        {
            InitializeComponent();
        }

        public static bool tempMode = false;
        Computer computer = new Computer() { CPUEnabled = true, GPUEnabled = true };
        int cores = 0, cpuavg = 0, cpupack = 0, gputemp = 0;                          //MUST init dem vars

        private void tempControl_Load(object sender, EventArgs e)
        {
            computer.Open();

            foreach (var hardware in computer.Hardware)
            {
                deviceBox.Items.Add(hardware.Name);
            }

            deviceBox.SelectedIndex = 0;
            countcores();

            
        }

        private void tempTimer_Tick(object sender, EventArgs e)
        {
            gputemp = 0;
            cpuavg = 0;
            cpupack = 0;

            foreach (var hardwareItem in computer.Hardware)
            {
                if (hardwareItem.HardwareType == HardwareType.CPU)
                {
                    hardwareItem.Update();
                    foreach (var subHardware in hardwareItem.SubHardware)
                        subHardware.Update();

                    foreach (var sensor in hardwareItem.Sensors)
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            if (sensor.Name == "CPU Package")
                            {
                                cpupack = (int)sensor.Value.Value;
                            }
                            else
                            {
                                cpuavg += (int)sensor.Value;
                            }
                        }
                }
                else
                {
                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        hardwareItem.Update();
                        if (sensor.SensorType == SensorType.Temperature)
                            gputemp = (int)sensor.Value;
                    }
                }

                if (deviceBox.SelectedIndex == 0)
                {
                    if (cpupack == 0)  //if the cpu package sensor is NOT found display temp/cores average
                    {
                        txtValue.Text = (cpuavg / cores) + Environment.NewLine + "°C";
                    }
                    else               //if the cpu package sensor is found, display it
                    {
                        txtValue.Text = cpupack.ToString() + "°C";
                    }
                }
                else
                {
                    txtValue.Text = gputemp.ToString() + "°C";
                }
            }
        }

        private void countcores()
        {
            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_Processor").Get())
                cores = int.Parse(item["NumberOfCores"].ToString());
        }

        private void tempModeStart(object sender, EventArgs e)
        {
            tempMode = true;
            tempTimer.Start();
        }
        private void tempModeStop(object sender, EventArgs e)
        {
            tempMode = false;
            tempTimer.Stop();
        }

        private void lowerColorBox_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            lowerColorBox.BackColor = colorDialog1.Color;
        }
        private void upperColorBox_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            upperColorBox.BackColor = colorDialog1.Color;
        }

    }
}
