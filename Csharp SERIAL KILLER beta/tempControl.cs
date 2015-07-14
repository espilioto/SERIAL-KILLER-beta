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
        public tempControl()
        {
            InitializeComponent();
        }

        public static bool tempMode = false;

        int cores = 0, cpuavg = 0, cpupack = 0, gputemp = 0;                          //MUST init dem vars 
        int currentTempvalue = 0, temperature = 0;

        int[] rArray, gArray, bArray;
        int r = 0, g = 0, b = 0;
        int rStep = 0, gStep = 0, bStep = 0;
        int rDiff = 0, gDiff = 0, bDiff = 0;
        int steps = 0;

        private void tempControl_Load(object sender, EventArgs e)
        {
            stuff.OpenHardware.FindDevices();

            foreach (var device in stuff.OpenHardware.devices)
            {
                deviceBox.Items.Add(device);
            }

            deviceBox.SelectedIndex = 0;
            countcores();
        }

        public void MeasureTemp()
        {

        }

        private void tempTimer_Tick(object sender, EventArgs e)
        {
            gputemp = 0; cpuavg = 0; cpupack = 0;

            foreach (var hardwareItem in stuff.OpenHardware.computer.Hardware)
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
                        temperature = cpuavg / cores;
                        txtValue.Text = (cpuavg / cores) + Environment.NewLine + "°C";
                        currentTempvalue = (cpuavg / cores) - (int)txtLower.Value;
                    }
                    else               //if the cpu package sensor is found, display it
                    {
                        temperature = cpupack;
                        txtValue.Text = cpupack.ToString() + "°C";
                        currentTempvalue = cpupack - (int)txtLower.Value;
                    }
                }
                else
                {
                    temperature = gputemp;
                    txtValue.Text = gputemp.ToString() + "°C";
                    currentTempvalue = gputemp - (int)txtLower.Value;
                }
            }

            if (temperature > (int)txtUpper.Value)
            {
                r = rArray.Last();
                g = gArray.Last();
                b = bArray.Last();
            }
            else if (temperature < (int)txtLower.Value)
            {
                r = rArray.First();
                g = gArray.First();
                b = bArray.First();
            }
            else
            {
                r = rArray[currentTempvalue];
                g = gArray[currentTempvalue];
                b = bArray[currentTempvalue];
            }

            stuff.Serial.uart.Write("rgb " + stuff.Gamma.correction[r] + "," + stuff.Gamma.correction[g] + "," + stuff.Gamma.correction[b] + ";");
            //serial.uart.Write("rgb " + r + "," + g + "," + b + ";");
        }

        private void countcores()
        {
            foreach (var item in new System.Management.ManagementObjectSearcher("Select * from Win32_Processor").Get())
                cores = int.Parse(item["NumberOfCores"].ToString());
        }

        public void tempModeStart(object sender, EventArgs e)
        {
            steps = (int)txtUpper.Value - (int)txtLower.Value;                              //find the color steps
            rDiff = lowerColorBox.BackColor.R - upperColorBox.BackColor.R;                  //find the color value difference
            gDiff = lowerColorBox.BackColor.G - upperColorBox.BackColor.G;
            bDiff = lowerColorBox.BackColor.B - upperColorBox.BackColor.B;
            rStep = Math.Abs(rDiff / steps);                                                //find each step's value
            gStep = Math.Abs(gDiff / steps);
            bStep = Math.Abs(bDiff / steps);

            r = lowerColorBox.BackColor.R;
            g = lowerColorBox.BackColor.G;
            b = lowerColorBox.BackColor.B;

            rArray = new int[steps + 1];
            rArray.Initialize();
            if (rDiff < 0)
                for (int i = 0; i < steps + 1; i++)
                    rArray[i] = rStep * i;
            else if (rDiff > 0)
                for (int i = 0; i < steps + 1; i++)
                    rArray[i] = rStep * (steps - i);
            else ;
                

            gArray = new int[steps + 1];
            gArray.Initialize();
            if (gDiff < 0)
                for (int i = 0; i < steps + 1; i++)
                    gArray[i] = gStep * i;
            else if (gDiff > 0)
                for (int i = 0; i < steps + 1; i++)
                    gArray[i] = gStep * (steps - i);
            else ;
            
            bArray = new int[steps + 1];
            bArray.Initialize();
            if (bDiff < 0)
                for (int i = 0; i < steps + 1; i++)
                    bArray[i] = bStep * i;
            else if (bDiff > 0)
                for (int i = 0; i < steps + 1; i++)
                    bArray[i] = bStep * (steps - i);
            else ;
                

            txtUpper.Enabled = false;
            txtLower.Enabled = false;
            lowerColorBox.Enabled = false;
            upperColorBox.Enabled = false;
            deviceBox.Enabled = false;

            tempMode = true;
            tempTimer.Start();
        }
        public void tempModeStop(object sender, EventArgs e)
        {
            tempMode = false;
            tempTimer.Stop();
            stuff.Serial.RgbledOFF();

            txtUpper.Enabled = true;
            txtLower.Enabled = true;
            lowerColorBox.Enabled = true;
            upperColorBox.Enabled = true;
            deviceBox.Enabled = true;
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
