using CFSqlCe.Domain.Model;
using CFSqlCe.Dal.Services;
using CFSqlCe.Winform.Forms;
using System;
using System.Windows.Forms;

namespace CFSqlCe.Winform.Graphs.GraphRoot
{
    public partial class GraphFrame : UserControl
    {
        Patient Pat;

        public GraphFrame()
        {
            InitializeComponent();
            chart.ClickedBar += chart_ClickedBar;
            //ExamsGraph.SwitchBack += ExamsGraph_SwitchBack;
            this.Dock = DockStyle.Fill;
        }

        void ExamsGraph_SwitchBack(object sender, EventArgs e)
        {
            chart.Switch();            
        }

        void chart_ClickedBar(object sender, EventArgs e)
        {
            chart.Switch();
            ExamsGraph.SelectedExam = sender.ToString();
            chart.Options.LoadData(Pat);
        }

        internal void LoadData(Patient pat)
        {
            Pat = pat;
            patientCard1.DataSource = pat;
            chart.Options.LoadData(pat);            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            chart.Switch();
        }

        internal void UpdateSettings()
        {
            chart.UpdateSettings();
        }
    }
}
