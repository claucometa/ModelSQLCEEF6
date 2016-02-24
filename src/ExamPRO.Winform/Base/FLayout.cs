using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamPro.Winform.Base
{
    public partial class FLayout : FormBase
    {
        public FLayout()
        {
            InitializeComponent();
        }

        public Button ButtonOk
        {
            get
            {
                return button1;
            }
        }

        public Button ButtonCancel
        {
            get
            {
                return button2;
            }
        }

        private void FLayout_Load(object sender, EventArgs e)
        {

        }
    }
}
