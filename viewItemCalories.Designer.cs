
namespace OrderingSystem
{
    partial class viewItemCalories
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.itemChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.itemChart)).BeginInit();
            this.SuspendLayout();
            // 
            // itemChart
            // 
            chartArea1.Name = "ChartArea1";
            this.itemChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.itemChart.Legends.Add(legend1);
            this.itemChart.Location = new System.Drawing.Point(50, 50);
            this.itemChart.Name = "itemChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Calories";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Carbohydrates";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Fats";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Proteins";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "SodiumContent";
            this.itemChart.Series.Add(series1);
            this.itemChart.Series.Add(series2);
            this.itemChart.Series.Add(series3);
            this.itemChart.Series.Add(series4);
            this.itemChart.Series.Add(series5);
            this.itemChart.Size = new System.Drawing.Size(921, 382);
            this.itemChart.TabIndex = 0;
            this.itemChart.Text = "chart1";
            this.itemChart.Click += new System.EventHandler(this.itemChart_Click);
            // 
            // viewItemCalories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 494);
            this.Controls.Add(this.itemChart);
            this.Name = "viewItemCalories";
            this.Text = "viewItemCalories";
            this.Load += new System.EventHandler(this.viewItemCalories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.itemChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart itemChart;
    }
}