namespace BoneAgeChecker
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
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
            this.ibMain = new Emgu.CV.UI.ImageBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ibMain)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "BoneAge Checker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "이름";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(225, 139);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(301, 35);
            this.tbName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "생년월일";
            // 
            // dataTimePickerBirthday
            // 
            this.dataTimePickerBirthday.Location = new System.Drawing.Point(225, 201);
            this.dataTimePickerBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.dataTimePickerBirthday.Name = "dataTimePickerBirthday";
            this.dataTimePickerBirthday.Size = new System.Drawing.Size(301, 35);
            this.dataTimePickerBirthday.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 273);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "성별";
            // 
            // rbtnGenderMale
            // 
            this.rbtnGenderMale.AutoSize = true;
            this.rbtnGenderMale.Location = new System.Drawing.Point(265, 275);
            this.rbtnGenderMale.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnGenderMale.Name = "rbtnGenderMale";
            this.rbtnGenderMale.Size = new System.Drawing.Size(83, 29);
            this.rbtnGenderMale.TabIndex = 6;
            this.rbtnGenderMale.Text = "남자";
            this.rbtnGenderMale.UseVisualStyleBackColor = true;
            // 
            // rbtnGenderFemale
            // 
            this.rbtnGenderFemale.AutoSize = true;
            this.rbtnGenderFemale.Location = new System.Drawing.Point(402, 275);
            this.rbtnGenderFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnGenderFemale.Name = "rbtnGenderFemale";
            this.rbtnGenderFemale.Size = new System.Drawing.Size(83, 29);
            this.rbtnGenderFemale.TabIndex = 7;
            this.rbtnGenderFemale.Text = "여자";
            this.rbtnGenderFemale.UseVisualStyleBackColor = true;
            // 
            // xRayImagePath
            // 
            this.xRayImagePath.Location = new System.Drawing.Point(105, 339);
            this.xRayImagePath.Margin = new System.Windows.Forms.Padding(4);
            this.xRayImagePath.Name = "xRayImagePath";
            this.xRayImagePath.Size = new System.Drawing.Size(308, 35);
            this.xRayImagePath.TabIndex = 8;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Font = new System.Drawing.Font("굴림", 10.4F);
            this.btnLoadImage.Location = new System.Drawing.Point(426, 339);
            this.btnLoadImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(100, 49);
            this.btnLoadImage.TabIndex = 9;
            this.btnLoadImage.Text = "Load";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // ibMain
            // 
            this.ibMain.Location = new System.Drawing.Point(128, 495);
            this.ibMain.Margin = new System.Windows.Forms.Padding(4);
            this.ibMain.Name = "ibMain";
            this.ibMain.Size = new System.Drawing.Size(389, 307);
            this.ibMain.TabIndex = 2;
            this.ibMain.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(249, 418);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(152, 48);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "확인";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 831);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.ibMain);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Bone Age Checker";
            ((System.ComponentModel.ISupportInitialize)(this.ibMain)).EndInit();
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
        private Emgu.CV.UI.ImageBox ibMain;
        private System.Windows.Forms.Button btnSubmit;
    }
}
