using System.Windows.Forms;
using CFSqlCe.Domain.Model;

namespace CFSqlCe.Winform.Base
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
