namespace BoneAgeChecker
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbRecognized = new System.Windows.Forms.Label();
            this.lbContoursCount = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudMinICF = new System.Windows.Forms.NumericUpDown();
            this.nudMaxACFdesc = new System.Windows.Forms.NumericUpDown();
            this.nudMinACF = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbNoiseFilter = new System.Windows.Forms.CheckBox();
            this.nudMinDefinition = new System.Windows.Forms.NumericUpDown();
            this.nudMinContourArea = new System.Windows.Forms.NumericUpDown();
            this.nudMinContourLength = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbShowBinarized = new System.Windows.Forms.CheckBox();
            this.cbShowContours = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAdaptiveNoiseFilter = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudAdaptiveThBlockSize = new System.Windows.Forms.NumericUpDown();
            this.cbBlur = new System.Windows.Forms.CheckBox();
            this.cbAutoContrast = new System.Windows.Forms.CheckBox();
            this.ibSample = new Emgu.CV.UI.ImageBox();
            this.ibMain = new Emgu.CV.UI.ImageBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinICF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxACFdesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinACF)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinDefinition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinContourArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinContourLength)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdaptiveThBlockSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibSample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(1330, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MaximumSize = new System.Drawing.Size(520, 1000);
            this.panel1.MinimumSize = new System.Drawing.Size(520, 1000);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(520, 1000);
            this.panel1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(260, 896);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 54);
            this.button2.TabIndex = 8;
            this.button2.Text = "Process";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 896);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 54);
            this.button1.TabIndex = 7;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lbRecognized);
            this.groupBox5.Controls.Add(this.lbContoursCount);
            this.groupBox5.Location = new System.Drawing.Point(11, 755);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox5.Size = new System.Drawing.Size(474, 123);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Contour Status";
            // 
            // lbRecognized
            // 
            this.lbRecognized.AutoSize = true;
            this.lbRecognized.Location = new System.Drawing.Point(11, 83);
            this.lbRecognized.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbRecognized.Name = "lbRecognized";
            this.lbRecognized.Size = new System.Drawing.Size(248, 24);
            this.lbRecognized.TabIndex = 5;
            this.lbRecognized.Text = "Recognized Contours: ";
            // 
            // lbContoursCount
            // 
            this.lbContoursCount.AutoSize = true;
            this.lbContoursCount.Location = new System.Drawing.Point(11, 34);
            this.lbContoursCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbContoursCount.Name = "lbContoursCount";
            this.lbContoursCount.Size = new System.Drawing.Size(179, 24);
            this.lbContoursCount.TabIndex = 4;
            this.lbContoursCount.Text = "Total Contours: ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.nudMinICF);
            this.groupBox4.Controls.Add(this.nudMaxACFdesc);
            this.groupBox4.Controls.Add(this.nudMinACF);
            this.groupBox4.Location = new System.Drawing.Point(11, 603);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox4.Size = new System.Drawing.Size(474, 141);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Recognition parameters";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(361, 35);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Min. ICF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Min. ACF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Max. ACF deviation";
            // 
            // nudMinICF
            // 
            this.nudMinICF.DecimalPlaces = 2;
            this.nudMinICF.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudMinICF.Location = new System.Drawing.Point(362, 66);
            this.nudMinICF.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.nudMinICF.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinICF.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nudMinICF.Name = "nudMinICF";
            this.nudMinICF.Size = new System.Drawing.Size(104, 35);
            this.nudMinICF.TabIndex = 6;
            this.nudMinICF.Value = new decimal(new int[] {
            85,
            0,
            0,
            131072});
            this.nudMinICF.ValueChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // nudMaxACFdesc
            // 
            this.nudMaxACFdesc.Location = new System.Drawing.Point(15, 66);
            this.nudMaxACFdesc.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.nudMaxACFdesc.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudMaxACFdesc.Name = "nudMaxACFdesc";
            this.nudMaxACFdesc.Size = new System.Drawing.Size(159, 35);
            this.nudMaxACFdesc.TabIndex = 5;
            this.nudMaxACFdesc.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudMaxACFdesc.ValueChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // nudMinACF
            // 
            this.nudMinACF.DecimalPlaces = 2;
            this.nudMinACF.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudMinACF.Location = new System.Drawing.Point(249, 66);
            this.nudMinACF.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.nudMinACF.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinACF.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nudMinACF.Name = "nudMinACF";
            this.nudMinACF.Size = new System.Drawing.Size(104, 35);
            this.nudMinACF.TabIndex = 4;
            this.nudMinACF.Value = new decimal(new int[] {
            96,
            0,
            0,
            131072});
            this.nudMinACF.ValueChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cbNoiseFilter);
            this.groupBox3.Controls.Add(this.nudMinDefinition);
            this.groupBox3.Controls.Add(this.nudMinContourArea);
            this.groupBox3.Controls.Add(this.nudMinContourLength);
            this.groupBox3.Location = new System.Drawing.Point(11, 384);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox3.Size = new System.Drawing.Size(474, 206);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contour filtration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "Min. contour area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Min. contour length";
            // 
            // cbNoiseFilter
            // 
            this.cbNoiseFilter.AutoSize = true;
            this.cbNoiseFilter.Location = new System.Drawing.Point(15, 136);
            this.cbNoiseFilter.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbNoiseFilter.Name = "cbNoiseFilter";
            this.cbNoiseFilter.Size = new System.Drawing.Size(150, 28);
            this.cbNoiseFilter.TabIndex = 2;
            this.cbNoiseFilter.Text = "Noise filter";
            this.cbNoiseFilter.UseVisualStyleBackColor = true;
            this.cbNoiseFilter.CheckedChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // nudMinDefinition
            // 
            this.nudMinDefinition.Location = new System.Drawing.Point(190, 134);
            this.nudMinDefinition.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.nudMinDefinition.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMinDefinition.Name = "nudMinDefinition";
            this.nudMinDefinition.Size = new System.Drawing.Size(148, 35);
            this.nudMinDefinition.TabIndex = 9;
            this.nudMinDefinition.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudMinDefinition.ValueChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // nudMinContourArea
            // 
            this.nudMinContourArea.Location = new System.Drawing.Point(237, 80);
            this.nudMinContourArea.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.nudMinContourArea.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nudMinContourArea.Name = "nudMinContourArea";
            this.nudMinContourArea.Size = new System.Drawing.Size(148, 35);
            this.nudMinContourArea.TabIndex = 8;
            this.nudMinContourArea.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudMinContourArea.ValueChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // nudMinContourLength
            // 
            this.nudMinContourLength.Location = new System.Drawing.Point(15, 80);
            this.nudMinContourLength.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.nudMinContourLength.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nudMinContourLength.Name = "nudMinContourLength";
            this.nudMinContourLength.Size = new System.Drawing.Size(179, 35);
            this.nudMinContourLength.TabIndex = 7;
            this.nudMinContourLength.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudMinContourLength.ValueChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbShowBinarized);
            this.groupBox2.Controls.Add(this.cbShowContours);
            this.groupBox2.Location = new System.Drawing.Point(11, 227);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox2.Size = new System.Drawing.Size(474, 144);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View";
            // 
            // cbShowBinarized
            // 
            this.cbShowBinarized.AutoSize = true;
            this.cbShowBinarized.Location = new System.Drawing.Point(11, 85);
            this.cbShowBinarized.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbShowBinarized.Name = "cbShowBinarized";
            this.cbShowBinarized.Size = new System.Drawing.Size(199, 28);
            this.cbShowBinarized.TabIndex = 5;
            this.cbShowBinarized.Text = "Show binarized";
            this.cbShowBinarized.UseVisualStyleBackColor = true;
            // 
            // cbShowContours
            // 
            this.cbShowContours.AutoSize = true;
            this.cbShowContours.Location = new System.Drawing.Point(11, 42);
            this.cbShowContours.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbShowContours.Name = "cbShowContours";
            this.cbShowContours.Size = new System.Drawing.Size(200, 28);
            this.cbShowContours.TabIndex = 4;
            this.cbShowContours.Text = "Show contours";
            this.cbShowContours.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAdaptiveNoiseFilter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudAdaptiveThBlockSize);
            this.groupBox1.Controls.Add(this.cbBlur);
            this.groupBox1.Controls.Add(this.cbAutoContrast);
            this.groupBox1.Location = new System.Drawing.Point(8, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.groupBox1.Size = new System.Drawing.Size(478, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            // 
            // cbAdaptiveNoiseFilter
            // 
            this.cbAdaptiveNoiseFilter.AutoSize = true;
            this.cbAdaptiveNoiseFilter.Location = new System.Drawing.Point(229, 123);
            this.cbAdaptiveNoiseFilter.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbAdaptiveNoiseFilter.Name = "cbAdaptiveNoiseFilter";
            this.cbAdaptiveNoiseFilter.Size = new System.Drawing.Size(150, 28);
            this.cbAdaptiveNoiseFilter.TabIndex = 5;
            this.cbAdaptiveNoiseFilter.Text = "Noise filter";
            this.cbAdaptiveNoiseFilter.UseVisualStyleBackColor = true;
            this.cbAdaptiveNoiseFilter.CheckedChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adaptive threshold block size";
            // 
            // nudAdaptiveThBlockSize
            // 
            this.nudAdaptiveThBlockSize.Location = new System.Drawing.Point(15, 128);
            this.nudAdaptiveThBlockSize.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.nudAdaptiveThBlockSize.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudAdaptiveThBlockSize.Name = "nudAdaptiveThBlockSize";
            this.nudAdaptiveThBlockSize.Size = new System.Drawing.Size(148, 35);
            this.nudAdaptiveThBlockSize.TabIndex = 3;
            this.nudAdaptiveThBlockSize.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudAdaptiveThBlockSize.ValueChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // cbBlur
            // 
            this.cbBlur.AutoSize = true;
            this.cbBlur.Location = new System.Drawing.Point(229, 42);
            this.cbBlur.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbBlur.Name = "cbBlur";
            this.cbBlur.Size = new System.Drawing.Size(79, 28);
            this.cbBlur.TabIndex = 1;
            this.cbBlur.Text = "Blur";
            this.cbBlur.UseVisualStyleBackColor = true;
            this.cbBlur.CheckedChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // cbAutoContrast
            // 
            this.cbAutoContrast.AutoSize = true;
            this.cbAutoContrast.Location = new System.Drawing.Point(13, 42);
            this.cbAutoContrast.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cbAutoContrast.Name = "cbAutoContrast";
            this.cbAutoContrast.Size = new System.Drawing.Size(184, 28);
            this.cbAutoContrast.TabIndex = 0;
            this.cbAutoContrast.Text = "Auto contrast";
            this.cbAutoContrast.UseVisualStyleBackColor = true;
            this.cbAutoContrast.CheckedChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // ibSample
            // 
            this.ibSample.Location = new System.Drawing.Point(660, 0);
            this.ibSample.Margin = new System.Windows.Forms.Padding(0);
            this.ibSample.MaximumSize = new System.Drawing.Size(650, 870);
            this.ibSample.MinimumSize = new System.Drawing.Size(650, 870);
            this.ibSample.Name = "ibSample";
            this.ibSample.Size = new System.Drawing.Size(650, 870);
            this.ibSample.TabIndex = 3;
            this.ibSample.TabStop = false;
            this.ibSample.Paint += new System.Windows.Forms.PaintEventHandler(this.ibSample_Paint);
            // 
            // ibMain
            // 
            this.ibMain.Location = new System.Drawing.Point(0, 0);
            this.ibMain.Margin = new System.Windows.Forms.Padding(0);
            this.ibMain.MaximumSize = new System.Drawing.Size(650, 870);
            this.ibMain.MinimumSize = new System.Drawing.Size(650, 870);
            this.ibMain.Name = "ibMain";
            this.ibMain.Size = new System.Drawing.Size(650, 870);
            this.ibMain.TabIndex = 2;
            this.ibMain.TabStop = false;
            this.ibMain.Paint += new System.Windows.Forms.PaintEventHandler(this.ibMain_Paint);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1834, 949);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ibSample);
            this.Controls.Add(this.ibMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximumSize = new System.Drawing.Size(1860, 1020);
            this.MinimumSize = new System.Drawing.Size(1860, 1020);
            this.Name = "MainView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoneAge";
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinICF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxACFdesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinACF)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinDefinition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinContourArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinContourLength)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdaptiveThBlockSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibSample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox ibMain;
        private Emgu.CV.UI.ImageBox ibSample;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbAutoContrast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudMinICF;
        private System.Windows.Forms.NumericUpDown nudMaxACFdesc;
        private System.Windows.Forms.NumericUpDown nudMinACF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMinDefinition;
        private System.Windows.Forms.NumericUpDown nudMinContourArea;
        private System.Windows.Forms.NumericUpDown nudMinContourLength;
        private System.Windows.Forms.CheckBox cbShowBinarized;
        private System.Windows.Forms.CheckBox cbShowContours;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAdaptiveThBlockSize;
        private System.Windows.Forms.CheckBox cbNoiseFilter;
        private System.Windows.Forms.CheckBox cbBlur;
        private System.Windows.Forms.CheckBox cbAdaptiveNoiseFilter;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label lbRecognized;
        private System.Windows.Forms.Label lbContoursCount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}