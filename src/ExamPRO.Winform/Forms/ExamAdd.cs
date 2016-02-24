using ExamPro.DataAccess.Repo;
using ExamPro.Domain.Models;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace ExamPro.Winform.Forms
{
    public partial class ExamAdd : Base.FLayout
    {
        CrudRepo<Exam> repo = new CrudRepo<Exam>();
        public Exam Exam;

        struct g
        {
            public decimal min;
            public decimal max;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosed(e);

            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                g male, fema;
                string nome = textBox1.Text;
                string unit = comboBox1.Text;

                if (!decimal.TryParse(mMin.Text, out male.min)) { MessageBox.Show("Valor min inválido!"); e.Cancel = true; return; }
                if (!decimal.TryParse(mMax.Text, out male.max)) { MessageBox.Show("Valor máx inválido!"); e.Cancel = true; return; }
                if (!decimal.TryParse(fMin.Text, out fema.min)) { MessageBox.Show("Valor min inválido!"); e.Cancel = true; return; }
                if (!decimal.TryParse(fMax.Text, out fema.max)) { MessageBox.Show("Valor máx inválido!"); e.Cancel = true; return; }
                if (string.IsNullOrWhiteSpace(unit)) { MessageBox.Show("Unidade Obrigatória!"); e.Cancel = true; return; }
                if (string.IsNullOrWhiteSpace(nome)) { MessageBox.Show("Nome inválido!"); e.Cancel = true; return; }

                if (Services.AllWords.FindExam(nome, unit) != null)
                {
                    MessageBox.Show("Já existe um exame com este nome / unidade!");
                    e.Cancel = true;
                    return;
                }

                Exam = new Exam();
                Exam.Nome = nome;
                Exam.Unidade = comboBox1.Text;
                Exam.MaleMin = male.min;
                Exam.MaleMax = male.max;
                Exam.FemaleMin = fema.min;
                Exam.FemaleMax = fema.max;
            }
        }

        public ExamAdd()
        {
            InitializeComponent();
            var x = repo.GetAll().ToList().Select(t => t.Unidade).Distinct();
            comboBox1.Items.AddRange(x.ToArray());
            ButtonOk.TabIndex = 10;
            ButtonCancel.TabIndex = 11;
        }
    }
}
