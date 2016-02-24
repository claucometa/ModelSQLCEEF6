using ExamPro.Domain.Views;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace ExamPro.Domain.Models
{
    public class Laudo
    {
        public long Id { get; set; }
        public string Pdf { get; set; }
        public string Lab { get; set; }
        public string Description { get; set; }
        public string FilePath { get; set; }
        public char Sep { get; set; }
        public DateTime ReportData { get; set; }

        public Laudo()
        {
            Femaleviews = new List<FemaleView>();
            Maleviews = new List<MaleView>();
            Sep = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
        }

        public string SomeName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Description))
                    return FileName;
                return Description;
            }
        }

        public string Directory
        {
            get
            {
                return Path.GetDirectoryName(FilePath);
            }
        }

        public string FileName
        {
            get
            {
                return Path.GetFileName(FilePath);
            }
        }

        // Patient Navigation
        public long PatientId { get; set; }
        public virtual Patient Patient { get; set; }

        public virtual List<FemaleView> Femaleviews { get; set; }
        public virtual List<MaleView> Maleviews { get; set; }
    }
}