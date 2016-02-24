using ExamPro.Domain.Models;
using ExamPro.Services;
using ExamPRO.Services;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ExamPro.Winform.Graphs.GraphRoot
{
    public partial class GraphBase : UserControl, IGraph
    {
        public event EventHandler ClickedBar;
        public iSettings setting;

        public GraphBase()
        {
            InitializeComponent();
        }

        public void Start()
        {
            Chart.MouseDown += chart_MouseDown;
        }

        public void DefineColors()
        {
            Chart.PaletteCustomColors[(int)eSettings.Area] = setting.Area;
            Chart.PaletteCustomColors[(int)eSettings.Res] = setting.Res;
            Chart.PaletteCustomColors[(int)eSettings.Marca] = setting.Marca;
            Chart.Update();
            Chart.ChartAreas[0].RecalculateAxesScale();
        }

        protected internal void chart_MouseDown(object sender, MouseEventArgs e)
        {
            var chart = sender as Chart;

            var result = chart.HitTest(e.X, e.Y);
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                var dp = (DataPoint)result.Object;
                if (ClickedBar != null) ClickedBar(dp.AxisLabel, null);
            }
        }

        public virtual void LoadData(Domain.Models.Patient Patient)
        {
            throw new NotImplementedException();
        }

        public void SetTitle(string p)
        {
            Chart.Titles[0].Text = p;
        }

        public void Undo()
        {
            setting.Undo();
        }

        public void Restore()
        {
            setting.Default();            
        }

        Chart chart;
        public Chart Chart
        {
            get
            {
                return chart;
            }
            set
            {
                chart = value;
            }
        }

        public void UpdateSettings()
        {
            DefineColors();
        }
    }
}
