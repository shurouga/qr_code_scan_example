using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;

namespace QRScanExample
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection captureDevice;
        private VideoCaptureDevice finalFrame;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            captureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in captureDevice)
                cbCameraList.Items.Add(device.Name);

            cbCameraList.SelectedIndex= 0;
            finalFrame= new VideoCaptureDevice();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (finalFrame.IsRunning == true)
                return;
            finalFrame = new VideoCaptureDevice(captureDevice[cbCameraList.SelectedIndex].MonikerString);
            finalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            finalFrame.Start();
            timer1.Start();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pbCameraCapture.Image = (Image)eventArgs.Frame.Clone();
        }

        private void stopCamera()
        {
            if (finalFrame.IsRunning == true)
            {
                finalFrame.SignalToStop();
                finalFrame.WaitForStop();
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopCamera();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pbCameraCapture.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pbCameraCapture.Image);
                if (result != null)
                {
                    try
                    {
                        string decoded = result.ToString().Trim();
                        if (decoded != "")
                        {
                            txbScanResult.Text = decoded;
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }
    }
}
