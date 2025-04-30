using System.Windows.Forms;

using System.Drawing.Imaging;
using System.Runtime.InteropServices;

/* �׸���
 *  �гη� ���� ��
 *  �̹��� ���� �׸���
 *      - �׳� �̹��� ó�� �ϸ� �ɵ�
 *  �̹��� �ִ� �׸�
 *      - �̹����� ������ ����?
 *  ��, ��, ���찳, ����
 *  RGBA ����
 *  �ҷ�����, ����
 */

namespace ExWinApp
{

    public partial class Form1 : Form
    {
        private Bitmap canvas;
        private Image originalImage;
        private Point startPoint;
        private Point endPoint;
        private bool isDrawing = false;
        private bool isDragging = false;
        public Form1()
        {
            InitializeComponent();
            // �ʱ� ����� ����������.
            panel1.BackColor = Color.FromArgb(255, 0, 0, 0);

            // �ʱ� �Է°� ����
            textBox_R.Text = 0.ToString();
            textBox_G.Text = 0.ToString();
            textBox_B.Text = 0.ToString();

            textBox_A.Text = 255.ToString();
            // PictureBox�� �̹����� �̹� �����Ǿ� �ִٰ� ����
            if (pictureBox.Image != null)
            {
                // ���� �̹����� �����ؼ� Bitmap���� ����
                Image originalImage = pictureBox.Image;
                canvas = new Bitmap(originalImage.Width, originalImage.Height);

                using (Graphics g = Graphics.FromImage(canvas))
                {
                    g.DrawImage(originalImage, 0, 0); // ���� �̹��� ����
                }

                pictureBox.Image = canvas; // ����� ��Ʈ���� �ٽ� PictureBox�� ����
            }

            //// PictureBox�� �����̳ʿ��� ������ ������ �ִٰ� ����
            //if (pictureBox.Image != null)
            //{
            //    originalImage = new Bitmap(pictureBox.Image); // ���� �̹��� ����
            //    pictureBox.Image = new Bitmap(originalImage); // �۾��� �̹���
            //}

            // �̺�Ʈ ����
            pictureBox.MouseDown += pictureBox_MouseDown;
            pictureBox.MouseMove += PictureBox_MouseMove;
            pictureBox.MouseUp += pictureBox_MouseUp;
        }

        
        private void scroll_RGBA(object sender, ScrollEventArgs e)
        {
            // RGBA �� ����        
            int red = hScrollBar_R.Value;
            int green = hScrollBar_G.Value;
            int blue = hScrollBar_B.Value;
            int alpha = hScrollBar_A.Value;


            // ���� ����
            panel1.BackColor = Color.FromArgb(alpha, red, green, blue);

            // RGBA �� ���
            textBox_R.Text = red.ToString();
            textBox_G.Text = green.ToString();
            textBox_B.Text = blue.ToString();
            textBox_A.Text = alpha.ToString();

            if (pictureBox.Image == null) return;

            Bitmap original = new Bitmap(pictureBox.Image);
            Bitmap adjusted = new Bitmap(original.Width, original.Height, PixelFormat.Format32bppArgb);

            BitmapData originalData = original.LockBits(new Rectangle(0, 0, original.Width, original.Height),
                                                         ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            BitmapData adjustedData = adjusted.LockBits(new Rectangle(0, 0, adjusted.Width, adjusted.Height),
                                                         ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            int bytes = Math.Abs(originalData.Stride) * original.Height;
            byte[] pixelBuffer = new byte[bytes];
            byte[] resultBuffer = new byte[bytes];

            Marshal.Copy(originalData.Scan0, pixelBuffer, 0, bytes);
            original.UnlockBits(originalData);

            // ���� ����
            byte targetR = (byte)red;
            byte targetG = (byte)green;
            byte targetB = (byte)blue;
            byte targetA = (byte)alpha;

            for (int k = 0; k < pixelBuffer.Length; k += 4)
            {
                byte b = pixelBuffer[k];
                byte g = pixelBuffer[k + 1];
                byte r = pixelBuffer[k + 2];
                byte a = pixelBuffer[k + 3];

                // ����: (���� �� (1 - strength)) + (���� �� strength)
                float strength = 0.5f; // 0.0 ~ 1.0 (0�̸� ����, 1�̸� ���� ���ͻ�)

                byte newB = (byte)(b * (1 - strength) + targetB * strength);
                byte newG = (byte)(g * (1 - strength) + targetG * strength);
                byte newR = (byte)(r * (1 - strength) + targetR * strength);
                byte newA = (byte)(a * (1 - strength) + targetA * strength);

                resultBuffer[k] = newB;    // Blue
                resultBuffer[k + 1] = newG; // Green
                resultBuffer[k + 2] = newR;  // Red
                resultBuffer[k + 3] = newA; // Alpha
            }

            Marshal.Copy(resultBuffer, 0, adjustedData.Scan0, bytes);
            adjusted.UnlockBits(adjustedData);

            var oldImage = pictureBox.Image;
            pictureBox.Image = adjusted;
            oldImage.Dispose();
        }

        private void textchanged_RGBA(object sender, EventArgs e)
        {
            // ������ ������� ����
            if (textBox_R.Text != "" && textBox_G.Text != ""
                && textBox_B.Text != "" && textBox_A.Text != "")
            {
                // 255�̻� �ԷµǸ� 255�� ����
                int red = int.Parse(textBox_R.Text);
                if (red > 255)
                {
                    red = 255;
                    textBox_R.Text = red.ToString();
                }
                int green = int.Parse(textBox_G.Text);
                if (green > 255)
                {
                    green = 255;
                    textBox_G.Text = green.ToString();
                }
                int blue = int.Parse(textBox_B.Text);
                if (blue > 255)
                {
                    blue = 255;
                    textBox_B.Text = blue.ToString();
                }
                int alpha = int.Parse(textBox_A.Text);
                if (alpha > 255)
                {
                    alpha = 255;
                    textBox_A.Text = alpha.ToString();
                }
                // ���󺯰�
                panel1.BackColor = Color.FromArgb(alpha, red, green, blue);

                // RGBA�� ���
                hScrollBar_R.Value = red;
                hScrollBar_G.Value = green;
                hScrollBar_B.Value = blue;
                hScrollBar_A.Value = alpha;
            }
        }

        private Point TranslateZoomMousePosition(PictureBox pb, MouseEventArgs e)
        {
            if (pb.Image == null) return e.Location;

            int imageWidth = pb.Image.Width;
            int imageHeight = pb.Image.Height;
            int pbWidth = pb.Width;
            int pbHeight = pb.Height;

            float ratioWidth = (float)pbWidth / imageWidth;
            float ratioHeight = (float)pbHeight / imageHeight;
            float ratio = Math.Min(ratioWidth, ratioHeight);

            int offsetX = (int)((pbWidth - imageWidth * ratio) / 2);
            int offsetY = (int)((pbHeight - imageHeight * ratio) / 2);

            int x = (int)((e.X - offsetX) / ratio);
            int y = (int)((e.Y - offsetY) / ratio);

            return new Point(x, y);
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (RdBtn1.Checked)
            {
                if (e.Button == MouseButtons.Left)
                {
                    Point translatedPoint = TranslateZoomMousePosition(pictureBox, e);

                    using (Graphics g = Graphics.FromImage(pictureBox.Image))
                    {
                        int size = 10;
                        g.FillEllipse(Brushes.BlueViolet,
                            translatedPoint.X - size / 2, translatedPoint.Y - size / 2, size, size);
                    }

                    pictureBox.Invalidate();
                }
            }
            if (RdBtn2.Checked)
            {
                if (isDragging)
                {
                    pictureBox.Image.Dispose();
                    pictureBox.Image = new Bitmap(originalImage); // �������� ����

                    using (Graphics g = Graphics.FromImage(pictureBox.Image))
                    {
                        Rectangle rect = GetRectangle(startPoint, e.Location);
                        using (Pen pen = new Pen(Color.Blue, 2))
                        {
                            g.DrawRectangle(pen, rect); // �׵θ��� �׸�
                        }
                    }

                    pictureBox.Invalidate();
                }
            }
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
                isDragging = true;
            }
        }

        // ���콺 �̵� �� �簢�� �̸� ����
        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                pictureBox.Image.Dispose();
                pictureBox.Image = new Bitmap(originalImage); // �������� ����

                using (Graphics g = Graphics.FromImage(pictureBox.Image))
                {
                    Rectangle rect = GetRectangle(startPoint, e.Location);
                    using (Pen pen = new Pen(Color.Blue, 2))
                    {
                        g.DrawRectangle(pen, rect); // �׵θ��� �׸�
                    }
                }

                pictureBox.Invalidate();
            }
        }
        // ���콺 ���� ��
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                isDragging = false;

                using (Graphics g = Graphics.FromImage(originalImage))
                {
                    Rectangle rect = GetRectangle(startPoint, e.Location);
                    using (Pen pen = new Pen(Color.Blue, 2))
                    {
                        g.DrawRectangle(pen, rect); // ���� ������ �׸�
                    }
                }

                pictureBox.Image.Dispose();
                pictureBox.Image = new Bitmap(originalImage); // �ٽ� ǥ��
                pictureBox.Invalidate();
            }
        }

        // �������� �������� �簢�� ���
        private Rectangle GetRectangle(Point p1, Point p2)
        {
            return new Rectangle(
                Math.Min(p1.X, p2.X),
                Math.Min(p1.Y, p2.Y),
                Math.Abs(p1.X - p2.X),
                Math.Abs(p1.Y - p2.Y));
        }


        //Bitmap originalBitmap; // ���� �̹��� �����


        //// RGBA ��ũ�� �� �̹��� ���� ����
        //private void scroll_RGBA_P(object sender, ScrollEventArgs e)
        //{
        //    int red = ScrBarR.Value;
        //    int green = ScrBarG.Value;
        //    int blue = ScrBarB.Value;
        //    int alpha = ScrBarA.Value;

        //    TxtBoxR.Text = red.ToString();
        //    TxtBoxG.Text = green.ToString();
        //    TxtBoxB.Text = blue.ToString();
        //    TxtBoxA.Text = alpha.ToString();

        //    ApplyColorToImage(red, green, blue, alpha);
        //}

        //// �ؽ�Ʈ ���� �� �̹��� ���� ����
        //private void textchanged_RGBA_P(object sender, EventArgs e)
        //{
        //    if (TxtBoxR.Text != "" && TxtBoxG.Text != "" && TxtBoxB.Text != "" && TxtBoxA.Text != "")
        //    {
        //        int red = Math.Min(int.Parse(TxtBoxR.Text), 255);
        //        int green = Math.Min(int.Parse(TxtBoxG.Text), 255);
        //        int blue = Math.Min(int.Parse(TxtBoxB.Text), 255);
        //        int alpha = Math.Min(int.Parse(TxtBoxA.Text), 255);

        //        TxtBoxR.Text = red.ToString();
        //        TxtBoxG.Text = green.ToString();
        //        TxtBoxB.Text = blue.ToString();
        //        TxtBoxA.Text = alpha.ToString();

        //        ScrBarR.Value = red;
        //        ScrBarG.Value = green;
        //        ScrBarB.Value = blue;
        //        ScrBarA.Value = alpha;

        //        ApplyColorToImage(red, green, blue, alpha);
        //        //object sy = pictureBox.Sy;
        //    }
        //}

        //// �̹��� ��ü�� RGBA ���� ���� �Լ�
        //private void ApplyColorToImage(int r, int g, int b, int a)
        //{
        //    Bitmap newBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);

        //    for (int y = 0; y < originalBitmap.Height; y++)
        //    {
        //        for (int x = 0; x < originalBitmap.Width; x++)
        //        {
        //            Color originalColor = originalBitmap.GetPixel(x, y);
        //            Color newColor = Color.FromArgb(a, r, g, b);
        //            newBitmap.SetPixel(x, y, newColor);
        //        }
        //    }

        //    pictureBox.Image = newBitmap;
        //}

        //private void ChangePictureBoxColor(int alpha, int red, int green, int blue)
        //{
        //    if (pictureBox.Image == null) return;

        //    Bitmap original = new Bitmap(pictureBox.Image);
        //    Bitmap adjusted = new Bitmap(original.Width, original.Height);

        //    for (int y = 0; y < original.Height; y++)
        //    {
        //        for (int x = 0; x < original.Width; x++)
        //        {
        //            Color pixel = original.GetPixel(x, y);

        //            // ���� �ȼ� ���� ����ڰ� ������ ������ '������'
        //            int newR = pixel.R * red / 255;
        //            int newG = pixel.G * green / 255;
        //            int newB = pixel.B * blue / 255;
        //            int newA = pixel.A * alpha / 255;

        //            Color newColor = Color.FromArgb(newA, newR, newG, newB);
        //            adjusted.SetPixel(x, y, newColor);
        //        }
        //    }

        //    // ���� �̹��� �޸� ����
        //    var oldImage = pictureBox.Image;
        //    pictureBox.Image = adjusted;
        //    oldImage.Dispose();
        //}

        //private void ChangePictureBoxColor(int alpha, int red, int green, int blue)
        //{
        //    if (pictureBox.Image == null) return;

        //    Bitmap bmp = new Bitmap(pictureBox.Image.Width, pictureBox.Image.Height);
        //    using (Graphics g = Graphics.FromImage(bmp))
        //    {
        //        g.Clear(Color.FromArgb(alpha, red, green, blue));
        //    }

        //    // ���� �̹��� �޸� ����
        //    var oldImage = pictureBox.Image;
        //    pictureBox.Image = bmp;
        //    oldImage.Dispose();
        //}

        //private void pictureBox_Click(object sender, EventArgs e)
        //{

        //}

        //private void pictureBox_SystemColorsChanged(object sender, EventArgs e)
        //{
        //    // RGBA �� ����        
        //    int red = hScrollBar_R.Value;
        //    int green = hScrollBar_G.Value;
        //    int blue = hScrollBar_B.Value;
        //    int alpha = hScrollBar_A.Value;

        //    if (pictureBox.Image == null) return;

        //    Bitmap bmp = new Bitmap(pictureBox.Image.Width, pictureBox.Image.Height);
        //    using (Graphics g = Graphics.FromImage(bmp))
        //    {
        //        g.Clear(Color.FromArgb(alpha, red, green, blue));
        //    }

        //    // ���� �̹��� �޸� ����
        //    var oldImage = pictureBox.Image;
        //    pictureBox.Image = bmp;
        //    oldImage.Dispose();
        //}

    }
}
