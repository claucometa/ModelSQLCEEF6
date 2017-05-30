using System;
using System.IO;

namespace CFSDDD.Dal.Repo
{
    public static class MainContext
    { 
        public static CFSContext Production;
        public static CFSContext Mock;

        static MainContext()
        {
            var appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData).ToString();
            appdata += "\\CFSDDD\\Database";
            if (!Directory.Exists(appdata))
                Directory.CreateDirectory(appdata);
            Production = new CFSContext("Data Source=" + appdata + "\\data.sdf");
        }
    }
}
