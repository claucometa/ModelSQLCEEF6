using System.Collections.Generic;
using System.Windows.Forms.DataVisualization.Charting;

namespace ExamPro.Winform.Graphs.GraphRoot
{
    public static class ChartTypes
    {
        public enum Charts
        {
            ChartValues = 2,
            ChartMinMax,
        }

        public static SeriesChartType[] GetData(Charts chart)
        {
            if (chart == Charts.ChartValues)
                return DataChartValues();
            return DataChartMinMax();
        }

        static SeriesChartType[] DataChartMinMax()
        {
            var zebra = new List<SeriesChartType>();
            zebra.Add(SeriesChartType.Area);
            zebra.Add(SeriesChartType.Column);
            zebra.Add(SeriesChartType.RangeColumn);
            zebra.Add(SeriesChartType.StackedColumn);
            zebra.Add(SeriesChartType.StackedColumn100);
            zebra.Add(SeriesChartType.Line);
            zebra.Add(SeriesChartType.Point);
            zebra.Add(SeriesChartType.Stock);
            zebra.Add(SeriesChartType.StepLine);
            zebra.Add(SeriesChartType.Spline);
            zebra.Add(SeriesChartType.SplineArea);
            zebra.Add(SeriesChartType.SplineRange);
            return zebra.ToArray();
        }

        static SeriesChartType[] DataChartValues()
        {
            var zebra = new List<SeriesChartType>();
            zebra.Add(SeriesChartType.Area);
            zebra.Add(SeriesChartType.BoxPlot);
            zebra.Add(SeriesChartType.Bubble);
            zebra.Add(SeriesChartType.Candlestick);
            zebra.Add(SeriesChartType.Column);
            zebra.Add(SeriesChartType.ErrorBar);
            zebra.Add(SeriesChartType.FastLine);
            zebra.Add(SeriesChartType.FastPoint);
            zebra.Add(SeriesChartType.Line);
            zebra.Add(SeriesChartType.Point);
            zebra.Add(SeriesChartType.Stock);
            zebra.Add(SeriesChartType.StepLine);
            zebra.Add(SeriesChartType.Spline);
            zebra.Add(SeriesChartType.SplineArea);
            zebra.Add(SeriesChartType.SplineRange);
            return zebra.ToArray();
        }
    }
}
