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
    public partial class admin : Form
    {
        DB db = new DB();
        string IDX = "GSM_ADMIN";
        string PWD = "0102";

        public admin()
        {
            InitializeComponent();
        }
        private void SELECTtest_Click(object sender, EventArgs e)
        {
           
            
        }
    

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }


        private void PW_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDX == ID.Text && PWD == PW.Text)
                {
                    MessageBox.Show("관리자 로그인 성공!");
                    this.Visible = false; // 현재 폼 안보이게 하기
                    students frm = new students(); // 새 폼 생성¬
                    frm.Owner = this; // 새 폼의 오너를 현재 폼으로
                    frm.Show(); // 새폼 보여 주 기
                }
                else if (IDX != ID.Text || PWD != PW.Text)
                {
                    MessageBox.Show("등록되지 않은 회원입니다");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
        }

        private void button3_Click(object sender, EventArgs e)
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
    }
}
