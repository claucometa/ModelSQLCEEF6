
using System.Globalization;
using System.Threading;

namespace ExamPro.Utils
{
    public static class Helper
    {
        public static decimal DecParse(string x)
        {
            decimal z = 0;
            decimal.TryParse(x, out z);
            return z;
        }

        public static string RemoveSpaces(string content)
        {
            var old = content.Length;
            var n = content.Length;
            do
            {
                old = content.Length;
                content = content.Replace(" ", "");
                n = content.Length;
            } while (old != n);
            return content;
        }

        public static class Culture
        {
            static string DefaultCulture;

            public static void SetCulture(string cultureInfo = null)
            {
                if (DefaultCulture == null)
                {
                    DefaultCulture = Thread.CurrentThread.CurrentCulture.Name;
                }
                var x = new CultureInfo(cultureInfo ?? DefaultCulture);
                Thread.CurrentThread.CurrentCulture = x;
                Thread.CurrentThread.CurrentUICulture = x;
            }

            public static void GetDefaultCulture()
            {
                DefaultCulture = Thread.CurrentThread.CurrentCulture.Name;
            }
        }


    }
}
