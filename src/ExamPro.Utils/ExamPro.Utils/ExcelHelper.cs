using Microsoft.Office.Interop.Excel;
using System;
using System.IO;

namespace ExamPro.Utils
{
    public static class ExcelHelper
    {
        public static string GetXlsAsCsv(byte[] file)
        {
            Workbook wbWorkbook = null;
            string stream = null;
            try
            {
                var app = new Application();
                File.WriteAllBytes(@"c:\temp\one.xls", file);
                wbWorkbook = app.Workbooks.Open(@"c:\temp\one.xls");
                wbWorkbook.SaveAs(@"c:\temp\two.xls", XlFileFormat.xlWorkbookNormal, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlShared, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                wbWorkbook.SaveAs(@"c:\temp\two.csv", XlFileFormat.xlCSV, Type.Missing, Type.Missing, Type.Missing, Type.Missing, XlSaveAsAccessMode.xlShared, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                stream = File.ReadAllText(@"c:\temp\two.csv");
            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }
            finally
            {
                if (wbWorkbook != null) wbWorkbook.Close(false, "", true);
                if (File.Exists(@"c:\temp\one.xls")) File.Delete(@"c:\temp\one.xls");
                if (File.Exists(@"c:\temp\two.xls")) File.Delete(@"c:\temp\two.xls");
                if (File.Exists(@"c:\temp\two.csv")) File.Delete(@"c:\temp\two.csv");
            }
            return stream;
        }
    }
}
