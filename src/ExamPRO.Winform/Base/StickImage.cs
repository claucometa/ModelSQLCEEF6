using System.Drawing;
using System.Windows.Forms;

namespace ExamPro.Winform.Base
{
    public partial class StickImage : UserControl
    {
        Graphics graph;
        int border = 5;


        public StickImage()
        {
            InitializeComponent();
            graph = this.CreateGraphics();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            graph.FillRectangle(new SolidBrush(Color.DarkGray), new Rectangle(5, 3, this.Width - 5, 5));
            graph.FillEllipse(new SolidBrush(Color.Blue), new Rectangle(0, 0, 10, 10));            
        }

        int realWidth
        {
            get
            {
                return this.Width - border * 2;
            }
        }

        internal int DrawPoint 
        {
            set
            {
                var pos = (this.realWidth * value / 100);
                if (pos > this.realWidth) pos = this.realWidth;

                graph.Clear(this.BackColor);
                graph.FillRectangle(new SolidBrush(Color.DarkGray), new Rectangle(border, 3, this.Width - border, border));
                graph.FillEllipse(new SolidBrush(Color.Blue), new Rectangle(pos, 0, 10, 10));
            }
        }
    }
}
