using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using ContourAnalysisNS;
using System.Reflection;
using System.Resources;

namespace BoneAgeChecker
{
    public partial class MainView : Form
    {
        String name;
        int gender;
        Image<Bgr, Byte> frame;
        ImageProcessor processor;
        Dictionary<string, Image> AugmentedRealityImages = new Dictionary<string, Image>();
        List<Rectangle> userRectangle = new List<Rectangle>();
        DateTime birthday;
        int age;
        int sampleAge;
        bool showAngle;
        String templateFile;

        //   Image<Bgr, Byte> userFrame;
        public MainView(Image<Bgr, Byte> userFrame, String name, int gender, DateTime birthday)
        {/*
            InitializeComponent();

            this.userFrame = userFrame;
            imageBox1.Image = userFrame;
            */

            InitializeComponent();
            //create image preocessor
            processor = new ImageProcessor();

            this.name = name;
            this.gender = gender;
            this.birthday = birthday;

            this.Height = 960;
            this.Width = 1860;

            sampleAge = calcAge();
            age = calcAge();

            if (sampleAge == 3)
                    sampleAge = 4;
                else if (sampleAge > 20)
                sampleAge = 19;
            

            // 가져올 아이콘 이름
            string iconName = string.Format("m{0}y", sampleAge);
            // 현재 실행 중인 어셈블리를 구해서
            Assembly thisAssembly = Assembly.GetExecutingAssembly();
            // 리소스 관리자를 생성하고
            ResourceManager rm = new ResourceManager("BoneAgeChecker.Properties.Resources", thisAssembly);

            ibSample.Image = new Image<Bgr, byte>((Bitmap) rm.GetObject(iconName));


            System.Diagnostics.Trace.WriteLine(name + " / " + gender);

            frame = userFrame;
            ibMain.Image = userFrame;

            templateFile = AppDomain.CurrentDomain.BaseDirectory + "\\bone.bin";
            LoadTemplates(templateFile);
            //start capture from cam
            // StartCapture();
            //apply settings


            /**
             *   todo
             *      cam부분 template제외 code 입력
             *      벗 바이너리 제외 작동 안함.
             */
            ApplySettings();
            //
            Application.Idle += new EventHandler(Application_Idle);

        }

        int calcAge()
        {
            int age;
            if (DateTime.Now.Month > birthday.Month)
                age = DateTime.Now.Year - birthday.Year;
            else if (DateTime.Now.Month == birthday.Month)
            {
                if (DateTime.Now.Day >= birthday.Day)
                    age = DateTime.Now.Year - birthday.Year;
                else
                    age = DateTime.Now.Year - birthday.Year - 1;
            }
            else
                age = DateTime.Now.Year - birthday.Year - 1;

            return age;
        }
     

        void Application_Idle(object sender, EventArgs e)
        {
            ProcessFrame();

        }

        private void ProcessFrame()
        {
            try
            {

                //
                processor.ProcessImage(frame);
                //
                if (cbShowBinarized.Checked)
                    ibMain.Image = processor.binarizedFrame;
                else
                    ibMain.Image = frame;

                if (processor.contours != null)
                    lbContoursCount.Text = "Total Contours: " + processor.contours.Count;
                if (processor.foundTemplates != null)
                    lbRecognized.Text = "Recognized Contours: " + processor.foundTemplates.Count;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void ibSample_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font(Font.FontFamily, 24);//16
            e.Graphics.DrawString("Sample Image (" + sampleAge + "y)", new Font(Font.FontFamily, 16), Brushes.Yellow, new PointF(1, 1));

        }

        private void ibMain_Paint(object sender, PaintEventArgs e)
        {
            if (frame == null) return;

            Font font = new Font(Font.FontFamily, 24);//16

            e.Graphics.DrawString(name + "(" + age + "y)", new Font(Font.FontFamily, 16), Brushes.Yellow, new PointF(1, 1));
                

            Brush bgBrush = new SolidBrush(Color.FromArgb(255, 0, 0, 0));
            Brush foreBrush = new SolidBrush(Color.FromArgb(255, 255, 255, 255));
            Pen borderPen = new Pen(Color.FromArgb(150, 0, 255, 0));
            //
            if (cbShowContours.Checked)
                foreach (var contour in processor.contours)
                    if (contour.Total > 1)
                        e.Graphics.DrawLines(Pens.Red, contour.ToArray());
            //
            lock (processor.foundTemplates)
                foreach (FoundTemplateDesc found in processor.foundTemplates)
                {
                    if (found.template.name.EndsWith(".png") || found.template.name.EndsWith(".jpg"))
                    {
                        DrawAugmentedReality(found, e.Graphics);
                        continue;
                    }

                    Rectangle foundRect = found.sample.contour.SourceBoundingRect;
                    Point p1 = new Point((foundRect.Left + foundRect.Right) / 2, foundRect.Top);
                    string text = found.template.name;
                    if (showAngle)
                        text += string.Format("\r\nangle={0:000}°\r\nscale={1:0.0}", 180 * found.angle / Math.PI, found.scale);
                    e.Graphics.DrawRectangle(borderPen, foundRect);
                    //e.Graphics.DrawString(text, font, bgBrush, new PointF(p1.X + 1 - font.Height / 3, p1.Y + 1 - font.Height));
                    //e.Graphics.DrawString(text, font, foreBrush, new PointF(p1.X - font.Height / 3, p1.Y - font.Height));
                }
           
           
        }

        private void LoadTemplates(string fileName)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                    processor.templates.AddRange((Templates)new BinaryFormatter().Deserialize(fs));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DrawAugmentedReality(FoundTemplateDesc found, Graphics gr)
        {
            string fileName = Path.GetDirectoryName(templateFile) + "\\" + found.template.name;
            if (!AugmentedRealityImages.ContainsKey(fileName))
            {
                if (!File.Exists(fileName)) return;
                AugmentedRealityImages[fileName] = Image.FromFile(fileName);
            }
            Image img = AugmentedRealityImages[fileName];
            Point p = found.sample.contour.SourceBoundingRect.Center();
            var state = gr.Save();
            gr.TranslateTransform(p.X, p.Y);
            gr.RotateTransform((float)(180f * found.angle / Math.PI));
            gr.ScaleTransform((float)(found.scale), (float)(found.scale));
            gr.DrawImage(img, new Point(-img.Width / 2, -img.Height / 2));
            gr.Restore(state);
        }

        private void cbAutoContrast_CheckedChanged(object sender, EventArgs e)
        {
            ApplySettings();
        }

        private void ApplySettings()
        {
            try
            {
                processor.equalizeHist = cbAutoContrast.Checked;
                showAngle = false;
                //   captureFromCam = cbCaptureFromCam.Checked;
                //   btLoadImage.Enabled = !captureFromCam;
                //   cbCamResolution.Enabled = captureFromCam;
                processor.finder.maxRotateAngle =  Math.PI / 4;
                processor.minContourArea = (int)nudMinContourArea.Value;
                processor.minContourLength = (int)nudMinContourLength.Value;
                processor.finder.maxACFDescriptorDeviation = (int)nudMaxACFdesc.Value;
                processor.finder.minACF = (double)nudMinACF.Value;
                processor.finder.minICF = (double)nudMinICF.Value;
                processor.blur = cbBlur.Checked;
                processor.noiseFilter = cbNoiseFilter.Checked;
                processor.cannyThreshold = (int)nudMinDefinition.Value;
                nudMinDefinition.Enabled = processor.noiseFilter;
                processor.adaptiveThresholdBlockSize = (int)nudAdaptiveThBlockSize.Value;
                processor.adaptiveThresholdParameter = cbAdaptiveNoiseFilter.Checked ? 1.5 : 0.5;
                //cam resolution
                System.Console.WriteLine(showAngle + " / " + processor.equalizeHist + " / " + processor.blur);
                /*
                string[] parts = cbCamResolution.Text.ToLower().Split('x');
                if (parts.Length == 2)
                {
                    int camWidth = int.Parse(parts[0]);
                    int camHeight = int.Parse(parts[1]);
                    if (this.camHeight != camHeight || this.camWidth != camWidth)
                    {
                        this.camWidth = camWidth;
                        this.camHeight = camHeight;
                        ApplyCamSettings();
                    }
                }
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            InitView initView = new InitView();
            initView.Owner = this;
            initView.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}


