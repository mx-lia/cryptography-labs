namespace lab_4
{
    partial class TrisemusTable
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.decoded_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.encoded_chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TextInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.decoded_chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encoded_chart)).BeginInit();
            this.SuspendLayout();
            // 
            // decoded_chart
            // 
            chartArea5.AxisX.Interval = 1D;
            chartArea5.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea5.Name = "ChartArea1";
            this.decoded_chart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.decoded_chart.Legends.Add(legend5);
            this.decoded_chart.Location = new System.Drawing.Point(1, 397);
            this.decoded_chart.Name = "decoded_chart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.MarkerSize = 1;
            series5.Name = "Alphabet";
            series5.SmartLabelStyle.Enabled = false;
            this.decoded_chart.Series.Add(series5);
            this.decoded_chart.Size = new System.Drawing.Size(1300, 390);
            this.decoded_chart.TabIndex = 1;
            this.decoded_chart.Text = "chart1";
            title5.Name = "Title1";
            title5.Text = "Chart of decoded text";
            this.decoded_chart.Titles.Add(title5);
            // 
            // encoded_chart
            // 
            chartArea6.AxisX.Interval = 1D;
            chartArea6.Name = "ChartArea1";
            this.encoded_chart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.encoded_chart.Legends.Add(legend6);
            this.encoded_chart.Location = new System.Drawing.Point(1, 1);
            this.encoded_chart.Name = "encoded_chart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Alphabet";
            this.encoded_chart.Series.Add(series6);
            this.encoded_chart.Size = new System.Drawing.Size(1300, 390);
            this.encoded_chart.TabIndex = 2;
            this.encoded_chart.Text = "chart2";
            title6.Name = "Title1";
            title6.Text = "Chart of encoded text";
            this.encoded_chart.Titles.Add(title6);
            // 
            // TextInfo
            // 
            this.TextInfo.AutoSize = true;
            this.TextInfo.Location = new System.Drawing.Point(1307, 9);
            this.TextInfo.Name = "TextInfo";
            this.TextInfo.Size = new System.Drawing.Size(0, 17);
            this.TextInfo.TabIndex = 3;
            // 
            // TrisemusTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1632, 803);
            this.Controls.Add(this.TextInfo);
            this.Controls.Add(this.encoded_chart);
            this.Controls.Add(this.decoded_chart);
            this.Name = "TrisemusTable";
            this.Text = "TrisemusTable";
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