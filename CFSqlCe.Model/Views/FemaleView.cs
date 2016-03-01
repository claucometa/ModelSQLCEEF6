using CFSqlCe.Domain.Model;

namespace CFSqlCe.Domain.Views
{
    public class FemaleView : BaseView
    {
        public override decimal Min { get { return Female == null ? 0 : Female.FemaleMin; } }
        public override decimal Max { get { return Female == null ? 0 : Female.FemaleMax; } }
        public override string Unit { get { return Female == null ? "" : Female.Unidade; } }
        public override string Nome { get { return Female == null ? "[N/A]" : Female.Nome; } }

        public override string Summary
        {
            get
            {
                if (Min + Max == 0) return "-";
                return string.Format("{0} - {1} {2}", Min, Max, Unit);
            }
        }

        // Assossiation
        public long? FemaleId { get; set; }
        public virtual Exam Female { get; set; }
    }
}

