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
    public partial class Sheet : Form
    {
        Main mainform;

        public Sheet()
        {
            InitializeComponent();
        }

        public Sheet(Main frm_main)
        {
            InitializeComponent();
            mainform = frm_main;
        }

        public string strSql = "Data Source=localhost;Database=test;User Id=root;Password=tinyos";

        private void Sheet_Load(object sender, EventArgs e)
        {
            var MConn = new MySqlConnection(strSql);
            MConn.Open();
            DataSet ds = new DataSet();

            string sql = "select distinct id from datasheet";
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = new MySqlCommand(sql, MConn);
            adapter.Fill(ds);

            foreach (DataRow r in ds.Tables[0].Rows)
            {
                clb_list.Items.Add(r["id"] + "\n");
            }
            MConn.Close();
            this.KeyPreview = true;
        }

        private void btn_apply_Click(object sender, EventArgs e)
        {
            mainform.lbx_list.Items.Clear();

            int size = clb_list.Items.Count;
            //String list = "";
            List<string> list = new List<string>();
            for (int i = 0; i < size; i++)
            {
                if (clb_list.GetItemChecked(i))
                {
                    list.Add(clb_list.Items[i].ToString());
                }
            }

            foreach (string r in list)
            {
                mainform.lbx_list.Items.Add(r);
            }     
        }

        private void Sheet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}