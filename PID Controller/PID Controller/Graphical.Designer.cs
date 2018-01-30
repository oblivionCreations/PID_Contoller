namespace PID_Controller
{
    partial class PIDController
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
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries1 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo1 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo1 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries2 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo2 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            this.gpbControl = new System.Windows.Forms.GroupBox();
            this.btnPause = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnAStop = new Syncfusion.Windows.Forms.ButtonAdv();
            this.btnAStart = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TraceBarExInput = new Syncfusion.Windows.Forms.Tools.TrackBarEx(-100, 100);
            this.numericUpDownInput = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownEI = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.numericUpDownED = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.numericUpDownEP = new Syncfusion.Windows.Forms.Tools.NumericUpDownExt();
            this.chkBoxAD = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.chkBoxAI = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.chkBoxAP = new Syncfusion.Windows.Forms.Tools.CheckBoxAdv();
            this.timerInput = new System.Windows.Forms.Timer(this.components);
            this.lblPIDControlledValueLabel = new System.Windows.Forms.Label();
            this.lblPIDControlledValue = new System.Windows.Forms.Label();
            this.timerOutput = new System.Windows.Forms.Timer(this.components);
            this.chartExInput = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.chartExOutput = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.btnAnimation = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTemparatureControl = new Syncfusion.Windows.Forms.ButtonAdv();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericUpDownGraphSpeed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbControl.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInput)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownED)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBoxAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBoxAI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBoxAP)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraphSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbControl
            // 
            this.gpbControl.Controls.Add(this.btnPause);
            this.gpbControl.Controls.Add(this.btnAStop);
            this.gpbControl.Controls.Add(this.btnAStart);
            this.gpbControl.Location = new System.Drawing.Point(23, 63);
            this.gpbControl.Name = "gpbControl";
            this.gpbControl.Size = new System.Drawing.Size(236, 62);
            this.gpbControl.TabIndex = 0;
            this.gpbControl.TabStop = false;
            this.gpbControl.Text = "Controls";
            // 
            // btnPause
            // 
            this.btnPause.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnPause.IsBackStageButton = false;
            this.btnPause.Location = new System.Drawing.Point(74, 19);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 23);
            this.btnPause.TabIndex = 9;
            this.btnPause.Text = "Pause";
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnAStop
            // 
            this.btnAStop.BeforeTouchSize = new System.Drawing.Size(75, 23);
            this.btnAStop.IsBackStageButton = false;
            this.btnAStop.Location = new System.Drawing.Point(155, 19);
            this.btnAStop.Name = "btnAStop";
            this.btnAStop.Size = new System.Drawing.Size(75, 23);
            this.btnAStop.TabIndex = 8;
            this.btnAStop.Text = "Stop";
            this.btnAStop.Click += new System.EventHandler(this.btnAStop_Click);
            // 
            // btnAStart
            // 
            this.btnAStart.BeforeTouchSize = new System.Drawing.Size(67, 23);
            this.btnAStart.IsBackStageButton = false;
            this.btnAStart.Location = new System.Drawing.Point(6, 19);
            this.btnAStart.Name = "btnAStart";
            this.btnAStart.Size = new System.Drawing.Size(67, 23);
            this.btnAStart.TabIndex = 2;
            this.btnAStart.Text = "Start";
            this.btnAStart.Click += new System.EventHandler(this.btnAStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TraceBarExInput);
            this.groupBox1.Controls.Add(this.numericUpDownInput);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 89);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input Settings";
            // 
            // TraceBarExInput
            // 
            this.TraceBarExInput.BackColor = System.Drawing.Color.Transparent;
            this.TraceBarExInput.BeforeTouchSize = new System.Drawing.Size(156, 20);
            this.TraceBarExInput.Location = new System.Drawing.Point(11, 36);
            this.TraceBarExInput.Name = "TraceBarExInput";
            this.TraceBarExInput.Size = new System.Drawing.Size(156, 20);
            this.TraceBarExInput.Style = Syncfusion.Windows.Forms.Tools.TrackBarEx.Theme.Default;
            this.TraceBarExInput.TabIndex = 3;
            this.TraceBarExInput.Text = "trackBarEx1";
            this.TraceBarExInput.TimerInterval = 100;
            this.TraceBarExInput.TrackBarGradientEnd = System.Drawing.Color.White;
            this.TraceBarExInput.TrackBarGradientStart = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TraceBarExInput.Value = 5;
            this.TraceBarExInput.Scroll += new System.EventHandler(this.TraceBarExInput_Scroll);
            // 
            // numericUpDownInput
            // 
            this.numericUpDownInput.BeforeTouchSize = new System.Drawing.Size(36, 20);
            this.numericUpDownInput.Location = new System.Drawing.Point(183, 36);
            this.numericUpDownInput.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.numericUpDownInput.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownInput.Name = "numericUpDownInput";
            this.numericUpDownInput.Size = new System.Drawing.Size(36, 20);
            this.numericUpDownInput.TabIndex = 3;
            this.numericUpDownInput.ValueChanged += new System.EventHandler(this.numericUpDownInput_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amplitude";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDownEI);
            this.groupBox2.Controls.Add(this.numericUpDownED);
            this.groupBox2.Controls.Add(this.numericUpDownEP);
            this.groupBox2.Controls.Add(this.chkBoxAD);
            this.groupBox2.Controls.Add(this.chkBoxAI);
            this.groupBox2.Controls.Add(this.chkBoxAP);
            this.groupBox2.Location = new System.Drawing.Point(23, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 128);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gain Settings";
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
            this.numericUpDownEI.Location = new System.Drawing.Point(44, 55);
            this.numericUpDownEI.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.numericUpDownEI.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownEI.Name = "numericUpDownEI";
            this.numericUpDownEI.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownEI.TabIndex = 15;
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
            this.numericUpDownED.Location = new System.Drawing.Point(44, 89);
            this.numericUpDownED.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.numericUpDownED.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownED.Name = "numericUpDownED";
            this.numericUpDownED.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownED.TabIndex = 14;
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
            this.numericUpDownEP.Location = new System.Drawing.Point(44, 20);
            this.numericUpDownEP.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.numericUpDownEP.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownEP.Name = "numericUpDownEP";
            this.numericUpDownEP.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownEP.TabIndex = 13;
            this.numericUpDownEP.ValueChanged += new System.EventHandler(this.numericUpDownEP_ValueChanged);
            // 
            // chkBoxAD
            // 
            this.chkBoxAD.BeforeTouchSize = new System.Drawing.Size(32, 20);
            this.chkBoxAD.Location = new System.Drawing.Point(6, 89);
            this.chkBoxAD.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.chkBoxAD.Name = "chkBoxAD";
            this.chkBoxAD.Size = new System.Drawing.Size(32, 20);
            this.chkBoxAD.TabIndex = 12;
            this.chkBoxAD.Text = "D";
            this.chkBoxAD.ThemesEnabled = false;
            // 
            // chkBoxAI
            // 
            this.chkBoxAI.BeforeTouchSize = new System.Drawing.Size(32, 20);
            this.chkBoxAI.Location = new System.Drawing.Point(6, 55);
            this.chkBoxAI.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.chkBoxAI.Name = "chkBoxAI";
            this.chkBoxAI.Size = new System.Drawing.Size(32, 20);
            this.chkBoxAI.TabIndex = 11;
            this.chkBoxAI.Text = "I";
            this.chkBoxAI.ThemesEnabled = false;
            this.chkBoxAI.CheckStateChanged += new System.EventHandler(this.chkBoxAI_CheckStateChanged);
            // 
            // chkBoxAP
            // 
            this.chkBoxAP.BeforeTouchSize = new System.Drawing.Size(32, 20);
            this.chkBoxAP.Location = new System.Drawing.Point(6, 20);
            this.chkBoxAP.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(89)))), ((int)(((byte)(91)))));
            this.chkBoxAP.Name = "chkBoxAP";
            this.chkBoxAP.Size = new System.Drawing.Size(32, 20);
            this.chkBoxAP.TabIndex = 10;
            this.chkBoxAP.Text = "P";
            this.chkBoxAP.ThemesEnabled = false;
            this.chkBoxAP.CheckStateChanged += new System.EventHandler(this.chkBoxAP_CheckStateChanged);
            // 
            // timerInput
            // 
            this.timerInput.Interval = 1000;
            this.timerInput.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblPIDControlledValueLabel
            // 
            this.lblPIDControlledValueLabel.AutoSize = true;
            this.lblPIDControlledValueLabel.Location = new System.Drawing.Point(1235, 626);
            this.lblPIDControlledValueLabel.Name = "lblPIDControlledValueLabel";
            this.lblPIDControlledValueLabel.Size = new System.Drawing.Size(108, 13);
            this.lblPIDControlledValueLabel.TabIndex = 5;
            this.lblPIDControlledValueLabel.Text = "PID Controlled Value:";
            // 
            // lblPIDControlledValue
            // 
            this.lblPIDControlledValue.AutoSize = true;
            this.lblPIDControlledValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPIDControlledValue.Location = new System.Drawing.Point(408, 11);
            this.lblPIDControlledValue.Name = "lblPIDControlledValue";
            this.lblPIDControlledValue.Size = new System.Drawing.Size(0, 16);
            this.lblPIDControlledValue.TabIndex = 7;
            // 
            // timerOutput
            // 
            this.timerOutput.Tick += new System.EventHandler(this.timerOutput_Tick);
            // 
            // chartExInput
            // 
            this.chartExInput.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(241)))), ((int)(((byte)(231))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))))});
            this.chartExInput.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.chartExInput.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartExInput.ChartArea.CursorReDraw = false;
            this.chartExInput.ChartInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.chartExInput.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(69)))), ((int)(((byte)(153))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(44)))), ((int)(((byte)(36))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(88)))), ((int)(((byte)(167))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(95)))), ((int)(((byte)(47))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(83)))), ((int)(((byte)(27))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))))};
            this.chartExInput.DataSourceName = "[none]";
            this.chartExInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.chartExInput.IsWindowLess = false;
            // 
            // 
            // 
            this.chartExInput.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Far;
            this.chartExInput.Legend.Border.Width = 2F;
            this.chartExInput.Legend.Location = new System.Drawing.Point(594, 161);
            this.chartExInput.Localize = null;
            this.chartExInput.Location = new System.Drawing.Point(265, 63);
            this.chartExInput.Name = "chartExInput";
            this.chartExInput.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.chartExInput.PrimaryXAxis.DrawGrid = false;
            this.chartExInput.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.chartExInput.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.chartExInput.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartExInput.PrimaryXAxis.Margin = true;
            this.chartExInput.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.chartExInput.PrimaryXAxis.Title = "Time (sec)";
            this.chartExInput.PrimaryXAxis.TitleColor = System.Drawing.SystemColors.ControlText;
            this.chartExInput.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.chartExInput.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.chartExInput.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartExInput.PrimaryYAxis.Margin = true;
            this.chartExInput.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.chartExInput.PrimaryYAxis.Title = "Amplitude";
            this.chartExInput.PrimaryYAxis.TitleColor = System.Drawing.SystemColors.ControlText;
            chartSeries1.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries1.Name = "Input";
            chartSeries1.Resolution = 0D;
            chartSeries1.StackingGroup = "Default Group";
            chartSeries1.Style.AltTagFormat = "";
            chartSeries1.Style.Border.Width = 2F;
            chartSeries1.Style.DisplayShadow = true;
            chartSeries1.Style.DrawTextShape = false;
            chartLineInfo1.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            chartLineInfo1.Color = System.Drawing.SystemColors.ControlText;
            chartLineInfo1.DashPattern = null;
            chartLineInfo1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartLineInfo1.Width = 1F;
            chartCustomShapeInfo1.Border = chartLineInfo1;
            chartCustomShapeInfo1.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo1.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries1.Style.TextShape = chartCustomShapeInfo1;
            chartSeries1.Text = "Input";
            chartSeries1.Type = Syncfusion.Windows.Forms.Chart.ChartSeriesType.StepLine;
            this.chartExInput.Series.Add(chartSeries1);
            this.chartExInput.ShowToolbar = true;
            this.chartExInput.Size = new System.Drawing.Size(688, 256);
            this.chartExInput.TabIndex = 8;
            this.chartExInput.Text = "Input";
            // 
            // 
            // 
            this.chartExInput.Title.Name = "Default";
            this.chartExInput.Titles.Add(this.chartExInput.Title);
            this.chartExInput.ToolBar.ButtonSize = new System.Drawing.Size(22, 19);
            this.chartExInput.ToolBar.Visible = true;
            // 
            // chartExOutput
            // 
            this.chartExOutput.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.Horizontal, new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(241)))), ((int)(((byte)(231))))),
            System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))))});
            this.chartExOutput.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.chartExOutput.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartExOutput.ChartArea.CursorReDraw = false;
            this.chartExOutput.ChartInterior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.Transparent);
            this.chartExOutput.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(69)))), ((int)(((byte)(153))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(44)))), ((int)(((byte)(36))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(88)))), ((int)(((byte)(167))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(95)))), ((int)(((byte)(47))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(83)))), ((int)(((byte)(27))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(31)))), ((int)(((byte)(64)))))};
            this.chartExOutput.DataSourceName = "[none]";
            this.chartExOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            this.chartExOutput.IsWindowLess = false;
            // 
            // 
            // 
            this.chartExOutput.Legend.Alignment = Syncfusion.Windows.Forms.Chart.ChartAlignment.Far;
            this.chartExOutput.Legend.Location = new System.Drawing.Point(586, 173);
            this.chartExOutput.Localize = null;
            this.chartExOutput.Location = new System.Drawing.Point(265, 326);
            this.chartExOutput.Name = "chartExOutput";
            this.chartExOutput.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.chartExOutput.PrimaryXAxis.DrawGrid = false;
            this.chartExOutput.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.chartExOutput.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.chartExOutput.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartExOutput.PrimaryXAxis.Margin = true;
            this.chartExOutput.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.chartExOutput.PrimaryXAxis.Title = "Time (sec)";
            this.chartExOutput.PrimaryXAxis.TitleColor = System.Drawing.SystemColors.ControlText;
            this.chartExOutput.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.chartExOutput.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.chartExOutput.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartExOutput.PrimaryYAxis.Margin = true;
            this.chartExOutput.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(158)))), ((int)(((byte)(205)))));
            this.chartExOutput.PrimaryYAxis.Title = "Amplitude";
            this.chartExOutput.PrimaryYAxis.TitleColor = System.Drawing.SystemColors.ControlText;
            chartSeries2.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries2.Name = "Output";
            chartSeries2.Points.Add(1D, ((double)(15D)));
            chartSeries2.Points.Add(2D, ((double)(20D)));
            chartSeries2.Points.Add(3D, ((double)(30D)));
            chartSeries2.Points.Add(4D, ((double)(45D)));
            chartSeries2.Points.Add(5D, ((double)(65D)));
            chartSeries2.Points.Add(6D, ((double)(70D)));
            chartSeries2.Points.Add(7D, ((double)(75D)));
            chartSeries2.Resolution = 0D;
            chartSeries2.StackingGroup = "Default Group";
            chartSeries2.Style.AltTagFormat = "";
            chartSeries2.Style.Border.Width = 2F;
            chartSeries2.Style.DisplayShadow = true;
            chartSeries2.Style.DrawTextShape = false;
            chartCustomShapeInfo2.Border = chartLineInfo1;
            chartCustomShapeInfo2.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo2.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries2.Style.TextShape = chartCustomShapeInfo2;
            chartSeries2.Text = "Output";
            chartSeries2.Type = Syncfusion.Windows.Forms.Chart.ChartSeriesType.Spline;
            this.chartExOutput.Series.Add(chartSeries2);
            this.chartExOutput.ShowToolbar = true;
            this.chartExOutput.Size = new System.Drawing.Size(688, 268);
            this.chartExOutput.TabIndex = 9;
            this.chartExOutput.Text = "Output";
            // 
            // 
            // 
            this.chartExOutput.Title.Name = "Default";
            this.chartExOutput.Titles.Add(this.chartExOutput.Title);
            this.chartExOutput.ToolBar.ButtonSize = new System.Drawing.Size(22, 19);
            this.chartExOutput.ToolBar.EnableDefaultItems = false;
            this.chartExOutput.ToolBar.Items.Add(chartToolBarSaveItem1);
            this.chartExOutput.ToolBar.Items.Add(chartToolBarCopyItem1);
            this.chartExOutput.ToolBar.Items.Add(chartToolBarPrintItem1);
            this.chartExOutput.ToolBar.Items.Add(chartToolBarPrintPreviewItem1);
            this.chartExOutput.ToolBar.Items.Add(chartToolBarSplitter1);
            this.chartExOutput.ToolBar.Items.Add(chartToolBarPaletteItem1);
            this.chartExOutput.ToolBar.Items.Add(chartToolBarStyleItem1);
            this.chartExOutput.ToolBar.Items.Add(chartToolBarTypeItem1);
            this.chartExOutput.ToolBar.Items.Add(chartToolBarSeries3DItem1);
            this.chartExOutput.ToolBar.Items.Add(chartToolBarShowLegendItem1);
            this.chartExOutput.ToolBar.Visible = true;
            // 
            // btnAnimation
            // 
            this.btnAnimation.BeforeTouchSize = new System.Drawing.Size(89, 39);
            this.btnAnimation.IsBackStageButton = false;
            this.btnAnimation.Location = new System.Drawing.Point(15, 19);
            this.btnAnimation.Name = "btnAnimation";
            this.btnAnimation.Size = new System.Drawing.Size(89, 39);
            this.btnAnimation.TabIndex = 10;
            this.btnAnimation.Text = "Fluid Level Control";
            this.btnAnimation.Click += new System.EventHandler(this.btnAnimation_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnTemparatureControl);
            this.groupBox3.Controls.Add(this.btnAnimation);
            this.groupBox3.Location = new System.Drawing.Point(23, 426);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 78);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Applications";
            // 
            // btnTemparatureControl
            // 
            this.btnTemparatureControl.BeforeTouchSize = new System.Drawing.Size(87, 39);
            this.btnTemparatureControl.IsBackStageButton = false;
            this.btnTemparatureControl.Location = new System.Drawing.Point(132, 19);
            this.btnTemparatureControl.Name = "btnTemparatureControl";
            this.btnTemparatureControl.Size = new System.Drawing.Size(87, 39);
            this.btnTemparatureControl.TabIndex = 11;
            this.btnTemparatureControl.Text = "Temparature Control";
            this.btnTemparatureControl.Click += new System.EventHandler(this.btnTemparatureControl_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericUpDownGraphSpeed);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Location = new System.Drawing.Point(23, 360);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(236, 60);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Timer Settings";
            // 
            // numericUpDownGraphSpeed
            // 
            this.numericUpDownGraphSpeed.DecimalPlaces = 1;
            this.numericUpDownGraphSpeed.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownGraphSpeed.Location = new System.Drawing.Point(168, 19);
            this.numericUpDownGraphSpeed.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownGraphSpeed.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownGraphSpeed.Name = "numericUpDownGraphSpeed";
            this.numericUpDownGraphSpeed.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownGraphSpeed.TabIndex = 1;
            this.numericUpDownGraphSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownGraphSpeed.ValueChanged += new System.EventHandler(this.numericUpDownGraphSpeed_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sampling rate(Second)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(261, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Controlled PID  Output:";
            // 
            // PIDController
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(987, 605);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.chartExOutput);
            this.Controls.Add(this.chartExInput);
            this.Controls.Add(this.lblPIDControlledValue);
            this.Controls.Add(this.lblPIDControlledValueLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbControl);
            this.Name = "PIDController";
            this.Text = "PID Controller";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.PIDController_Load);
            this.gpbControl.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInput)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownED)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBoxAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBoxAI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkBoxAP)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraphSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timerInput;
        private System.Windows.Forms.Label lblPIDControlledValueLabel;
        private System.Windows.Forms.Label lblPIDControlledValue;
        private System.Windows.Forms.Timer timerOutput;
        private Syncfusion.Windows.Forms.ButtonAdv btnAStop;
        private Syncfusion.Windows.Forms.ButtonAdv btnAStart;
        private Syncfusion.Windows.Forms.Tools.TrackBarEx TraceBarExInput;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownInput;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownEI;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownED;
        private Syncfusion.Windows.Forms.Tools.NumericUpDownExt numericUpDownEP;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkBoxAD;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkBoxAI;
        private Syncfusion.Windows.Forms.Tools.CheckBoxAdv chkBoxAP;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartExInput;
        private Syncfusion.Windows.Forms.Chart.ChartControl chartExOutput;
        private Syncfusion.Windows.Forms.ButtonAdv btnPause;
        private Syncfusion.Windows.Forms.ButtonAdv btnAnimation;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownGraphSpeed;
        private Syncfusion.Windows.Forms.ButtonAdv btnTemparatureControl;
        private System.Windows.Forms.Label label3;
    }
}

