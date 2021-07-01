using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;
namespace _2FGO
{
    public partial class Form2 : Form
    {
        check ch = new check();
        int num = 0; // Column ID 값
        string student = ""; // 학생정보를 저장하는 필드
        string sql = ""; // 쿼리 명령문을 저장하는 필드
        DB db = new DB();
        public Form2()
        {
            InitializeComponent();
            //this.btn_Confirm.Click += button1_Click;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false; // 현재 폼 안보이게 하기
            Form1 frm = new Form1(); // 새 폼 생성¬
            frm.Owner = this; // 새 폼의 오너를 현재 폼으로
            frm.Show(); // 새폼 보여 주 기 
        }

     

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txt_Message_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void studentt_Click(object sender, EventArgs e)
        {
            student = txt_Message.Text; // student에 학생정보를 넘겨주는 코드
            sql = "INSERT INTO TWOFGO VALUES(" + ++num + ",'" + student + "', 'STUDENT', 'FALSE')";// 쿼리문

            try
            {
                db.CRUD(sql); // DB에 저장하는 메서드
                MessageBox.Show(student + "님 자습신청이 되었습니다.");
                ch.Student(student);
                this.Visible = false; // 현재 폼 안보이게 하기
            Form1 frm = new Form1(); // 새 폼 생성¬
            frm.Owner = this; // 새 폼의 오너를 현재 폼으로
            frm.Show(); // 새폼 보여 주 기
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }
    }
}
