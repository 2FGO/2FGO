using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2FGO
{
    public partial class check : Form
    {
        DB db = new DB();
        string student = "";
        string sql = "";
        public check()
        {
            InitializeComponent();
        }

        private void check_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false; // 현재 폼 안보이게 하기
            Form1 frm = new Form1(); // 새 폼 생성¬
            frm.Owner = this; // 새 폼의 오너를 현재 폼으로
            frm.Show(); // 새폼 보여 주 기 
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            student = txt_Message.Text; // 텍스트박스의 문자열(학생정보)를 저장
            sql = "UPDATE TWOFGO SET CHECKED = 'TRUE' WHERE STUDENT = '" + student + "'"; // 쿼리문 실행 시 CHECKED 컬럼의 값을 TRUE로 바꿔 출석체크 상태를 확인함
            db.CRUD(sql); // 저장된 쿼리문을 실행
            if (student == "")
            {
                MessageBox.Show("학번과 이름을 다시 입력해주세요");
            }
            else { 
            string message = string.Empty;
            message = string.Format("{0}님 출석체크가 되었습니다.", txt_Message.Text);
            MessageBox.Show(message);
                this.Visible = false; // 현재 폼 안보이게 하기
                Form1 frm = new Form1(); // 새 폼 생성¬
                frm.Owner = this; // 새 폼의 오너를 현재 폼으로
                frm.Show(); // 새폼 보여 주 기
            }
        }
        public string Student(string student__)
        {
            student = "";
            return student__;
        }
    }
}
