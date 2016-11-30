using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace BoneAgeChecker
{
    public partial class Form1 : Form
    {

        Image<Bgr, Byte> iframe;
        public Form1()
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
                    //ibMain에 로드한 이미지띄우기
                    iframe._EqualizeHist();
                    iframe._EqualizeHist();
                    iframe._EqualizeHist();
                    ibMain.Image = iframe;

                    xRayImagePath.Text = ofd.FileName;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    System.Diagnostics.Trace.WriteLine(ex.StackTrace + "***************이미지못불로왔따******");
                }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 frm = new Form2(iframe);
            frm.Owner = this;
            frm.Show();
        }
    }
}