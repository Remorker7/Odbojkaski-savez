namespace Zadaca_2___Selmir_Hasanovic__16926_
{
    partial class Izvještaj
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Prefiksi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Prefiksi2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Prefiksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prefiksi2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(686, 377);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrovani timovi";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Prefiksi);
            this.groupBox2.Location = new System.Drawing.Point(3, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(334, 355);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bar chart";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Prefiksi2);
            this.groupBox3.Location = new System.Drawing.Point(343, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(334, 355);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pie chart";
            // 
            // Prefiksi
            // 
            chartArea2.Name = "ChartArea1";
            this.Prefiksi.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Prefiksi.Legends.Add(legend2);
            this.Prefiksi.Location = new System.Drawing.Point(28, 34);
            this.Prefiksi.Name = "Prefiksi";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Legend1";
            series2.Name = "Prefiksi";
            this.Prefiksi.Series.Add(series2);
            this.Prefiksi.Size = new System.Drawing.Size(300, 300);
            this.Prefiksi.TabIndex = 0;
            this.Prefiksi.Text = "Prefiksi";
            // 
            // Prefiksi2
            // 
            chartArea1.Name = "ChartArea1";
            this.Prefiksi2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.Prefiksi2.Legends.Add(legend1);
            this.Prefiksi2.Location = new System.Drawing.Point(17, 28);
            this.Prefiksi2.Name = "Prefiksi2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "PPrefiksi";
            this.Prefiksi2.Series.Add(series1);
            this.Prefiksi2.Size = new System.Drawing.Size(300, 300);
            this.Prefiksi2.TabIndex = 0;
            this.Prefiksi2.Text = "chart1";
            // 
            // Izvještaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 380);
            this.Controls.Add(this.groupBox1);
            this.Name = "Izvještaj";
            this.Text = "Izvještaj";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Prefiksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Prefiksi2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Prefiksi;
        private System.Windows.Forms.DataVisualization.Charting.Chart Prefiksi2;
    }
}