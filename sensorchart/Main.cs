using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms.DataVisualization.Charting;
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
            dtp_to_date.Value = DateTime.Now;
            dtp_to_time.Value = DateTime.Now;
            dtp_from_date.Value = DateTime.Now.AddHours(-1);
            dtp_from_time.Value = DateTime.Now.AddHours(-1);


            /* 아래 내용은 차트 테스트 입니다. */
            /*List<string[]> lists = new List<string[]>();

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
            MConn.Close();*/
            /* 위의 내용은 차트 테스트 입니다. */

        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            Sheet sheetform = new Sheet(this);
            sheetform.Show();
        }

        /* 데이트 타임 픽커의 밸류값을 조정하는 버튼입니다. */
        private void btn_from_m10m_Click(object sender, EventArgs e)
        {
            dtp_from_date.Value = dtp_from_date.Value.AddMinutes(-10);
            dtp_from_time.Value = dtp_from_time.Value.AddMinutes(-10);
        }

        private void btn_from_p10m_Click(object sender, EventArgs e)
        {
            dtp_from_date.Value = dtp_from_date.Value.AddMinutes(10);
            dtp_from_time.Value = dtp_from_time.Value.AddMinutes(10);
        }

        private void btn_from_m1h_Click(object sender, EventArgs e)
        {
            dtp_from_date.Value = dtp_from_date.Value.AddHours(-1);
            dtp_from_time.Value = dtp_from_time.Value.AddHours(-1);
        }

        private void btn_from_p1h_Click(object sender, EventArgs e)
        {
            dtp_from_date.Value = dtp_from_date.Value.AddHours(1);
            dtp_from_time.Value = dtp_from_time.Value.AddHours(1);
        }

        private void btn_from_m1d_Click(object sender, EventArgs e)
        {
            dtp_from_date.Value = dtp_from_date.Value.AddDays(-1);
            dtp_from_time.Value = dtp_from_time.Value.AddDays(-1);
        }

        private void btn_from_p1d_Click(object sender, EventArgs e)
        {
            dtp_from_date.Value = dtp_from_date.Value.AddDays(1);
            dtp_from_time.Value = dtp_from_time.Value.AddDays(1);
        }

        private void btn_now_Click(object sender, EventArgs e)
        {
            dtp_to_date.Value = DateTime.Now;
            dtp_to_time.Value = DateTime.Now;
        }

        private void btn_to_m10m_Click(object sender, EventArgs e)
        {
            dtp_to_date.Value = dtp_to_date.Value.AddMinutes(-10);
            dtp_to_time.Value = dtp_to_time.Value.AddMinutes(-10);
        }

        private void btn_to_p10m_Click(object sender, EventArgs e)
        {
            dtp_to_date.Value = dtp_to_date.Value.AddMinutes(10);
            dtp_to_time.Value = dtp_to_time.Value.AddMinutes(10);
        }

        private void btn_to_m1h_Click(object sender, EventArgs e)
        {
            dtp_to_date.Value = dtp_to_date.Value.AddHours(-1);
            dtp_to_time.Value = dtp_to_time.Value.AddHours(-1);
        }

        private void btn_to_p1h_Click(object sender, EventArgs e)
        {
            dtp_to_date.Value = dtp_to_date.Value.AddHours(1);
            dtp_to_time.Value = dtp_to_time.Value.AddHours(1);
        }

        private void btn_to_m1d_Click(object sender, EventArgs e)
        {
            dtp_to_date.Value = dtp_to_date.Value.AddDays(-1);
            dtp_to_time.Value = dtp_to_time.Value.AddDays(-1);
        }

        private void btn_to_p1d_Click(object sender, EventArgs e)
        {
            dtp_to_date.Value = dtp_to_date.Value.AddDays(1);
            dtp_to_time.Value = dtp_to_time.Value.AddDays(1);
        }
        /* *************************************************** */

        private void btn_apply_Click(object sender, EventArgs e)
        {
            var MConn = new MySqlConnection(strSql);
            MConn.Open();
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            List<string[]> lists = new List<string[]>();
            List<string> split = new List<string>();
            string result = "";
            string date_from = "";
            string date_to = "";

            for (int i = 0; i < lbx_list.Items.Count; i++)
            {
                split.Add(lbx_list.Items[i].ToString());
                result += split[i].Split('\n')[0];
                if (i < lbx_list.Items.Count - 1)
                    result += ",";
            }

            date_from += dtp_from_date.Value.ToString("yyyyMMdd");
            date_from += dtp_from_time.Value.ToString("HHmm00");
            date_to += dtp_to_date.Value.ToString("yyyyMMdd");
            date_to += dtp_to_time.Value.ToString("HHmm00");

            try {
                string sql = "select seq, id, value, datetime from datasheet where id in(" + result + ") and datetime between date(" + date_from + ") and date(" + date_to + ") order by seq";   
                adapter.SelectCommand = new MySqlCommand(sql, MConn);
                adapter.Fill(ds);
            } catch (MySql.Data.MySqlClient.MySqlException sqlerror) {

            }

            chart.Series.Clear();

            for (int i = 0; i < lbx_list.Items.Count; i++)
            {
                chart.Series.Add("Series" + i);
                chart.Series["Series" + i].LegendText = split[i];
                chart.Series["Series" + i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;


                foreach (DataRow r in ds.Tables[0].Rows)        //차트 데이터 입력
                {
                    if (r["id"].ToString()+'\n' == split[i].ToString())
                    {
                        string[] temp = new string[4];
                        temp[0] = r["seq"].ToString();
                        temp[1] = r["id"].ToString();
                        temp[2] = r["value"].ToString();
                        temp[3] = r["datetime"].ToString();
                        lists.Add(temp);
                    }
                }

                foreach (string[] value in lists)       //차트 그리기
                {
                    chart.Series["Series" + i].Points.AddXY(value[3], value[2]);
                }
                lists.Clear();
            }
            MConn.Close();
        }
    }
}
