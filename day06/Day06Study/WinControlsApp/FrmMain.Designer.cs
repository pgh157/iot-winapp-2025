namespace WinControlsApp
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
            statusStrip1 = new StatusStrip();
            LblState = new ToolStripStatusLabel();
            menuStrip1 = new MenuStrip();
            MnuFile = new ToolStripMenuItem();
            MnuNewFile = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            MnuExit = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            TxtResult = new TextBox();
            ChkItalic = new CheckBox();
            ChkBold = new CheckBox();
            CboFonts = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            BtnOpenimage = new Button();
            PicImage = new PictureBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            BtnModal = new Button();
            BtnMsgBox = new Button();
            BtnModaless = new Button();
            groupBox6 = new GroupBox();
            PrgProcess = new ProgressBar();
            TrbProcess = new TrackBar();
            groupBox7 = new GroupBox();
            BtnNode = new Button();
            BtnRoot = new Button();
            LsvDummy = new ListView();
            imageList1 = new ImageList(components);
            TrvDummy = new TreeView();
            groupBox8 = new GroupBox();
            DlgOpenImage = new OpenFileDialog();
            groupBox9 = new GroupBox();
            BtnCheck = new Button();
            LblUrl = new LinkLabel();
            TxtDay = new TextBox();
            TxtMonth = new TextBox();
            TxtYear = new TextBox();
            DtpBirth = new DateTimePicker();
            CalSchedule = new MonthCalendar();
            toolTip1 = new ToolTip(components);
            statusStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PicImage).BeginInit();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TrbProcess).BeginInit();
            groupBox7.SuspendLayout();
            groupBox9.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { LblState });
            statusStrip1.Location = new Point(0, 539);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1184, 22);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // LblState
            // 
            LblState.Name = "LblState";
            LblState.Size = new Size(86, 17);
            LblState.Text = "상태: 일반상태";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLightLight;
            menuStrip1.Items.AddRange(new ToolStripItem[] { MnuFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1184, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // MnuFile
            // 
            MnuFile.DropDownItems.AddRange(new ToolStripItem[] { MnuNewFile, toolStripMenuItem1, MnuExit });
            MnuFile.Name = "MnuFile";
            MnuFile.Size = new Size(57, 20);
            MnuFile.Text = "파일(&F)";
            // 
            // MnuNewFile
            // 
            MnuNewFile.Name = "MnuNewFile";
            MnuNewFile.Size = new Size(119, 22);
            MnuNewFile.Text = "새 글(&N)";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(116, 6);
            // 
            // MnuExit
            // 
            MnuExit.Name = "MnuExit";
            MnuExit.Size = new Size(119, 22);
            MnuExit.Text = "종료(&X)";
            MnuExit.Click += MnuExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(378, 132);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(TxtResult);
            groupBox3.Controls.Add(ChkItalic);
            groupBox3.Controls.Add(ChkBold);
            groupBox3.Controls.Add(CboFonts);
            groupBox3.Controls.Add(label1);
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(378, 132);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "일반 컨트롤";
            // 
            // TxtResult
            // 
            TxtResult.Location = new Point(15, 64);
            TxtResult.Name = "TxtResult";
            TxtResult.Size = new Size(340, 21);
            TxtResult.TabIndex = 3;
            TxtResult.Text = "Sample Text";
            // 
            // ChkItalic
            // 
            ChkItalic.AutoSize = true;
            ChkItalic.Font = new Font("나눔고딕", 9F, FontStyle.Italic);
            ChkItalic.Location = new Point(301, 27);
            ChkItalic.Name = "ChkItalic";
            ChkItalic.Size = new Size(59, 18);
            ChkItalic.TabIndex = 2;
            ChkItalic.Text = "이탤릭";
            ChkItalic.UseVisualStyleBackColor = true;
            ChkItalic.CheckedChanged += ChkItalic_CheckedChanged;
            // 
            // ChkBold
            // 
            ChkBold.AutoSize = true;
            ChkBold.Font = new Font("나눔고딕", 9F, FontStyle.Bold);
            ChkBold.Location = new Point(247, 27);
            ChkBold.Name = "ChkBold";
            ChkBold.Size = new Size(48, 18);
            ChkBold.TabIndex = 2;
            ChkBold.Text = "볼드";
            ChkBold.UseVisualStyleBackColor = true;
            ChkBold.CheckedChanged += ChkBold_CheckedChanged;
            // 
            // CboFonts
            // 
            CboFonts.FormattingEnabled = true;
            CboFonts.Location = new Point(50, 25);
            CboFonts.Name = "CboFonts";
            CboFonts.Size = new Size(191, 22);
            CboFonts.TabIndex = 1;
            CboFonts.SelectedIndexChanged += CboFonts_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 28);
            label1.Name = "label1";
            label1.Size = new Size(29, 14);
            label1.TabIndex = 0;
            label1.Text = "폰트";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(BtnOpenimage);
            groupBox2.Controls.Add(PicImage);
            groupBox2.Controls.Add(groupBox4);
            groupBox2.Location = new Point(396, 27);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(385, 503);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "픽처박스";
            // 
            // BtnOpenimage
            // 
            BtnOpenimage.Location = new Point(278, 470);
            BtnOpenimage.Name = "BtnOpenimage";
            BtnOpenimage.Size = new Size(100, 27);
            BtnOpenimage.TabIndex = 5;
            BtnOpenimage.Text = "이미지열기";
            BtnOpenimage.UseVisualStyleBackColor = true;
            BtnOpenimage.Click += BtnOpenimage_Click;
            // 
            // PicImage
            // 
            PicImage.BackColor = SystemColors.GradientInactiveCaption;
            PicImage.Location = new Point(6, 20);
            PicImage.Name = "PicImage";
            PicImage.Size = new Size(372, 444);
            PicImage.TabIndex = 3;
            PicImage.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Location = new Point(384, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(385, 132);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox1";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(BtnModal);
            groupBox5.Controls.Add(BtnMsgBox);
            groupBox5.Controls.Add(BtnModaless);
            groupBox5.Location = new Point(12, 291);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(378, 70);
            groupBox5.TabIndex = 2;
            groupBox5.TabStop = false;
            groupBox5.Text = "모달, 모달리스";
            // 
            // BtnModal
            // 
            BtnModal.Location = new Point(22, 20);
            BtnModal.Name = "BtnModal";
            BtnModal.Size = new Size(100, 40);
            BtnModal.TabIndex = 0;
            BtnModal.Text = "Modal";
            BtnModal.UseVisualStyleBackColor = true;
            BtnModal.Click += BtnModal_Click;
            // 
            // BtnMsgBox
            // 
            BtnMsgBox.Location = new Point(234, 20);
            BtnMsgBox.Name = "BtnMsgBox";
            BtnMsgBox.Size = new Size(121, 40);
            BtnMsgBox.TabIndex = 0;
            BtnMsgBox.Text = "MessageBox";
            BtnMsgBox.UseVisualStyleBackColor = true;
            BtnMsgBox.Click += BtnMsgBox_Click;
            // 
            // BtnModaless
            // 
            BtnModaless.Location = new Point(128, 20);
            BtnModaless.Name = "BtnModaless";
            BtnModaless.Size = new Size(100, 40);
            BtnModaless.TabIndex = 0;
            BtnModaless.Text = "Modaless";
            BtnModaless.UseVisualStyleBackColor = true;
            BtnModaless.Click += BtnModaless_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(PrgProcess);
            groupBox6.Controls.Add(TrbProcess);
            groupBox6.Location = new Point(12, 175);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(378, 110);
            groupBox6.TabIndex = 2;
            groupBox6.TabStop = false;
            groupBox6.Text = "트랙바";
            // 
            // PrgProcess
            // 
            PrgProcess.Location = new Point(15, 71);
            PrgProcess.Name = "PrgProcess";
            PrgProcess.Size = new Size(340, 23);
            PrgProcess.TabIndex = 1;
            // 
            // TrbProcess
            // 
            TrbProcess.Location = new Point(6, 20);
            TrbProcess.Maximum = 100;
            TrbProcess.Name = "TrbProcess";
            TrbProcess.Size = new Size(354, 45);
            TrbProcess.TabIndex = 0;
            TrbProcess.TickFrequency = 10;
            TrbProcess.Scroll += TrbProcess_Scroll;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(BtnNode);
            groupBox7.Controls.Add(BtnRoot);
            groupBox7.Controls.Add(LsvDummy);
            groupBox7.Controls.Add(TrvDummy);
            groupBox7.Controls.Add(groupBox8);
            groupBox7.Location = new Point(12, 367);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(385, 169);
            groupBox7.TabIndex = 2;
            groupBox7.TabStop = false;
            groupBox7.Text = "트리뷰, 리스트뷰";
            // 
            // BtnNode
            // 
            BtnNode.Location = new Point(273, 136);
            BtnNode.Name = "BtnNode";
            BtnNode.Size = new Size(100, 27);
            BtnNode.TabIndex = 5;
            BtnNode.Text = "노드추가";
            BtnNode.UseVisualStyleBackColor = true;
            BtnNode.Click += BtnNode_Click;
            // 
            // BtnRoot
            // 
            BtnRoot.Location = new Point(167, 136);
            BtnRoot.Name = "BtnRoot";
            BtnRoot.Size = new Size(100, 27);
            BtnRoot.TabIndex = 5;
            BtnRoot.Text = "루트추가";
            BtnRoot.UseVisualStyleBackColor = true;
            BtnRoot.Click += BtnRoot_Click;
            // 
            // LsvDummy
            // 
            LsvDummy.LargeImageList = imageList1;
            LsvDummy.Location = new Point(199, 20);
            LsvDummy.Name = "LsvDummy";
            LsvDummy.Size = new Size(174, 110);
            LsvDummy.SmallImageList = imageList1;
            LsvDummy.TabIndex = 4;
            LsvDummy.UseCompatibleStateImageBehavior = false;
            LsvDummy.View = View.SmallIcon;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "folder-normal.png");
            // 
            // TrvDummy
            // 
            TrvDummy.ImageIndex = 0;
            TrvDummy.ImageList = imageList1;
            TrvDummy.Location = new Point(6, 20);
            TrvDummy.Name = "TrvDummy";
            TrvDummy.SelectedImageIndex = 0;
            TrvDummy.Size = new Size(187, 110);
            TrvDummy.TabIndex = 3;
            // 
            // groupBox8
            // 
            groupBox8.Location = new Point(384, 0);
            groupBox8.Name = "groupBox8";
            groupBox8.Size = new Size(385, 132);
            groupBox8.TabIndex = 2;
            groupBox8.TabStop = false;
            groupBox8.Text = "groupBox1";
            // 
            // groupBox9
            // 
            groupBox9.Controls.Add(BtnCheck);
            groupBox9.Controls.Add(LblUrl);
            groupBox9.Controls.Add(TxtDay);
            groupBox9.Controls.Add(TxtMonth);
            groupBox9.Controls.Add(TxtYear);
            groupBox9.Controls.Add(DtpBirth);
            groupBox9.Controls.Add(CalSchedule);
            groupBox9.Location = new Point(787, 27);
            groupBox9.Name = "groupBox9";
            groupBox9.Size = new Size(385, 503);
            groupBox9.TabIndex = 4;
            groupBox9.TabStop = false;
            groupBox9.Text = "기타 컨트롤";
            // 
            // BtnCheck
            // 
            BtnCheck.Location = new Point(272, 201);
            BtnCheck.Name = "BtnCheck";
            BtnCheck.Size = new Size(100, 27);
            BtnCheck.TabIndex = 5;
            BtnCheck.Text = "확인";
            BtnCheck.UseVisualStyleBackColor = true;
            BtnCheck.Click += BtnCheck_Click;
            // 
            // LblUrl
            // 
            LblUrl.AutoSize = true;
            LblUrl.Location = new Point(12, 228);
            LblUrl.Name = "LblUrl";
            LblUrl.Size = new Size(40, 14);
            LblUrl.TabIndex = 3;
            LblUrl.TabStop = true;
            LblUrl.Text = "네이버";
            LblUrl.LinkClicked += LblUrl_LinkClicked;
            // 
            // TxtDay
            // 
            TxtDay.Location = new Point(272, 82);
            TxtDay.Name = "TxtDay";
            TxtDay.Size = new Size(100, 21);
            TxtDay.TabIndex = 2;
            // 
            // TxtMonth
            // 
            TxtMonth.Location = new Point(272, 55);
            TxtMonth.Name = "TxtMonth";
            TxtMonth.Size = new Size(100, 21);
            TxtMonth.TabIndex = 2;
            // 
            // TxtYear
            // 
            TxtYear.Location = new Point(272, 28);
            TxtYear.Name = "TxtYear";
            TxtYear.Size = new Size(100, 21);
            TxtYear.TabIndex = 2;
            // 
            // DtpBirth
            // 
            DtpBirth.Location = new Point(12, 202);
            DtpBirth.Name = "DtpBirth";
            DtpBirth.Size = new Size(200, 21);
            DtpBirth.TabIndex = 1;
            DtpBirth.ValueChanged += DtpBirth_ValueChanged;
            // 
            // CalSchedule
            // 
            CalSchedule.FirstDayOfWeek = Day.Sunday;
            CalSchedule.Location = new Point(12, 28);
            CalSchedule.Name = "CalSchedule";
            CalSchedule.TabIndex = 0;
            CalSchedule.DateChanged += CalSchedule_DateChanged;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1184, 561);
            Controls.Add(groupBox9);
            Controls.Add(groupBox7);
            Controls.Add(groupBox2);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            Font = new Font("나눔고딕", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UI컨트롤예제 윈앱";
            FormClosing += FrmMain_FormClosing;
            Load += FrmMain_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PicImage).EndInit();
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TrbProcess).EndInit();
            groupBox7.ResumeLayout(false);
            groupBox9.ResumeLayout(false);
            groupBox9.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TextBox TxtResult;
        private CheckBox ChkBold;
        private ComboBox CboFonts;
        private Label label1;
        private CheckBox ChkItalic;
        private ToolStripStatusLabel LblState;
        private GroupBox groupBox6;
        private ProgressBar PrgProcess;
        private TrackBar TrbProcess;
        private Button BtnModal;
        private Button BtnMsgBox;
        private Button BtnModaless;
        private GroupBox groupBox7;
        private Button BtnNode;
        private Button BtnRoot;
        private ListView LsvDummy;
        private TreeView TrvDummy;
        private GroupBox groupBox8;
        private ImageList imageList1;
        private Button BtnOpenimage;
        private PictureBox PicImage;
        private OpenFileDialog DlgOpenImage;
        private GroupBox groupBox9;
        private LinkLabel LblUrl;
        private TextBox TxtDay;
        private TextBox TxtMonth;
        private TextBox TxtYear;
        private DateTimePicker DtpBirth;
        private MonthCalendar CalSchedule;
        private Button BtnCheck;
        private ToolStripMenuItem MnuFile;
        private ToolStripMenuItem MnuNewFile;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem MnuExit;
        private ToolTip toolTip1;
    }
}
