using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace photo
{
    public partial class FrmMain : Form
    {
        private Bitmap canvas;
        private Bitmap originalImage;
        private Point startPoint;
        private bool isDragging;
        private bool imageLoaded = false;
        private Color selectedColor = Color.Orchid;
        private Stack<Bitmap> undoStack = new Stack<Bitmap>();
        private Stack<Bitmap> redoStack = new Stack<Bitmap>();

        private enum DrawMode { Pen, Brush, Marker, Crayon, Rectangle, Triangle, Circle }
        private DrawMode currentMode = DrawMode.Pen;

        public FrmMain()
        {
            InitializeComponent();

            BtnRect.Click += BtnRect_Click;
            BtnCircle.Click += BtnCircle_Click;
            BtnTriangle.Click += BtnTriangle_Click;
            BtnUndo.Click += BtnUndo_Click;
            BtnRedo.Click += BtnRedo_Click;
            BtnReset.Click += BtnReset_Click;
            BtnGray.Click += BtnGray_Click;
            BtnInvert.Click += BtnInvert_Click;
            BtnPen.Click += BtnPen_Click;
            BtnBrush.Click += BtnBrush_Click;
            BtnMarker.Click += BtnMarker_Click;
            BtnCrayon.Click += BtnCrayon_Click;

            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
        }

        private bool CheckImage(bool showMessage = true)
        {
            if (!imageLoaded)
            {
                if (showMessage)
                    MessageBox.Show("이미지를 업로드 하세요.");
                return false;
            }
            return true;
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Image";
            openFileDialog.Filter = "( *.bmp; *.jpg; *.png; *.jpeg) | *.BMP; *.JPG; *.PNG; *.JPEG";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image img = Bitmap.FromFile(openFileDialog.FileName);
                canvas = new Bitmap(img);
                originalImage = new Bitmap(img);
                pictureBox1.Image = canvas;
                undoStack.Clear();
                redoStack.Clear();
                imageLoaded = true;
            }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (!CheckImage()) return;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "paint1.png";
            saveFileDialog.Filter = "PNG File|*.png|Bitmap File|*.bmp|JPEG File|*.jpg";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog.FileName);
            }
        }

        private void SaveState()
        {
            undoStack.Push((Bitmap)canvas.Clone());
            redoStack.Clear();
        }

        private void Undo()
        {
            if (!CheckImage()) return;
            if (undoStack.Count > 0)
            {
                redoStack.Push((Bitmap)canvas.Clone());
                canvas = undoStack.Pop();
                pictureBox1.Image = canvas;
                pictureBox1.Invalidate();
            }
        }

        private void Redo()
        {
            if (!CheckImage()) return;
            if (redoStack.Count > 0)
            {
                undoStack.Push((Bitmap)canvas.Clone());
                canvas = redoStack.Pop();
                pictureBox1.Image = canvas;
                pictureBox1.Invalidate();
            }
        }

        private void ResetToOriginal()
        {
            if (!CheckImage()) return;
            if (originalImage != null)
            {
                canvas = new Bitmap(originalImage);
                pictureBox1.Image = canvas;
                undoStack.Clear();
                redoStack.Clear();
            }
        }

        private Point TranslateZoomMousePosition(PictureBox pb, MouseEventArgs e)
        {
            if (pb.Image == null) return e.Location;

            float ratio = Math.Min((float)pb.Width / pb.Image.Width, (float)pb.Height / pb.Image.Height);
            int offsetX = (int)((pb.Width - pb.Image.Width * ratio) / 2);
            int offsetY = (int)((pb.Height - pb.Image.Height * ratio) / 2);

            int x = (int)((e.X - offsetX) / ratio);
            int y = (int)((e.Y - offsetY) / ratio);

            return new Point(x, y);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!CheckImage()) return;

            if (e.Button == MouseButtons.Left)
            {
                SaveState();
                startPoint = TranslateZoomMousePosition(pictureBox1, e);
                isDragging = true;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!CheckImage(false)) return;
            if (e.Button == MouseButtons.Left && isDragging &&
                (currentMode == DrawMode.Pen || currentMode == DrawMode.Brush || currentMode == DrawMode.Marker || currentMode == DrawMode.Crayon))
            {
                Point pt = TranslateZoomMousePosition(pictureBox1, e);
                using (Graphics g = Graphics.FromImage(canvas))
                using (Brush brush = new SolidBrush(selectedColor))
                {
                    int size = TrbPenSize.Value;
                    switch (currentMode)
                    {
                        case DrawMode.Pen:
                            g.FillEllipse(brush, pt.X - size / 2, pt.Y - size / 2, size, size);
                            break;
                        case DrawMode.Brush:
                            g.FillEllipse(brush, pt.X - size, pt.Y - size, size * 2, size * 2);
                            break;
                        case DrawMode.Marker:
                            g.FillRectangle(brush, pt.X - size, pt.Y - size / 2, size * 2, size);
                            break;
                        case DrawMode.Crayon:
                            g.DrawEllipse(new Pen(brush, 1), pt.X - size / 2, pt.Y - size / 2, size, size);
                            break;
                    }
                }
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!CheckImage(false) || !isDragging) return;
            isDragging = false;

            if (currentMode == DrawMode.Pen || currentMode == DrawMode.Brush || currentMode == DrawMode.Marker || currentMode == DrawMode.Crayon)
                return;

            Point endPoint = TranslateZoomMousePosition(pictureBox1, e);
            Rectangle rect = new Rectangle(
                Math.Min(startPoint.X, endPoint.X),
                Math.Min(startPoint.Y, endPoint.Y),
                Math.Abs(startPoint.X - endPoint.X),
                Math.Abs(startPoint.Y - endPoint.Y));

            using (Graphics g = Graphics.FromImage(canvas))
            using (Pen pen = new Pen(selectedColor, TrbPenSize.Value))
            using (Brush fillBrush = new SolidBrush(selectedColor))
            {
                switch (currentMode)
                {
                    case DrawMode.Rectangle:
                        if (checkBox1.Checked)
                            g.FillRectangle(fillBrush, rect); // 도형을 채우기
                        g.DrawRectangle(pen, rect); // 도형 테두리
                        break;

                    case DrawMode.Circle:
                        // 원의 크기 및 위치 계산
                        int radius = Math.Min(rect.Width, rect.Height) / 2;
                        Point center = new Point(rect.Left + radius, rect.Top + radius);
                        Rectangle circleRect = new Rectangle(center.X - radius, center.Y - radius, radius * 2, radius * 2);

                        if (checkBox1.Checked)
                            g.FillEllipse(fillBrush, circleRect); // 원을 채우기
                        g.DrawEllipse(pen, circleRect); // 원 테두리
                        break;

                    case DrawMode.Triangle:
                        // 삼각형의 세 꼭짓점 계산
                        Point top = new Point((rect.Left + rect.Right) / 2, rect.Top);
                        Point left = new Point(rect.Left, rect.Bottom);
                        Point right = new Point(rect.Right, rect.Bottom);

                        if (checkBox1.Checked)
                            g.FillPolygon(fillBrush, new[] { top, left, right }); // 삼각형을 채우기
                        g.DrawPolygon(pen, new[] { top, left, right }); // 삼각형 테두리
                        break;
                }
            }

            pictureBox1.Invalidate();
        }

        private void ConvertToGrayscale()
        {
            if (!CheckImage()) return;
            SaveState();
            for (int y = 0; y < canvas.Height; y++)
            {
                for (int x = 0; x < canvas.Width; x++)
                {
                    Color c = canvas.GetPixel(x, y);
                    int gray = (c.R + c.G + c.B) / 3;
                    canvas.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }
            pictureBox1.Invalidate();
        }

        private void InvertColors()
        {
            if (!CheckImage()) return;
            SaveState();
            for (int y = 0; y < canvas.Height; y++)
            {
                for (int x = 0; x < canvas.Width; x++)
                {
                    Color c = canvas.GetPixel(x, y);
                    canvas.SetPixel(x, y, Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B));
                }
            }
            pictureBox1.Invalidate();
        }

        private void BtnPenColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                selectedColor = colorDialog1.Color;
        }
        private void FrmMain_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까? (저장 후 종료하세요)", "종료여부", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                e.Cancel = true;    // 종료를 안시키는 것
            }
        }


        private void BtnRect_Click(object sender, EventArgs e) { if (CheckImage()) currentMode = DrawMode.Rectangle; }
        private void BtnCircle_Click(object sender, EventArgs e) { if (CheckImage()) currentMode = DrawMode.Circle; }
        private void BtnTriangle_Click(object sender, EventArgs e) { if (CheckImage()) currentMode = DrawMode.Triangle; }
        private void BtnPen_Click(object sender, EventArgs e) { if (CheckImage()) currentMode = DrawMode.Pen; }
        private void BtnBrush_Click(object sender, EventArgs e) { if (CheckImage()) currentMode = DrawMode.Brush; }
        private void BtnMarker_Click(object sender, EventArgs e) { if (CheckImage()) currentMode = DrawMode.Marker; }
        private void BtnCrayon_Click(object sender, EventArgs e) { if (CheckImage()) currentMode = DrawMode.Crayon; }
        private void BtnUndo_Click(object sender, EventArgs e) => Undo();
        private void BtnRedo_Click(object sender, EventArgs e) => Redo();
        private void BtnReset_Click(object sender, EventArgs e) => ResetToOriginal();
        private void BtnGray_Click(object sender, EventArgs e) => ConvertToGrayscale();
        private void BtnInvert_Click(object sender, EventArgs e) => InvertColors();


    }
}
