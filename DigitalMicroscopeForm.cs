using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;
using DirectShowLib;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Threading;
using System.Drawing.Text;
using System.IO;
using System.Drawing.Drawing2D;

namespace DigitalMicroscope
{
    public partial class DigitalMicroscopeForm : MetroForm
    {

        private DsDevice[] CaptureDevices;
        private VideoCapture Camera;
        public Mat Frame;
        private VideoWriter vw;
        private SaveFileDialog SFDLG;
        private int FOURCC;

        private bool AsyncTaskResult;

        private double SensorSizeW = 2592;
        private double SensorSizeH = 1944;
        private double FPS = 14;

        private int ContainerDisplayWidth;
        private int ContainerDisplayHeight;

        private bool StartMonitoringControl = false;

        private double SensorSizeRatio;
        private double ImageXRatio;
        private double ImageYRatio;

        private bool VideoRecordingControl = false;
        
        private bool LengthMeasureType = false;
        private bool RadiusMeasureType = false;

        private bool IsMouseDown = false;
        private Point StartLocation;
        private Point EndLocation;
        private Point CircleEndLocation;

        private double PixelResolution = 8.63;

        private double MeasureLenghtX;
        private double MeasureLenghtY;
        private double MeasureLenghtPx;
        private double MeasureLenghtmm;

        private double MeasureRadiusPx;
        private double MeasureRadiusmm;

        Pen MeasureLengthPen;
        AdjustableArrowCap MeasureLengthPenArrow;

        Font MeasureStringFont;
        SolidBrush MeasureStringBrush;
        
        Pen MeasureRadiusPen;

        public DigitalMicroscopeForm()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;

            Frame = new Mat();
            SFDLG = new SaveFileDialog();

            DefaultMeasurePoints();

            MeasureLengthPen = new Pen(Color.IndianRed, 5f);
            MeasureLengthPenArrow = new AdjustableArrowCap(5, 5);
            MeasureLengthPen.CustomEndCap = MeasureLengthPenArrow;
            MeasureLengthPen.CustomStartCap = MeasureLengthPenArrow;

            MeasureStringFont = new Font(Display.Font.FontFamily, 32, FontStyle.Regular, GraphicsUnit.Pixel);
            MeasureStringBrush = new SolidBrush(Color.Blue);

            MeasureRadiusPen = new Pen(Color.ForestGreen, 5f);

            Display.SizeMode = PictureBoxSizeMode.Zoom;

            InstallCaptureDevicesAndMeasureTypes();
        }
        
        private async Task<bool> AsyncIconMonitoring(string filename)
        {
            Display.Image = new Bitmap(Application.StartupPath + "\\" + filename);
            return true;
        }

        private async void DigitalMicroscopeForm_Load(object sender, EventArgs e)
        {
            SensorSizeWidthTxt.Text = SensorSizeW.ToString();
            SensorSizeHeightTxt.Text = SensorSizeH.ToString();
            CameraFpsTxt.Text = FPS.ToString();
            PixelResolutionTxt.Text = PixelResolution.ToString();
            
            AsyncTaskResult = await Task.Run<bool>(() => AsyncIconMonitoring("microscope.png"));

            this.WindowState = FormWindowState.Maximized;
            
            //Display Scaling
            ContainerDisplayPanel.Width = this.Width - 45 - ControlPanel.Width;
            ContainerDisplayPanel.Height = this.Height - 75;
            ControlPanel.Location = new Point(ContainerDisplayPanel.Width + 30, ContainerDisplayPanel.Location.Y);
            ControlPanel.Height = ContainerDisplayPanel.Height;

            Display.Location = new Point(0, 0);
            Display.Dock = DockStyle.Fill;

            VideoRecordInfoLabel.Text = "";
        }

        private void DigitalMicroscopeForm_Resize(object sender, EventArgs e)
        {
            /*
            TempWidth = this.Width - ControlPanel.Width;
            Display.Width = TempWidth - 50;
            int a = Convert.ToInt32(this.Height / 1.86);
            Display.Height = a;
            ControlPanel.Location = new Point(TempWidth - 15, Display.Location.Y);
            */
        }


        private void InstallCaptureDevicesAndMeasureTypes()
        {
            CaptureDevices = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            foreach (DsDevice capturedevice in CaptureDevices)
            {
                CaptureDevicesCombobox.Items.Add(capturedevice.Name);
            }
            CaptureDevicesCombobox.SelectedItem = 0;

            MeasureTypesCombobox.Items.Add("Length");
            MeasureTypesCombobox.Items.Add("Radius");
            MeasureTypesCombobox.SelectedItem = 0;
        }

        private async void StartMonitoringButton_Click(object sender, EventArgs e)
        {
            AsyncTaskResult = await Task.Run<bool>(() => AsyncIconMonitoring("PleaseWait.gif"));
            Thread.Sleep(1000);

            if (!CaptureDevicesCombobox.Text.Equals("") && !SensorSizeWidthTxt.Text.Equals("") && !SensorSizeHeightTxt.Text.Equals("") && !CameraFpsTxt.Text.Equals(""))
            {
                SensorSizeW = Convert.ToInt32(SensorSizeWidthTxt.Text);
                SensorSizeH = Convert.ToInt32(SensorSizeHeightTxt.Text);
                FPS = Convert.ToInt32(CameraFpsTxt.Text);
                
                Display.Dock = DockStyle.None;
                ContainerDisplayWidth = ContainerDisplayPanel.Width;
                ContainerDisplayHeight = ContainerDisplayPanel.Height;
                SensorSizeRatio = SensorSizeW / SensorSizeH;

                if (ContainerDisplayWidth > ContainerDisplayHeight)
                {
                    Display.Width = Convert.ToInt32(ContainerDisplayHeight * SensorSizeRatio);
                    Display.Height = ContainerDisplayHeight;
                    Display.Location = new Point((ContainerDisplayWidth - Display.Width) / 2, 0);
                    ImageXRatio = SensorSizeW / Display.Width;
                    ImageYRatio = SensorSizeH / Display.Height;
                }
                else
                {
                    Display.Width = ContainerDisplayWidth;
                    Display.Height = Convert.ToInt32(ContainerDisplayWidth * SensorSizeRatio);
                    Display.Location = new Point(0 , (ContainerDisplayHeight - Display.Height) / 2);
                    ImageXRatio = SensorSizeW / Display.Width;
                    ImageYRatio = SensorSizeH / Display.Height;
                }

                StartMonitoring();
            }
            else
            {
                AsyncTaskResult = await Task.Run<bool>(() => AsyncIconMonitoring("microscope.png"));
                MetroFramework.MetroMessageBox.Show(this, "\n\nCheck the Capture Device , Sensor Size Width , Sensor Size Height and Camera FPS Values", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void StartMonitoring()
        {
            AsyncTaskResult = await Task.Run<bool>(() => AsyncIconMonitoring("PleaseWait.gif"));
            Camera = new VideoCapture(CaptureDevicesCombobox.SelectedIndex);
            Camera.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth, SensorSizeW);
            Camera.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight, SensorSizeH);
            Camera.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps, FPS);
            //Camera.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameCount, FrameCount);
            Application.Idle += ProcessFrame;
        }


        private async void ProcessFrame(object sender, EventArgs arg)
        {
            try
            {
                Frame = Camera.QueryFrame();
                Display.Image = Frame.ToImage<Bgr, Byte>().Bitmap;
                Frame.Dispose();
                StartMonitoringControl = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                StartMonitoringControl = false;
                Application.Idle -= ProcessFrame;
                AsyncTaskResult = await Task.Run<bool>(() => AsyncIconMonitoring("microscope.png"));
                MetroFramework.MetroMessageBox.Show(this, "\n\nCapture device not found\nMake sure the device is connected", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ProcessFrameVideoRecord(object sender, EventArgs arg)
        {
            try
            {
                Frame = Camera.QueryFrame();
                Display.Image = Frame.ToImage<Bgr, Byte>().Bitmap;
                vw.Write(Frame);
                Frame.Dispose();
                StartMonitoringControl = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                StartMonitoringControl = false;
                Application.Idle -= ProcessFrameVideoRecord;
                AsyncTaskResult = await Task.Run<bool>(() => AsyncIconMonitoring("microscope.png"));
                MetroFramework.MetroMessageBox.Show(this, "\n\nCapture device not found\nMake sure the device is connected", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ZoomInButton_Click(object sender, EventArgs e)
        {

        }

        private void ZoomOutButton_Click(object sender, EventArgs e)
        {

        }

        private void FocusIncreaseButton_Click(object sender, EventArgs e)
        {

        }

        private void FocusDecreaseButton_Click(object sender, EventArgs e)
        {

        }

        private void TakeSnapshotButton_Click(object sender, EventArgs e)
        {
            //MemoryStream ms = new MemoryStream();

            //Display.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);

            //byte[] buff = ms.GetBuffer();

            //Image x = (Bitmap)((new ImageConverter()).ConvertFrom(buff));

            //pictureBox1.Image = x;


            //pictureBox1.Image = newBitmap;


            //Bitmap destBitmap = new Bitmap(Display.Width, Display.Height);
            //Graphics g = Graphics.FromImage(destBitmap);
            //g.DrawImage(Display.Image, new Rectangle(0, 0, Display.Width, Display.Height), rectCropArea, GraphicsUnit.Pixel);
            //g.Dispose();

            //pictureBox1.Image = destBitmap;



            if (StartMonitoringControl)
            {
                SFDLG.FileName = "*";
                SFDLG.DefaultExt = "jpg";
                SFDLG.ValidateNames = true;
                SFDLG.Filter = "JPG Image (.jpg)|*.jpg |Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif |Png Image (.png)|*.png |Tiff Image (.tiff)|*.tiff";
                if (SFDLG.ShowDialog() == DialogResult.OK)
                {
                    //Frame.Save(SFDLG.FileName);
                    //CvInvoke.Imwrite(SFDLG.FileName, Frame);

                    switch (Path.GetExtension(SFDLG.FileName))
                    {

                        case ".jpg":
                            Display.Image.Save(SFDLG.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;
                        case ".bmp":
                            Display.Image.Save(SFDLG.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;
                        case ".gif":
                            Display.Image.Save(SFDLG.FileName, System.Drawing.Imaging.ImageFormat.Gif);
                            break;
                        case ".png":
                            Display.Image.Save(SFDLG.FileName, System.Drawing.Imaging.ImageFormat.Png);
                            break;
                        case ".tiff":
                            Display.Image.Save(SFDLG.FileName, System.Drawing.Imaging.ImageFormat.Tiff);
                            break;
                        default:
                            break;
                    }
                }
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "\n\nBefore The Image Should Be Taken", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void VideoRecordStartButton_Click(object sender, EventArgs e)
        {
            if (StartMonitoringControl)
            {
                SFDLG.FileName = "*";
                SFDLG.DefaultExt = "mp4";
                SFDLG.ValidateNames = true;
                SFDLG.Filter = "MP4 Video (.mp4)|*.mp4 | AVI Video (.avi)|*.avi | MKV Video (.mkv)|*.mkv ";
                if (SFDLG.ShowDialog() == DialogResult.OK)
                {
                    FOURCC = Convert.ToInt32(Camera.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.FourCC));
                    vw = new VideoWriter(SFDLG.FileName, FOURCC, FPS, new Size(Convert.ToInt32(SensorSizeW), Convert.ToInt32(SensorSizeH)), true);
                    Application.Idle -= ProcessFrame;
                    Application.Idle += ProcessFrameVideoRecord;
                    VideoRecordInfoLabel.Text = "Video Recording...";
                    VideoRecordingControl = true;
                }
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "\n\nBefore The Image Should Be Taken", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void VideoRecordStopButton_Click(object sender, EventArgs e)
        {
            if (StartMonitoringControl)
            {
                if (VideoRecordingControl)
                {
                    Application.Idle -= ProcessFrameVideoRecord;
                    Application.Idle += ProcessFrame;
                    if (vw.IsOpened)
                        vw.Dispose();
                    MetroFramework.MetroMessageBox.Show(this, "\n\nVideo Recorded", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    VideoRecordInfoLabel.Text = "";
                    VideoRecordingControl = false;
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "\n\nVideo Recording Must Be Started Before", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "\n\nBefore The Image Should Be Taken", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DefaultMeasurePoints()
        {
            StartLocation = new Point(0, 0);
            EndLocation = new Point(-50, -50);
            CircleEndLocation = new Point(0, 0);
        }

        private void MeasureTypesCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StartMonitoringControl)
            {
                DefaultMeasurePoints();
                if (MeasureTypesCombobox.SelectedIndex.Equals(0))
                {
                    LengthMeasureType = true;
                    RadiusMeasureType = false;
                }
                else if (MeasureTypesCombobox.SelectedIndex.Equals(1))
                {
                    RadiusMeasureType = true;
                    LengthMeasureType = false;
                }
                else
                {
                    RadiusMeasureType = false;
                    LengthMeasureType = false;
                }
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "\n\nBefore The Image Should Be Taken", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MeasureButton_Click(object sender, EventArgs e)
        {
            if (StartMonitoringControl)
            {
                if (!MeasureTypesCombobox.Text.Equals("") && !PixelResolutionTxt.Text.Equals(""))
                    PixelResolution = Convert.ToDouble(PixelResolutionTxt.Text);
                else
                    MetroFramework.MetroMessageBox.Show(this, "\n\nCheck the Measure Types and Pixel Resolution Values", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "\n\nBefore The Image Should Be Taken", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Display_MouseDown(object sender, MouseEventArgs e)
        {
            if (StartMonitoringControl)
            {
                if (LengthMeasureType || RadiusMeasureType)
                {
                    IsMouseDown = true;
                    StartLocation = e.Location;
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "\n\nSelect the Measure Type", "Info!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "\n\nBefore The Image Should Be Taken", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Display_MouseMove(object sender, MouseEventArgs e)
        {
            if (StartMonitoringControl)
            {
                if (EndLocation.X > Display.Width && EndLocation.Y > Display.Height)
                {
                    MouseUpandOwerflowControl(e);
                }
                if (IsMouseDown)
                {
                    EndLocation = e.Location;
                    Display.Invalidate();

                    if (LengthMeasureType)
                    {
                        MeasureLenghtX = Math.Abs(EndLocation.X - StartLocation.X) * ImageXRatio;
                        MeasureLenghtY = Math.Abs(EndLocation.Y - StartLocation.Y) * ImageYRatio;
                        MeasureLenghtPx = Math.Sqrt((MeasureLenghtX * MeasureLenghtX) + (MeasureLenghtY * MeasureLenghtY));
                        MeasureLenghtmm = Math.Round(((MeasureLenghtPx * PixelResolution) / 1000), 2);
                    }

                    if (RadiusMeasureType)
                    {
                        if ((StartLocation.X - EndLocation.X) < (StartLocation.Y - EndLocation.Y))
                            CircleEndLocation = new Point(Math.Abs(StartLocation.X - EndLocation.X), Math.Abs(StartLocation.X - EndLocation.X));
                        else
                            CircleEndLocation = new Point(Math.Abs(StartLocation.Y - EndLocation.Y), Math.Abs(StartLocation.Y - EndLocation.Y));

                        MeasureRadiusPx = (CircleEndLocation.X / 2) * ImageXRatio;
                        MeasureRadiusmm = Math.Round((MeasureRadiusPx * PixelResolution) / 1000, 2);
                    }
                }
            }
        }

        private void Display_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUpandOwerflowControl(e);
        }

        private void MouseUpandOwerflowControl(MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                EndLocation = e.Location;
                IsMouseDown = false;
            }
        }
        private void Display_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            if (StartMonitoringControl)
            {
                if (LengthMeasureType || RadiusMeasureType)
                {
                    if (LengthMeasureType)
                    {
                        e.Graphics.DrawLine(MeasureLengthPen, StartLocation, EndLocation);
                        e.Graphics.DrawString(MeasureLenghtmm + " mm", MeasureStringFont, MeasureStringBrush, EndLocation);
                    }

                    if (RadiusMeasureType)
                    {
                        e.Graphics.DrawEllipse(MeasureRadiusPen, StartLocation.X, StartLocation.Y, CircleEndLocation.X, CircleEndLocation.Y);
                        e.Graphics.DrawString(MeasureRadiusmm + " mm", MeasureStringFont, MeasureStringBrush, EndLocation);
                    }
                }
            }
        }

        private void DigitalMicroscopeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (!Frame.IsEmpty)
            //{
            //    Frame.Dispose();
            //}
        }
    }
}
