namespace BoneAgeChecker
{
    partial class Form2
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
            this.ibMain = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudMinICF = new System.Windows.Forms.NumericUpDown();
            this.nudMaxACFdesc = new System.Windows.Forms.NumericUpDown();
            this.nudMinACF = new System.Windows.Forms.NumericUpDown();
            this.cbAllowAngleMore45 = new System.Windows.Forms.CheckBox();
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
            this.cbShowAngle = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAdaptiveNoiseFilter = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudAdaptiveThBlockSize = new System.Windows.Forms.NumericUpDown();
            this.cbBlur = new System.Windows.Forms.CheckBox();
            this.cbAutoContrast = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ibMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.SuspendLayout();
            // 
            // ibMain
            this.ibMain.Location = new System.Drawing.Point(1, 0);
            this.ibMain.Name = "ibMain";
            this.ibMain.Size = new System.Drawing.Size(237, 439);
            this.ibMain.TabIndex = 2;
            this.ibMain.TabStop = false;
            this.ibMain.Paint += new System.Windows.Forms.PaintEventHandler(this.ibMain_Paint);
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(244, 0);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(238, 439);
            this.imageBox2.TabIndex = 3;
            this.imageBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(488, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 439);
            this.panel1.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.nudMinICF);
            this.groupBox4.Controls.Add(this.nudMaxACFdesc);
            this.groupBox4.Controls.Add(this.nudMinACF);
            this.groupBox4.Controls.Add(this.cbAllowAngleMore45);
            this.groupBox4.Location = new System.Drawing.Point(6, 318);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 121);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Recognition parameters";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(104, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "Min. ICF";

            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Min. ACF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Max. ACF descriptor deviation";
            // 
            // nudMinICF
            // 
            this.nudMinICF.DecimalPlaces = 2;
            this.nudMinICF.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudMinICF.Location = new System.Drawing.Point(106, 73);
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
            this.nudMinICF.Size = new System.Drawing.Size(56, 21);
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
            this.nudMaxACFdesc.Location = new System.Drawing.Point(8, 33);
            this.nudMaxACFdesc.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudMaxACFdesc.Name = "nudMaxACFdesc";
            this.nudMaxACFdesc.Size = new System.Drawing.Size(86, 21);
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
            this.nudMinACF.Location = new System.Drawing.Point(6, 73);
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
            this.nudMinACF.Size = new System.Drawing.Size(56, 21);
            this.nudMinACF.TabIndex = 4;
            this.nudMinACF.Value = new decimal(new int[] {
            96,
            0,
            0,
            131072});
            this.nudMinACF.ValueChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // cbAllowAngleMore45
            // 
            this.cbAllowAngleMore45.AutoSize = true;
            this.cbAllowAngleMore45.Location = new System.Drawing.Point(5, 100);
            this.cbAllowAngleMore45.Name = "cbAllowAngleMore45";
            this.cbAllowAngleMore45.Size = new System.Drawing.Size(125, 16);
            this.cbAllowAngleMore45.TabIndex = 1;
            this.cbAllowAngleMore45.Text = "Allow angles > 45";
            this.cbAllowAngleMore45.UseVisualStyleBackColor = true;
            this.cbAllowAngleMore45.CheckedChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cbNoiseFilter);
            this.groupBox3.Controls.Add(this.nudMinDefinition);
            this.groupBox3.Controls.Add(this.nudMinContourArea);
            this.groupBox3.Controls.Add(this.nudMinContourLength);
            this.groupBox3.Location = new System.Drawing.Point(6, 209);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(248, 103);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contour filtration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "Min. contour area";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "Min. contour length";
            // 
            // cbNoiseFilter
            // 
            this.cbNoiseFilter.AutoSize = true;
            this.cbNoiseFilter.Location = new System.Drawing.Point(8, 68);
            this.cbNoiseFilter.Name = "cbNoiseFilter";
            this.cbNoiseFilter.Size = new System.Drawing.Size(84, 16);
            this.cbNoiseFilter.TabIndex = 2;
            this.cbNoiseFilter.Text = "Noise filter";
            this.cbNoiseFilter.UseVisualStyleBackColor = true;
            // 
            // nudMinDefinition
            // 
            this.nudMinDefinition.Location = new System.Drawing.Point(102, 67);
            this.nudMinDefinition.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMinDefinition.Name = "nudMinDefinition";
            this.nudMinDefinition.Size = new System.Drawing.Size(80, 21);
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
            this.nudMinContourArea.Location = new System.Drawing.Point(128, 40);
            this.nudMinContourArea.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nudMinContourArea.Name = "nudMinContourArea";
            this.nudMinContourArea.Size = new System.Drawing.Size(80, 21);
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
            this.nudMinContourLength.Location = new System.Drawing.Point(8, 40);
            this.nudMinContourLength.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.nudMinContourLength.Name = "nudMinContourLength";
            this.nudMinContourLength.Size = new System.Drawing.Size(96, 21);
            this.nudMinContourLength.TabIndex = 7;
            this.nudMinContourLength.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudMinContourLength.ValueChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbShowBinarized);
            this.groupBox2.Controls.Add(this.cbShowContours);
            this.groupBox2.Controls.Add(this.cbShowAngle);
            this.groupBox2.Location = new System.Drawing.Point(6, 114);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 89);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View";
            // 
            // cbShowBinarized
            // 
            this.cbShowBinarized.AutoSize = true;
            this.cbShowBinarized.Location = new System.Drawing.Point(6, 64);
            this.cbShowBinarized.Name = "cbShowBinarized";
            this.cbShowBinarized.Size = new System.Drawing.Size(112, 16);
            this.cbShowBinarized.TabIndex = 5;
            this.cbShowBinarized.Text = "Show binarized";
            this.cbShowBinarized.UseVisualStyleBackColor = true;
            // 
            // cbShowContours
            // 
            this.cbShowContours.AutoSize = true;
            this.cbShowContours.Location = new System.Drawing.Point(5, 42);
            this.cbShowContours.Name = "cbShowContours";
            this.cbShowContours.Size = new System.Drawing.Size(109, 16);
            this.cbShowContours.TabIndex = 4;
            this.cbShowContours.Text = "Show contours";
            this.cbShowContours.UseVisualStyleBackColor = true;
            // 
            // cbShowAngle
            // 
            this.cbShowAngle.AutoSize = true;
            this.cbShowAngle.Location = new System.Drawing.Point(6, 20);
            this.cbShowAngle.Name = "cbShowAngle";
            this.cbShowAngle.Size = new System.Drawing.Size(98, 16);
            this.cbShowAngle.TabIndex = 3;
            this.cbShowAngle.Text = "Show angles";
            this.cbShowAngle.UseVisualStyleBackColor = true;
            this.cbShowAngle.CheckedChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbAdaptiveNoiseFilter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudAdaptiveThBlockSize);
            this.groupBox1.Controls.Add(this.cbBlur);
            this.groupBox1.Controls.Add(this.cbAutoContrast);
            this.groupBox1.Location = new System.Drawing.Point(4, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 95);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // cbAdaptiveNoiseFilter
            // 
            this.cbAdaptiveNoiseFilter.AutoSize = true;
            this.cbAdaptiveNoiseFilter.Location = new System.Drawing.Point(108, 65);
            this.cbAdaptiveNoiseFilter.Name = "cbAdaptiveNoiseFilter";
            this.cbAdaptiveNoiseFilter.Size = new System.Drawing.Size(84, 16);
            this.cbAdaptiveNoiseFilter.TabIndex = 5;
            this.cbAdaptiveNoiseFilter.Text = "Noise filter";
            this.cbAdaptiveNoiseFilter.UseVisualStyleBackColor = true;
            this.cbAdaptiveNoiseFilter.CheckedChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adaptive threshold block size";
            // 
            // nudAdaptiveThBlockSize
            // 
            this.nudAdaptiveThBlockSize.Location = new System.Drawing.Point(8, 64);
            this.nudAdaptiveThBlockSize.Name = "nudAdaptiveThBlockSize";
            this.nudAdaptiveThBlockSize.Size = new System.Drawing.Size(80, 21);
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
            this.cbBlur.Location = new System.Drawing.Point(108, 21);
            this.cbBlur.Name = "cbBlur";
            this.cbBlur.Size = new System.Drawing.Size(46, 16);
            this.cbBlur.TabIndex = 1;
            this.cbBlur.Text = "Blur";
            this.cbBlur.UseVisualStyleBackColor = true;
            this.cbBlur.CheckedChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged);
            // 
            // cbAutoContrast
            // 
            this.cbAutoContrast.AutoSize = true;
            this.cbAutoContrast.Location = new System.Drawing.Point(7, 21);
            this.cbAutoContrast.Name = "cbAutoContrast";
            this.cbAutoContrast.Size = new System.Drawing.Size(98, 16);
            this.cbAutoContrast.TabIndex = 0;
            this.cbAutoContrast.Text = "Auto contrast";
            this.cbAutoContrast.UseVisualStyleBackColor = true;
            this.cbAutoContrast.CheckedChanged += new System.EventHandler(this.cbAutoContrast_CheckedChanged_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 442);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.ibMain);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.ibMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.panel1.ResumeLayout(false);
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
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox ibMain;
        private Emgu.CV.UI.ImageBox imageBox2;
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
        private System.Windows.Forms.CheckBox cbAllowAngleMore45;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMinDefinition;
        private System.Windows.Forms.NumericUpDown nudMinContourArea;
        private System.Windows.Forms.NumericUpDown nudMinContourLength;
        private System.Windows.Forms.CheckBox cbShowBinarized;
        private System.Windows.Forms.CheckBox cbShowContours;
        private System.Windows.Forms.CheckBox cbShowAngle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudAdaptiveThBlockSize;
        private System.Windows.Forms.CheckBox cbNoiseFilter;
        private System.Windows.Forms.CheckBox cbBlur;
        private System.Windows.Forms.CheckBox cbAdaptiveNoiseFilter;
    }
}