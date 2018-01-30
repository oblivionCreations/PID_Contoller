namespace PID_Controller
{
    partial class Animation
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
            this.btnStart = new Syncfusion.Windows.Forms.ButtonAdv();
            this.gradientLabel1 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.numericUpDownWaterLevel = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.gradientLabel2 = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.numericUpDownOutlet = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.WaterLevel = new Syncfusion.Windows.Forms.Tools.ProgressBarAdv();
            this.model1 = new Syncfusion.Windows.Forms.Diagram.Model(this.components);
            this.timerInput = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownEI = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.numericUpDownED = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.numericUpDownEP = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.chkBoxAD = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.chkBoxAI = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.chkBoxAP = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.lblPIDControlledValueLabel = new System.Windows.Forms.Label();
            this.lblWaterLevelValue = new Syncfusion.Windows.Forms.Tools.GradientLabel();
            this.timerOutlet = new System.Windows.Forms.Timer(this.components);
            this.btnGraphicalView = new Syncfusion.Windows.Forms.ButtonAdv();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnStop = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnPause = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonAdv1 = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numericUpDownExtSamplingRate = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWaterLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutlet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaterLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBoxAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBoxAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBoxAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExtSamplingRate)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
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
            this.gradientLabel1.Text = "Water Lavel to be Maintained";
            this.gradientLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownWaterLevel
            // 
            this.numericUpDownWaterLevel.BeforeTouchSize = new System.Drawing.Size(69, 20);
            this.numericUpDownWaterLevel.Location = new System.Drawing.Point(167, 28);
            this.numericUpDownWaterLevel.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.numericUpDownWaterLevel.Name = "numericUpDownWaterLevel";
            this.numericUpDownWaterLevel.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownWaterLevel.TabIndex = 3;
            this.numericUpDownWaterLevel.ValueChanged += new System.EventHandler(this.numericUpDownWaterLevel_ValueChanged);
            // 
            // gradientLabel2
            // 
            this.gradientLabel2.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.gradientLabel2.BeforeTouchSize = new System.Drawing.Size(155, 19);
            this.gradientLabel2.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.gradientLabel2.Location = new System.Drawing.Point(6, 60);
            this.gradientLabel2.Name = "gradientLabel2";
            this.gradientLabel2.Size = new System.Drawing.Size(155, 19);
            this.gradientLabel2.TabIndex = 4;
            this.gradientLabel2.Text = "Rate of water Outlet";
            this.gradientLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownOutlet
            // 
            this.numericUpDownOutlet.BeforeTouchSize = new System.Drawing.Size(69, 20);
            this.numericUpDownOutlet.Location = new System.Drawing.Point(167, 59);
            this.numericUpDownOutlet.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.numericUpDownOutlet.Name = "numericUpDownOutlet";
            this.numericUpDownOutlet.Size = new System.Drawing.Size(69, 20);
            this.numericUpDownOutlet.TabIndex = 5;
            // 
            // WaterLevel
            // 
            this.WaterLevel.BackGradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.WaterLevel.BackGradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.WaterLevel.BackgroundStyle = Syncfusion.Windows.Forms.Tools.ProgressBarBackgroundStyles.Gradient;
            this.WaterLevel.BackMultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.WaterLevel.BackSegments = false;
            this.WaterLevel.BackTubeEndColor = System.Drawing.Color.Black;
            this.WaterLevel.BackTubeStartColor = System.Drawing.Color.LightGray;
            this.WaterLevel.Border3DStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.WaterLevel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(158)))), ((int)(((byte)(214)))));
            this.WaterLevel.BorderSingle = System.Windows.Forms.ButtonBorderStyle.None;
            this.WaterLevel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WaterLevel.CustomText = null;
            this.WaterLevel.CustomWaitingRender = false;
            this.WaterLevel.FontColor = System.Drawing.Color.White;
            this.WaterLevel.ForegroundImage = null;
            this.WaterLevel.GradientEndColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.WaterLevel.GradientStartColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.WaterLevel.Location = new System.Drawing.Point(589, 187);
            this.WaterLevel.MultipleColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty};
            this.WaterLevel.Name = "WaterLevel";
            this.WaterLevel.ProgressOrientation = System.Windows.Forms.Orientation.Vertical;
            this.WaterLevel.ProgressStyle = Syncfusion.Windows.Forms.Tools.ProgressBarStyles.Metro;
            this.WaterLevel.SegmentWidth = 12;
            this.WaterLevel.ShowProgressImage = true;
            this.WaterLevel.Size = new System.Drawing.Size(157, 287);
            this.WaterLevel.TabIndex = 0;
            this.WaterLevel.Text = "progressBarAdv1";
            this.WaterLevel.TextOrientation = System.Windows.Forms.Orientation.Vertical;
            this.WaterLevel.TextStyle = Syncfusion.Windows.Forms.Tools.ProgressBarTextStyles.Value;
            this.WaterLevel.ThemesEnabled = false;
            this.WaterLevel.TubeEndColor = System.Drawing.Color.Black;
            this.WaterLevel.TubeStartColor = System.Drawing.Color.Red;
            this.WaterLevel.Value = 0;
            this.WaterLevel.WaitingGradientWidth = 400;
            // 
            // model1
            // 
            this.model1.AlignmentType = AlignmentType.SelectedNode;
            this.model1.BackgroundStyle.PathBrushStyle = Syncfusion.Windows.Forms.Diagram.PathGradientBrushStyle.RectangleCenter;
            this.model1.DocumentScale.DisplayName = "No Scale";
            this.model1.DocumentScale.Height = 1F;
            this.model1.DocumentScale.Width = 1F;
            this.model1.DocumentSize.Height = 1169F;
            this.model1.DocumentSize.Width = 827F;
            this.model1.LineStyle.DashPattern = null;
            this.model1.LineStyle.LineColor = System.Drawing.Color.Black;
            this.model1.LogicalSize = new System.Drawing.SizeF(827F, 1169F);
            this.model1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.model1.ShadowStyle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.model1.ShadowStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            // 
            // timerInput
            // 
            this.timerInput.Tick += new System.EventHandler(this.timerInput_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gradientLabel2);
            this.groupBox1.Controls.Add(this.numericUpDownOutlet);
            this.groupBox1.Controls.Add(this.gradientLabel1);
            this.groupBox1.Controls.Add(this.numericUpDownWaterLevel);
            this.groupBox1.Location = new System.Drawing.Point(23, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 95);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
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
            // lblPIDControlledValueLabel
            // 
            this.lblPIDControlledValueLabel.AutoSize = true;
            this.lblPIDControlledValueLabel.Location = new System.Drawing.Point(312, 66);
            this.lblPIDControlledValueLabel.Name = "lblPIDControlledValueLabel";
            this.lblPIDControlledValueLabel.Size = new System.Drawing.Size(68, 13);
            this.lblPIDControlledValueLabel.TabIndex = 7;
            this.lblPIDControlledValueLabel.Text = "Water Lavel:";
            // 
            // lblWaterLevelValue
            // 
            this.lblWaterLevelValue.BackgroundColor = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Vertical, System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(240)))), ((int)(((byte)(247))))), System.Drawing.Color.LightCyan);
            this.lblWaterLevelValue.BeforeTouchSize = new System.Drawing.Size(100, 23);
            this.lblWaterLevelValue.BorderSides = ((System.Windows.Forms.Border3DSide)((((System.Windows.Forms.Border3DSide.Left | System.Windows.Forms.Border3DSide.Top) 
            | System.Windows.Forms.Border3DSide.Right) 
            | System.Windows.Forms.Border3DSide.Bottom)));
            this.lblWaterLevelValue.Location = new System.Drawing.Point(387, 66);
            this.lblWaterLevelValue.Name = "lblWaterLevelValue";
            this.lblWaterLevelValue.Size = new System.Drawing.Size(100, 23);
            this.lblWaterLevelValue.TabIndex = 8;
            this.lblWaterLevelValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGraphicalView
            // 
            this.btnGraphicalView.BeforeTouchSize = new System.Drawing.Size(99, 34);
            this.btnGraphicalView.IsBackStageButton = false;
            this.btnGraphicalView.Location = new System.Drawing.Point(13, 19);
            this.btnGraphicalView.Name = "btnGraphicalView";
            this.btnGraphicalView.Size = new System.Drawing.Size(99, 34);
            this.btnGraphicalView.TabIndex = 9;
            this.btnGraphicalView.Text = "Graphical View";
            this.btnGraphicalView.Click += new System.EventHandler(this.btnGraphicalView_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::PID_Controller.Properties.Resources.blue;
            this.pictureBox7.Location = new System.Drawing.Point(736, 187);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(10, 287);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::PID_Controller.Properties.Resources.dbb8fb4889763e5ca0953a0bbf788584__irrigation_controller_water_timer;
            this.pictureBox6.Location = new System.Drawing.Point(801, 485);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(50, 47);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 15;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::PID_Controller.Properties.Resources.blue;
            this.pictureBox5.Location = new System.Drawing.Point(656, 464);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(18, 68);
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::PID_Controller.Properties.Resources.blue;
            this.pictureBox4.Location = new System.Drawing.Point(670, 515);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(138, 17);
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PID_Controller.Properties.Resources.blue;
            this.pictureBox3.Location = new System.Drawing.Point(655, 119);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 62);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PID_Controller.Properties.Resources.blue;
            this.pictureBox2.Location = new System.Drawing.Point(519, 119);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(138, 19);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::PID_Controller.Properties.Resources.dbb8fb4889763e5ca0953a0bbf788584__irrigation_controller_water_timer;
            this.pictureBox1.Location = new System.Drawing.Point(519, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::PID_Controller.Properties.Resources.blue;
            this.pictureBox8.Location = new System.Drawing.Point(589, 187);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(10, 287);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::PID_Controller.Properties.Resources.blue;
            this.pictureBox9.Location = new System.Drawing.Point(589, 176);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(157, 10);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 18;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = global::PID_Controller.Properties.Resources.blue;
            this.pictureBox10.Location = new System.Drawing.Point(589, 464);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(157, 10);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 19;
            this.pictureBox10.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.btnPause);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Location = new System.Drawing.Point(23, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 64);
            this.groupBox2.TabIndex = 20;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGraphicalView);
            this.groupBox3.Location = new System.Drawing.Point(23, 411);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(242, 65);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Views";
            // 
            // buttonAdv1
            // 
            this.buttonAdv1.BeforeTouchSize = new System.Drawing.Size(99, 34);
            this.buttonAdv1.IsBackStageButton = false;
            this.buttonAdv1.Location = new System.Drawing.Point(13, 16);
            this.buttonAdv1.Name = "buttonAdv1";
            this.buttonAdv1.Size = new System.Drawing.Size(99, 34);
            this.buttonAdv1.TabIndex = 10;
            this.buttonAdv1.Text = "Temparature Control";
            this.buttonAdv1.Click += new System.EventHandler(this.buttonAdv1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDownEI);
            this.groupBox4.Controls.Add(this.numericUpDownEP);
            this.groupBox4.Controls.Add(this.numericUpDownED);
            this.groupBox4.Controls.Add(this.chkBoxAP);
            this.groupBox4.Controls.Add(this.chkBoxAI);
            this.groupBox4.Controls.Add(this.chkBoxAD);
            this.groupBox4.Location = new System.Drawing.Point(23, 229);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(242, 116);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gain Srttings";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numericUpDownExtSamplingRate);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(23, 351);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(242, 54);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Timer Settings";
            // 
            // numericUpDownExtSamplingRate
            // 
            this.numericUpDownExtSamplingRate.BeforeTouchSize = new System.Drawing.Size(62, 20);
            this.numericUpDownExtSamplingRate.DecimalPlaces = 1;
            this.numericUpDownExtSamplingRate.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownExtSamplingRate.Location = new System.Drawing.Point(141, 13);
            this.numericUpDownExtSamplingRate.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownExtSamplingRate.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.numericUpDownExtSamplingRate.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
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
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sampling rate(in Second)";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonAdv1);
            this.groupBox6.Location = new System.Drawing.Point(23, 482);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(242, 60);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Applications";
            // 
            // Animation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(968, 549);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblWaterLevelValue);
            this.Controls.Add(this.lblPIDControlledValueLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.WaterLevel);
            this.Name = "Animation";
            this.Text = "Water Level Controller";
            this.Load += new System.EventHandler(this.Animation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWaterLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOutlet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WaterLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.model1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBoxAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBoxAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBoxAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExtSamplingRate)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.Windows.Forms.ButtonAdv btnStart;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel1;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownWaterLevel;
        private Syncfusion.Windows.Forms.Tools.GradientLabel gradientLabel2;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownOutlet;
        private Syncfusion.Windows.Forms.Tools.ProgressBarAdv WaterLevel;
        private Syncfusion.Windows.Forms.Diagram.Model model1;
        private System.Windows.Forms.Timer timerInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownEI;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownED;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownEP;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkBoxAD;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkBoxAI;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkBoxAP;
        private System.Windows.Forms.Label lblPIDControlledValueLabel;
        private Syncfusion.Windows.Forms.Tools.GradientLabel lblWaterLevelValue;
        private System.Windows.Forms.Timer timerOutlet;
        private Syncfusion.Windows.Forms.ButtonAdv btnGraphicalView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private Syncfusion.Windows.Forms.ButtonAdv btnStop;
        private Syncfusion.Windows.Forms.ButtonAdv btnPause;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownExtSamplingRate;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.ButtonAdv buttonAdv1;
        private System.Windows.Forms.GroupBox groupBox6;
    }
}