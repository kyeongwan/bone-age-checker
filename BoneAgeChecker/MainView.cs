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
using System.ComponentModel;

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
        double resultAge;

        AlertForm alert;

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

            ibSample.Image = new Image<Bgr, byte>((Bitmap)rm.GetObject(iconName));


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
                processor.finder.maxRotateAngle = Math.PI / 4;
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
            double tmp = 0;
            List<int> agelist = new List<int>();
            foreach (FoundTemplateDesc found in processor.foundTemplates)
            {
                int tage = Int32.Parse((found.template.name.Substring(0, 2).Replace("y", "").Replace("m", "")));
                // if ((tage - age < 6 && tage - age > 0)||(age-tage < 6 && age-tage > 0))
                {
                    agelist.Add(tage);
                    System.Console.WriteLine(tage);
                }
            }
            agelist.Sort();
            System.Console.WriteLine(agelist.Count + " ////// ");
            try
            {
                int cnt = 0;
                for (int i = (int)(agelist.Count * 0.3); i < agelist.Count; i++)
                {
                    System.Console.WriteLine(agelist[i] + " /  " + i);
                    tmp += agelist[i];
                    cnt++;
                }
                tmp /= cnt;
            }
            catch (Exception ex)
            {
                tmp = age;
            }


            resultAge = (tmp * 0.7) + (age * 0.3);
            System.Console.WriteLine(resultAge);

            if (backgroundWorker1.IsBusy != true)
            {
                // create a new instance of the alert form
                alert = new AlertForm();
                // event handler for the Cancel button in AlertForm
                alert.Canceled += new EventHandler<EventArgs>(buttonCancel_Click);
                alert.Show();
                // Start the asynchronous operation.
                backgroundWorker1.RunWorkerAsync();
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                backgroundWorker1.CancelAsync();
                // Close the AlertForm
                alert.Close();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            for (int i = 1; i <= 10; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    // Perform a time consuming operation and report progress.
                    worker.ReportProgress(i * 10);
                    System.Threading.Thread.Sleep(500);
                }
            }
        }

        // This event handler updates the progress.
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Show the progress in main form (GUI)
            //labelResult.Text = (e.ProgressPercentage.ToString() + "%");
            // Pass the progress to AlertForm label and progressbar
            alert.Message = "In progress, please wait... " + e.ProgressPercentage.ToString() + "%";
            alert.ProgressValue = e.ProgressPercentage;
        }

        // This event handler deals with the results of the background operation.
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                MessageBox.Show("Cancle.",
                 "Cancle");
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Error requried.",
                "Error");
            }
            else
            {
                MessageBox.Show("Real Age: " + age + "\nResult Age: "+resultAge.ToString("N2"), "Result");
            }
            // Close the AlertForm
            alert.Close();
        }
    }
}


