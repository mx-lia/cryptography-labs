namespace lab_5
{
    partial class BarChartForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.originalTextChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.newTextChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.originalTextChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTextChart)).BeginInit();
            this.SuspendLayout();
            // 
            // originalTextChart
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            this.originalTextChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.originalTextChart.Legends.Add(legend1);
            this.originalTextChart.Location = new System.Drawing.Point(12, 12);
            this.originalTextChart.Name = "originalTextChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Alphabet";
            this.originalTextChart.Series.Add(series1);
            this.originalTextChart.Size = new System.Drawing.Size(1300, 300);
            this.originalTextChart.TabIndex = 0;
            this.originalTextChart.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Chart of original text";
            this.originalTextChart.Titles.Add(title1);
            // 
            // newTextChart
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.Name = "ChartArea1";
            this.newTextChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.newTextChart.Legends.Add(legend2);
            this.newTextChart.Location = new System.Drawing.Point(12, 318);
            this.newTextChart.Name = "newTextChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Alphabet";
            this.newTextChart.Series.Add(series2);
            this.newTextChart.Size = new System.Drawing.Size(1300, 300);
            this.newTextChart.TabIndex = 1;
            this.newTextChart.Text = "chart2";
            title2.Name = "Title1";
            title2.Text = "Chart of new text";
            this.newTextChart.Titles.Add(title2);
            // 
            // BarChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1324, 629);
            this.Controls.Add(this.newTextChart);
            this.Controls.Add(this.originalTextChart);
            this.Name = "BarChartForm";
            this.Text = "BarChartForm";
            ((System.ComponentModel.ISupportInitialize)(this.originalTextChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newTextChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart originalTextChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart newTextChart;
    }
}