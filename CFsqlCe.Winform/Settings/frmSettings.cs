using CFSqlCe.Dal.Services;
using System;
using System.Windows;
using System.Windows.Forms;

namespace CFSqlCe.Winform.Forms
{
    public partial class frmSettings : Base.FLayout
    {
        // LaudoGraphSettings setLaudoGraph = null;
        GraphSettings setExamGraph = null;

        public frmSettings()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.Items.AddRange(Enum.GetNames(typeof(Options)));
            listBox1.SelectedIndex = 0;            
        }

        enum Options
        {
            // Gráficos_Laudo
            Gráfico
        }

        void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listBox1.SelectedIndex)
            {
                //case (int)Options.Gráficos_Laudo:
                //    if (setLaudoGraph == null) setLaudoGraph = new LaudoGraphSettings(LaudoGraphSettings.Option.Laudo);
                //    panel2.Controls.Clear();
                //    panel2.Controls.Add(setLaudoGraph);
                //    break;
                case (int)Options.Gráfico:
                    if (setExamGraph == null) setExamGraph = new GraphSettings(listBox1.SelectedItem.ToString(), SettingService.Exam);
                    panel2.Controls.Clear();
                    panel2.Controls.Add(setExamGraph);
                    break;
                default:
                    break;
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (this.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                SettingService.Save();
            }
            else
            {
                //if (setLaudoGraph != null) setLaudoGraph.Undo();
                if (setExamGraph != null) setExamGraph.Undo();
            }
        }
    }
}