using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.UI;
using Emgu.CV.VideoSurveillance;
using Emgu.CV.Structure;
using Emgu.Util;
using Emgu.CV.OCR;

using AForge.Imaging;
using AForge.Math;
using AForge.Imaging.Filters;
using AForge.Imaging.ColorReduction;


namespace VNPRS
{
    public partial class CameraCapture : Form
    {
        private Capture _capture;
        private bool _captureInProgress;
        private int intnudmaxgray, intnudmingray;
        public CameraCapture()
        {
            InitializeComponent();

        }

        private void ProcessFrame(object sender, EventArgs arg)
        {
            intnudmaxgray = int.Parse(nudmaxgray.Value.ToString());
            intnudmingray = int.Parse(nudmingray.Value.ToString());
            Image<Bgr, Byte> frame1 = _capture.QueryFrame();    
            
         //   frame1.PyrDown().PyrUp();
            frame1._Dilate(1);
            frame1._SmoothGaussian(1);
            Image<Gray, Byte> gray = frame1.Convert<Gray, Byte>();    // value 120     
            gray = frame1.Convert<Gray, Byte>().ThresholdBinary(new Gray(133), new Gray(255));
            //gray = frame1.Convert<Gray, Byte>().ThresholdBinary(new Gray(intnudmingray), new Gray(intnudmaxgray));
            Image<Gray, Byte> imgLines = gray.CopyBlank();
            Image<Gray, Byte> imgRect = gray.CopyBlank();
            Image<Gray, Byte> canny = gray.Canny(new Gray(160), new Gray(80));
            //Image<Gray, Byte> canny = gray.Canny(new Gray(intnudmingray), new Gray(intnudmaxgray));
            double dblReoRes = 1.0;
            double dblThetaRes = 4.0 * (Math.PI / 180.0);
            int intThreshold = 20;
            double dblMinLineWidth = 30.0;
            double dblMinGapBetweenLines = 10.0;

            LineSegment2D[] lines =canny.HoughLinesBinary(dblReoRes,dblThetaRes,intThreshold,dblMinLineWidth,dblMinGapBetweenLines)[0];

            foreach (LineSegment2D line in lines)
            {
                imgLines.Draw(line, new Gray(200), 2);
            }


            List<MCvBox2D> boxList = new List<MCvBox2D>();

            using (MemStorage storage = new MemStorage()) //allocate storage for contour approximation
                for (Contour<Point> contours = canny.FindContours(); contours != null; contours = contours.HNext)
                {
                    Contour<Point> currentContour = contours.ApproxPoly(contours.Perimeter * 0.05, storage);

                    if (contours.Area > 250) //only consider contours with area greater than 250
                    {
                        if (currentContour.Total == 4) //The contour has 4 vertices.
                        {
                           
                            bool isRectangle = true;
                            Point[] pts = currentContour.ToArray();
                            LineSegment2D[] edges = PointCollection.PolyLine(pts, true);

                            for (int i = 0; i < edges.Length; i++)
                            {
                                double angle = Math.Abs(
                                   edges[(i + 1) % edges.Length].GetExteriorAngleDegree(edges[i]));
                                if (angle < 80 || angle > 100)
                                {
                                    isRectangle = false;
                                    break;
                                }
                            }
                           

                            if (isRectangle) boxList.Add(currentContour.GetMinAreaRect());
                        }
                    }
                }

            foreach (MCvBox2D box in boxList)
                imgRect.Draw(box, new Gray(200), 2);
            ibRect.Image = imgRect;
            
            
            //perform binarization
                      
            ibframe1.Image = gray;
            Image<Bgr, Byte> frame2 = _capture.QueryFrame();
            frame2._EqualizeHist();
         //   grayscaleImageBox.Image = gray;
            captureImageBox.Image = canny;
          grayscaleImageBox.Image =imgLines;
            Bitmap gr = gray.ToBitmap();
          //test bgr treshold
            ibOriginal.Image = frame2;                          //added
            HorizontalIntensityStatistics hhis = new HorizontalIntensityStatistics(gr);
            Histogram hhistogram = hhis.Gray;
            histogram1.Values = hhistogram.Values;
          
            VerticalIntensityStatistics vhis = new VerticalIntensityStatistics(gr);
            Histogram vhistogram = vhis.Gray;
           histogram2.Values = vhistogram.Values;
           label1.Text = "horizontal =" + histogram2.Size + Environment.NewLine + "vertical =" + histogram1.Size;
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (_capture == null)
            {
                try
                {
                    _capture = new Capture();
                }
                catch (NullReferenceException excpt)
                {
                    MessageBox.Show(excpt.Message);
                }
            }

            if (_capture != null)
            {
                if (_captureInProgress)
                {  //stop the capture
                    button1.Text = "Start Capture";
                    
                    Application.Idle -= ProcessFrame;
                }
                else
                {
                    //start the capture
                    button1.Text = "Stop";
                    Application.Idle += ProcessFrame;
                }

                _captureInProgress = !_captureInProgress;
            }


            // create array with histogram values
       //    int[] histogramValues = new int[] { 3, 8, 53, 57, 79, 69,43,54,6,3,6,2,6,45,23,54,23,55,66,44,77,55,66,33,44,77,11,33,43};
       // histogram1.Values = histogramValues;
           intnudmaxgray = int.Parse(nudmaxgray.Value.ToString());
           intnudmingray = int.Parse(nudmingray.Value.ToString());
        }

        private void ReleaseData()
        {
            if (_capture != null)
                _capture.Dispose();
        }

        private void nudmaxgray_ValueChanged(object sender, EventArgs e)
        {
            intnudmaxgray = int.Parse(nudmaxgray.Value.ToString());
            label1.Text = intnudmaxgray.ToString();
        }

        private void nudmingray_ValueChanged(object sender, EventArgs e)
        {
            intnudmingray = int.Parse(nudmingray.Value.ToString());
            label1.Text = intnudmingray.ToString();
        }

       

       

       
    }
}
