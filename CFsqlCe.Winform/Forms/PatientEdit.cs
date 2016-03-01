using CFSqlCe.Dal;
using CFSqlCe.Domain.Model;
using System.Collections.Generic;

namespace CFSqlCe.Winform.Forms
{
    public partial class PatientEdit : Base.FLayout
    {
        CrudRepo<Patient> repo = new CrudRepo<Patient>();
        
        public Patient GetPatient
        {
            get
            {
                return bs.Current as Patient;
            }
        }

        public PatientEdit(Patient Patient)
        {
            InitializeComponent();
            this.Text = Patient.Id == 0 ? "Novo Paciente" : "Editar Paciente";
            bs.DataSource = Patient;
            if (Patient.Gender == Gender.Feminino)
                radioButton2.Checked = true;                
            birthDayDateTimePicker.ValueChanged += birthDayDateTimePicker_ValueChanged;
        }

        void birthDayDateTimePicker_ValueChanged(object sender, System.EventArgs e)
        {
            var pat = bs.Current as Patient;
            ageLabel.Text = pat.Age.ToString();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                if (Invalido)
                {
                    e.Cancel = true;
                    ShowErrorMessages();
                    return;
                }

                var pat = bs.Current as Patient;

                if (radioButton2.Checked)
                    pat.Gender = Gender.Feminino;
                if (radioButton1.Checked)
                    pat.Gender = Gender.Masculino;

                if (pat.Id == 0)
                    repo.Add(pat);
                else
                    repo.Update(pat);
                repo.Save();
            }
        }

        private void ShowErrorMessages()
        {
            var tudo = string.Join("!", errors.ToArray());
            System.Windows.Forms.MessageBox.Show(tudo);
            errors.Clear();
            nameTextBox.Focus();
        }

        List<string> errors = new List<string>();
        bool Invalido
        {
            get
            {
                if (string.IsNullOrWhiteSpace(nameTextBox.Text))
                    errors.Add("Favor preencher o nome!\r\n");
                return errors.Count > 0;
            }
        }
    }
}