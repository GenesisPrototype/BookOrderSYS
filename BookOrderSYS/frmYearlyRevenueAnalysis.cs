using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BookOrderSYS
{
    public partial class frmYearlyRevenueAnalysis : Form
    {
        frmMainMenu parent;
        public frmYearlyRevenueAnalysis()
        {
            InitializeComponent();
        }

        public frmYearlyRevenueAnalysis(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void mnuYearlyRevenueAnalysisBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void frmYearlyRevenueAnalysis_Load(object sender, EventArgs e)
        {
            //bar chart 
            chartYearlyRevenueAnalysis.Series.Clear();
            var series = chartYearlyRevenueAnalysis.Series.Add("Revenue");
            series.ChartType = SeriesChartType.Column;
            series.IsValueShownAsLabel = true;

            Dictionary<string, int> revenueData = new Dictionary<string, int>
            {
                { "2021", 12450 },
                { "2022", 18320 },
                { "2023", 22780 },
                { "2024", 19600 },
                { "2025", 25340 }
            };

            foreach (var entry in revenueData)
            {
                series.Points.AddXY(entry.Key, entry.Value);
            }

            //summary list
            listBoxYearlyRevenueAnalysis.Items.Clear(); 
            listBoxYearlyRevenueAnalysis.Items.Add("\r\r");
            listBoxYearlyRevenueAnalysis.Items.Add("2021: €12,450");
            listBoxYearlyRevenueAnalysis.Items.Add("2022: €18,320");
            listBoxYearlyRevenueAnalysis.Items.Add("2023: €22,780");
            listBoxYearlyRevenueAnalysis.Items.Add("2024: €19,600");
            listBoxYearlyRevenueAnalysis.Items.Add("2025: €25,340");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
