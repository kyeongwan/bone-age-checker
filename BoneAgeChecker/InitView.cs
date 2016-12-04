using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace BoneAgeChecker
{
    public partial class InitView : Form
    {
        String name;
        int gender = 0;
        Image<Bgr, Byte> iframe;
        public InitView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image|*.bmp;*.png;*.jpg;*.jpeg";
            if (ofd.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                try
                {
                    iframe = new Image<Bgr, byte>((Bitmap)Bitmap.FromFile(ofd.FileName));
                    xRayImagePath.Text = ofd.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    System.Diagnostics.Trace.WriteLine(ex.StackTrace + "Fail Load Image");
                }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (iframe == null)
            {
                MessageBox.Show("Can not load image. Please check your file path.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            else if(tbName.Text == "")
            {
                MessageBox.Show("Please insert patient's name.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            else if(gender == 0)
            {
                MessageBox.Show("Please check patient's gender.",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            }
            else
            {
                this.Visible = false;
                MainView mainView = new MainView(iframe, tbName.Text, gender, dataTimePickerBirthday.Value);
                mainView.Owner = this;
                mainView.Show();
            }
        }

        private void rbtnGenderMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = 1;
        }

        private void rbtnGenderFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = 2;
        }
    }
}