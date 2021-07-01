using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;

namespace _2FGO
{
    class DB
    {

        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);// App.config에 있는 con 태그 설정을 가져와서 Oracle을 연동함
        
        
        public void CRUD(string sql) // ExecuteNonQuery() 메서드가 SQL insert, update, delete의 기능을 가지고 있음.
        {
            OracleCommand cmd = new OracleCommand(sql); // 쿼리 실행을 위한 command 객체 생성
            cmd.Connection = con;
            con.Close();
            con.Open();  // DB 실행
            cmd.ExecuteNonQuery(); // 쿼리문 실행
            con.Close();
        }
        public DataTable GetDBTable(string sql)
        {
            OracleDataAdapter adapter = new OracleDataAdapter(sql, con);
            OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }
       
        public void test(OracleConnection con)
        {   
            try
            {
                con.Open(); // sql 연결 실행
                MessageBox.Show("Connect");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " 오류가 발생했습니다");
            }
            con.Close(); //sql 닫기
        }
    }
}
