using System.Windows.Forms;

using System.Drawing.Imaging;
using System.Runtime.InteropServices;

/* 그림판
 *  패널로 연습 ㅇ
 *  이미지 없는 그림판
 *      - 그냥 이미지 처럼 하면 될듯
 *  이미지 있는 그림
 *      - 이미지를 저장후 덮는?
 *  점, 선, 지우개, 도형
 *  RGBA 설정
 *  불러오기, 저장
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
            // 초기 배경을 검정색으로.
            panel1.BackColor = Color.FromArgb(255, 0, 0, 0);

            // 초기 입력값 셋팅
            textBox_R.Text = 0.ToString();
            textBox_G.Text = 0.ToString();
            textBox_B.Text = 0.ToString();

            textBox_A.Text = 255.ToString();
            // PictureBox에 이미지가 이미 설정되어 있다고 가정
            if (pictureBox.Image != null)
            {
                // 원래 이미지를 복사해서 Bitmap으로 만듦
                Image originalImage = pictureBox.Image;
                canvas = new Bitmap(originalImage.Width, originalImage.Height);

                using (Graphics g = Graphics.FromImage(canvas))
                {
                    g.DrawImage(originalImage, 0, 0); // 기존 이미지 복사
                }

                pictureBox.Image = canvas; // 복사된 비트맵을 다시 PictureBox에 설정
            }

            //// PictureBox에 디자이너에서 사진이 설정돼 있다고 가정
            //if (pictureBox.Image != null)
            //{
            //    originalImage = new Bitmap(pictureBox.Image); // 원본 이미지 저장
            //    pictureBox.Image = new Bitmap(originalImage); // 작업용 이미지
            //}

            // 이벤트 연결
            pictureBox.MouseDown += pictureBox_MouseDown;
            pictureBox.MouseMove += PictureBox_MouseMove;
            //pictureBox.MouseUp += pictureBox_MouseUp;
        }

        
        private void scroll_RGBA(object sender, ScrollEventArgs e)
        {
            // RGBA 값 추출        
            int red = hScrollBar_R.Value;
            int green = hScrollBar_G.Value;
            int blue = hScrollBar_B.Value;
            int alpha = hScrollBar_A.Value;


            // 색상 변경
            panel1.BackColor = Color.FromArgb(alpha, red, green, blue);

            // RGBA 값 출력
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

            // 필터 색상
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

                // 블렌딩: (원본 × (1 - strength)) + (필터 × strength)
                float strength = 0.5f; // 0.0 ~ 1.0 (0이면 원본, 1이면 완전 필터색)

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
            // 공백은 허용하지 않음
            if (textBox_R.Text != "" && textBox_G.Text != ""
                && textBox_B.Text != "" && textBox_A.Text != "")
            {
                // 255이상 입력되면 255로 고정
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
                // 색상변경
                panel1.BackColor = Color.FromArgb(alpha, red, green, blue);

                // RGBA값 출력
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
                //if (isDragging)
                //{
                //    pictureBox.Image.Dispose();
                //    pictureBox.Image = new Bitmap(originalImage); // 원본에서 복사

                //    using (Graphics g = Graphics.FromImage(pictureBox.Image))
                //    {
                //        Rectangle rect = GetRectangle(startPoint, e.Location);
                //        using (Pen pen = new Pen(Color.Blue, 2))
                //        {
                //            g.DrawRectangle(pen, rect); // 테두리만 그림
                //        }
                //    }

                //    pictureBox.Invalidate();
                //}
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

        //// 마우스 이동 시 사각형 미리 보기
        //private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        //{
        //    if (isDragging)
        //    {
        //        pictureBox.Image.Dispose();
        //        pictureBox.Image = new Bitmap(originalImage); // 원본에서 복사

        //        using (Graphics g = Graphics.FromImage(pictureBox.Image))
        //        {
        //            Rectangle rect = GetRectangle(startPoint, e.Location);
        //            using (Pen pen = new Pen(Color.Blue, 2))
        //            {
        //                g.DrawRectangle(pen, rect); // 테두리만 그림
        //            }
        //        }

        //        pictureBox.Invalidate();
        //    }
        //}
        //// 마우스 누를 때
        //private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        //{
        //    if (isDragging)
        //    {
        //        isDragging = false;

        //        using (Graphics g = Graphics.FromImage(originalImage))
        //        {
        //            Rectangle rect = GetRectangle(startPoint, e.Location);
        //            using (Pen pen = new Pen(Color.Blue, 2))
        //            {
        //                g.DrawRectangle(pen, rect); // 실제 원본에 그림
        //            }
        //        }

        //        pictureBox.Image.Dispose();
        //        pictureBox.Image = new Bitmap(originalImage); // 다시 표시
        //        pictureBox.Invalidate();
        //    }
        //}

        //// 시작점과 끝점으로 사각형 계산
        //private Rectangle GetRectangle(Point p1, Point p2)
        //{
        //    return new Rectangle(
        //        Math.Min(p1.X, p2.X),
        //        Math.Min(p1.Y, p2.Y),
        //        Math.Abs(p1.X - p2.X),
        //        Math.Abs(p1.Y - p2.Y));
        //}




    }
}
