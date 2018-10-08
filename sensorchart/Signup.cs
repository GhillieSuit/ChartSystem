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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        public string strSql = "Data Source=localhost;Database=test;User Id=root;Password=tinyos";
        bool idchk = false;
        string id = "";

        private void btn_chk_Click(object sender, EventArgs e)
        {
            var MConn = new MySqlConnection(strSql);
            MConn.Open();

            if (tbx_id.Text != "")
            {
                string sql = "select id, pw from members where id= '" + tbx_id.Text + "'";
                var Comm = new MySqlCommand(sql, MConn);
                var myRead = Comm.ExecuteReader();

                if (!myRead.HasRows)
                {
                    MessageBox.Show("사용할수 있는 아이디 입니다.", "사용하기", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    id = tbx_id.Text;
                    idchk = true;
                }
                else
                {
                    MessageBox.Show("중복된 아이디입니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    id = "";
                    idchk = false;
                }
                MConn.Close();
            }
            else
            {
                MessageBox.Show("사용하실 아이디를 입력하세요.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            var MConn = new MySqlConnection(strSql);
            MConn.Open();

            if (idchk == false)
            {
                MessageBox.Show("아이디 중복확인을 하세요.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(tbx_passwd.Text == "")
                {
                    MessageBox.Show("사용하실 비밀번호를 입력하세요.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (tbx_passwd.Text == tbx_passok.Text)
                    {
                        string sql = "insert into members values('"+ id +"', '"+ tbx_passwd.Text + "', false)";
                        var Comm = new MySqlCommand(sql, MConn);
                        var myRead = Comm.ExecuteReader();
                        idchk = false;
                        MessageBox.Show("가입이 완료되었습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("비밀번호확인이 일치하지 않습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }  
            }
            MConn.Close();
        }

        private void tbx_id_TextChanged(object sender, EventArgs e)
        {
            idchk = false;
        }

        private void Signup_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }
    }
}
