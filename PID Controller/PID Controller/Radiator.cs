#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PID_Controller
{
    public partial class Radiator : MetroForm
    {
        private Thread threadWeather;
        private Thread threadTemp;
        float currentTemp = 0;
        private Double Input;
        private Double Output = -40;
        private double Error = 0;
        private double preError = 0;
        private double P = 0;
        private double I = 0;
        private double D = 0;
        private int timerTempControlInterval = 1000;
        private int timerWeatherChangeInterval = 10000;
        private double PIDControlledValue = 0;
        // Gains
        private double Kp = 0;
        private double Ki = 0;
        private double Kd = 0;


        public Radiator()
        {
           
            InitializeComponent();
          //  btnStart.Enabled = false;
            chkBoxAD.Checked = true;
            chkBoxAI.Checked = true;
            chkBoxAP.Checked = true;
            timerTempControlInterval = (int)numericUpDownExtSamplingRate.Value * 1000;
            pbContainer.ImageLocation = @"C:\Users\Admin\Desktop\baclup\Projects_2017_12_10_125942\Projects\PID Controller\PID Controller\Resources\Container.png";
            pbMedical.ImageLocation = @"C:\Users\Admin\Desktop\baclup\Projects_2017_12_10_125942\Projects\PID Controller\PID Controller\Resources\Medical.jpg";

        }

        private void timerWeatherChange_Tick(object sender, EventArgs e)
        {
            threadWeather = new Thread(new ThreadStart(this.GetWeather));
            threadWeather.IsBackground = true;
            threadWeather.Start();
        
        }
        public void GetWeather()
        {
            this.Invoke((MethodInvoker)delegate { Weather(); });


        }
        public void Weather()
        {
            Random Rand = new Random();
            currentTemp = Rand.Next(-50, 50);
            Output =  currentTemp;
            preError = 0;
            lblTemparature.Text = currentTemp.ToString();
            if(currentTemp < 0)
             pbWeather.ImageLocation = @"C:\Users\Admin\Desktop\baclup\Projects_2017_12_10_125942\Projects\PID Controller\PID Controller\Resources\Snow1.gif";
            else
             pbWeather.ImageLocation = @"C:\Users\Admin\Desktop\baclup\Projects_2017_12_10_125942\Projects\PID Controller\PID Controller\Resources\Sunny.gif";

        }


        private void timerTempControl_Tick(object sender, EventArgs e)
        {
            threadTemp = new Thread(new ThreadStart(this.getControlTemparature));
            threadTemp.IsBackground = true;
            threadTemp.Start();
           
        }


        public void getControlTemparature()
        {
            this.Invoke((MethodInvoker)delegate { ControlTemparature(); });


        }
        public void ControlTemparature()
        {

            Input = Convert.ToDouble(numericUpDownTemperature.Value);
            Error = Input - Output;
            Kp = Convert.ToDouble(numericUpDownEP.Value);
            Ki = Convert.ToDouble(numericUpDownEI.Value);
            Kd = Convert.ToDouble(numericUpDownED.Value);


            P = PID.POutput(Kp, Error);
            I = PID.IOutput(Ki, I, Error, 1);
            D = PID.DOutput(Kd, preError, Error,1);

            PIDControlledValue = (chkBoxAP.Checked ? P : 0) + (chkBoxAI.Checked ? I : 0) + (chkBoxAD.Checked ? D : 0);
            lblControlledTemparature.Text = Math.Round(PIDControlledValue, 2).ToString();
            Output = PIDControlledValue; 
            preError = Error;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timerWeatherChange.Enabled = true;
            timerTempControl.Enabled = true;
            timerWeatherChange.Interval= timerWeatherChangeInterval;
            timerTempControl.Interval = timerTempControlInterval;
            timerTempControl.Start();
            timerWeatherChange.Start();
            
            
           
            
           
          
        }

        private void numericUpDownExtSamplingRate_ValueChanged(object sender, EventArgs e)
        {
            timerTempControl.Interval = (int)numericUpDownExtSamplingRate.Value * 1000;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            timerTempControl.Stop();
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdv1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Radiator radiator = new Radiator();
            radiator.ShowDialog();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnTempControl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Animation animation = new Animation();
            animation.ShowDialog();
        }

        private void btnGraphicalView_Click(object sender, EventArgs e)
        {
            this.Hide();
            PIDController Ani = new PIDController();
            Ani.ShowDialog();
        }
    }
}
