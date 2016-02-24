using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFSqlCe.Winform.Base
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
            Cursor.Current = Cursors.WaitCursor;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Cursor.Current = Cursors.Default;
        }
    }
}
