using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sensorchart
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

        }

        public string strSql = "Data Source=localhost;Database=test;User Id=root;Password=tinyos";

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            List<string[]> lists = new List<string[]>();

            var MConn = new MySqlConnection(strSql);
            MConn.Open();
            DataSet ds = new DataSet();

            string sql = "select seq, id, value, mid(datetime, 12, 5) as time from datasheet where id = 100";
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = new MySqlCommand(sql, MConn);
            adapter.Fill(ds);

            foreach (DataRow r in ds.Tables[0].Rows)        //차트 데이터 입력
            {
                string[] temp = new string[4];
                temp[0] = r["seq"].ToString();
                temp[1] = r["id"].ToString();
                temp[2] = r["value"].ToString();
                temp[3] = r["time"].ToString();
                lists.Add(temp);
            }

            foreach (string[] value in lists)       //차트 그리기
            {
                chart.Series[0].Points.AddXY(value[3], value[2]);
            }
            MConn.Close();
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            Sheet sheetform = new Sheet(this);
            sheetform.Show();
        }
    }
}
