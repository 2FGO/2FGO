
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false; // 현재 폼 안보이게 하기
            Form2 frm = new Form2(); // 새 폼 생성¬
            frm.Owner = this; // 새 폼의 오너를 현재 폼으로
            frm.Show(); // 새폼 보여 주 기 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false; // 현재 폼 안보이게 하기
            check frm = new check(); // 새 폼 생성¬
            frm.Owner = this; // 새 폼의 오너를 현재 폼으로
            frm.Show(); // 새폼 보여 주 기 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false; // 현재 폼 안보이게 하기
            admin frm = new admin(); // 새 폼 생성¬
            frm.Owner = this; // 새 폼의 오너를 현재 폼으로
            frm.Show(); // 새폼 보여 주 기 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void studentt_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
