namespace ExWinApp
{
    public partial class Form1 : Form
    {
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

        Bitmap originalBitmap; // ���� �̹��� �����


        // RGBA ��ũ�� �� �̹��� ���� ����
        private void scroll_RGBA_P(object sender, ScrollEventArgs e)
        {
            int red = ScrBarR.Value;
            int green = ScrBarG.Value;
            int blue = ScrBarB.Value;
            int alpha = ScrBarA.Value;

            TxtBoxR.Text = red.ToString();
            TxtBoxG.Text = green.ToString();
            TxtBoxB.Text = blue.ToString();
            TxtBoxA.Text = alpha.ToString();

            ApplyColorToImage(red, green, blue, alpha);
        }

        // �ؽ�Ʈ ���� �� �̹��� ���� ����
        private void textchanged_RGBA_P(object sender, EventArgs e)
        {
            if (TxtBoxR.Text != "" && TxtBoxG.Text != "" && TxtBoxB.Text != "" && TxtBoxA.Text != "")
            {
                int red = Math.Min(int.Parse(TxtBoxR.Text), 255);
                int green = Math.Min(int.Parse(TxtBoxG.Text), 255);
                int blue = Math.Min(int.Parse(TxtBoxB.Text), 255);
                int alpha = Math.Min(int.Parse(TxtBoxA.Text), 255);

                TxtBoxR.Text = red.ToString();
                TxtBoxG.Text = green.ToString();
                TxtBoxB.Text = blue.ToString();
                TxtBoxA.Text = alpha.ToString();

                ScrBarR.Value = red;
                ScrBarG.Value = green;
                ScrBarB.Value = blue;
                ScrBarA.Value = alpha;

                ApplyColorToImage(red, green, blue, alpha);
                object sy = pictureBox.Sy;
            }
        }

        // �̹��� ��ü�� RGBA ���� ���� �Լ�
        private void ApplyColorToImage(int r, int g, int b, int a)
        {
            Bitmap newBitmap = new Bitmap(originalBitmap.Width, originalBitmap.Height);

            for (int y = 0; y < originalBitmap.Height; y++)
            {
                for (int x = 0; x < originalBitmap.Width; x++)
                {
                    Color originalColor = originalBitmap.GetPixel(x, y);
                    Color newColor = Color.FromArgb(a, r, g, b);
                    newBitmap.SetPixel(x, y, newColor);
                }
            }

            pictureBox.Image = newBitmap;
        }
    }
}
