using System;
using System.Windows.Forms;
using CFSqlCe.Winform.Base;
using CFSqlCe.Winform.Forms;
using System.Drawing;

namespace CFSqlCe.Winform
{
    public partial class Main : Form
    {
        Frames.FormExams frmExam;
        Frames.Patients patients;
        Graphs.GraphRoot.GraphFrame graph;

        #region List View Spacing
        // This is no longer being used
        //[DllImport("user32.dll")]
        //public static extern int SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);

        //public int MakeLong(short lowPart, short highPart)
        //{
        //    return (int)(((ushort)lowPart) | (uint)(highPart << 16));
        //}

        //public void ListViewItem_SetSpacing(ListView listview, short leftPadding, short topPadding)
        //{
        //    const int LVM_FIRST = 0x1000;
        //    const int LVM_SETICONSPACING = LVM_FIRST + 53;
        //    SendMessage(listview.Handle, LVM_SETICONSPACING, IntPtr.Zero, (IntPtr)MakeLong(leftPadding, topPadding));
        //}
        #endregion

        public Main()
        {
            this.Opacity = 0;

            CFSqlCe.Dal.Utils.ErrorHandling.Error += ErrorHandling_Error;

            InitializeComponent();

            // Set NavButtons Events
            navPatients.Click += navPatients_Click;
            navExams.Click += navMale_Click;
            navGraph.Click += navGraph_Click;
            navExit.Click += navExit_Click;

            // Set NavButtons Images
            navPatients.Btt.ImageIndex = (int)NavIcons.Patient;
            navGraph.Btt.ImageIndex = (int)NavIcons.Graph;
            navExams.Btt.ImageIndex = (int)NavIcons.Lab;
            navExit.Btt.ImageIndex = (int)NavIcons.Close;
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem1_Click;
            logToolStripMenuItem.Click += errorsToolStripMenuItem_Click;
            pacientesToolStripMenuItem.Click += pacientesToolStripMenuItem_Click;
            gráficoToolStripMenuItem.Click += gráficoToolStripMenuItem_Click;
            examesToolStripMenuItem.Click += examesToolStripMenuItem_Click;
            configToolStripMenuItem.Click += configToolStripMenuItem_Click;
        }

        void configToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (new frmSettings().ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (graph != null) graph.UpdateSettings();
            }
        }

        void switchAppearance(ToolStripMenuItem x)
        {
            examesToolStripMenuItem.Font = this.Font;
            gráficoToolStripMenuItem.Font = this.Font;
            pacientesToolStripMenuItem.Font = this.Font;
            x.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        void examesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            navExams.PerformClick();
        }

        void gráficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            navGraph.PerformClick();
        }

        void pacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            navPatients.PerformClick();
        }

        void navExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ErrorHandling_Error(object sender, EventArgs e)
        {
            programToolStripMenuItem.Text = string.Format("Log ({0})", CFSqlCe.Dal.Utils.ErrorHandling.ErrorsCount);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.WindowState = FormWindowState.Normal;
            this.WindowState = FormWindowState.Maximized;
            this.Opacity = 100;
            Pacientes();
        }

        #region Simulates Button Activation according to mdi activated
        void patients_Activated(object sender, EventArgs e)
        {
            switchAppearance(pacientesToolStripMenuItem);
            NavButton.Activate(navPatients.Btt);
        }

        void exams_Activated(object sender, EventArgs e)
        {
            switchAppearance(examesToolStripMenuItem);
            NavButton.Activate(navExams.Btt);
        }

        private void graph_Activated(object sender, EventArgs e)
        {
            switchAppearance(gráficoToolStripMenuItem);
            NavButton.Activate(navGraph.Btt);
        }
        #endregion

        #region NavClick Handling
        void navGraph_Click(object sender, EventArgs e)
        {
            OpenGraph();
        }

        void navMale_Click(object sender, EventArgs e)
        {
            OpenMaleExam();
        }

        void navPatients_Click(object sender, EventArgs e)
        {
            Pacientes();
        }
        #endregion

        #region Mdi Handling
        private void OpenGraph()
        {
            var pat = patients.Current;

            if (pat == null)
            {
                MessageBox.Show("Nenhum paciente selecionado!");
                return;
            }

            if (pat.Laudos.Count == 0)
            {
                MessageBox.Show("O paciente atual não contém nenhum laudo!");
                return;
            }

            if (graph == null)
            {
                graph = new CFSqlCe.Winform.Graphs.GraphRoot.GraphFrame();
            }

            graph.LoadData(patients.Current);
            addFrame(graph);
        }

        private void OpenMaleExam()
        {
            if (frmExam == null)
                frmExam = new Frames.FormExams();
            addFrame(frmExam);
        }

        private void Pacientes()
        {
            if (patients == null)
            {
                patients = new Frames.Patients();
                patients.GraphClicked -= patients_GraphClicked;
                patients.GraphClicked += patients_GraphClicked;
            }
            addFrame(patients);
        }

        void addFrame(UserControl ctrl)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(ctrl);
        }

        void patients_GraphClicked(object sender, EventArgs e)
        {
            navGraph.PerformClick();
        }
        #endregion

        private void errorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CFSqlCe.Dal.Utils.ErrorHandling.ShowErrors();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }
    }
}
