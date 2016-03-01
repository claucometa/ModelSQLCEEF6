using System.Drawing;

namespace CFSqlCe.Domain
{
    public static class MyIndicator
    {
        static int height = 3;
        static int border = 5;

        public static Bitmap DoImage(int percentage, int width = 126)
        {
            Color color = Color.Green;
            
            int realWidth = width - border * 2;

            var pos = (realWidth * percentage / 100);

            if (pos > realWidth)
            {
                pos = realWidth;
                color = Color.Red;
            }

            if (pos < 0)
            {
                pos = 0;
                color = Color.Red;
            }
            
            var bitmap = new Bitmap(width, height + 7);
            using (var graph = Graphics.FromImage(bitmap))
            {
                graph.FillRectangle(new SolidBrush(Color.DarkGray), new Rectangle(border, height, width - border, border));
                graph.FillEllipse(new SolidBrush(color), new Rectangle(pos, 0, 10, 10));
            }
            return bitmap;
        }
    }
}
