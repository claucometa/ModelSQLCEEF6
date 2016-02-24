using ExamPro.Domain.Models;
using Spire.Pdf;
using System.IO;
using System.Text;
using ExamPro.Utils;

namespace ExamPro.Services
{
    public static class LaudoService
    {
        public static Laudo GetPdf(string FileName)
        {
            if (!FileName.EndsWith(".pdf")) return null;
            Helper.Culture.SetCulture("en-US");
            var file = File.ReadAllBytes(FileName);
            string text = null;

            var doc = new PdfDocument();
            doc.LoadFromBytes(file);
            var buffer = new StringBuilder();
            foreach (PdfPageBase page in doc.Pages)
            {
                buffer.Append(page.ExtractText());
            }
            doc.Close();

            text = buffer.ToString().ToLower();
            text = Helper.RemoveSpaces(text);

            var laudo = new Laudo()
            {
                Pdf = text,
                FilePath = FileName
            };

            Helper.Culture.SetCulture();

            return laudo;
        }

        public static void Analyze(Gender gender, Laudo laudo)
        {
            if (gender == Gender.Masculino)
                AnalyzeMale(laudo);
            else
                AnalyzeFemale(laudo);
        }

        private static void AnalyzeMale(Laudo laudo)
        {
            try
            {
                ExamService.ExtractData(laudo.Pdf, Gender.Masculino);

                foreach (var item in ExamService.MaleData)
                {
                    item.Patient = laudo.Patient;

                    var exist = laudo.Maleviews.Find(t => t.Nome == item.Nome);
                    if (exist == null)
                    {
                        laudo.Maleviews.Add(item);
                    }
                }
            }
            catch (System.Exception ex)
            {
                ErrorHandling.AddError(ex);
            }
        }

        public static void AnalyzeFemale(Laudo laudo)
        {
            try
            {
                var pat = laudo.Patient;
                ExamService.ExtractData(laudo.Pdf, Gender.Feminino);

                foreach (var item in ExamService.FemaleData)
                {
                    item.Patient = pat;
                    var exist = laudo.Femaleviews.Find(t => t.Nome == item.Nome);
                    if (exist == null)
                    {
                        laudo.Femaleviews.Add(item);
                    }
                }
            }
            catch (System.Exception ex)
            {
                ErrorHandling.AddError(ex);
            }
        }
    }
}
