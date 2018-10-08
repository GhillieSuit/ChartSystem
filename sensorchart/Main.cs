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
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;


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

        private void draw_chart()
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

            try
            {
                string sql = "select seq, id, value, datetime from datasheet where id in(" + result + ") and datetime between " + date_from + " and " + date_to + " order by seq";
                adapter.SelectCommand = new MySqlCommand(sql, MConn);
                adapter.Fill(ds);
            }
            catch (MySql.Data.MySqlClient.MySqlException sqlerror)
            {

            }

            chart.Series.Clear();

            for (int i = 0; i < lbx_list.Items.Count; i++)
            {
                chart.Series.Add("Series" + i);
                chart.Series["Series" + i].LegendText = split[i];
                chart.Series["Series" + i].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;


                foreach (DataRow r in ds.Tables[0].Rows)        //차트 데이터 입력
                {
                    if (r["id"].ToString() + '\n' == split[i].ToString())
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

        private void btn_apply_Click(object sender, EventArgs e)
        {
            draw_chart();
        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            var MConn = new MySqlConnection(strSql);
            MConn.Open();
            DataSet ds = new DataSet();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            Excel.Application excelApp = null;
            Excel.Workbook wb = null;
            Excel.Worksheet ws = null;

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
                string sql = "select seq, id, value, datetime from datasheet where id in(" + result + ") and datetime between " + date_from + " and " + date_to + " order by seq";
                adapter.SelectCommand = new MySqlCommand(sql, MConn);
                adapter.Fill(ds);
            } catch (MySql.Data.MySqlClient.MySqlException sqlerror) {

            }

            try {
                excelApp = new Excel.Application();
                wb = excelApp.Workbooks.Add();          // Excel 첫번째 워크시트 가져오기  
                for (int i = lbx_list.Items.Count - 1; i >= 0; i--)
                {
                    if (i != lbx_list.Items.Count - 1)
                        wb.Worksheets.Add();        
                    wb.Worksheets.get_Item(1).Name = split[i].ToString();
                    ws = wb.Worksheets.get_Item(1) as Excel.Worksheet;

                    int j = 2;
                    ws.Cells[1, 1] = "seq";
                    ws.Cells[1, 2] = "id";
                    ws.Cells[1, 3] = "value";
                    ws.Cells[1, 4] = "datetime";  
                    foreach (DataRow r in ds.Tables[0].Rows)        // 데이타 넣기
                    {
                        if (r["id"].ToString() + '\n' == split[i].ToString())
                        {   
                            ws.Cells[j, 1] = r["seq"].ToString();
                            ws.Cells[j, 2] = r["id"].ToString();
                            ws.Cells[j, 3] = r["value"].ToString();
                            ws.Cells[j, 4] = r["datetime"].ToString();
                            j++;
                        }
                    }
                }
 
                wb.SaveAs(@"D:\Users\Desktop\test.xls", Excel.XlFileFormat.xlWorkbookNormal);   // 엑셀파일 저장
                wb.Close(true);
                excelApp.Quit();
            } catch (Exception error) {

            } finally {
                // Clean up
                ReleaseExcelObject(ws);
                ReleaseExcelObject(wb);
                ReleaseExcelObject(excelApp);
            }

            MConn.Close();
        }

        private static void ReleaseExcelObject(object obj)
        {
            try
            {
                if (obj != null)
                {
                    Marshal.ReleaseComObject(obj);
                    obj = null;
                }
            }
            catch (Exception ex)
            {
                obj = null;
                throw ex;
            }
            finally
            {
                GC.Collect();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ckb_auto.Checked)
                draw_chart();
            else
                return;
        }

        private void ckb_auto_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_auto.Checked)
                timer1.Enabled = true;
            else
            {
                timer1.Enabled = false;
            }
        }
    }
}
