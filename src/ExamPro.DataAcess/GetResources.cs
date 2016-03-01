using ExamPro.Domain.Models;
using ExamPro.Utils;
using System.Collections.Generic;
using System.Linq;

namespace ExamPro.DataAccess
{
    public static class GetResources
    {
        public static List<Exam> GetExamData(string x)
        {            
            var data = new List<Exam>();
            x = x.Replace("\r\n", ";");
            var parts = x.Split(';');
            for (int i = 0; i < parts.Length; i += 6)
            {
                if (i == parts.Length - 1) break;
                var b = new Exam();
                b.Nome = parts[i + 0];
                b.MaleMin = Helper.DecParse(parts[i + 1]);
                b.MaleMax = Helper.DecParse(parts[i + 2]);
                b.FemaleMin = Helper.DecParse(parts[i + 3]);
                b.FemaleMax = Helper.DecParse(parts[i + 4]);
                b.Unidade = parts[i + 5];                
                data.Add(b);
            }
            return data;
        }

        public static IEnumerable<Sinonimo> GetSymData(Exam[] exams, string x)
        {
            var data = new List<Sinonimo>();
            x = x.Replace("\r\n", ";");
            var parts = x.Split(';');
            for (int i = 0; i < parts.Length; i += 6)
            {
                if (i == parts.Length - 1) break;
                var exam = exams.First(t => t.Nome == parts[i + 0]);
                var b = new Sinonimo();
                b.Exam = exam;
                b.Sym = parts[i + 1];
                data.Add(b);
            }
            return data;
        }
    }
}
