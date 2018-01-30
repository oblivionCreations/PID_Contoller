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
using MetroFramework.Forms;

namespace PID_Controller
{
    public partial class PIDController : MetroForm
    {
        private Thread threadInput;
        private Thread threadOutput;

        // Gains
        private double Kp = 0;
        private double Ki = 0;
        private double Kd = 0;
        //
        private Double Input;
        private Double Output;
        private double Error = 0;
        private double preError = 0;
        private double P = 0;
        private double I = 0;
        private double D = 0;
        private double PIDControlledValue = 0;
        private int Dt =0;
      
        private double DtCounter = 0;
        private double DtBy4Counter = 0;
        //private double ErrorSum = 0;


        public PIDController()
        {
            InitializeComponent();
            chkBoxAP.Checked = true;
            chkBoxAI.Checked = true;
            chkBoxAD.Checked = true;
            Dt = (int)numericUpDownGraphSpeed.Value*1000;
            
            //DtOutput = (int)numericUpDownGraphSpeed.Value;

        }

        #region CheckBox Enabling



        private void chkBoxI_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxAI.Checked == false)
            {

                numericUpDownEI.Enabled = false;
            }
            else
            {

                numericUpDownEI.Enabled = true;
            }
        }

        private void ChkBoxD_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoxAD.Checked == false)
            {

                numericUpDownED.Enabled = false;
            }
            else
            {

                numericUpDownED.Enabled = true;
            }
        }
        #endregion



        public void GetInputChartDetails()
        {
            this.Invoke((MethodInvoker)delegate { UpdateInputChart(); });
          
        }
        public void UpdateInputChart()
        {


            chartExInput.Series["Input"].Points.Add(DtCounter, TraceBarExInput.Value);
            if (chartExInput.Series["Input"].Points.Count > 0)
            {
                //ChartInput.ChartAreas["Input"].RecalculateAxesScale();
                if (chartExInput.Series["Input"].Points.Count > 10) chartExInput.Series["Input"].Points.RemoveAt(0);
                // ChartOutput.ResetAutoValues();
            }
        }

        public void GetOutputChartDetails()
        {
            this.Invoke((MethodInvoker)delegate { UpdateOutputChart(); });
            

        }
        public void UpdateOutputChart()
        {
             
            Input = Convert.ToDouble(numericUpDownInput.Value); 
            //Output = ChartOutput.Series["Output"].Points.Count > 0 ? ChartOutput.Series["Output"].Points.LastOrDefault().YValues.Last() : 0;

            Error = Input - Output;
            Kp = Convert.ToDouble(numericUpDownEP.Value);
            Ki = Convert.ToDouble(numericUpDownEI.Value);
            Kd = Convert.ToDouble(numericUpDownED.Value);


            P = PID.POutput(Kp, Error);
            I = PID.IOutput(Ki, I, Error, Dt / Dt);
            D = PID.DOutput(Kd, preError, Error, Dt / Dt);

            PIDControlledValue = (chkBoxAP.Checked ? P : 0) + (chkBoxAI.Checked ? I : 0) + (chkBoxAD.Checked ? D : 0);

            lblPIDControlledValue.Text = Math.Round(PIDControlledValue, 4).ToString();
            Output = PIDControlledValue;
            chartExOutput.Series["Output"].Points.Add(DtBy4Counter, PIDControlledValue);

            if (chartExOutput.Series["Output"].Points.Count > 0)
            {
                //ChartOutput.ChartAreas["Output"].RecalculateAxesScale();
                if (chartExOutput.Series["Output"].Points.Count > 10) chartExOutput.Series["Output"].Points.RemoveAt(0);
                //chartExOutput.ResetAutoValues();
            }
            preError = Error;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            threadInput = new Thread(new ThreadStart(this.GetInputChartDetails));
            threadInput.IsBackground = true;
            threadInput.Start();
            Thread.Sleep(Dt);
            DtCounter++;
        }


        private void timerOutput_Tick(object sender, EventArgs e)
        {
            threadOutput = new Thread(new ThreadStart(this.GetOutputChartDetails));
            threadOutput.IsBackground = true;
            threadOutput.Start();
            Thread.Sleep(Dt);
            DtBy4Counter++;
            
        }
        #region TraceBar
        private void numericUpDownP_ValueChanged(object sender, EventArgs e)
        {
            // trackBarP.Value = Convert.ToInt32(numericUpDownP.Value);
        }
        private void numericUpDownI_ValueChanged(object sender, EventArgs e)
        {
            // trackBarI.Value = Convert.ToInt32(numericUpDownI.Value);
        }

        private void numericUpDownD_ValueChanged(object sender, EventArgs e)
        {
            //  trackBarD.Value = Convert.ToInt32(numericUpDownD.Value);

        }
        #endregion

        private void ChartOutput_AxisViewChanged(object sender, System.Windows.Forms.DataVisualization.Charting.ViewEventArgs e)
        {
         //   Output = ChartOutput.Series["Output"].Points.LastOrDefault().YValues.Last();
        }

        private void ChartInput_AxisViewChanged(object sender, System.Windows.Forms.DataVisualization.Charting.ViewEventArgs e)
        {
            //Input = ChartInput.Series["Input"].Points.LastOrDefault().YValues.Last();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerInput.Stop();
            timerOutput.Stop();
        }

        private void PIDController_Load(object sender, EventArgs e)
        {
            chartExOutput.Series["Output"].Points.Clear();
        }

        private void btnAStart_Click(object sender, EventArgs e)
        {
            timerInput.Enabled = true;
            timerInput.Start();
            timerOutput.Enabled = true;
            timerOutput.Start();

        }

        private void btnAStop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TraceBarExInput_Scroll(object sender, EventArgs e)
        {
            numericUpDownInput.Value = TraceBarExInput.Value;
          
        }

        private void numericUpDownInput_ValueChanged(object sender, EventArgs e)
        {
            TraceBarExInput.Value = Convert.ToInt32(numericUpDownInput.Value);
           
        }

        private void chkBoxAP_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkBoxAP.Checked == false) numericUpDownEP.Enabled = false;
            else numericUpDownEP.Enabled = true;
        }

        private void chkBoxAI_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkBoxAI.Checked == false)
                numericUpDownEI.Enabled = false;
            else
                numericUpDownEI.Enabled = true;

        }

        private void numericUpDownEP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timerInput.Stop();
            timerOutput.Stop();
        }

        private void btnAnimation_Click(object sender, EventArgs e)
        {
            this.Hide();

            Animation Ani = new Animation();
            Ani.ShowDialog();
            //this.Close();
        }

        private void numericUpDownGraphSpeed_ValueChanged(object sender, EventArgs e)
        {
            Dt = (int)numericUpDownGraphSpeed.Value * 1000;
            // DtOutput = (int)numericUpDownGraphSpeed.Value;
        }

        private void btnTemparatureControl_Click(object sender, EventArgs e)
        {

            this.Hide();
            Radiator radiator = new Radiator();
            radiator.ShowDialog();
        }
    }
}
