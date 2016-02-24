using System.Windows.Forms;
using System;
using CFSqlCe.Dal;
using CFSqlCe.Domain.Model;
using CFSqlCe.Dal.Services;

namespace CFSqlCe.Winform.Forms
{
    public partial class FormSinonimo : Base.FLayout
    {
        CrudRepo<Sinonimo> repo = new CrudRepo<Sinonimo>();

        Exam exam;

        public FormSinonimo()
        {
            InitializeComponent();
            view1.Deleting += view1_Deleting;
            view1.CellEndEdit += View1_CellEndEdit;
            view1.CellBeginEdit += View1_CellBeginEdit;
            ButtonCancel.Visible = false;
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            repo.Save();
        }

        object oldValue;
        private void View1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            oldValue = view1[e.ColumnIndex, e.RowIndex].Value;
            if(e.RowIndex < view1.RowCount - 1 )
            {
                view1.AllowUserToAddRows = false;
            }
        }

        private void View1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row =  view1.Rows[e.RowIndex];
            var newValue = view1[e.ColumnIndex, e.RowIndex].Value;

            if (oldValue == null) 
            {
                if (newValue == null)
                {
                   // view1.Rows.Remove(row);
                    return;
                }

                if (string.IsNullOrEmpty(newValue.ToString().Trim()))
                {
                    view1.Rows.Remove(row);
                    return;
                }

                if (AllWords.FindExam(newValue.ToString()) != null)
                {
                    MessageBox.Show("Já existe um exame/sinônimo com este nome!");
                    if (e.RowIndex == view1.RowCount - 2)
                        bs.Remove(bs.Current);
                    else
                        view1[e.ColumnIndex, e.RowIndex].Value = oldValue;
                    return;
                }

                view1.AllowUserToAddRows = true; repo.Save(); return; 
            }

            if (newValue == null) { view1.AllowUserToAddRows = true; view1[e.ColumnIndex, e.RowIndex].Value = oldValue; return; }
           
            if (string.IsNullOrEmpty(newValue.ToString()))
            {
                MessageBox.Show("Valor não pode ser nulo");
                view1[e.ColumnIndex, e.RowIndex].Value = oldValue;
                view1.AllowUserToAddRows = true;
                return;
            }

            if (newValue == oldValue) { view1.AllowUserToAddRows = true; return; }
            if (string.IsNullOrWhiteSpace(newValue.ToString())) { view1.AllowUserToAddRows = true; view1[e.ColumnIndex, e.RowIndex].Value = oldValue; return; }

            if (AllWords.FindExam(newValue.ToString()) != null)
            {
                MessageBox.Show("Já existe um exame/sinônimo com este nome!");
                if (e.RowIndex == view1.RowCount - 2)
                    bs.Remove(bs.Current);
                else
                    view1[e.ColumnIndex, e.RowIndex].Value = oldValue;
                view1.AllowUserToAddRows = true;
                return;
            }

            view1[e.ColumnIndex, e.RowIndex].Value = oldValue;
            var x = bs.Current as Sinonimo;
            repo.Remove(x);
            bs.Remove(x);
            repo.Save();

            var newExa = new Sinonimo(x);
            newExa.Sym = newValue.ToString();
            bs.Insert(e.RowIndex, newExa);
            repo.Save();
            view1.AllowUserToAddRows = true;
        }

        void view1_Deleting(object sender, System.EventArgs e)
        {
            var x = bs.Current as Sinonimo;
            bs.Remove(x);
            repo.Remove(x);
            repo.Save();
        }

        public FormSinonimo(Exam Exam)
            : this()
        {
            exam = Exam;
            this.Text = this.Text + " - " + exam.Nome;
            bs.DataSource = exam.Sinonimos;
        }
    }
}
