using System;
using System.Drawing;

namespace CFSqlCe.Dal.Services
{
    public class SettingService
    {
        public static LaudoSet Laudo { get; set; }
        public static ExamSet Exam { get; set; }
        
        static SettingService()
        {
            Laudo = new LaudoSet();
            Exam = new ExamSet();
        }

        public static string GetName(eSettings x)
        {
            return Enum.GetName(typeof(eSettings), x);
        }
        
        public class LaudoSet : iSettings
        {
            public string Title { get { return SettingsLaudo.Default.Title; } set { SettingsLaudo.Default.Title = value; } }
            public Color Res { get { return SettingsLaudo.Default.Res; } set { SettingsLaudo.Default.Res = value; } }
            public Color Min { get { return SettingsLaudo.Default.Min; } set { SettingsLaudo.Default.Min = value; } }
            public Color Marca { get { return SettingsLaudo.Default.Max; } set { SettingsLaudo.Default.Max = value; } }
            public Color Area { get { return SettingsLaudo.Default.Area; } set { SettingsLaudo.Default.Area = value; } }
            public Color Font { get { return SettingsLaudo.Default.Font; } set { SettingsLaudo.Default.Font = value; } }

            public void Default()
            {                
                SettingsLaudo.Default.Reset();
            }

            public void Undo()
            {
                SettingsLaudo.Default.Reload();
            }
        }

        public class ExamSet : iSettings
        {
            public string Title { get { return SettingsExam.Default.Title; } set { SettingsExam.Default.Title = value; } }
            public Color Res { get { return SettingsExam.Default.Res; } set { SettingsExam.Default.Res = value; } }
            public Color Marca { get { return SettingsExam.Default.Marca; } set { SettingsExam.Default.Marca = value; } }
            public Color Area { get { return SettingsExam.Default.Area; } set { SettingsExam.Default.Area = value; } }
            public Color Font { get { return SettingsExam.Default.Font; } set { SettingsExam.Default.Font = value; } }

            public void Default()
            {                
                SettingsExam.Default.Reset();
            }

            public void Undo()
            {
                SettingsExam.Default.Reload();
            }
        }

        public static void Save()
        {
            SettingsExam.Default.Save();
            SettingsLaudo.Default.Save();           
        }
    }
}
