using CFSqlCe.Dal;
using CFSqlCe.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CFSqlCe.Winform.Frames
{
    public partial class Patients : UserControl
    {
        public event EventHandler GraphClicked;

        CrudRepo<Patient> repo = new CrudRepo<Patient>();
        CrudRepo<Laudo> repoLaudo = new CrudRepo<Laudo>();
        List<Patient> patients = new List<Patient>();
        public Patient Current
        {
            get
            {
                return bs.Current as Patient;
            }
        }

        public Patients()
        {
            InitializeComponent();
            view1.RowTemplate.Height = 34;
            view1.CellClick += view1_CellClick;
            view1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            view1.MultiSelect = false;
            searchBox1.Searching += searchBox1_Searching;
            searchBox1.StopSearch += searchBox1_StopSearch;
            patients = repo.GetAll().ToList();
            bs.DataSource = patients;
            view1.Deleting += view1_Deleting;
            this.Dock = DockStyle.Fill;
        }

        void view1_Deleting(object sender, EventArgs e)
        {
            var pat = bs.Current as Patient;
            repoLaudo.Remove(pat.Laudos);
            repo.Remove(pat);
            bs.Remove(bs.Current);
            repo.Save();
            view1.Refresh();
        }

        void searchBox1_StopSearch(object sender, EventArgs e)
        {
            bs.DataSource = patients; 
        }

        void searchBox1_Searching(object sender, EventArgs e)
        {
            bs.DataSource = patients.FindAll(x => x.Name.ToLower().Contains(searchBox1.Text.ToLower()));
        }

        void view1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == colEdit.Index)
            {
                var x = bs.Current as Patient;
                new Forms.PatientEdit(x).ShowDialog();
                view1.Refresh();
            }
            if (e.ColumnIndex == colOk.Index)
            {
                var x = bs.Current as Patient;
                new Forms.GraphData(x).ShowDialog();
            }
            if (e.ColumnIndex == colChart.Index)
            {
                if (GraphClicked != null) GraphClicked(null, null);
            }
        }

        private void btNovo_Click(object sender, EventArgs e)
        {
            var x = new Forms.PatientEdit(new Patient());
            if (x.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                bs.Insert(0, x.GetPatient);
                bs.MoveFirst();
            }
            view1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var pat = (bs.Current as Patient);
            if (pat == null)
            {
                MessageBox.Show("Nenhum paciente selecionado!");
                return;
            }
            var x = new Forms.Laudos(pat);
            x.ShowDialog();
        }
    }
}
