namespace PsychHRV
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.amChartLF = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.amChartHF = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.amChartVLF = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.amChartL2H = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amChartLF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amChartHF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amChartVLF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amChartL2H)).BeginInit();
            this.SuspendLayout();
            // 
            // amChartLF
            // 
            chartArea1.Name = "ChartArea1";
            this.amChartLF.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.amChartLF.Legends.Add(legend1);
            this.amChartLF.Location = new System.Drawing.Point(30, 57);
            this.amChartLF.Name = "amChartLF";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.amChartLF.Series.Add(series1);
            this.amChartLF.Size = new System.Drawing.Size(388, 165);
            this.amChartLF.TabIndex = 0;
            this.amChartLF.Text = "chart1";
            // 
            // amChartHF
            // 
            chartArea2.Name = "ChartArea1";
            this.amChartHF.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.amChartHF.Legends.Add(legend2);
            this.amChartHF.Location = new System.Drawing.Point(447, 57);
            this.amChartHF.Name = "amChartHF";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.amChartHF.Series.Add(series2);
            this.amChartHF.Size = new System.Drawing.Size(388, 165);
            this.amChartHF.TabIndex = 1;
            this.amChartHF.Text = "chart1";
            // 
            // amChartVLF
            // 
            chartArea3.Name = "ChartArea1";
            this.amChartVLF.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.amChartVLF.Legends.Add(legend3);
            this.amChartVLF.Location = new System.Drawing.Point(30, 263);
            this.amChartVLF.Name = "amChartVLF";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.amChartVLF.Series.Add(series3);
            this.amChartVLF.Size = new System.Drawing.Size(388, 165);
            this.amChartVLF.TabIndex = 2;
            this.amChartVLF.Text = "chart2";
            // 
            // amChartL2H
            // 
            chartArea4.Name = "ChartArea1";
            this.amChartL2H.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.amChartL2H.Legends.Add(legend4);
            this.amChartL2H.Location = new System.Drawing.Point(447, 263);
            this.amChartL2H.Name = "amChartL2H";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.amChartL2H.Series.Add(series4);
            this.amChartL2H.Size = new System.Drawing.Size(388, 165);
            this.amChartL2H.TabIndex = 3;
            this.amChartL2H.Text = "chart3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chart LF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chart VLF";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Chart HF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chart LF/HF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 452);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.amChartL2H);
            this.Controls.Add(this.amChartVLF);
            this.Controls.Add(this.amChartHF);
            this.Controls.Add(this.amChartLF);
            this.Name = "Form1";
            this.Text = "HRV Data Visualization";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amChartLF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amChartHF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amChartVLF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amChartL2H)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart amChartLF;
        public System.Windows.Forms.DataVisualization.Charting.Chart amChartHF;
        public System.Windows.Forms.DataVisualization.Charting.Chart amChartVLF;
        public System.Windows.Forms.DataVisualization.Charting.Chart amChartL2H;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

