using ExamPro.DataAccess;
using ExamPro.Domain.Models;
using ExamPro.Domain.Views;
using ExamPro.Services;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace ExamPro.Winform.Forms
{
    public partial class GraphData : Base.FLayout
    {
        Patient pat;
        Laudo laudo;

        GraphData()
        {
            InitializeComponent();
            view1.Deleting += view1_Deleting;
            view1.CellClick += view1_CellClick;
            view1.AllowUserToOrderColumns = true;
            searchBox1.Searching += searchBox1_Searching;
            searchBox1.StopSearch += searchBox1_StopSearch;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            searchBox1.Focus();
        }

        void searchBox1_StopSearch(object sender, EventArgs e)
        {
            if (pat.Gender == Gender.Masculino)
                if (mode == "Individual")
                    bs.DataSource = laudo.Maleviews.Where(t => t.Patient == pat).ToList();
                else
                    bs.DataSource = pat.MaleReport;

            if (pat.Gender == Gender.Feminino)
                if (mode == "Individual")
                    bs.DataSource = laudo.Femaleviews.Where(t => t.Patient == pat).ToList();
                else
                    bs.DataSource = pat.FemaleReport;

        }

        void searchBox1_Searching(object sender, EventArgs e)
        {
            if (pat.Gender == Gender.Masculino)
                if (mode == "Individual")
                    bs.DataSource = laudo.Maleviews.Where(t => t.Patient == pat).ToList().FindAll(x => x.Nome.ToLower().Contains(searchBox1.Text.ToLower()));
                else
                    bs.DataSource = pat.MaleReport.FindAll(x => x.Nome.ToLower().Contains(searchBox1.Text.ToLower()));

            if (pat.Gender == Gender.Feminino)
                if (mode == "Individual")
                    bs.DataSource = laudo.Femaleviews.Where(t => t.Patient == pat).ToList().FindAll(x => x.Nome.ToLower().Contains(searchBox1.Text.ToLower()));
                else
                    bs.DataSource = pat.FemaleReport.FindAll(x => x.Nome.ToLower().Contains(searchBox1.Text.ToLower()));
        }

        void view1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == colFolder.Index)
            {
                if (pat.Gender == Gender.Masculino)
                {
                    var x = (bs.Current as MaleView);
                    Process.Start(x.Laudo.Directory);
                }
                if (pat.Gender == Gender.Feminino)
                {
                    var x = (bs.Current as FemaleView);
                    Process.Start(x.Laudo.Directory);
                }
            }
        }

        void view1_Deleting(object sender, EventArgs e)
        {
            if (pat.Gender == Gender.Masculino)
            {
                var x = (bs.Current as MaleView);
                MyContext.db.MaleView.Remove(x);
                MyContext.db.SaveChanges();
                bs.Remove(x);
            }
            if (pat.Gender == Gender.Feminino)
            {
                var x = (bs.Current as FemaleView);
                MyContext.db.FemaleView.Remove(x);
                MyContext.db.SaveChanges();
                bs.Remove(x);
            }
        }

        string mode =  "Individual";

        public GraphData(Laudo Laudo)
            : this()
        {
            laudo = Laudo;

            if (laudo == null)
            {
                MessageBox.Show("Laudo corrompido!");
                return;
            }

            pat = laudo.Patient;
            patientCard1.DataSource = pat;
            this.Text = "Análise Individual do Laudo";

            if (pat.Gender == Gender.Masculino)
                bs.DataSource = laudo.Maleviews.Where(t=>t.Patient == pat).ToList();

            if (pat.Gender == Gender.Feminino)
                bs.DataSource = laudo.Femaleviews.Where(t => t.Patient == pat).ToList();
        }

        public GraphData(Patient Patient)
            : this()
        {
            pat = Patient;
            patientCard1.DataSource = pat;
            mode = "Todos";
            this.Text = "Análise dos Laudos do Paciente";

            if (pat.Gender == Gender.Masculino)
                bs.DataSource = pat.MaleReport;

            if (pat.Gender == Gender.Feminino)
                bs.DataSource = pat.FemaleReport;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pat.Gender == Gender.Masculino)
            {
                LaudoService.Analyze(pat.Gender, laudo);
                MyContext.db.SaveChanges();
                bs.DataSource = laudo.Maleviews.Where(t => t.Patient == pat).ToList();
            }

            if (pat.Gender == Gender.Feminino)
            {
                LaudoService.Analyze(pat.Gender, laudo);
                MyContext.db.SaveChanges();
                bs.DataSource = laudo.Femaleviews.Where(t => t.Patient == pat).ToList();
            }
        }
    }
}
