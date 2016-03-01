using System;
using System.Collections.Generic;
using System.Linq;
using ExamPro.Domain.Models;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using ExamPRO.Services;
using ExamPro.Services;

namespace ExamPro.Winform.Graphs
{
    public partial class LaudoGraph : GraphRoot.GraphBase
    {
        Random rand = new Random();
        Patient pat;
        List<ChartData> data;

        public LaudoGraph()
        {
            InitializeComponent();
            Chart = Chart;
            setting = new SettingService.LaudoSet();
            Chart.ChartAreas[0].AxisX.Interval = 1;
            Chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            Chart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            Chart.ChartAreas[0].AxisX.IsMarginVisible = false;
            Chart.MouseDown += chart_MouseDown;
            DefineColors();
            comboLaudo.SelectionChangeCommitted += comboLaudo_SelectionChangeCommitted;
            checkedListBox1.SelectedValueChanged += checkedListBox1_SelectedValueChanged;
            this.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            FillGraph();
        }

        void comboLaudo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FillGraph();
            loadExamsCheckList();
        }

        void FillGraph()
        {
            var laudo = comboLaudo.SelectedItem as Laudo;

            if (laudo == null) return;

            data = Services.BuildGraph.LaudoGraph(laudo);
            
            // Remove selected exams
            foreach (var item in but)
            {
                var rem = data.Find(t => t.Category == item);
                data.Remove(rem);
            }
            
            // Chart.ChartAreas[0].AxisY.Crossing = (double)data.Select(t => t.Min).First();

            bs.DataSource = data;
            SetTitle(string.Format(setting.Title, laudo.SomeName));
            
            // Select Auto
            foreach (var item in Chart.Series)
                item.XValueType = ChartValueType.Auto;
            Chart.DataBind();
        }

        public override void LoadData(Patient Patient)
        {
            pat = Patient;
            fillUIControls();
            FillGraph();
            loadExamsCheckList();
        }

        private void loadExamsCheckList()
        {
            checkedListBox1.Items.Clear();
            var z = data.Select(t => t.Index);
            if (z != null)
                checkedListBox1.Items.AddRange(z.ToArray());
        }

        void fillUIControls()
        {
            if (pat.Gender == Gender.Masculino)
            {
                var laudos = pat.MaleReport.Select(t => t.Laudo).Distinct().ToList();
                comboLaudo.DataSource = laudos;
                comboLaudo.DisplayMember = "SomeName";
                comboLaudo.ValueMember = "Id";
            }

            if (pat.Gender == Gender.Feminino)
            {
                var laudos = pat.FemaleReport.Select(t => t.Laudo).Distinct().ToList();
                comboLaudo.DataSource = laudos;
                comboLaudo.DisplayMember = "SomeName";
                comboLaudo.ValueMember = "Id";
            }
        }

        string[] but
        {
            get
            {
                var x = new List<string>();
                foreach (var item in checkedListBox1.CheckedItems)
                {
                    x.Add(item.ToString());
                }
                return x.ToArray();
            }
        }

    }
}
