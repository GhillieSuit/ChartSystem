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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string strSql = "Data Source=localhost;Database=test;User Id=root;Password=tinyos";

        private void login()
        {
            var MConn = new MySqlConnection(strSql);
            MConn.Open();
            if (tbx_id.Text != "" && tbx_passwd.Text != "")
            {
                string sql = "select id, pw from members where id= '" + tbx_id.Text + "'";
                var Comm = new MySqlCommand(sql, MConn);
                var myRead = Comm.ExecuteReader();
                if (myRead.HasRows)
                {
                    if (myRead.Read())
                    {
                        if (myRead["pw"].ToString() == tbx_passwd.Text)
                        {
                            Main mainform = new Main();
                            mainform.Show();
                            this.Hide();
                        }
                        else
                            MessageBox.Show("암호가 일치하지 않습니다", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("일치하는 계정이 없습니다", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                myRead.Close();
                MConn.Close();
            }
            else
            {
                MessageBox.Show("아이디와 암호를 입력하세요", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            Signup signupform = new Signup();
            signupform.Owner = this;
            signupform.Show();
        }
    }
}
