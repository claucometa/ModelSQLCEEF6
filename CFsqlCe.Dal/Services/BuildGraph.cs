using CFSqlCe.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CFSqlCe.Dal.Services
{
    public class BuildGraph
    {
        public static List<ChartData> FakeExamGraph(ref DateTime minDate, ref DateTime maxDate)
        {
            var feedGraph = new List<ChartData>();
            feedGraph.Add(new ChartData(DateTime.Now.AddMonths(0).ToShortDateString(), 110, 50, 150));
            feedGraph.Add(new ChartData( DateTime.Now.AddMonths(1).ToShortDateString(), 95, 50, 150));
            feedGraph.Add(new ChartData(DateTime.Now.AddMonths(2).ToShortDateString(), 140, 50, 150));
            feedGraph.Add(new ChartData( DateTime.Now.AddMonths(3).ToShortDateString(), 90, 50, 150));
            return feedGraph.OrderBy(t => t.DateIndex).ToList();
        }

        public static List<ChartData> ExamGraph(ref DateTime minDate, ref DateTime maxDate, Patient pat, string x)
        {
            var feedGraph = new List<ChartData>();

            if (pat.Gender == Gender.Feminino)
            {
                if (pat.FemaleReport.Count == 0)
                {
                    MessageBox.Show("Este laudo está corrompido!");
                    return null;
                }

                var y = pat.FemaleReport.FindAll(t => t.Female.Nome == x);
                minDate = y.Min(t => t.Laudo.ReportData);
                maxDate = y.Max(t => t.Laudo.ReportData);
                foreach (var item in y)
                    feedGraph.Add(new ChartData(item.Laudo.ReportData.ToShortDateString(), item.Valor, item.Min, item.Max));
            }

            if (pat.Gender == Gender.Masculino)
            {
                if (pat.MaleReport.Count == 0)
                {
                    MessageBox.Show("Este laudo está corrompido!");
                    return null;
                }

                var y = pat.MaleReport.FindAll(t => t.Male.Nome == x);
                minDate = y.Min(t => t.Laudo.ReportData);
                maxDate = y.Max(t => t.Laudo.ReportData);

                foreach (var item in y)
                    feedGraph.Add(new ChartData(item.Laudo.ReportData.ToShortDateString(), item.Valor, item.Min, item.Max));
            }

            return feedGraph.OrderBy(t => t.DateIndex).ToList();
        }

        public static List<ChartData> LaudoGraph(Laudo laudo)
        {
            var feedGraph = new List<ChartData>();

            if (laudo == null)
            {
                MessageBox.Show("Este laudo está vazio ou corrompido!");
                return null;
            }

            var pat = laudo.Patient;

            if (pat.Gender == Gender.Masculino)
            {
                if (laudo.Maleviews.Count == 0)
                {
                    MessageBox.Show("Este laudo está vazio ou corrompido!");
                    return null;
                }

                foreach (var item in pat.MaleReport.FindAll(t => t.Laudo == laudo))
                {
                    feedGraph.Add(new ChartData(item.Nome, item.Valor, item.Min, item.Max));
                }
            }

            if (pat.Gender == Gender.Feminino)
            {
                if (laudo.Femaleviews.Count == 0)
                {
                    MessageBox.Show("Este laudo está vazio ou corrompido!");
                    return null;
                }

                foreach (var item in pat.FemaleReport.FindAll(t => t.Laudo == laudo))
                {
                    feedGraph.Add(new ChartData(item.Nome, item.Valor, item.Min, item.Max));
                }
            }
            return feedGraph.OrderBy(t => t.Index).ToList();
        }
    }
}
