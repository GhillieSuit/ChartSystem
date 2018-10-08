namespace sensorchart
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dtp_from_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_from = new System.Windows.Forms.Label();
            this.dtp_to_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_to = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtp_from_time = new System.Windows.Forms.DateTimePicker();
            this.dtp_to_time = new System.Windows.Forms.DateTimePicker();
            this.lbx_list = new System.Windows.Forms.ListBox();
            this.btn_list = new System.Windows.Forms.Button();
            this.btn_now = new System.Windows.Forms.Button();
            this.btn_to_m1d = new System.Windows.Forms.Button();
            this.btn_to_m1h = new System.Windows.Forms.Button();
            this.btn_to_m10m = new System.Windows.Forms.Button();
            this.btn_to_p10m = new System.Windows.Forms.Button();
            this.btn_to_p1h = new System.Windows.Forms.Button();
            this.btn_to_p1d = new System.Windows.Forms.Button();
            this.btn_from_m1d = new System.Windows.Forms.Button();
            this.btn_from_p1d = new System.Windows.Forms.Button();
            this.btn_from_m1h = new System.Windows.Forms.Button();
            this.btn_from_p1h = new System.Windows.Forms.Button();
            this.btn_from_m10m = new System.Windows.Forms.Button();
            this.btn_from_p10m = new System.Windows.Forms.Button();
            this.ckb_auto = new System.Windows.Forms.CheckBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_from_date
            // 
            this.dtp_from_date.CustomFormat = "yyyy년 MM월 dd일 dddd";
            this.dtp_from_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_from_date.Location = new System.Drawing.Point(150, 31);
            this.dtp_from_date.Name = "dtp_from_date";
            this.dtp_from_date.Size = new System.Drawing.Size(170, 21);
            this.dtp_from_date.TabIndex = 2;
            this.dtp_from_date.Value = new System.DateTime(2018, 10, 1, 0, 0, 0, 0);
            // 
            // lbl_from
            // 
            this.lbl_from.AutoSize = true;
            this.lbl_from.Font = new System.Drawing.Font("굴림", 12F);
            this.lbl_from.Location = new System.Drawing.Point(147, 12);
            this.lbl_from.Name = "lbl_from";
            this.lbl_from.Size = new System.Drawing.Size(45, 16);
            this.lbl_from.TabIndex = 1;
            this.lbl_from.Text = "From";
            // 
            // dtp_to_date
            // 
            this.dtp_to_date.CustomFormat = "yyyy년 MM월 dd일 dddd";
            this.dtp_to_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_to_date.Location = new System.Drawing.Point(150, 92);
            this.dtp_to_date.Name = "dtp_to_date";
            this.dtp_to_date.Size = new System.Drawing.Size(170, 21);
            this.dtp_to_date.TabIndex = 4;
            // 
            // lbl_to
            // 
            this.lbl_to.AutoSize = true;
            this.lbl_to.Font = new System.Drawing.Font("굴림", 12F);
            this.lbl_to.Location = new System.Drawing.Point(147, 73);
            this.lbl_to.Name = "lbl_to";
            this.lbl_to.Size = new System.Drawing.Size(27, 16);
            this.lbl_to.TabIndex = 3;
            this.lbl_to.Text = "To";
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart.Legends.Add(legend6);
            this.chart.Location = new System.Drawing.Point(15, 122);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(1237, 547);
            this.chart.TabIndex = 10;
            this.chart.TabStop = false;
            this.chart.Text = "Chart";
            title6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title6.Name = "Title1";
            title6.Text = "Chart";
            this.chart.Titles.Add(title6);
            // 
            // dtp_from_time
            // 
            this.dtp_from_time.CustomFormat = "tt hh:mm";
            this.dtp_from_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_from_time.Location = new System.Drawing.Point(326, 31);
            this.dtp_from_time.Name = "dtp_from_time";
            this.dtp_from_time.ShowUpDown = true;
            this.dtp_from_time.Size = new System.Drawing.Size(90, 21);
            this.dtp_from_time.TabIndex = 3;
            this.dtp_from_time.Value = new System.DateTime(2018, 10, 1, 0, 0, 0, 0);
            // 
            // dtp_to_time
            // 
            this.dtp_to_time.CustomFormat = "tt hh:mm";
            this.dtp_to_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_to_time.Location = new System.Drawing.Point(326, 92);
            this.dtp_to_time.Name = "dtp_to_time";
            this.dtp_to_time.ShowUpDown = true;
            this.dtp_to_time.Size = new System.Drawing.Size(90, 21);
            this.dtp_to_time.TabIndex = 5;
            // 
            // lbx_list
            // 
            this.lbx_list.Font = new System.Drawing.Font("굴림", 11F);
            this.lbx_list.FormattingEnabled = true;
            this.lbx_list.HorizontalScrollbar = true;
            this.lbx_list.ItemHeight = 15;
            this.lbx_list.Location = new System.Drawing.Point(15, 12);
            this.lbx_list.Name = "lbx_list";
            this.lbx_list.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbx_list.Size = new System.Drawing.Size(126, 79);
            this.lbx_list.Sorted = true;
            this.lbx_list.TabIndex = 0;
            // 
            // btn_list
            // 
            this.btn_list.Location = new System.Drawing.Point(15, 93);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(126, 23);
            this.btn_list.TabIndex = 1;
            this.btn_list.Text = "선택";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // btn_now
            // 
            this.btn_now.Location = new System.Drawing.Point(372, 68);
            this.btn_now.Name = "btn_now";
            this.btn_now.Size = new System.Drawing.Size(45, 21);
            this.btn_now.TabIndex = 11;
            this.btn_now.Text = "now";
            this.btn_now.UseVisualStyleBackColor = true;
            this.btn_now.Click += new System.EventHandler(this.btn_now_Click);
            // 
            // btn_to_m1d
            // 
            this.btn_to_m1d.Location = new System.Drawing.Point(525, 68);
            this.btn_to_m1d.Name = "btn_to_m1d";
            this.btn_to_m1d.Size = new System.Drawing.Size(45, 21);
            this.btn_to_m1d.TabIndex = 11;
            this.btn_to_m1d.Text = "-1d";
            this.btn_to_m1d.UseVisualStyleBackColor = true;
            this.btn_to_m1d.Click += new System.EventHandler(this.btn_to_m1d_Click);
            // 
            // btn_to_m1h
            // 
            this.btn_to_m1h.Location = new System.Drawing.Point(474, 68);
            this.btn_to_m1h.Name = "btn_to_m1h";
            this.btn_to_m1h.Size = new System.Drawing.Size(45, 21);
            this.btn_to_m1h.TabIndex = 11;
            this.btn_to_m1h.Text = "-1h";
            this.btn_to_m1h.UseVisualStyleBackColor = true;
            this.btn_to_m1h.Click += new System.EventHandler(this.btn_to_m1h_Click);
            // 
            // btn_to_m10m
            // 
            this.btn_to_m10m.Location = new System.Drawing.Point(423, 68);
            this.btn_to_m10m.Name = "btn_to_m10m";
            this.btn_to_m10m.Size = new System.Drawing.Size(45, 21);
            this.btn_to_m10m.TabIndex = 11;
            this.btn_to_m10m.Text = "-10m";
            this.btn_to_m10m.UseVisualStyleBackColor = true;
            this.btn_to_m10m.Click += new System.EventHandler(this.btn_to_m10m_Click);
            // 
            // btn_to_p10m
            // 
            this.btn_to_p10m.Location = new System.Drawing.Point(423, 93);
            this.btn_to_p10m.Name = "btn_to_p10m";
            this.btn_to_p10m.Size = new System.Drawing.Size(45, 21);
            this.btn_to_p10m.TabIndex = 11;
            this.btn_to_p10m.Text = "+10m";
            this.btn_to_p10m.UseVisualStyleBackColor = true;
            this.btn_to_p10m.Click += new System.EventHandler(this.btn_to_p10m_Click);
            // 
            // btn_to_p1h
            // 
            this.btn_to_p1h.Location = new System.Drawing.Point(474, 92);
            this.btn_to_p1h.Name = "btn_to_p1h";
            this.btn_to_p1h.Size = new System.Drawing.Size(45, 21);
            this.btn_to_p1h.TabIndex = 11;
            this.btn_to_p1h.Text = "+1h";
            this.btn_to_p1h.UseVisualStyleBackColor = true;
            this.btn_to_p1h.Click += new System.EventHandler(this.btn_to_p1h_Click);
            // 
            // btn_to_p1d
            // 
            this.btn_to_p1d.Location = new System.Drawing.Point(525, 92);
            this.btn_to_p1d.Name = "btn_to_p1d";
            this.btn_to_p1d.Size = new System.Drawing.Size(45, 21);
            this.btn_to_p1d.TabIndex = 11;
            this.btn_to_p1d.Text = "+1d";
            this.btn_to_p1d.UseVisualStyleBackColor = true;
            this.btn_to_p1d.Click += new System.EventHandler(this.btn_to_p1d_Click);
            // 
            // btn_from_m1d
            // 
            this.btn_from_m1d.Location = new System.Drawing.Point(525, 7);
            this.btn_from_m1d.Name = "btn_from_m1d";
            this.btn_from_m1d.Size = new System.Drawing.Size(45, 21);
            this.btn_from_m1d.TabIndex = 11;
            this.btn_from_m1d.Text = "-1d";
            this.btn_from_m1d.UseVisualStyleBackColor = true;
            this.btn_from_m1d.Click += new System.EventHandler(this.btn_from_m1d_Click);
            // 
            // btn_from_p1d
            // 
            this.btn_from_p1d.Location = new System.Drawing.Point(525, 31);
            this.btn_from_p1d.Name = "btn_from_p1d";
            this.btn_from_p1d.Size = new System.Drawing.Size(45, 21);
            this.btn_from_p1d.TabIndex = 11;
            this.btn_from_p1d.Text = "+1d";
            this.btn_from_p1d.UseVisualStyleBackColor = true;
            this.btn_from_p1d.Click += new System.EventHandler(this.btn_from_p1d_Click);
            // 
            // btn_from_m1h
            // 
            this.btn_from_m1h.Location = new System.Drawing.Point(474, 7);
            this.btn_from_m1h.Name = "btn_from_m1h";
            this.btn_from_m1h.Size = new System.Drawing.Size(45, 21);
            this.btn_from_m1h.TabIndex = 11;
            this.btn_from_m1h.Text = "-1h";
            this.btn_from_m1h.UseVisualStyleBackColor = true;
            this.btn_from_m1h.Click += new System.EventHandler(this.btn_from_m1h_Click);
            // 
            // btn_from_p1h
            // 
            this.btn_from_p1h.Location = new System.Drawing.Point(474, 31);
            this.btn_from_p1h.Name = "btn_from_p1h";
            this.btn_from_p1h.Size = new System.Drawing.Size(45, 21);
            this.btn_from_p1h.TabIndex = 11;
            this.btn_from_p1h.Text = "+1h";
            this.btn_from_p1h.UseVisualStyleBackColor = true;
            this.btn_from_p1h.Click += new System.EventHandler(this.btn_from_p1h_Click);
            // 
            // btn_from_m10m
            // 
            this.btn_from_m10m.Location = new System.Drawing.Point(423, 7);
            this.btn_from_m10m.Name = "btn_from_m10m";
            this.btn_from_m10m.Size = new System.Drawing.Size(45, 21);
            this.btn_from_m10m.TabIndex = 11;
            this.btn_from_m10m.Text = "-10m";
            this.btn_from_m10m.UseVisualStyleBackColor = true;
            this.btn_from_m10m.Click += new System.EventHandler(this.btn_from_m10m_Click);
            // 
            // btn_from_p10m
            // 
            this.btn_from_p10m.Location = new System.Drawing.Point(423, 32);
            this.btn_from_p10m.Name = "btn_from_p10m";
            this.btn_from_p10m.Size = new System.Drawing.Size(45, 21);
            this.btn_from_p10m.TabIndex = 11;
            this.btn_from_p10m.Text = "+10m";
            this.btn_from_p10m.UseVisualStyleBackColor = true;
            this.btn_from_p10m.Click += new System.EventHandler(this.btn_from_p10m_Click);
            // 
            // ckb_auto
            // 
            this.ckb_auto.AutoSize = true;
            this.ckb_auto.Location = new System.Drawing.Point(576, 39);
            this.ckb_auto.Name = "ckb_auto";
            this.ckb_auto.Size = new System.Drawing.Size(96, 16);
            this.ckb_auto.TabIndex = 12;
            this.ckb_auto.Text = "Auto Refresh";
            this.ckb_auto.UseVisualStyleBackColor = true;
            this.ckb_auto.CheckedChanged += new System.EventHandler(this.ckb_auto_CheckedChanged);
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(576, 61);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(96, 23);
            this.btn_apply.TabIndex = 13;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(576, 90);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(96, 23);
            this.btn_export.TabIndex = 13;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.ckb_auto);
            this.Controls.Add(this.btn_from_p10m);
            this.Controls.Add(this.btn_to_p10m);
            this.Controls.Add(this.btn_from_m10m);
            this.Controls.Add(this.btn_from_p1h);
            this.Controls.Add(this.btn_to_m10m);
            this.Controls.Add(this.btn_from_m1h);
            this.Controls.Add(this.btn_to_p1h);
            this.Controls.Add(this.btn_from_p1d);
            this.Controls.Add(this.btn_to_m1h);
            this.Controls.Add(this.btn_from_m1d);
            this.Controls.Add(this.btn_to_p1d);
            this.Controls.Add(this.btn_to_m1d);
            this.Controls.Add(this.btn_now);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.lbx_list);
            this.Controls.Add(this.dtp_to_time);
            this.Controls.Add(this.dtp_from_time);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.lbl_to);
            this.Controls.Add(this.dtp_to_date);
            this.Controls.Add(this.lbl_from);
            this.Controls.Add(this.dtp_from_date);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chart";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_from_date;
        private System.Windows.Forms.Label lbl_from;
        private System.Windows.Forms.DateTimePicker dtp_to_date;
        private System.Windows.Forms.Label lbl_to;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DateTimePicker dtp_from_time;
        private System.Windows.Forms.DateTimePicker dtp_to_time;
        private System.Windows.Forms.Button btn_list;
        public System.Windows.Forms.ListBox lbx_list;
        private System.Windows.Forms.Button btn_now;
        private System.Windows.Forms.Button btn_to_m1d;
        private System.Windows.Forms.Button btn_to_m1h;
        private System.Windows.Forms.Button btn_to_m10m;
        private System.Windows.Forms.Button btn_to_p10m;
        private System.Windows.Forms.Button btn_to_p1h;
        private System.Windows.Forms.Button btn_to_p1d;
        private System.Windows.Forms.Button btn_from_m1d;
        private System.Windows.Forms.Button btn_from_p1d;
        private System.Windows.Forms.Button btn_from_m1h;
        private System.Windows.Forms.Button btn_from_p1h;
        private System.Windows.Forms.Button btn_from_m10m;
        private System.Windows.Forms.Button btn_from_p10m;
        private System.Windows.Forms.CheckBox ckb_auto;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Timer timer1;
    }
}

