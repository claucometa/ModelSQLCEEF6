using CFSqlCe.Domain.Views;
using System;
using System.Collections.Generic;

namespace CFSqlCe.Domain.Model
{
    public class Patient
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime BirthDay { get; set; }
        public DateTime Created { get; set; }

        public override string ToString()
        {
            return string.Format("Nome: {0} | Sexo: {1} | Nascimento: {2} | Idade: {3}", Name, Gender, BirthDay.ToShortDateString(), Age);
        }

        public int TotalLaudos
        {
            get
            {
                return Laudos.Count;
            }
        }

        public Patient()
        {
            BirthDay = DateTime.Now;
            Created = BirthDay;
            Laudos = new List<Laudo>();
        }

        public int Age
        {
            get
            {
                return GetAge(BirthDay);
            }
        }

        public int GetAge(DateTime birth)
        {
            var now = DateTime.Now;
            int age = now.Year - birth.Year;
            if (now.Month < birth.Month || (now.Month == birth.Month && now.Day < birth.Day)) age--;
            return age;
        }

        public virtual List<Laudo> Laudos { get; set; }
        public virtual List<MaleView> MaleReport { get; set; }
        public virtual List<FemaleView> FemaleReport { get; set; }
    }
}
