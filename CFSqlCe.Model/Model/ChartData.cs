
using System;
namespace CFSqlCe.Domain.Model
{
    public class ChartData
    {
        public object Index { get; set; }
        public decimal? Val { get; set; }
        public decimal Min { get; set; }
        public decimal Max { get; set; }

        public DateTime DateIndex
        {
            get
            {
                return DateTime.Parse(Index.ToString());
            }
        }

        public ChartData()
        {
        }

        public ChartData(object i, decimal? val, decimal min, decimal max)
            : this()
        {
            Index = i;
            Min = min;
            Max = max;
            Val = val;
        }

        public string Category
        {
            get
            {
                return Index.ToString();
            }
        }
    }
}
