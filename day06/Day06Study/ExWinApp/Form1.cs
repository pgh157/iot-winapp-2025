using System.Windows.Forms;

using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ExWinApp
{
    public partial class Form1 : Form
    {
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

        //Bitmap originalBitmap; // 원본 이미지 저장용


        //// RGBA 스크롤 시 이미지 색상 적용
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

        //// 텍스트 변경 시 이미지 색상 적용
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

        //// 이미지 전체에 RGBA 색상 적용 함수
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

        //            // 원본 픽셀 색상에 사용자가 선택한 색상을 '곱해줌'
        //            int newR = pixel.R * red / 255;
        //            int newG = pixel.G * green / 255;
        //            int newB = pixel.B * blue / 255;
        //            int newA = pixel.A * alpha / 255;

        //            Color newColor = Color.FromArgb(newA, newR, newG, newB);
        //            adjusted.SetPixel(x, y, newColor);
        //        }
        //    }

        //    // 기존 이미지 메모리 해제
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

        //    // 기존 이미지 메모리 해제
        //    var oldImage = pictureBox.Image;
        //    pictureBox.Image = bmp;
        //    oldImage.Dispose();
        //}

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_SystemColorsChanged(object sender, EventArgs e)
        {
            // RGBA 값 추출        
            int red = hScrollBar_R.Value;
            int green = hScrollBar_G.Value;
            int blue = hScrollBar_B.Value;
            int alpha = hScrollBar_A.Value;

            if (pictureBox.Image == null) return;

            Bitmap bmp = new Bitmap(pictureBox.Image.Width, pictureBox.Image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.FromArgb(alpha, red, green, blue));
            }

            // 기존 이미지 메모리 해제
            var oldImage = pictureBox.Image;
            pictureBox.Image = bmp;
            oldImage.Dispose();
        }
    }
}
