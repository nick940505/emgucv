using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using tessnet2;

namespace LicensePlateRecognition
{
   public partial class LicensePlateRecognitionForm : Form
   {
      private Tesseract _ocr; 

      public LicensePlateRecognitionForm()
      {
         InitializeComponent();
         
         //create OCR
         _ocr = new Tesseract();

         //You can download more language definition data from
         //http://code.google.com/p/tesseract-ocr/downloads/list
         //Languages supported includes:
         //Dutch, Spanish, German, Italian, French and English
         _ocr.Init("eng", false);
         
         DetectLicensePlate(new Image<Bgr, byte>("license-plate.jpg"));

      }

      public List<Word> PlateOCR(Image<Gray, Byte> plate)
      {
         Image<Gray, Byte> thresh = plate.ThresholdBinaryInv(new Gray(120), new Gray(255));
         Image<Gray, Byte> plateMask = new Image<Gray, byte>(plate.Size);

         Image<Gray, Byte> plateCanny = plate.Canny(new Gray(100), new Gray(50));
         using (MemStorage stor = new MemStorage())
         {
            for (Contour<Point> contours = plateCanny.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_EXTERNAL, stor); contours != null; contours = contours.HNext)
            {
               Rectangle rect = contours.BoundingRectangle;
               if (rect.Height > (plate.Height >> 1))
               {
                  rect.X -= 1; rect.Y -= 1; rect.Width += 2; rect.Height += 2;
                  rect.Intersect(plate.ROI);

                  plateMask.Draw(rect, new Gray(255.0), -1);
               }
            }
         }
         plateMask._Not();
         thresh.SetValue(0, plateMask);
         thresh._Erode(1);
         thresh._Dilate(1);

         return _ocr.DoOCR(thresh.Bitmap, thresh.ROI);
      }

      public void DetectLicensePlate(Image<Bgr, byte> img)
      {
         Image<Gray, byte> gray = img.Convert<Gray, Byte>();
         Image<Gray, byte> canny = gray.Canny(new Gray(100), new Gray(50));

         List<MCvBox2D> boxList = new List<MCvBox2D>();

         using (MemStorage stor = new MemStorage())
         {
            for (Contour<Point> contours = canny.FindContours(Emgu.CV.CvEnum.CHAIN_APPROX_METHOD.CV_CHAIN_APPROX_SIMPLE, Emgu.CV.CvEnum.RETR_TYPE.CV_RETR_LIST, stor); contours != null; contours = contours.HNext)
            {
               Contour<Point> currentContour = contours.ApproxPoly(contours.Perimeter * 0.05, stor);
               if (currentContour.Area > 250 && currentContour.Total == 4)
               {
                  #region determine if all the angles in the contour are within the range of [80, 100] degree
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
                  #endregion

                  if (isRectangle) boxList.Add(currentContour.GetMinAreaRect());
               }
            }
         }

         foreach (MCvBox2D box in boxList)
         {
            RotationMatrix2D<double> rot = new RotationMatrix2D<double>(box.center, -(box.angle - 90), 1.0);
            Image<Gray, Byte> rotatedGray = gray.WarpAffine(rot, Emgu.CV.CvEnum.INTER.CV_INTER_LINEAR, Emgu.CV.CvEnum.WARP.CV_WRAP_DEFAULT, new Gray(0.0));
            Image<Gray, Byte> plate = rotatedGray.Copy(new Rectangle((int)box.center.X - ((int)box.size.Width >> 1), (int)box.center.Y - ((int)box.size.Height >> 1), (int)box.size.Width, (int)box.size.Height));

            List<Word> words = PlateOCR(plate);
            StringBuilder builder = new StringBuilder();
            foreach (Word w in words)
               builder.Append(w.Text);

            label1.Text = builder.ToString();

         }

         imageBox1.Image = img;

      }

   }
}