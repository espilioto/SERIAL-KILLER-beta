using System;
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
    public partial class normalControl : Form
    {
        public normalControl()
        {
            InitializeComponent();
        }

        public static bool normalMode = false;
        int r = 0, g = 0, b = 0;

        private void normalControl_Load(object sender, EventArgs e)
        {
            colorDialog1.FullOpen = true;
        }

        private void redbar_Scroll(object sender, EventArgs e)
        {
            redupdown.Value = redbar.Value;
            r = redbar.Value;
            serial.uart.Write("rgb " + gamma.correction[r] + "," + gamma.correction[g] + "," + gamma.correction[b] + ";");
        }
        private void greenbar_Scroll(object sender, EventArgs e)
        {
            greenupdown.Value = greenbar.Value;
            g = greenbar.Value;
            serial.uart.Write("rgb " + gamma.correction[r] + "," + gamma.correction[g] + "," + gamma.correction[b] + ";");
        }
        private void bluebar_Scroll(object sender, EventArgs e)
        {
            blueupdown.Value = bluebar.Value;
            b = bluebar.Value;
            serial.uart.Write("rgb " + gamma.correction[r] + "," + gamma.correction[g] + "," + gamma.correction[b] + ";");
        }
        private void redupdown_ValueChanged(object sender, EventArgs e)
        {
            redbar.Value = int.Parse(redupdown.Value.ToString());
            r = int.Parse(redupdown.Value.ToString());
            serial.uart.Write("rgb " + gamma.correction[r] + "," + gamma.correction[g] + "," + gamma.correction[b] + ";");
        }
        private void greenupdown_ValueChanged(object sender, EventArgs e)
        {
            greenbar.Value = int.Parse(greenupdown.Value.ToString());
            g = int.Parse(greenupdown.Value.ToString());
            serial.uart.Write("rgb " + gamma.correction[r] + "," + gamma.correction[g] + "," + gamma.correction[b] + ";");
        }
        private void blueupdown_ValueChanged(object sender, EventArgs e)
        {
            bluebar.Value = int.Parse(blueupdown.Value.ToString());
            b = int.Parse(blueupdown.Value.ToString());
            serial.uart.Write("rgb " + gamma.correction[r] + "," + gamma.correction[g] + "," + gamma.correction[b] + ";");
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            serial.rgbledOFF();

            redbar.Value = 0;
            bluebar.Value = 0;
            greenbar.Value = 0;
        }

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

    }
}
