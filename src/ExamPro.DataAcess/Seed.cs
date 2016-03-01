using ExamPro.DataAccess;
using ExamPro.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace ExamPro.DataAccess
{
    public static class Seed
    {

        public static Exam[] SeedExams(ExamProContext context)
        {
            var exams = new List<Exam>();
            exams.AddRange(GetResources.GetExamData(Properties.Resources.Exames));
            return exams.ToArray();
        }

        public static Sinonimo[] SeedSinonyms(Exam[] exams, ExamProContext context)
        {
            var symn = new List<Sinonimo>();            
            symn.AddRange(GetResources.GetSymData(exams, Properties.Resources.Sinonimos));
            return symn.ToArray();
        }
    }
}
