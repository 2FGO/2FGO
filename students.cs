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
    public partial class students : Form
    {
        DB db = new DB();
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);// App.config에 있는 con 태그 설정을 가져와서 Oracle을 연동함

        public students()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string sql = "SELECT ID, STUDENT, CHECKED FROM TWOFGO"; // DB에 있는 ID, STUDENT, CHECKED 값을 불러오는 쿼리문
            DataTable dt = db.GetDBTable(sql); // 쿼리문을 실행해서 출력 된 값을 저장
            dataGridView1.DataSource = dt; // 저장된 값을 테이블에 뿌려줌
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM TWOFGO";
            db.CRUD(sql);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Visible = false; // 현재 폼 안보이게 하기
            admin frm = new admin(); // 새 폼 생성¬
            frm.Owner = this; // 새 폼의 오너를 현재 폼으로
            frm.Show(); // 새폼 보여 주 기 
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}
