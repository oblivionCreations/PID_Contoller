using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PID_Controller
{
    public partial class Animation : MetroForm
    {
        private Thread threadOutput;
        private Double WaterLevelToBeMaintained;
        //private Double Output;
        private double Error = 0;
        private double preError = 0;
        private double P = 0;
        private double I = 0;
        private double D = 0;
        private double Current = 0;
        private int WaterControlInterval = 1000;
        private double DtBy4Counter = 0;

        public Animation()
        {
            InitializeComponent();
        }

        private void Animation_Load(object sender, EventArgs e)
        {
            chkBoxAD.Checked = true;
            chkBoxAI.Checked = true;
            chkBoxAP.Checked = true;
            WaterControlInterval = (int)numericUpDownExtSamplingRate.Value * 1000;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timerInput.Enabled = true;
            timerInput.Interval = WaterControlInterval;
            timerInput.Start();
        }

        private void timerInput_Tick(object sender, EventArgs e)
        {

            if (WaterLevelToBeMaintained != Current)
            {
                threadOutput = new Thread(new ThreadStart(this.GetOutputChartDetails));
                threadOutput.IsBackground = true;
                threadOutput.Start();
            }

        }



        public void GetOutputChartDetails()
        {
            this.Invoke((MethodInvoker)delegate { UpdateOutputChart(); });
        }
        public void UpdateOutputChart()
        {
            WaterLevelToBeMaintained = Convert.ToDouble(numericUpDownWaterLevel.Value);
            Error = WaterLevelToBeMaintained - Current;

            P = PID.POutput(Convert.ToDouble(numericUpDownEP.Value), Error);
            I = PID.IOutput(Convert.ToDouble(numericUpDownEI.Value), I, Error, WaterControlInterval / WaterControlInterval);
            D = PID.DOutput(Convert.ToDouble(numericUpDownED.Value), preError, Error, WaterControlInterval / WaterControlInterval);

            Current = (chkBoxAP.Checked ? P : 0) + (chkBoxAI.Checked ? I : 0) + (chkBoxAD.Checked ? D : 0);
            Current = Current - Convert.ToDouble(numericUpDownOutlet.Value);
            lblWaterLevelValue.Text = Math.Round(Current, 2).ToString();
            WaterLevel.Value = Convert.ToInt32(Current);
            preError = Error;
        }

        private void numericUpDownWaterLevel_ValueChanged(object sender, EventArgs e)
        {
            WaterLevel.Value = Convert.ToInt32(numericUpDownWaterLevel.Value);
            WaterLevelToBeMaintained = Convert.ToInt32(numericUpDownWaterLevel.Value);

        }

        private void btnGraphicalView_Click(object sender, EventArgs e)
        {
            this.Hide();
            PIDController Ani = new PIDController();
            Ani.ShowDialog();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timerInput.Stop();
            timerOutlet.Stop();
        }

        private void numericUpDownExtSamplingRate_ValueChanged(object sender, EventArgs e)
        {
            WaterControlInterval = (int)numericUpDownExtSamplingRate.Value * 1000;
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Radiator radiator = new Radiator();
            radiator.ShowDialog();
        }
    }
}
