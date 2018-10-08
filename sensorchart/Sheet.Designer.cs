namespace sensorchart
{
    partial class Sheet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sheet));
            this.tbc_control1 = new System.Windows.Forms.TabControl();
            this.tbp_1 = new System.Windows.Forms.TabPage();
            this.btn_apply = new System.Windows.Forms.Button();
            this.clb_list = new System.Windows.Forms.CheckedListBox();
            this.tbp_2 = new System.Windows.Forms.TabPage();
            this.tbc_control1.SuspendLayout();
            this.tbp_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbc_control1
            // 
            this.tbc_control1.Controls.Add(this.tbp_1);
            this.tbc_control1.Controls.Add(this.tbp_2);
            this.tbc_control1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbc_control1.Location = new System.Drawing.Point(0, 0);
            this.tbc_control1.Name = "tbc_control1";
            this.tbc_control1.SelectedIndex = 0;
            this.tbc_control1.Size = new System.Drawing.Size(484, 461);
            this.tbc_control1.TabIndex = 0;
            // 
            // tbp_1
            // 
            this.tbp_1.Controls.Add(this.btn_apply);
            this.tbp_1.Controls.Add(this.clb_list);
            this.tbp_1.Location = new System.Drawing.Point(4, 22);
            this.tbp_1.Name = "tbp_1";
            this.tbp_1.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_1.Size = new System.Drawing.Size(476, 435);
            this.tbp_1.TabIndex = 0;
            this.tbp_1.Text = "선택";
            this.tbp_1.UseVisualStyleBackColor = true;
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(6, 401);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(150, 28);
            this.btn_apply.TabIndex = 1;
            this.btn_apply.Text = "적용";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // clb_list
            // 
            this.clb_list.CheckOnClick = true;
            this.clb_list.FormattingEnabled = true;
            this.clb_list.Location = new System.Drawing.Point(6, 7);
            this.clb_list.Name = "clb_list";
            this.clb_list.Size = new System.Drawing.Size(150, 388);
            this.clb_list.Sorted = true;
            this.clb_list.TabIndex = 0;
            // 
            // tbp_2
            // 
            this.tbp_2.Location = new System.Drawing.Point(4, 22);
            this.tbp_2.Name = "tbp_2";
            this.tbp_2.Padding = new System.Windows.Forms.Padding(3);
            this.tbp_2.Size = new System.Drawing.Size(476, 435);
            this.tbp_2.TabIndex = 1;
            this.tbp_2.Text = "시트";
            this.tbp_2.UseVisualStyleBackColor = true;
            // 
            // Sheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.tbc_control1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sheet";
            this.Load += new System.EventHandler(this.Sheet_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sheet_KeyDown);
            this.tbc_control1.ResumeLayout(false);
            this.tbp_1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbc_control1;
        private System.Windows.Forms.TabPage tbp_1;
        private System.Windows.Forms.TabPage tbp_2;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.CheckedListBox clb_list;
    }
}