namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            // �б⹮
            // if else ��
            if (TxtPain.Text == "�ƴϿ�")
            {
                MessageBox.Show("������ �� �Ծ��. ������!");
            }
            else if (TxtPain.Text == "��")
            {
                string PainPoint = CboPainPoint.SelectedItem.ToString();

                // switch ��
                switch (PainPoint)
                {
                    case "�Ӹ�":
                        MessageBox.Show("�Ű���� ���ϴ�", "����� ����");
                        break;
                    case "��":
                        MessageBox.Show("�Ȱ��� ���ϴ�", "����� ����");
                        break;
                    case "��":
                        MessageBox.Show("�̺����İ��� ���ϴ�", "����� ����");
                        break;
                    case "��":
                        MessageBox.Show("�̺����İ��� ���ϴ�", "����� ����");
                        break;
                    case "����":
                        MessageBox.Show("������ ���ϴ�", "����� ����");
                        break;
                    case "��":
                        MessageBox.Show("��ȭ���� ���ϴ�", "����� ����");
                        break;

                }
            }
        }


        private void TxtPain_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Ű���������� ���͸� �Է��ϸ� C, C++ if���� ����
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show(TxtPain.Text, "�Է°�");
            }
        }

        private void CboPainPoint_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedPoint = CboPainPoint.SelectedItem.ToString();
            MessageBox.Show(selectedPoint, "��������");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            TxtResult.Text = string.Empty;  // �ʱ�ȭ
            // for�� 
            for (int x = 2; x < 10; x++)
            {
                for (int y = 1; y < 10; y++)
                {
                    var result = x + "x" + y + "=" + (x * y);
                    TxtResult.Text += result + " ";
                }
                TxtResult.Text += "\r\n";   // ���� ������� \r\n�� ���� ��� ��
            }
        }

        int clickNum = 0;

        private void BtnWhile_Click(object sender, EventArgs e)
        {
            // 
            // ���� �ݺ�
            while(true)
            {
                MessageBox.Show("��� > " + clickNum);
                clickNum++;

                if(clickNum == 10)
                {
                    break;  // �ݺ��� Ż�� for, foreach, while ���� ��밡��
                    // continue; �� �ľ��� ��
                    // goto; �� �ظ��ϸ� ���� ����
                }
            }
        }
    }
}