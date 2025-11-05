namespace BookOrderSYS
{
    partial class frmYearlyRevenueAnalysis
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mnuYearlyRevenueAnalysis = new System.Windows.Forms.MenuStrip();
            this.mnuYearlyRevenueAnalysisBack = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblYearlyRevenueAnalysis = new System.Windows.Forms.Label();
            this.chartYearlyRevenueAnalysis = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblRevenueSummary = new System.Windows.Forms.Label();
            this.listBoxYearlyRevenueAnalysis = new System.Windows.Forms.ListBox();
            this.mnuYearlyRevenueAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartYearlyRevenueAnalysis)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuYearlyRevenueAnalysis
            // 
            this.mnuYearlyRevenueAnalysis.BackColor = System.Drawing.Color.Teal;
            this.mnuYearlyRevenueAnalysis.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuYearlyRevenueAnalysisBack});
            this.mnuYearlyRevenueAnalysis.Location = new System.Drawing.Point(0, 0);
            this.mnuYearlyRevenueAnalysis.Name = "mnuYearlyRevenueAnalysis";
            this.mnuYearlyRevenueAnalysis.Size = new System.Drawing.Size(619, 24);
            this.mnuYearlyRevenueAnalysis.TabIndex = 0;
            this.mnuYearlyRevenueAnalysis.Text = "menuStrip1";
            // 
            // mnuYearlyRevenueAnalysisBack
            // 
            this.mnuYearlyRevenueAnalysisBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuYearlyRevenueAnalysisBack.Font = new System.Drawing.Font("MS Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuYearlyRevenueAnalysisBack.ForeColor = System.Drawing.Color.LightGray;
            this.mnuYearlyRevenueAnalysisBack.Name = "mnuYearlyRevenueAnalysisBack";
            this.mnuYearlyRevenueAnalysisBack.Size = new System.Drawing.Size(41, 20);
            this.mnuYearlyRevenueAnalysisBack.Text = "Back";
            this.mnuYearlyRevenueAnalysisBack.Click += new System.EventHandler(this.mnuYearlyRevenueAnalysisBack_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // lblYearlyRevenueAnalysis
            // 
            this.lblYearlyRevenueAnalysis.AutoSize = true;
            this.lblYearlyRevenueAnalysis.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearlyRevenueAnalysis.Location = new System.Drawing.Point(195, 51);
            this.lblYearlyRevenueAnalysis.Name = "lblYearlyRevenueAnalysis";
            this.lblYearlyRevenueAnalysis.Size = new System.Drawing.Size(223, 16);
            this.lblYearlyRevenueAnalysis.TabIndex = 2;
            this.lblYearlyRevenueAnalysis.Text = "Yearly Revenue Analysis:";
            // 
            // chartYearlyRevenueAnalysis
            // 
            chartArea2.Name = "ChartArea1";
            this.chartYearlyRevenueAnalysis.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartYearlyRevenueAnalysis.Legends.Add(legend2);
            this.chartYearlyRevenueAnalysis.Location = new System.Drawing.Point(50, 83);
            this.chartYearlyRevenueAnalysis.Name = "chartYearlyRevenueAnalysis";
            this.chartYearlyRevenueAnalysis.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartYearlyRevenueAnalysis.Series.Add(series2);
            this.chartYearlyRevenueAnalysis.Size = new System.Drawing.Size(524, 300);
            this.chartYearlyRevenueAnalysis.TabIndex = 3;
            this.chartYearlyRevenueAnalysis.Text = "chart1";
            // 
            // lblRevenueSummary
            // 
            this.lblRevenueSummary.AutoSize = true;
            this.lblRevenueSummary.Font = new System.Drawing.Font("MS Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueSummary.Location = new System.Drawing.Point(47, 409);
            this.lblRevenueSummary.Name = "lblRevenueSummary";
            this.lblRevenueSummary.Size = new System.Drawing.Size(159, 13);
            this.lblRevenueSummary.TabIndex = 4;
            this.lblRevenueSummary.Text = "Revenue Summary (€)";
            // 
            // listBoxYearlyRevenueAnalysis
            // 
            this.listBoxYearlyRevenueAnalysis.FormattingEnabled = true;
            this.listBoxYearlyRevenueAnalysis.Location = new System.Drawing.Point(50, 436);
            this.listBoxYearlyRevenueAnalysis.Name = "listBoxYearlyRevenueAnalysis";
            this.listBoxYearlyRevenueAnalysis.Size = new System.Drawing.Size(524, 95);
            this.listBoxYearlyRevenueAnalysis.TabIndex = 5;
            this.listBoxYearlyRevenueAnalysis.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // frmYearlyRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(619, 565);
            this.Controls.Add(this.listBoxYearlyRevenueAnalysis);
            this.Controls.Add(this.lblRevenueSummary);
            this.Controls.Add(this.chartYearlyRevenueAnalysis);
            this.Controls.Add(this.lblYearlyRevenueAnalysis);
            this.Controls.Add(this.mnuYearlyRevenueAnalysis);
            this.MainMenuStrip = this.mnuYearlyRevenueAnalysis;
            this.Name = "frmYearlyRevenueAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booktopia - [Yearly Revenue Analysis]";
            this.Load += new System.EventHandler(this.frmYearlyRevenueAnalysis_Load);
            this.mnuYearlyRevenueAnalysis.ResumeLayout(false);
            this.mnuYearlyRevenueAnalysis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartYearlyRevenueAnalysis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuYearlyRevenueAnalysis;
        private System.Windows.Forms.ToolStripMenuItem mnuYearlyRevenueAnalysisBack;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblYearlyRevenueAnalysis;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartYearlyRevenueAnalysis;
        private System.Windows.Forms.Label lblRevenueSummary;
        private System.Windows.Forms.ListBox listBoxYearlyRevenueAnalysis;
    }
}