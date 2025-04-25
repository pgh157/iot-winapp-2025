namespace ExWinApp
{
    partial class Form1
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
            panel1 = new Panel();
            hScrollBar_R = new HScrollBar();
            label1 = new Label();
            label2 = new Label();
            textBox_R = new TextBox();
            hScrollBar_G = new HScrollBar();
            label3 = new Label();
            textBox_G = new TextBox();
            hScrollBar_B = new HScrollBar();
            label4 = new Label();
            textBox_B = new TextBox();
            hScrollBar_A = new HScrollBar();
            label5 = new Label();
            textBox_A = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            pictureBox = new PictureBox();
            ScrBarG = new HScrollBar();
            TxtBoxA = new TextBox();
            label6 = new Label();
            ScrBarR = new HScrollBar();
            label7 = new Label();
            TxtBoxB = new TextBox();
            label8 = new Label();
            label9 = new Label();
            TxtBoxG = new TextBox();
            label10 = new Label();
            ScrBarB = new HScrollBar();
            ScrBarA = new HScrollBar();
            TxtBoxR = new TextBox();
            bindingSource1 = new BindingSource(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(6, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(290, 144);
            panel1.TabIndex = 0;
            // 
            // hScrollBar_R
            // 
            hScrollBar_R.Location = new Point(66, 200);
            hScrollBar_R.Maximum = 264;
            hScrollBar_R.Name = "hScrollBar_R";
            hScrollBar_R.Size = new Size(152, 24);
            hScrollBar_R.TabIndex = 1;
            hScrollBar_R.Scroll += scroll_RGBA;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 204);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 2;
            label1.Text = "R";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 264);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 2;
            // 
            // textBox_R
            // 
            textBox_R.Location = new Point(235, 201);
            textBox_R.Name = "textBox_R";
            textBox_R.Size = new Size(67, 23);
            textBox_R.TabIndex = 3;
            textBox_R.TextChanged += textchanged_RGBA;
            // 
            // hScrollBar_G
            // 
            hScrollBar_G.Location = new Point(66, 227);
            hScrollBar_G.Maximum = 264;
            hScrollBar_G.Name = "hScrollBar_G";
            hScrollBar_G.Size = new Size(152, 24);
            hScrollBar_G.TabIndex = 1;
            hScrollBar_G.Scroll += scroll_RGBA;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(12, 231);
            label3.Name = "label3";
            label3.Size = new Size(16, 15);
            label3.TabIndex = 2;
            label3.Text = "G";
            // 
            // textBox_G
            // 
            textBox_G.Location = new Point(235, 228);
            textBox_G.Name = "textBox_G";
            textBox_G.Size = new Size(67, 23);
            textBox_G.TabIndex = 3;
            textBox_G.TextChanged += textchanged_RGBA;
            // 
            // hScrollBar_B
            // 
            hScrollBar_B.Location = new Point(66, 255);
            hScrollBar_B.Maximum = 264;
            hScrollBar_B.Name = "hScrollBar_B";
            hScrollBar_B.Size = new Size(152, 24);
            hScrollBar_B.TabIndex = 1;
            hScrollBar_B.Scroll += scroll_RGBA;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 0, 192);
            label4.Location = new Point(12, 259);
            label4.Name = "label4";
            label4.Size = new Size(15, 15);
            label4.TabIndex = 2;
            label4.Text = "B";
            // 
            // textBox_B
            // 
            textBox_B.Location = new Point(235, 256);
            textBox_B.Name = "textBox_B";
            textBox_B.Size = new Size(67, 23);
            textBox_B.TabIndex = 3;
            textBox_B.TextChanged += textchanged_RGBA;
            // 
            // hScrollBar_A
            // 
            hScrollBar_A.Location = new Point(66, 289);
            hScrollBar_A.Maximum = 264;
            hScrollBar_A.Name = "hScrollBar_A";
            hScrollBar_A.Size = new Size(152, 24);
            hScrollBar_A.TabIndex = 1;
            hScrollBar_A.Scroll += scroll_RGBA;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            label5.Location = new Point(12, 293);
            label5.Name = "label5";
            label5.Size = new Size(15, 15);
            label5.TabIndex = 2;
            label5.Text = "A";
            // 
            // textBox_A
            // 
            textBox_A.Location = new Point(235, 290);
            textBox_A.Name = "textBox_A";
            textBox_A.Size = new Size(67, 23);
            textBox_A.TabIndex = 3;
            textBox_A.TextChanged += textchanged_RGBA;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(textBox_A);
            groupBox1.Controls.Add(hScrollBar_R);
            groupBox1.Controls.Add(textBox_B);
            groupBox1.Controls.Add(hScrollBar_G);
            groupBox1.Controls.Add(textBox_G);
            groupBox1.Controls.Add(hScrollBar_B);
            groupBox1.Controls.Add(textBox_R);
            groupBox1.Controls.Add(hScrollBar_A);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(324, 332);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "RGBA연습";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox);
            groupBox2.Controls.Add(ScrBarG);
            groupBox2.Controls.Add(TxtBoxA);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(ScrBarR);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(TxtBoxB);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(TxtBoxG);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(ScrBarB);
            groupBox2.Controls.Add(ScrBarA);
            groupBox2.Controls.Add(TxtBoxR);
            groupBox2.Location = new Point(351, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(370, 332);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "이미지RGBA";
            // 
            // pictureBox
            // 
            pictureBox.Image = Properties.Resources.wrtFileImageView;
            pictureBox.Location = new Point(6, 22);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(358, 144);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 4;
            pictureBox.TabStop = false;
            // 
            // ScrBarG
            // 
            ScrBarG.Location = new Point(83, 222);
            ScrBarG.Maximum = 264;
            ScrBarG.Name = "ScrBarG";
            ScrBarG.Size = new Size(152, 24);
            ScrBarG.TabIndex = 1;
            ScrBarG.Scroll += scroll_RGBA_P;
            // 
            // TxtBoxA
            // 
            TxtBoxA.Location = new Point(252, 285);
            TxtBoxA.Name = "TxtBoxA";
            TxtBoxA.Size = new Size(67, 23);
            TxtBoxA.TabIndex = 3;
            TxtBoxA.TextChanged += textchanged_RGBA_P;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(0, 0, 192);
            label6.Location = new Point(29, 254);
            label6.Name = "label6";
            label6.Size = new Size(15, 15);
            label6.TabIndex = 2;
            label6.Text = "B";
            // 
            // ScrBarR
            // 
            ScrBarR.Location = new Point(83, 195);
            ScrBarR.Maximum = 264;
            ScrBarR.Name = "ScrBarR";
            ScrBarR.Size = new Size(152, 24);
            ScrBarR.TabIndex = 1;
            ScrBarR.Scroll += scroll_RGBA_P;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            label7.ForeColor = Color.Lime;
            label7.Location = new Point(29, 226);
            label7.Name = "label7";
            label7.Size = new Size(16, 15);
            label7.TabIndex = 2;
            label7.Text = "G";
            // 
            // TxtBoxB
            // 
            TxtBoxB.Location = new Point(252, 251);
            TxtBoxB.Name = "TxtBoxB";
            TxtBoxB.Size = new Size(67, 23);
            TxtBoxB.TabIndex = 3;
            TxtBoxB.TextChanged += textchanged_RGBA_P;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            label8.Location = new Point(29, 288);
            label8.Name = "label8";
            label8.Size = new Size(15, 15);
            label8.TabIndex = 2;
            label8.Text = "A";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(29, 199);
            label9.Name = "label9";
            label9.Size = new Size(15, 15);
            label9.TabIndex = 2;
            label9.Text = "R";
            // 
            // TxtBoxG
            // 
            TxtBoxG.Location = new Point(252, 223);
            TxtBoxG.Name = "TxtBoxG";
            TxtBoxG.Size = new Size(67, 23);
            TxtBoxG.TabIndex = 3;
            TxtBoxG.TextChanged += textchanged_RGBA_P;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(38, 259);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 2;
            // 
            // ScrBarB
            // 
            ScrBarB.Location = new Point(83, 250);
            ScrBarB.Maximum = 264;
            ScrBarB.Name = "ScrBarB";
            ScrBarB.Size = new Size(152, 24);
            ScrBarB.TabIndex = 1;
            ScrBarB.Scroll += scroll_RGBA_P;
            // 
            // ScrBarA
            // 
            ScrBarA.Location = new Point(83, 284);
            ScrBarA.Maximum = 264;
            ScrBarA.Name = "ScrBarA";
            ScrBarA.Size = new Size(152, 24);
            ScrBarA.TabIndex = 1;
            ScrBarA.Scroll += scroll_RGBA_P;
            // 
            // TxtBoxR
            // 
            TxtBoxR.Location = new Point(252, 196);
            TxtBoxR.Name = "TxtBoxR";
            TxtBoxR.Size = new Size(67, 23);
            TxtBoxR.TabIndex = 3;
            TxtBoxR.TextChanged += textchanged_RGBA_P;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 355);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private HScrollBar hScrollBar_R;
        private Label label1;
        private Label label2;
        private TextBox textBox_R;
        private HScrollBar hScrollBar_G;
        private Label label3;
        private TextBox textBox_G;
        private HScrollBar hScrollBar_B;
        private Label label4;
        private TextBox textBox_B;
        private HScrollBar hScrollBar_A;
        private Label label5;
        private TextBox textBox_A;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox;
        private HScrollBar ScrBarG;
        private TextBox TxtBoxA;
        private Label label6;
        private HScrollBar ScrBarR;
        private Label label7;
        private TextBox TxtBoxB;
        private Label label8;
        private Label label9;
        private TextBox TxtBoxG;
        private Label label10;
        private HScrollBar ScrBarB;
        private HScrollBar ScrBarA;
        private TextBox TxtBoxR;
        private BindingSource bindingSource1;
    }
}
