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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dtp_from_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_from = new System.Windows.Forms.Label();
            this.dtp_to_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_to = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dtp_from_time = new System.Windows.Forms.DateTimePicker();
            this.dtp_to_time = new System.Windows.Forms.DateTimePicker();
            this.lbx_list = new System.Windows.Forms.ListBox();
            this.btn_list = new System.Windows.Forms.Button();
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
            chartArea2.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart.Legends.Add(legend2);
            this.chart.Location = new System.Drawing.Point(15, 122);
            this.chart.Name = "chart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(1237, 547);
            this.chart.TabIndex = 10;
            this.chart.TabStop = false;
            this.chart.Text = "Chart";
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
            this.dtp_from_time.Value = new System.DateTime(2018, 10, 3, 8, 9, 0, 0);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
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
    }
}

