using System.Collections.Generic;

namespace CFSqlCe.Domain.Model
{
    public class Sinonimo
    {
        public string Sym { get; set; }

        public long ExamId { get; set; }
        public virtual Exam Exam { get; set; }

        public Sinonimo()
        {
        }

        public Sinonimo(Sinonimo x) : this()
        {
            ExamId = x.ExamId;
            Sym = x.Sym;
        }
    }
}
