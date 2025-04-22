namespace SyntaxWinApp04
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            if(TxtName.Text == "" || TxtAge.Text == "")
            {
                MessageBox.Show("값을 채워주세요.");
                return; // 메서드 탈출
            }
            else
            {
                // 위의 문제가 없을때 동작...
                LblResult.Text = "처리결과 : ";
                TxtResul.Text = "먼가 처리될거임";

                string name = TxtName.Text.Trim();  // 앞뒤 여백을 제거
                // 파싱 -> 분석해서 형 변환
                DateTime birthday = DateTime.Parse(TxtAge.Text.Trim());
                int age = (DateTime.Now.Year - birthday.Year);
                // 3항식 분기
                string gender = RdoMale.Checked ? "남" : "여";

                // 옛날 방식 문자열 포맷팅
                TxtResul.Text = "저는" + name + "이고," + birthday + "에 태어난 " + age+ "살"+ gender + "자입니다.";
                // 최신방식 문자열 포맷팅 $""
                TxtResul.Text = $"저는 {name}이고, {birthday:yyyy-MM-dd}일에 태어난 {age:F2}살 {gender}자 입니다.!!";
            }
            
        }
    }
}
