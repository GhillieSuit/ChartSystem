namespace sensorchart
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.gbx_login = new System.Windows.Forms.GroupBox();
            this.btn_signup = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.tbx_passwd = new System.Windows.Forms.TextBox();
            this.tbx_id = new System.Windows.Forms.TextBox();
            this.lbl_passwd = new System.Windows.Forms.Label();
            this.gbx_login.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_login
            // 
            this.gbx_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbx_login.BackColor = System.Drawing.Color.White;
            this.gbx_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbx_login.Controls.Add(this.btn_signup);
            this.gbx_login.Controls.Add(this.btn_login);
            this.gbx_login.Controls.Add(this.lbl_id);
            this.gbx_login.Controls.Add(this.tbx_passwd);
            this.gbx_login.Controls.Add(this.tbx_id);
            this.gbx_login.Controls.Add(this.lbl_passwd);
            this.gbx_login.Cursor = System.Windows.Forms.Cursors.Default;
            this.gbx_login.Location = new System.Drawing.Point(200, 100);
            this.gbx_login.Name = "gbx_login";
            this.gbx_login.Size = new System.Drawing.Size(400, 200);
            this.gbx_login.TabIndex = 4;
            this.gbx_login.TabStop = false;
            this.gbx_login.Text = "Login";
            // 
            // btn_signup
            // 
            this.btn_signup.Location = new System.Drawing.Point(210, 148);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(160, 30);
            this.btn_signup.TabIndex = 4;
            this.btn_signup.Text = "Sign up";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(32, 148);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(160, 30);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.Location = new System.Drawing.Point(30, 50);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(62, 12);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "ID";
            this.lbl_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbx_passwd
            // 
            this.tbx_passwd.Location = new System.Drawing.Point(120, 97);
            this.tbx_passwd.Name = "tbx_passwd";
            this.tbx_passwd.PasswordChar = '●';
            this.tbx_passwd.Size = new System.Drawing.Size(250, 21);
            this.tbx_passwd.TabIndex = 2;
            // 
            // tbx_id
            // 
            this.tbx_id.Location = new System.Drawing.Point(120, 47);
            this.tbx_id.Name = "tbx_id";
            this.tbx_id.Size = new System.Drawing.Size(250, 21);
            this.tbx_id.TabIndex = 1;
            // 
            // lbl_passwd
            // 
            this.lbl_passwd.AutoSize = true;
            this.lbl_passwd.Location = new System.Drawing.Point(30, 100);
            this.lbl_passwd.Name = "lbl_passwd";
            this.lbl_passwd.Size = new System.Drawing.Size(62, 12);
            this.lbl_passwd.TabIndex = 1;
            this.lbl_passwd.Text = "Password";
            this.lbl_passwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AcceptButton = this.btn_login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.gbx_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.gbx_login.ResumeLayout(false);
            this.gbx_login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_login;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox tbx_passwd;
        private System.Windows.Forms.TextBox tbx_id;
        private System.Windows.Forms.Label lbl_passwd;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Button btn_login;
    }
}