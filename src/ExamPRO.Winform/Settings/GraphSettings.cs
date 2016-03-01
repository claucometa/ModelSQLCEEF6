using ExamPro.Services;
using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ExamPro.Winform.Forms
{
    public partial class GraphSettings : ExamPro.Winform.Graphs.GraphRoot.GraphBase
    {
        public GraphSettings(string title, iSettings sets)
        {
            InitializeComponent();
            Chart = chart;
            setting = sets;
            label2.Text = title;

            textBox1.DataBindings.Add("Text", setting, "Title");            
            areaColor.BackColor = setting.Area;
            resColor.BackColor = setting.Res;
            marcaColor.BackColor = setting.Marca;
            fontColor.BackColor = setting.Font;

            areaColor.Click += minColor_Click;
            resColor.Click += minColor_Click;
            marcaColor.Click += minColor_Click;
            fontColor.Click += minColor_Click;

            areaColor.Tag = eSettings.Area;
            resColor.Tag = eSettings.Res;
            marcaColor.Tag = eSettings.Marca;
            fontColor.Tag = eSettings.Font;

            button1.Click += button1_Click;
            this.Dock = DockStyle.Fill;

            chart.ChartAreas[0].AxisX.Interval = 1;
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.ChartAreas[0].AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            chart.ChartAreas[0].AxisX.IsMarginVisible = false;

            DefineColors();
            FillGraph();
        }

        void FillGraph()
        {
            var minDate = DateTime.MinValue; // Initialize
            var maxDate = DateTime.MinValue; // Initialize
            bs.DataSource = Services.BuildGraph.FakeExamGraph(ref minDate, ref maxDate);
        }

        void minColor_Click(object sender, System.EventArgs e)
        {
            var obj = sender as Panel;
            var c = new ColorPicker.ColorDialog();
            if (c.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                obj.BackColor = c.WheelColor.ToColor();

            switch ((eSettings)obj.Tag)
            {
                case eSettings.Res:
                    setting.Res = obj.BackColor;
                    break;
                case eSettings.Marca:
                    setting.Marca = obj.BackColor;
                    break;
                case eSettings.Area:
                    setting.Area = obj.BackColor;
                    break;
                case eSettings.Font:
                    setting.Font = obj.BackColor;
                    break;
            }

            DefineColors();
        }

        void button1_Click(object sender, System.EventArgs e)
        {
            setting.Default();
            marcaColor.BackColor = setting.Marca;
            resColor.BackColor = setting.Res;
            areaColor.BackColor = setting.Area;
            fontColor.BackColor = setting.Font;
            DefineColors();
            SetTitle(setting.Title);
        }

    }
}
