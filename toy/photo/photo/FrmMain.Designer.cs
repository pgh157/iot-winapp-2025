namespace photo
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            pictureBox1 = new PictureBox();
            BtnOpen = new Button();
            imageList1 = new ImageList(components);
            colorDialog1 = new ColorDialog();
            savebutton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox2 = new GroupBox();
            BtnPenColor = new Button();
            TrbPenSize = new TrackBar();
            groupBox5 = new GroupBox();
            BtnCrayon = new Button();
            BtnMarker = new Button();
            BtnPen = new Button();
            BtnBrush = new Button();
            BtnGray = new Button();
            BtnInvert = new Button();
            BtnReset = new Button();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            BtnRect = new Button();
            BtnCircle = new Button();
            BtnTriangle = new Button();
            BtnRedo = new Button();
            imageList2 = new ImageList(components);
            BtnUndo = new Button();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrbPenSize).BeginInit();
            groupBox5.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1164, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BtnOpen
            // 
            BtnOpen.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            BtnOpen.ImageAlign = ContentAlignment.MiddleRight;
            BtnOpen.ImageIndex = 0;
            BtnOpen.ImageList = imageList1;
            BtnOpen.Location = new Point(960, 613);
            BtnOpen.Name = "BtnOpen";
            BtnOpen.Size = new Size(100, 43);
            BtnOpen.TabIndex = 2;
            BtnOpen.Text = "이미지열기";
            BtnOpen.UseVisualStyleBackColor = true;
            BtnOpen.Click += BtnOpen_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "folder-normal.png");
            imageList1.Images.SetKeyName(1, "disk.png");
            imageList1.Images.SetKeyName(2, "redo-arrow-symbol.png");
            imageList1.Images.SetKeyName(3, "undo-arrow (1).png");
            // 
            // savebutton
            // 
            savebutton.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            savebutton.ImageAlign = ContentAlignment.MiddleRight;
            savebutton.ImageIndex = 1;
            savebutton.ImageList = imageList1;
            savebutton.Location = new Point(1076, 613);
            savebutton.Name = "savebutton";
            savebutton.Size = new Size(100, 43);
            savebutton.TabIndex = 5;
            savebutton.Text = "저장";
            savebutton.UseVisualStyleBackColor = true;
            savebutton.Click += savebutton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnPenColor);
            groupBox2.Controls.Add(TrbPenSize);
            groupBox2.Location = new Point(22, 506);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(392, 69);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "색상 크기";
            // 
            // BtnPenColor
            // 
            BtnPenColor.Location = new Point(5, 21);
            BtnPenColor.Margin = new Padding(2);
            BtnPenColor.Name = "BtnPenColor";
            BtnPenColor.Size = new Size(73, 22);
            BtnPenColor.TabIndex = 1;
            BtnPenColor.Text = "펜 색상";
            BtnPenColor.UseVisualStyleBackColor = true;
            BtnPenColor.Click += BtnPenColor_Click;
            // 
            // TrbPenSize
            // 
            TrbPenSize.BackColor = SystemColors.GradientInactiveCaption;
            TrbPenSize.Location = new Point(82, 14);
            TrbPenSize.Margin = new Padding(2);
            TrbPenSize.Maximum = 40;
            TrbPenSize.Minimum = 2;
            TrbPenSize.Name = "TrbPenSize";
            TrbPenSize.Size = new Size(310, 45);
            TrbPenSize.TabIndex = 4;
            TrbPenSize.Value = 5;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(BtnCrayon);
            groupBox5.Controls.Add(BtnMarker);
            groupBox5.Controls.Add(BtnPen);
            groupBox5.Controls.Add(BtnBrush);
            groupBox5.Location = new Point(22, 576);
            groupBox5.Margin = new Padding(2);
            groupBox5.Name = "groupBox5";
            groupBox5.Padding = new Padding(2);
            groupBox5.Size = new Size(392, 70);
            groupBox5.TabIndex = 5;
            groupBox5.TabStop = false;
            groupBox5.Text = "펜 모드";
            // 
            // BtnCrayon
            // 
            BtnCrayon.Location = new Point(290, 33);
            BtnCrayon.Margin = new Padding(2);
            BtnCrayon.Name = "BtnCrayon";
            BtnCrayon.Size = new Size(73, 22);
            BtnCrayon.TabIndex = 0;
            BtnCrayon.Text = "크레용";
            BtnCrayon.UseVisualStyleBackColor = true;
            // 
            // BtnMarker
            // 
            BtnMarker.Location = new Point(200, 33);
            BtnMarker.Margin = new Padding(2);
            BtnMarker.Name = "BtnMarker";
            BtnMarker.Size = new Size(73, 22);
            BtnMarker.TabIndex = 0;
            BtnMarker.Text = "마커";
            BtnMarker.UseVisualStyleBackColor = true;
            // 
            // BtnPen
            // 
            BtnPen.Location = new Point(13, 33);
            BtnPen.Margin = new Padding(2);
            BtnPen.Name = "BtnPen";
            BtnPen.Size = new Size(73, 22);
            BtnPen.TabIndex = 3;
            BtnPen.Text = "펜";
            BtnPen.UseVisualStyleBackColor = true;
            // 
            // BtnBrush
            // 
            BtnBrush.Location = new Point(108, 33);
            BtnBrush.Margin = new Padding(2);
            BtnBrush.Name = "BtnBrush";
            BtnBrush.Size = new Size(73, 22);
            BtnBrush.TabIndex = 0;
            BtnBrush.Text = "브러쉬";
            BtnBrush.UseVisualStyleBackColor = true;
            // 
            // BtnGray
            // 
            BtnGray.Location = new Point(0, 22);
            BtnGray.Name = "BtnGray";
            BtnGray.Size = new Size(75, 23);
            BtnGray.TabIndex = 10;
            BtnGray.Text = "흑백";
            BtnGray.UseVisualStyleBackColor = true;
            // 
            // BtnInvert
            // 
            BtnInvert.Location = new Point(89, 22);
            BtnInvert.Name = "BtnInvert";
            BtnInvert.Size = new Size(75, 23);
            BtnInvert.TabIndex = 10;
            BtnInvert.Text = "반전";
            BtnInvert.UseVisualStyleBackColor = true;
            // 
            // BtnReset
            // 
            BtnReset.Location = new Point(197, 19);
            BtnReset.Name = "BtnReset";
            BtnReset.Size = new Size(75, 31);
            BtnReset.TabIndex = 10;
            BtnReset.Text = "복원";
            BtnReset.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(BtnRect);
            groupBox1.Controls.Add(BtnCircle);
            groupBox1.Controls.Add(BtnTriangle);
            groupBox1.Location = new Point(426, 520);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 50);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "도형";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = SystemColors.Info;
            checkBox1.ForeColor = SystemColors.ControlText;
            checkBox1.Location = new Point(89, 0);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(62, 19);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "채우기";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // BtnRect
            // 
            BtnRect.Location = new Point(149, 20);
            BtnRect.Name = "BtnRect";
            BtnRect.Size = new Size(45, 23);
            BtnRect.TabIndex = 6;
            BtnRect.Text = "네모";
            BtnRect.UseVisualStyleBackColor = true;
            // 
            // BtnCircle
            // 
            BtnCircle.Location = new Point(6, 20);
            BtnCircle.Name = "BtnCircle";
            BtnCircle.Size = new Size(48, 23);
            BtnCircle.TabIndex = 6;
            BtnCircle.Text = "원";
            BtnCircle.UseVisualStyleBackColor = true;
            // 
            // BtnTriangle
            // 
            BtnTriangle.Location = new Point(72, 20);
            BtnTriangle.Name = "BtnTriangle";
            BtnTriangle.Size = new Size(56, 23);
            BtnTriangle.TabIndex = 6;
            BtnTriangle.Text = "세모";
            BtnTriangle.UseVisualStyleBackColor = true;
            // 
            // BtnRedo
            // 
            BtnRedo.ImageAlign = ContentAlignment.MiddleRight;
            BtnRedo.ImageKey = "redo-arrow-symbol.png";
            BtnRedo.ImageList = imageList2;
            BtnRedo.Location = new Point(98, 19);
            BtnRedo.Name = "BtnRedo";
            BtnRedo.Size = new Size(75, 31);
            BtnRedo.TabIndex = 13;
            BtnRedo.Text = "Redo";
            BtnRedo.UseVisualStyleBackColor = true;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageStream = (ImageListStreamer)resources.GetObject("imageList2.ImageStream");
            imageList2.TransparentColor = Color.Transparent;
            imageList2.Images.SetKeyName(0, "redo-arrow-symbol.png");
            imageList2.Images.SetKeyName(1, "undo-arrow (1).png");
            // 
            // BtnUndo
            // 
            BtnUndo.ImageAlign = ContentAlignment.MiddleRight;
            BtnUndo.ImageKey = "undo-arrow (1).png";
            BtnUndo.ImageList = imageList2;
            BtnUndo.Location = new Point(6, 19);
            BtnUndo.Name = "BtnUndo";
            BtnUndo.Size = new Size(75, 31);
            BtnUndo.TabIndex = 12;
            BtnUndo.Text = "Undo";
            BtnUndo.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BtnGray);
            groupBox3.Controls.Add(BtnInvert);
            groupBox3.Location = new Point(426, 591);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(170, 55);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "이미지변환";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(BtnUndo);
            groupBox4.Controls.Add(BtnRedo);
            groupBox4.Controls.Add(BtnReset);
            groupBox4.Location = new Point(632, 520);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(293, 59);
            groupBox4.TabIndex = 15;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1188, 670);
            Controls.Add(groupBox4);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Controls.Add(savebutton);
            Controls.Add(BtnOpen);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "이미지편집";
            FormClosing += FrmMain_FormClosing_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrbPenSize).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Button BtnOpen;
        private ColorDialog colorDialog1;
        private Button savebutton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupBox2;
        private GroupBox groupBox5;
        private Button BtnCrayon;
        private Button BtnMarker;
        private Button BtnPen;
        private Button BtnBrush;
        private TrackBar TrbPenSize;
        private Button BtnPenColor;
        private Button BtnGray;
        private Button BtnInvert;
        private Button BtnReset;
        private GroupBox groupBox1;
        private Button BtnRect;
        private Button BtnCircle;
        private Button BtnTriangle;
        private Button BtnRedo;
        private Button BtnUndo;
        private GroupBox groupBox3;
        private CheckBox checkBox1;
        private GroupBox groupBox4;
        private ImageList imageList1;
        private ImageList imageList2;
    }
}
