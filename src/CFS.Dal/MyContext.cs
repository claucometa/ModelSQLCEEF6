using System;
using System.IO;

namespace CFSDDD.Dal
{
    public static class MyContext
    {
        public static CFSContext db;

        static MyContext()
        {
            var appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString();
            appdata += "\\CFSDDD\\CFSDDD Analytics";
            if (!Directory.Exists(appdata))
                Directory.CreateDirectory(appdata);
            db = new CFSContext("Data Source=" + appdata + "\\data.sdf");
        }

    }
}
