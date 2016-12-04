namespace BoneAgeChecker
{
    partial class InitView
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitView));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.rbtnGenderMale = new System.Windows.Forms.RadioButton();
            this.rbtnGenderFemale = new System.Windows.Forms.RadioButton();
            this.xRayImagePath = new System.Windows.Forms.TextBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(224, 235);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(316, 35);
            this.tbName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bone";
            // 
            // dataTimePickerBirthday
            // 
            this.dataTimePickerBirthday.Location = new System.Drawing.Point(224, 298);
            this.dataTimePickerBirthday.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dataTimePickerBirthday.Name = "dataTimePickerBirthday";
            this.dataTimePickerBirthday.Size = new System.Drawing.Size(316, 35);
            this.dataTimePickerBirthday.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Gender";
            // 
            // rbtnGenderMale
            // 
            this.rbtnGenderMale.AutoSize = true;
            this.rbtnGenderMale.Location = new System.Drawing.Point(224, 373);
            this.rbtnGenderMale.Name = "rbtnGenderMale";
            this.rbtnGenderMale.Size = new System.Drawing.Size(88, 28);
            this.rbtnGenderMale.TabIndex = 6;
            this.rbtnGenderMale.Text = "Male";
            this.rbtnGenderMale.UseVisualStyleBackColor = true;
            this.rbtnGenderMale.CheckedChanged += new System.EventHandler(this.rbtnGenderMale_CheckedChanged);
            // 
            // rbtnGenderFemale
            // 
            this.rbtnGenderFemale.AutoSize = true;
            this.rbtnGenderFemale.Location = new System.Drawing.Point(406, 373);
            this.rbtnGenderFemale.Name = "rbtnGenderFemale";
            this.rbtnGenderFemale.Size = new System.Drawing.Size(114, 28);
            this.rbtnGenderFemale.TabIndex = 7;
            this.rbtnGenderFemale.Text = "Female";
            this.rbtnGenderFemale.UseVisualStyleBackColor = true;
            this.rbtnGenderFemale.CheckedChanged += new System.EventHandler(this.rbtnGenderFemale_CheckedChanged);
            // 
            // xRayImagePath
            // 
            this.xRayImagePath.Location = new System.Drawing.Point(106, 435);
            this.xRayImagePath.Name = "xRayImagePath";
            this.xRayImagePath.Size = new System.Drawing.Size(308, 35);
            this.xRayImagePath.TabIndex = 8;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btnLoadImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLoadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadImage.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLoadImage.ForeColor = System.Drawing.Color.White;
            this.btnLoadImage.Location = new System.Drawing.Point(422, 432);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(120, 48);
            this.btnLoadImage.TabIndex = 9;
            this.btnLoadImage.Text = "Load";
            this.btnLoadImage.UseVisualStyleBackColor = false;
            this.btnLoadImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("돋움", 9F);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(210, 546);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(234, 59);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Next";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BoneAgeChecker.Properties.Resources.title;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(663, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // InitView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 642);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.xRayImagePath);
            this.Controls.Add(this.rbtnGenderFemale);
            this.Controls.Add(this.rbtnGenderMale);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataTimePickerBirthday);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(666, 713);
            this.MinimumSize = new System.Drawing.Size(666, 713);
            this.Name = "InitView";
            this.Text = "Bone Age";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dataTimePickerBirthday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbtnGenderMale;
        private System.Windows.Forms.RadioButton rbtnGenderFemale;
        private System.Windows.Forms.TextBox xRayImagePath;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}