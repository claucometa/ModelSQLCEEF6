using ExamPro.Domain.Models;

namespace ExamPro.Domain.Views
{
    public class MaleView : BaseView
    {
        public override decimal Min { get { return Male == null ? 0 : Male.MaleMin; } }
        public override decimal Max { get { return Male == null ? 0 : Male.MaleMax; } }
        public override string Unit { get { return Male == null ? "" : Male.Unidade; } }
        public override string Nome { get { return Male == null ? "[N/A]" : Male.Nome; } }
        
        public override string Summary
        {
            get
            {
                if (Min + Max == 0) return "-";
                return string.Format("{0} - {1} {2}", Min, Max, Unit);
            }
        }

        // Association
        public long? MaleId { get; set; }
        public virtual Exam Male { get; set; }
    }
}
