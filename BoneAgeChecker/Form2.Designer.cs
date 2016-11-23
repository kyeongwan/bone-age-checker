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
            this.imgBone1 = new Emgu.CV.UI.ImageBox();
            this.imgBone2 = new Emgu.CV.UI.ImageBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBone1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBone2)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBone1
            // 
            this.imgBone1.Location = new System.Drawing.Point(3, 0);
            this.imgBone1.Name = "imgBone1";
            this.imgBone1.Size = new System.Drawing.Size(250, 359);
            this.imgBone1.TabIndex = 2;
            this.imgBone1.TabStop = false;
            // 
            // imgBone2
            // 
            this.imgBone2.Location = new System.Drawing.Point(250, 0);
            this.imgBone2.Name = "imgBone2";
            this.imgBone2.Size = new System.Drawing.Size(250, 359);
            this.imgBone2.TabIndex = 2;
            this.imgBone2.TabStop = false;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(521, 359);
            this.Controls.Add(this.imgBone1);
            this.Controls.Add(this.imgBone2);
            this.Name = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.imgBone1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBone2)).EndInit();
            this.ResumeLayout(false);

        }

        private Emgu.CV.UI.ImageBox imgBone1;
        private Emgu.CV.UI.ImageBox imgBone2;
        private System.Windows.Forms.GroupBox groupBoxSource;
        private System.Windows.Forms.GroupBox groupBoxView;
        private System.Windows.Forms.GroupBox groupBoxFilteration;
        private System.Windows.Forms.GroupBox groupBoxParameters;

        private System.Windows.Forms.CheckBox cbAutoContrast; //source
        private System.Windows.Forms.CheckBox cbBlur; //source
        private System.Windows.Forms.Label labelSize; //source
        private System.Windows.Forms.NumericUpDown nudAdaptiveThBlockSize; //source
        private System.Windows.Forms.CheckBox cbAdaptiveNoiseFilter; //source

        private System.Windows.Forms.CheckBox cbShowAngle; //view
        private System.Windows.Forms.CheckBox cbShowContours; //view
        private System.Windows.Forms.CheckBox cbShowBinarized; //view

        private System.Windows.Forms.Label labelLength; //filtration
        private System.Windows.Forms.Label labelArea; //filtration
        private System.Windows.Forms.NumericUpDown nudMinContourLength; //f
        private System.Windows.Forms.NumericUpDown nudMinContourArea; //f
        private System.Windows.Forms.CheckBox cbNoiseFilter; //f
        private System.Windows.Forms.NumericUpDown nudMinDefinition; //f

        private System.Windows.Forms.Label labelDeviation; //parameters
        private System.Windows.Forms.NumericUpDown nudMaxACFdesc; //p
        private System.Windows.Forms.Label labelMinACF; //p
        private System.Windows.Forms.Label labelMinICF; //p
        private System.Windows.Forms.NumericUpDown nudMinACF; // p
        private System.Windows.Forms.NumericUpDown nudMinICF; //parameters
        private System.Windows.Forms.CheckBox cbAllowAngleMore45; //p











        #endregion

        private System.Windows.Forms.ListBox listBox1;
    }
}