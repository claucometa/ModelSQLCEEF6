
using ExamPro.Utils;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExamPro.Domain.Models
{
    public class Exam
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Unidade { get; set; }
        public decimal MaleMin { get; set; }
        public decimal MaleMax { get; set; }
        public decimal FemaleMin { get; set; }
        public decimal FemaleMax { get; set; }

        public Exam()
        {
            Sinonimos = new List<Sinonimo>();
        }

        public Exam(Exam x) : this()
        {
            Nome = x.Nome;
            Unidade = x.Unidade;
            MaleMax = x.MaleMax;
            Index = x.Index;
            MaleMin = x.MaleMin;
            FemaleMax = x.FemaleMax;
            FemaleMin = x.FemaleMin;
        }

        static int count = 0;
        int _Index = 0;
        [NotMapped]
        public int Index
        {
            set
            {
                _Index = value;
            }
            get
            {
                if (_Index == 0)
                {
                    count++;
                    _Index = count;
                }
                return _Index;
            }
        }

        public static void Reset()
        {
            count = 0;
        }

        public int SymCount
        {
            get
            {
                return Sinonimos.Count;
            }
        }

        public virtual ICollection<Views.FemaleView> Females { get; set; }
        public virtual ICollection<Views.MaleView> Males { get; set; }
        public virtual ICollection<Sinonimo> Sinonimos { get; set; }
    }
}
