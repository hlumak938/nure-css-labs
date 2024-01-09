using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_CSS
{
    public partial class Form2 : Form
    {
        public Form2(Image img, decimal rotateAngle, decimal scaleX, decimal scaleY)
        {
            InitializeComponent();
            pictureBox1.Image = RotateImage(img, (float)rotateAngle);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Image = ResizeImage(img, new Size((int)scaleX, (int)scaleY));
            pictureBox3.Image = DrawCenterCircle(img);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
        }

        public Bitmap RotateImage(Image image, float angle)
        {
            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            Graphics g = Graphics.FromImage(rotatedBmp);
            g.TranslateTransform(image.Width / 2, image.Height / 2);
            g.RotateTransform(angle);
            g.TranslateTransform(-image.Width / 2, -image.Height / 2);
            g.DrawImage(image, new Point(0, 0));

            return rotatedBmp;
        }

        public Image DrawCenterCircle(Image img)
        {
            Bitmap bmp = new Bitmap(img);
            Graphics grfx = Graphics.FromImage(bmp);
            Rectangle rect = new Rectangle(bmp.Size.Width / 2 - 50, bmp.Size.Height / 2 - 50, 100, 100);
            SolidBrush sb = new SolidBrush(Color.Black);

            grfx.FillEllipse(sb, rect);
            grfx.Dispose();

            return bmp;
        }
        public Image ResizeImage(Image imgToResize, Size size)
        {
            int sourceWidth = imgToResize.Width;
            int sourceHeight = imgToResize.Height;

            float PercentW = size.Width / (float)sourceWidth;
            float PercentH = size.Height / (float)sourceHeight;

            float resizePercent = PercentH < PercentW ? PercentH : PercentW;

            int destWidth = (int)(sourceWidth * resizePercent);
            int destHeight = (int)(sourceHeight * resizePercent);

            Bitmap bmp = new Bitmap(destWidth, destHeight);
            Graphics grfx = Graphics.FromImage(bmp);
            grfx.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            grfx.Dispose();

            return bmp;
        }
    }
}
