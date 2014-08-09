namespace UI
{
    partial class FormFrequency
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
            this.chartFrequencyLetters = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartFrequencyLetters)).BeginInit();
            this.SuspendLayout();
            // 
            // chartFrequencyLetters
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFrequencyLetters.ChartAreas.Add(chartArea1);
            this.chartFrequencyLetters.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartFrequencyLetters.Legends.Add(legend1);
            this.chartFrequencyLetters.Location = new System.Drawing.Point(0, 0);
            this.chartFrequencyLetters.Name = "chartFrequencyLetters";
            this.chartFrequencyLetters.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.MarkerSize = 1;
            series1.Name = "Letter";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartFrequencyLetters.Series.Add(series1);
            this.chartFrequencyLetters.Size = new System.Drawing.Size(1265, 487);
            this.chartFrequencyLetters.TabIndex = 0;
            this.chartFrequencyLetters.Text = "Frequency of Letters";
            // 
            // FormFrequency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 487);
            this.Controls.Add(this.chartFrequencyLetters);
            this.Name = "FormFrequency";
            this.Text = "Frequency";
            this.Load += new System.EventHandler(this.FormFrequency_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartFrequencyLetters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFrequencyLetters;
    }
}

