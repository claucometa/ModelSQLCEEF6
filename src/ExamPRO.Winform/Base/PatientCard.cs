using System.Windows.Forms;
using ExamPro.Domain.Models;

namespace ExamPro.Winform.Base
{
    public partial class PatientCard : UserControl
    {
        public PatientCard()
        {
            InitializeComponent();
        }

        public Patient DataSource
        {
            set
            {
                label4.Text = value.Name;
                label5.Text = value.Gender.ToString();
                label6.Text = value.Age.ToString();
            }
        }
    }
}
