using ExamPro.DataAccess.Repo;
using ExamPro.Domain.Models;
using ExamPro.Domain.Views;
using System.Collections.Generic;
using System.Linq;

namespace ExamPro.Services
{
    public static class AllWords
    {
        static CrudRepo<Exam> Exams = new CrudRepo<Exam>();
        static CrudRepo<Sinonimo> Syms = new CrudRepo<Sinonimo>();
        public static List<TT> All;

        public class TT
        {
            public Exam Exam { get; set; }
            public string Name {get;set;}
            public string Unit { get; set; }
        }

        //public static void GetWords()
        //{
        //    var x = Exams.GetAll().Select(t => new TT() { Exam = t, Name = t.Nome, Unit = t.Unidade }).Where(t=>t.Name == "Glicose").First();
        //    var y = Syms.GetAll().Select(t => new TT() { Exam = t.Exam, Name = t.Sym, Unit = t.Exam.Unidade });
        //    All = new List<TT>();
        //    All.Add(x);
        //}

        public static void GetWords()
        {
            var x = Exams.GetAll().Select(t => new TT() { Exam = t, Name = t.Nome, Unit = t.Unidade });
            var y = Syms.GetAll().Select(t => new TT() { Exam = t.Exam, Name = t.Sym, Unit = t.Exam.Unidade });
            All = new List<TT>();
            All.AddRange(x);
            All.AddRange(y);
        }

        public static Exam FindExam(string x)
        {
            var exam = Exams.Find(t => t.Nome.ToLower() == x.ToLower());
            if (exam.Count() > 0) return exam.First();

            var sym = Syms.Find(t => t.Sym.ToLower() == x);
            if (sym.Count() > 0) return sym.First().Exam;

            return null;
        }  

        public static Exam FindExam(string x, string unit)
        {
            var exam = Exams.Find(t => t.Nome.ToLower() == x.ToLower() && t.Unidade == unit);
            if (exam.Count() > 0) return exam.First();

            var sym = Syms.Find(t => t.Sym.ToLower() == x);
            if (sym.Count() > 0) return sym.First().Exam;
            
            return null;
        }      
    }
}
