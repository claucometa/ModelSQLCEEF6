using CFSqlCe.Dal;
using CFSqlCe.Dal.Services;
using CFSqlCe.Domain.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace CFSqlCe.Winform.Forms
{
    public partial class Laudos : Base.FLayout
    {
        public Laudo Laudo { get { return bs.Current as Laudo; } }
        public Patient patient;
        public List<Laudo> items;
        public List<Laudo> filtered;

        public Laudos()
        {
            InitializeComponent();
        }

        public Laudos(Patient Patient) : this()
        {
            patient = Patient;
            patientCard1.DataSource = Patient;
            items = Patient.Laudos.ToList();
            LoadLabs();
            view1.CellEndEdit += view1_CellEndEdit;
            view1.CellClick += view1_CellClick;
            view1.Deleting += view1_Deleting;
            view1.DataError += view1_DataError;
            bs.CurrentItemChanged += bs_CurrentItemChanged;
        }

        void view1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if( e.ColumnIndex == ReportData.Index)
            {
                MessageBox.Show("Data Inválida!");
                e.Cancel = true;
            }
        }

        void view1_Deleting(object sender, EventArgs e)
        {
            var x = bs.Current as Laudo;
            MyContext.db.Reports.Remove(x);
            bs.Remove(x);
        }

        void bs_CurrentItemChanged(object sender, EventArgs e)
        {
            var x = bs.Current as Laudo;
            if (x != null) // in the case item has been excluded
            {
                if (x.Patient != null)
                {
                    ButtonOk.Enabled = x.Patient.Gender != Gender.Indefinido;
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            listBox1.SelectedIndex = 0;
            listBox1.Focus();
            listBox1.Select();
            base.OnLoad(e);
        }

        void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            if (listBox1.SelectedItem.ToString() == "Todos")
            {
                bs.DataSource = items;
                fixEmptyLabName(items);
            }
            else
            {
                var value = listBox1.SelectedItem.ToString();
                filtered = items.Where(x => x.Lab == value).ToList();
                bs.DataSource = filtered;
                fixEmptyLabName(filtered);
            }
        }

        private void LoadLabs()
        {
            var labs = items.Where(x => !string.IsNullOrWhiteSpace(x.Lab)).Select(x => x.Lab).Distinct().ToList();
            listBox1.Items.Clear();
            labs.Insert(0, "Todos");
            foreach (var item in labs)
            {
                listBox1.Items.Add(item);
            }
        }

        void view1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == colFolder.Index)
            {
                var x = bs.Current as Laudo;
                Process.Start(x.Directory);
            }
            if (e.ColumnIndex == colOk.Index)
            {
                var x = bs.Current as Laudo;
                new GraphData(x).ShowDialog();
            }
        }

        private void fixEmptyLabName(List<Laudo> items)
        {
            int count = 0;
            foreach (var item in items)
            {
                view1.Rows[count++].Cells[colLab.Index].Value = item.Lab;
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            MyContext.db.SaveChanges();
            base.OnClosed(e);
        }

        void view1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colLab.Index)
            {
                var x = bs.Current as Laudo;
                
                // Get Value
                string value = null;                
                if (view1.CurrentCell.Value != null)
                    value = view1.CurrentCell.Value.ToString();
                
                // Set Value
                if (string.IsNullOrWhiteSpace(value))
                    x.Lab = null;
                else
                    x.Lab = value.ToString();

                // Refresh View
                LoadLabs();
            }
        }

        private void AddLaudo()
        {
            var frm = new OpenFileDialog();
            frm.Filter = "PDF Documents|*.pdf";
            Laudo laudo = null;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                laudo = LaudoService.GetPdf(frm.FileName);
            if (laudo == null) return;
            patient.Laudos.Add(laudo);
            laudo.Patient = patient;
            var curLab = listBox1.SelectedItem.ToString();
            if (curLab != "Todos") laudo.Lab = curLab;

            LaudoService.Analyze(laudo.Patient.Gender, laudo);

            if(patient.Gender == Gender.Feminino)
                LaudoService.Analyze(laudo.Patient.Gender, laudo);
            
            MyContext.db.SaveChanges();
            bs.Add(laudo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddLaudo();
        }
    }
}
