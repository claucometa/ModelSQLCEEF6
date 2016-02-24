using System;
using System.Collections.Generic;
using System.Linq;
using ExamPro.Domain.Models;
using System.Windows.Forms.DataVisualization.Charting;
using ExamPRO.Services;
using ExamPro.Services;

namespace ExamPro.Winform.Graphs
{
    public partial class ExamsGraph : GraphRoot.GraphBase
    {
        Random rand = new Random();
        Patient pat;
        List<ChartData> data;
        //public static event EventHandler SwitchBack;
        public static string SelectedExam;

        public ExamsGraph()
        {
            InitializeComponent();
            Chart = chart;
            setting = new SettingService.ExamSet();
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            Chart.ChartAreas[0].AxisX.Interval = 1;
            Chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            Chart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            Chart.ChartAreas[0].AxisX.IsMarginVisible = false;
            DefineColors();
            this.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGraph();
        }

        void FillGraph()
        {
            if (listBox1.SelectedItems.Count == 0) return;
            var x = listBox1.SelectedItem.ToString();

            var minDate = DateTime.MinValue; // Initialize
            var maxDate = DateTime.MinValue; // Initialize

            data = Services.BuildGraph.ExamGraph(ref minDate, ref maxDate, pat, x);

            var b = data[0];
            
            if(data.Count == 1)
            {
                data.Insert(0, new ChartData(DateTime.MinValue, null, b.Min, b.Max));
                data.Add(new ChartData(DateTime.MinValue, null, b.Min, b.Max));
            }

            bs.DataSource = data;

            // Set Title
            if (setting.Title.Contains("{0}") && setting.Title.Contains("{1}") && setting.Title.Contains("{2}"))
                SetTitle(string.Format(setting.Title, x, minDate.ToShortDateString(), maxDate.ToShortDateString()));
            else if (setting.Title.Contains("{0}") && setting.Title.Contains("{1}"))
                SetTitle(string.Format(setting.Title, x, minDate.ToShortDateString()));
            else if (setting.Title.Contains("{0}"))
                SetTitle(string.Format(setting.Title, x));
            else
                SetTitle(setting.Title);

            // Select DateTime
            foreach (var item in Chart.Series)
                item.XValueType = ChartValueType.DateTime;

            Chart.DataBind();

            if (Chart.Series[0].Points.Count > 0)
            {
                Chart.Series[1].Points[0].AxisLabel = "";
                Chart.Series[0].Points[Chart.Series[0].Points.Count - 1].AxisLabel = "";
            }
        }

        public override void LoadData(Patient Patient)
        {
            pat = Patient;
            fillUIControls();

            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                var item = listBox1.Items[i];
                if (item.ToString() == SelectedExam)
                {
                    listBox1.SelectedIndex = i;
                    return;
                }
            }

            listBox1.SelectedIndex = 0;
        }

        void fillUIControls()
        {
            string[] examNames = null;

            if (pat.Gender == Gender.Masculino)
            {
                var exames = pat.MaleReport.Select(t => t.Male).Distinct().ToList();
                examNames = exames.Select(t => t.Nome).Distinct().ToArray();
                var laudos = pat.MaleReport.Select(t => t.Laudo).Distinct().ToList();
            }

            if (pat.Gender == Gender.Feminino)
            {
                var exames = pat.FemaleReport.Select(t => t.Female).Distinct().ToList();
                examNames = exames.Select(t => t.Nome).Distinct().ToArray();
                var laudos = pat.FemaleReport.Select(t => t.Laudo).Distinct().ToList();
            }

            listBox1.Items.Clear();
            listBox1.Items.AddRange(examNames);
        }

        void checkedListBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            FillGraph();
        }


    }
}
