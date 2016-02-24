using ExamPro.Winform.Base;
using System.Drawing;
using System.Windows.Forms;

namespace ExamPro.Winform
{
    public static class MyImages
    {
        static Repository comp = new Repository();

        public enum Code
        {
            add,
            chart,
            del,
            edit,
            folder,
            info,
            search,
            ok
        }

        public static ImageList MenuIcons
        {
            get
            {
                return comp.menuIcons;
            }
        }

        public static Image Male
        {
            get
            {
                return  comp.femaieMale32.Images[1];
            }
        }

        public static Image Female
        {
            get
            {
                return comp.femaieMale32.Images[0];
            }
        }

        public static Image FlatIcons(Code i)
        {
            return comp.flatIcons.Images[(int)i];
        }
    }
}
