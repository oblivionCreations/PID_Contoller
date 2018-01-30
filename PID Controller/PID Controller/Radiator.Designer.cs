#region Copyright Syncfusion Inc. 2001-2017.
// Copyright Syncfusion Inc. 2001-2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace PID_Controller
{
    partial class Radiator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numericUpDownExt1 = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownExtSamplingRate = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericUpDownEI = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.numericUpDownEP = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.numericUpDownED = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.chkBoxAP = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.chkBoxAI = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.chkBoxAD = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTempControl = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnGraphicalView = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStop = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnPause = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnStart = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.numericUpDownTemperature = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.timerWeatherChange = new System.Windows.Forms.Timer(this.components);
            this.timerTempControl = new System.Windows.Forms.Timer(this.components);
            this.gradientLabel2 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.lblTemparature = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.lblControlledTemparature = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.gradientLabel4 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.pbMedical = new System.Windows.Forms.PictureBox();
            this.pbContainer = new System.Windows.Forms.PictureBox();
            this.pbWeather = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExtSamplingRate)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBoxAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBoxAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBoxAD)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemperature)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMedical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numericUpDownExt1);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.numericUpDownExtSamplingRate);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(10, 315);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(242, 88);
            this.groupBox5.TabIndex = 26;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Timer Settings";
            // 
            // numericUpDownExt1
            // 
            this.numericUpDownExt1.BeforeTouchSize = new System.Drawing.Size(62, 20);
            this.numericUpDownExt1.Location = new System.Drawing.Point(174, 39);
            this.numericUpDownExt1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownExt1.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.numericUpDownExt1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownExt1.Name = "numericUpDownExt1";
            this.numericUpDownExt1.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownExt1.TabIndex = 24;
            this.numericUpDownExt1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Weather Change rate(in Second)";
            // 
            // numericUpDownExtSamplingRate
            // 
            this.numericUpDownExtSamplingRate.BeforeTouchSize = new System.Drawing.Size(62, 20);
            this.numericUpDownExtSamplingRate.Location = new System.Drawing.Point(174, 13);
            this.numericUpDownExtSamplingRate.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownExtSamplingRate.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.numericUpDownExtSamplingRate.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownExtSamplingRate.Name = "numericUpDownExtSamplingRate";
            this.numericUpDownExtSamplingRate.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownExtSamplingRate.TabIndex = 22;
            this.numericUpDownExtSamplingRate.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownExtSamplingRate.ValueChanged += new System.EventHandler(this.numericUpDownExtSamplingRate_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control rate(in Second)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDownEI);
            this.groupBox4.Controls.Add(this.numericUpDownEP);
            this.groupBox4.Controls.Add(this.numericUpDownED);
            this.groupBox4.Controls.Add(this.chkBoxAP);
            this.groupBox4.Controls.Add(this.chkBoxAI);
            this.groupBox4.Controls.Add(this.chkBoxAD);
            this.groupBox4.Location = new System.Drawing.Point(10, 192);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(242, 117);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gain Srttings";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // numericUpDownEI
            // 
            this.numericUpDownEI.BeforeTouchSize = new System.Drawing.Size(60, 20);
            this.numericUpDownEI.DecimalPlaces = 2;
            this.numericUpDownEI.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownEI.Location = new System.Drawing.Point(48, 55);
            this.numericUpDownEI.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownEI.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.numericUpDownEI.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownEI.Name = "numericUpDownEI";
            this.numericUpDownEI.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownEI.TabIndex = 21;
            // 
            // numericUpDownEP
            // 
            this.numericUpDownEP.BeforeTouchSize = new System.Drawing.Size(62, 20);
            this.numericUpDownEP.DecimalPlaces = 2;
            this.numericUpDownEP.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownEP.Location = new System.Drawing.Point(48, 20);
            this.numericUpDownEP.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownEP.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.numericUpDownEP.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownEP.Name = "numericUpDownEP";
            this.numericUpDownEP.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownEP.TabIndex = 19;
            // 
            // numericUpDownED
            // 
            this.numericUpDownED.BeforeTouchSize = new System.Drawing.Size(62, 20);
            this.numericUpDownED.DecimalPlaces = 2;
            this.numericUpDownED.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownED.Location = new System.Drawing.Point(48, 89);
            this.numericUpDownED.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownED.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.numericUpDownED.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownED.Name = "numericUpDownED";
            this.numericUpDownED.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownED.TabIndex = 20;
            // 
            // chkBoxAP
            // 
            this.chkBoxAP.BeforeTouchSize = new System.Drawing.Size(32, 20);
            this.chkBoxAP.Location = new System.Drawing.Point(10, 20);
            this.chkBoxAP.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.chkBoxAP.Name = "chkBoxAP";
            this.chkBoxAP.Size = new System.Drawing.Size(32, 20);
            this.chkBoxAP.TabIndex = 16;
            this.chkBoxAP.Text = "P";
            this.chkBoxAP.ThemesEnabled = false;
            // 
            // chkBoxAI
            // 
            this.chkBoxAI.BeforeTouchSize = new System.Drawing.Size(32, 20);
            this.chkBoxAI.Location = new System.Drawing.Point(10, 55);
            this.chkBoxAI.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.chkBoxAI.Name = "chkBoxAI";
            this.chkBoxAI.Size = new System.Drawing.Size(32, 20);
            this.chkBoxAI.TabIndex = 17;
            this.chkBoxAI.Text = "I";
            this.chkBoxAI.ThemesEnabled = false;
            // 
            // chkBoxAD
            // 
            this.chkBoxAD.BeforeTouchSize = new System.Drawing.Size(32, 20);
            this.chkBoxAD.Location = new System.Drawing.Point(10, 89);
            this.chkBoxAD.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.chkBoxAD.Name = "chkBoxAD";
            this.chkBoxAD.Size = new System.Drawing.Size(32, 20);
            this.chkBoxAD.TabIndex = 18;
            this.chkBoxAD.Text = "D";
            this.chkBoxAD.ThemesEnabled = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGraphicalView);
            this.groupBox3.Location = new System.Drawing.Point(10, 409);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 63);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Views";
            // 
            // btnTempControl
            // 
            this.btnTempControl.BeforeTouchSize = new System.Drawing.Size(97, 34);
            this.btnTempControl.IsBackStageButton = false;
            this.btnTempControl.Location = new System.Drawing.Point(6, 19);
            this.btnTempControl.Name = "btnTempControl";
            this.btnTempControl.Size = new System.Drawing.Size(97, 34);
            this.btnTempControl.TabIndex = 34;
            this.btnTempControl.Text = "Fluid Level Control";
            this.btnTempControl.Click += new System.EventHandler(this.btnTempControl_Click);
            // 
            // btnGraphicalView
            // 
            this.btnGraphicalView.BeforeTouchSize = new System.Drawing.Size(97, 34);
            this.btnGraphicalView.IsBackStageButton = false;
            this.btnGraphicalView.Location = new System.Drawing.Point(6, 19);
            this.btnGraphicalView.Name = "btnGraphicalView";
            this.btnGraphicalView.Size = new System.Drawing.Size(97, 34);
            this.btnGraphicalView.TabIndex = 9;
            this.btnGraphicalView.Text = "Graphical View";
            this.btnGraphicalView.Click += new System.EventHandler(this.btnGraphicalView_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.btnPause);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Location = new System.Drawing.Point(10, 54);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 64);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control";
            // 
            // btnStop
            // 
            this.btnStop.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnStop.IsBackStageButton = false;
            this.btnStop.Location = new System.Drawing.Point(167, 19);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnPause.IsBackStageButton = false;
            this.btnPause.Location = new System.Drawing.Point(86, 19);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Pause";
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnStart.IsBackStageButton = false;
            this.btnStart.Location = new System.Drawing.Point(6, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gradientLabel1);
            this.groupBox1.Controls.Add(this.numericUpDownTemperature);
            this.groupBox1.Location = new System.Drawing.Point(10, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 62);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // gradientLabel1
            // 
            this.gradientLabel1.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.gradientLabel1.BeforeTouchSize = new System.Drawing.Size(155, 20);
            this.gradientLabel1.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel1.Location = new System.Drawing.Point(6, 28);
            this.gradientLabel1.Name = "gradientLabel1";
            this.gradientLabel1.Size = new System.Drawing.Size(155, 20);
            this.gradientLabel1.TabIndex = 2;
            this.gradientLabel1.Text = "Temperature to be Maintained";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownTemperature
            // 
            this.numericUpDownTemperature.BeforeTouchSize = new System.Drawing.Size(69, 20);
            this.numericUpDownTemperature.Location = new System.Drawing.Point(167, 28);
            this.numericUpDownTemperature.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.numericUpDownTemperature.Name = "numericUpDownTemperature";
            this.numericUpDownTemperature.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownTemperature.TabIndex = 3;
            // 
            // timerWeatherChange
            // 
            this.timerWeatherChange.Tick += new System.EventHandler(this.timerWeatherChange_Tick);
            // 
            // timerTempControl
            // 
            this.timerTempControl.Tick += new System.EventHandler(this.timerTempControl_Tick);
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.gradientLabel2.BeforeTouchSize = new System.Drawing.Size(132, 20);
            this.gradientLabel2.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel2.Location = new System.Drawing.Point(266, 31);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(132, 20);
            this.gradientLabel2.TabIndex = 29;
            this.gradientLabel2.Text = "Weather Temparature";
            this.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemparature
            // 
            this.lblTemparature.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.lblTemparature.BeforeTouchSize = new System.Drawing.Size(51, 20);
            this.lblTemparature.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblTemparature.Location = new System.Drawing.Point(404, 31);
            this.lblTemparature.Name = "lblTemparature";
            this.lblTemparature.Size = new System.Drawing.Size(51, 20);
            this.lblTemparature.TabIndex = 30;
            this.lblTemparature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblControlledTemparature
            // 
            this.lblControlledTemparature.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.lblControlledTemparature.BeforeTouchSize = new System.Drawing.Size(90, 20);
            this.lblControlledTemparature.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblControlledTemparature.Location = new System.Drawing.Point(842, 31);
            this.lblControlledTemparature.Name = "lblControlledTemparature";
            this.lblControlledTemparature.Size = new System.Drawing.Size(90, 20);
            this.lblControlledTemparature.TabIndex = 32;
            this.lblControlledTemparature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gradientLabel4
            // 
            this.gradientLabel4.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.gradientLabel4.BeforeTouchSize = new System.Drawing.Size(132, 20);
            this.gradientLabel4.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel4.Location = new System.Drawing.Point(704, 31);
            this.gradientLabel4.Name = "gradientLabel4";
            this.gradientLabel4.Size = new System.Drawing.Size(132, 20);
            this.gradientLabel4.TabIndex = 31;
            this.gradientLabel4.Text = "Controlled Temparature";
            this.gradientLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbMedical
            // 
            this.pbMedical.Location = new System.Drawing.Point(570, 452);
            this.pbMedical.Name = "pbMedical";
            this.pbMedical.Size = new System.Drawing.Size(64, 50);
            this.pbMedical.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMedical.TabIndex = 33;
            this.pbMedical.TabStop = false;
            // 
            // pbContainer
            // 
            this.pbContainer.Location = new System.Drawing.Point(466, 384);
            this.pbContainer.Name = "pbContainer";
            this.pbContainer.Size = new System.Drawing.Size(267, 156);
            this.pbContainer.TabIndex = 28;
            this.pbContainer.TabStop = false;
            // 
            // pbWeather
            // 
            this.pbWeather.Location = new System.Drawing.Point(266, 54);
            this.pbWeather.Name = "pbWeather";
            this.pbWeather.Size = new System.Drawing.Size(666, 486);
            this.pbWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWeather.TabIndex = 0;
            this.pbWeather.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnTempControl);
            this.groupBox6.Location = new System.Drawing.Point(10, 482);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(242, 70);
            this.groupBox6.TabIndex = 34;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Applications";
            // 
            // Radiator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 575);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.pbMedical);
            this.Controls.Add(this.lblControlledTemparature);
            this.Controls.Add(this.gradientLabel4);
            this.Controls.Add(this.lblTemparature);
            this.Controls.Add(this.gradientLabel2);
            this.Controls.Add(this.pbContainer);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pbWeather);
            this.Name = "Radiator";
            this.Text = "Temparature Controller";
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExtSamplingRate)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBoxAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBoxAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBoxAD)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemperature)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMedical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeather)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWeather;
        private System.Windows.Forms.GroupBox groupBox5;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownExtSamplingRate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownEI;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownEP;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownED;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkBoxAP;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkBoxAI;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkBoxAD;
        private System.Windows.Forms.GroupBox groupBox3;
        private Syncfusion.Windows.Forms.ButtonAdv btnGraphicalView;
        private System.Windows.Forms.GroupBox groupBox2;
        private Syncfusion.Windows.Forms.ButtonAdv btnStop;
        private Syncfusion.Windows.Forms.ButtonAdv btnPause;
        private Syncfusion.Windows.Forms.ButtonAdv btnStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownTemperature;
        private System.Windows.Forms.PictureBox pbContainer;
        private System.Windows.Forms.Timer timerWeatherChange;
        private System.Windows.Forms.Timer timerTempControl;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel2;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblTemparature;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblControlledTemparature;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel4;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownExt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbMedical;
        private Syncfusion.Windows.Forms.ButtonAdv btnTempControl;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}