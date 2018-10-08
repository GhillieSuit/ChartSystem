namespace sensorchart
{
    partial class Signup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbx_id = new System.Windows.Forms.TextBox();
            this.lbl_passwd = new System.Windows.Forms.Label();
            this.tbx_passwd = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_passok = new System.Windows.Forms.Label();
            this.tbx_passok = new System.Windows.Forms.TextBox();
            this.btn_signup = new System.Windows.Forms.Button();
            this.btn_chk = new System.Windows.Forms.Button();
            this.btn_esc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbx_id
            // 
            this.tbx_id.Location = new System.Drawing.Point(95, 70);
            this.tbx_id.Name = "tbx_id";
            this.tbx_id.Size = new System.Drawing.Size(210, 21);
            this.tbx_id.TabIndex = 1;
            // 
            // lbl_passwd
            // 
            this.lbl_passwd.Location = new System.Drawing.Point(93, 94);
            this.lbl_passwd.Name = "lbl_passwd";
            this.lbl_passwd.Size = new System.Drawing.Size(81, 21);
            this.lbl_passwd.TabIndex = 3;
            this.lbl_passwd.Text = "비밀번호";
            this.lbl_passwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbx_passwd
            // 
            this.tbx_passwd.Location = new System.Drawing.Point(95, 118);
            this.tbx_passwd.Name = "tbx_passwd";
            this.tbx_passwd.PasswordChar = '●';
            this.tbx_passwd.Size = new System.Drawing.Size(210, 21);
            this.tbx_passwd.TabIndex = 3;
            // 
            // lbl_id
            // 
            this.lbl_id.Location = new System.Drawing.Point(93, 46);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(81, 21);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID";
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_passok
            // 
            this.lbl_passok.Location = new System.Drawing.Point(93, 142);
            this.lbl_passok.Name = "lbl_passok";
            this.lbl_passok.Size = new System.Drawing.Size(81, 21);
            this.lbl_passok.TabIndex = 4;
            this.lbl_passok.Text = "비밀번호 확인";
            this.lbl_passok.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbx_passok
            // 
            this.tbx_passok.Location = new System.Drawing.Point(95, 166);
            this.tbx_passok.Name = "tbx_passok";
            this.tbx_passok.PasswordChar = '●';
            this.tbx_passok.Size = new System.Drawing.Size(210, 21);
            this.tbx_passok.TabIndex = 4;
            // 
            // btn_signup
            // 
            this.btn_signup.Location = new System.Drawing.Point(95, 194);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(210, 34);
            this.btn_signup.TabIndex = 5;
            this.btn_signup.Text = "가입하기";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // btn_chk
            // 
            this.btn_chk.Location = new System.Drawing.Point(230, 41);
            this.btn_chk.Name = "btn_chk";
            this.btn_chk.Size = new System.Drawing.Size(75, 23);
            this.btn_chk.TabIndex = 2;
            this.btn_chk.Text = "중복 확인";
            this.btn_chk.UseVisualStyleBackColor = true;
            this.btn_chk.Click += new System.EventHandler(this.btn_chk_Click);
            // 
            // btn_esc
            // 
            this.btn_esc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_esc.Location = new System.Drawing.Point(326, 13);
            this.btn_esc.Name = "btn_esc";
            this.btn_esc.Size = new System.Drawing.Size(46, 23);
            this.btn_esc.TabIndex = 6;
            this.btn_esc.Text = "Close";
            this.btn_esc.UseVisualStyleBackColor = true;
            this.btn_esc.Visible = false;
            this.btn_esc.Click += new System.EventHandler(this.btn_esc_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_esc;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btn_esc);
            this.Controls.Add(this.btn_chk);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.tbx_id);
            this.Controls.Add(this.tbx_passwd);
            this.Controls.Add(this.tbx_passok);
            this.Controls.Add(this.lbl_passok);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.lbl_passwd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbx_id;
        private System.Windows.Forms.Label lbl_passwd;
        private System.Windows.Forms.TextBox tbx_passwd;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_passok;
        private System.Windows.Forms.TextBox tbx_passok;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Button btn_chk;
        public System.Windows.Forms.Button btn_esc;
    }
}