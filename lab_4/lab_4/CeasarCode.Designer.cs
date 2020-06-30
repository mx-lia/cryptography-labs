namespace lab_4
{
    partial class CeasarCode
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.decoded_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.encoded_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TextInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.decoded_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encoded_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // decoded_chart
            // 
            chartArea7.AxisX.Interval = 1D;
            chartArea7.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea7.Name = "ChartArea1";
            this.decoded_chart.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.decoded_chart.Legends.Add(legend7);
            this.decoded_chart.Location = new System.Drawing.Point(1, 397);
            this.decoded_chart.Name = "decoded_chart";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.MarkerSize = 1;
            series7.Name = "Alphabet";
            series7.SmartLabelStyle.Enabled = false;
            this.decoded_chart.Series.Add(series7);
            this.decoded_chart.Size = new System.Drawing.Size(1300, 390);
            this.decoded_chart.TabIndex = 0;
            this.decoded_chart.Text = "Encoded Text";
            title7.Alignment = System.Drawing.ContentAlignment.TopCenter;
            title7.Name = "Title1";
            title7.Text = "Chart of decoded text";
            this.decoded_chart.Titles.Add(title7);
            // 
            // encoded_chart
            // 
            chartArea8.AxisX.Interval = 1D;
            chartArea8.Name = "ChartArea1";
            this.encoded_chart.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.encoded_chart.Legends.Add(legend8);
            this.encoded_chart.Location = new System.Drawing.Point(1, 1);
            this.encoded_chart.Name = "encoded_chart";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Alphabet";
            this.encoded_chart.Series.Add(series8);
            this.encoded_chart.Size = new System.Drawing.Size(1300, 390);
            this.encoded_chart.TabIndex = 1;
            this.encoded_chart.Text = "chart2";
            title8.Name = "Title1";
            title8.Text = "Chart of encoded text";
            this.encoded_chart.Titles.Add(title8);
            // 
            // TextInfo
            // 
            this.TextInfo.AutoSize = true;
            this.TextInfo.Location = new System.Drawing.Point(1307, 9);
            this.TextInfo.Name = "TextInfo";
            this.TextInfo.Size = new System.Drawing.Size(0, 17);
            this.TextInfo.TabIndex = 2;
            // 
            // CeasarCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1632, 803);
            this.Controls.Add(this.TextInfo);
            this.Controls.Add(this.encoded_chart);
            this.Controls.Add(this.decoded_chart);
            this.Name = "CeasarCode";
            this.Text = "CeasarCode";
            ((System.ComponentModel.ISupportInitialize)(this.decoded_chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encoded_chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart decoded_chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart encoded_chart;
        private System.Windows.Forms.Label TextInfo;
    }
}

