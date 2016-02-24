using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text;
using CFSqlCe.Domain.Views;
using CFSqlCe.Domain.Model;
using CFSqlCe.Dal.Utils;

namespace CFSqlCe.Dal.Services
{
    public static class ExamService
    {
        public static List<MaleView> MaleData;
        public static List<FemaleView> FemaleData;

        // Import data from a CVS file to the Exam database
        public static List<Exam> ImportData()
        {
            var frm = new OpenFileDialog();
            frm.Filter = "CSV (Separado por vírgulas) |*.csv";
            var exams = new List<Exam>();

            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (frm.FileName.EndsWith(".csv"))
                {
                    try
                    {
                        var x = File.ReadAllText(frm.FileName, Encoding.GetEncoding("iso-8859-1"));
                        exams.AddRange(GetResources.GetExamData(x));
                    }
                    catch (System.Exception ex)
                    {
                        ErrorHandling.AddError(ex);
                    }
                }
            }
            return exams;
        }

        // Analyse the PDF file and extract the exames found 
        public static void ExtractData(string pdf, Gender gender)
        {
            var sep = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
            MaleData = new List<MaleView>();
            FemaleData = new List<FemaleView>();

            pdf = eliminateNumbersNearOf('ª', pdf);
            pdf = eliminateNumbersNearOf('º', pdf);

            AllWords.GetWords();
            var keywords = AllWords.All.Select(t => t.Name).ToArray();
            var remainingWords = new List<string>(keywords);

            int i = 0;
            while (i < keywords.Length)
            {
                var item = keywords[i];

                if (remainingWords.Find(t => t == item) == null) { i++; continue; }

                var key = item.ToLower().Replace(" ", "");

                if (key.Length > 15)
                {
                    key = key.Substring(0, 15);
                }

                var keypos = pdf.IndexOf(key);

                if (keypos == -1) { i++; continue; }

                keypos += key.Length;
                var txt = pdf.Substring(keypos, pdf.Length - keypos);

                var u = pdf.ToArray();
                for (int w = keypos - key.Length; w < keypos; w++)
                {
                    u[w] = 'x';
                }
                pdf = new string(u);

                // Extract Numbers
                string numero = string.Empty;

                var linha = new List<string>();

                linha.Add(item);
                var count = 0;

                foreach (var ch in txt)
                {
                    int z;
                    if (count > 0 && ch == sep)
                    {
                        numero += sep;
                    }
                    else if (int.TryParse(ch.ToString(), out z))
                    {
                        count++;
                        numero += ch;
                    }
                    else if (count > 0)
                    {
                        count = 0;
                        linha.Add(numero);

                        // Matches Unit
                        var realUnit = AllWords.All[i].Unit;
                        var unit = txt.IndexOf(numero) + numero.Length;

                        if ((realUnit.ToLower() == txt.Substring(unit, realUnit.Length).ToLower()))
                        {
                            burnSynonyms(item, ref remainingWords);
                            if (gender == Gender.Masculino)
                            {
                                var d = new MaleView();
                                d.Male = AllWords.All[i].Exam;
                                d.Valor = decimal.Parse(linha[1]);
                                MaleData.Add(d);
                            }
                            if (gender == Gender.Feminino)
                            {
                                var d = new FemaleView();
                                d.Female = AllWords.All[i].Exam;
                                d.Valor = decimal.Parse(linha[1]);
                                FemaleData.Add(d);
                            }
                            i++;
                        }
                        break;
                    }
                }
            }
        }

        static string eliminateNumbersNearOf(char p, string pdf)
        {
            var pos = pdf.IndexOf(p);
            if (pos < 0) return pdf;

            while (pos > 0)
            {
                pdf = pdf.Remove(pos,1);
                int x = 0;
                int i = 1;
                while (int.TryParse(pdf.ElementAt(pos - i).ToString(), out x))
                {
                    pdf = pdf.Remove(pos - i, 1);
                    i++;
                }
                pos = pdf.IndexOf(p);
            }
            return pdf;
        }

        // Burn used / related words from the exams
        static void burnSynonyms(string key, ref List<string> words)
        {
            var u = AllWords.FindExam(key);
            words.Remove(key);
            foreach (var item in u.Sinonimos.Select(t => t.Sym).ToArray())
                words.Remove(item);
        }
    }
}
