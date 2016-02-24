using System;
using System.Windows.Forms;

namespace CFSqlCe.Winform.Graphs.GraphRoot
{
    public partial class MainGraph : UserControl
    {
        // GraphBase laudoGraph; 
        GraphBase examGraph = new Graphs.ExamsGraph();
        public event EventHandler ClickedBar;
        // bool laudo = false;

        public GraphBase Options
        {
            get
            {
                return examGraph;
                // return laudo ? laudoGraph : examGraph;
            }
        }

        public MainGraph()
        {
            InitializeComponent();                       
            this.Controls.Add(examGraph);
            // laudoGraph.ClickedBar += laudoGraph_ClickedBar;
        }

        void laudoGraph_ClickedBar(object sender, System.EventArgs e)
        {
            if (ClickedBar != null) ClickedBar(sender, null);
        }

        public void UpdateSettings()
        {
            examGraph.UpdateSettings();
        }

        public void Switch()
        {
            //if (laudo)
            //{
            //    this.Controls.Remove(laudoGraph);
            //    this.Controls.Add(examGraph);
            //}
            //else
            //{
            //    this.Controls.Remove(examGraph);
            //    this.Controls.Add(laudoGraph);
            //}
            //laudo = !laudo;
        }
    }
}
