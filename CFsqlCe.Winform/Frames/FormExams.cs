using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using CFSqlCe.Dal.Services;
using CFSqlCe.Domain.Model;
using CFSqlCe.Dal;
using CFSqlCe.Dal.Utils;

namespace CFSqlCe.Winform.Frames
{
    public partial class FormExams : UserControl
    {
        List<Exam> exams = new List<Exam>();

        object dataSource
        {
            set
            {
                bs.DataSource = value;
                if (value != null) label1.Text = "Total: " + bs.Count.ToString();
                else label1.Text = "Total: 0";
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            searchBox1.Focus();
        }

        void view1_Deleting(object sender, EventArgs e)
        {
            var x = bs.Current as Exam;
            MyContext.db.Exams.Remove(x);
            bs.Remove(x);
            MyContext.db.SaveChanges();
            //"ALTER TABLE `exampro`.`femaleview` DROP FOREIGN KEY `FemaleView_Female`";
            //"ALTER TABLE `exampro`.`maleview` DROP FOREIGN KEY `MaleView_Male`";
        }

        public FormExams()
        {
            InitializeComponent();
            view1.RowHeadersVisible = false;
            view1.AllowUserToResizeColumns = false;

            Exam.Reset();
            exams = MyContext.db.Exams.ToList();
            dataSource = exams;

            view1.Deleting += view1_Deleting;
            searchBox1.Searching += searchBox1_Searching;
            searchBox1.StopSearch += searchBox1_StopSearch;
            view1.CellClick += view1_CellClick;
            view1.CellPainting += view1_CellPainting;
            this.Dock = DockStyle.Fill;

            view1.CellBeginEdit += view1_CellBeginEdit;
            view1.CellEndEdit += view1_CellEndEdit;

        }

        string oldValue;
        void view1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == nomeDataGridViewTextBoxColumn.Index)
            {
                oldValue = view1[e.ColumnIndex, e.RowIndex].Value.ToString();
            }
        }

        void view1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == nomeDataGridViewTextBoxColumn.Index)
            {
                var newValue = view1[e.ColumnIndex, e.RowIndex].Value.ToString();
                if (newValue == oldValue) { return; }

                if (string.IsNullOrWhiteSpace(newValue.ToString()))
                {
                    MessageBox.Show("Valor não pode ser nulo");
                    view1[e.ColumnIndex, e.RowIndex].Value = oldValue;
                    return;
                }

                view1[e.ColumnIndex, e.RowIndex].Value = oldValue;
                if (AllWords.FindExam(newValue) != null)
                {
                    MessageBox.Show("Nome já existe!");
                }
                else
                {
                    var x = bs.Current as Exam;
                    var newExa = new Exam(x);
                    newExa.Nome = newValue;
                    MyContext.db.Exams.Remove(x);
                    bs.Remove(x);
                    MyContext.db.SaveChanges();
                    MyContext.db.Exams.Add(newExa);
                    bs.Insert(e.RowIndex, newExa);
                    MyContext.db.SaveChanges();
                }
            }
        }

        void view1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == colEdit.Index)
            {
                var f = new Forms.FormSinonimo(bs.Current as Exam);
                f.ShowDialog();
                view1.UpdateCellValue(SymCount.Index, view1.CurrentRow.Index);
            }
        }

        //this.images is an ImageList with your bitmaps
        void view1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            int index = -1;

            if (e.ColumnIndex == maleMinDataGridViewTextBoxColumn.Index) index = 0;
            if (e.ColumnIndex == maleMaxDataGridViewTextBoxColumn.Index) index = 0;
            if (e.ColumnIndex == femaleMinDataGridViewTextBoxColumn.Index) index = 1;
            if (e.ColumnIndex == femaleMaxDataGridViewTextBoxColumn.Index) index = 1;

            if (index >= 0 && e.RowIndex == -1)
            {
                e.PaintBackground(e.ClipBounds, false);
                var pt = e.CellBounds.Location;
                int offset = (e.CellBounds.Width - this.images.ImageSize.Width) / 2;
                pt.X += offset;
                pt.Y += 3;
                e.Graphics.DrawImage(images.Images[index], pt.X - 30, pt.Y, 24, 24);
                e.Graphics.DrawString(view1.Columns[e.ColumnIndex].HeaderText, this.Font, Brushes.Black, pt);
                e.Handled = true;
            }
        }

        void searchBox1_StopSearch(object sender, EventArgs e)
        {
            dataSource = exams;
        }

        void searchBox1_Searching(object sender, EventArgs e)
        {
            dataSource = exams.FindAll(x => x.Nome.ToLower().Contains(searchBox1.Text.ToLower()));
        }

        private void menuAcessoRestrito_Click(object sender, EventArgs e)
        {
            var text =
@"Ao ativar a edição deste formulário você poderá:

        1- Adicionar dados manualmente
        1- Editar todos os valores
        2- Excluir dados
        3- Limpar todos os dados
        4- Importar dados

Qualquer alteração só será salva após clique no botão Salvar!";

            var ask = new Forms.AskPassword(text);

            if (ask.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                enableRestrict(true);
            }
        }

        private void enableRestrict(bool access)
        {
            panel1.Visible = access;
            colDelete.Visible = access;
            view1.ReadOnly = !access;
            menuExams.Enabled = access;
            menuAcessoRestrito.Enabled = !access;
        }

        private void adicionarItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var x = new Forms.ExamAdd();
            if (x.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MyContext.db.Exams.Add(x.Exam);
                bs.Add(x.Exam);
                label1.Text = bs.Count.ToString();
                MyContext.db.SaveChanges();
            }
        }

        private void importarDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                exams.AddRange(ExamService.ImportData());
                MyContext.db.Exams.AddRange(exams);
                dataSource = exams;
                MyContext.db.SaveChanges();
            }
            catch (Exception ex)
            {
                ErrorHandling.AddError(ex);
            }
            view1.DataSource = null;
            view1.DataSource = bs;
            view1.Update();
            view1.Refresh();
        }

        private void limparTudoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Não é possível desfazer esse processo. Continuar?", "", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                MyContext.db.Exams.RemoveRange(MyContext.db.Exams);
                dataSource = null;
                MyContext.db.SaveChanges();
                exams.Clear();
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            MyContext.db.SaveChanges();
            enableRestrict(false);
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            enableRestrict(false);
        }
    }
}

