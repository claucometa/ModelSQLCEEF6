using CFSqlCe.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace CFSqlCe.Dal
{
    public static class Seed
    {

        public static Exam[] SeedExams(DvdContext context)
        {
            var exams = new List<Exam>();
            exams.AddRange(GetResources.GetExamData(Properties.Resources.Exames));
            return exams.ToArray();
        }

        public static Sinonimo[] SeedSinonyms(Exam[] exams, DvdContext context)
        {
            var symn = new List<Sinonimo>();            
            symn.AddRange(GetResources.GetSymData(exams, Properties.Resources.Sinonimos));
            return symn.ToArray();
        }
    }
}
