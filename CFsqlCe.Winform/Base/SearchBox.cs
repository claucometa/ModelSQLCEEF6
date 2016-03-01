using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFSqlCe.Winform.Base
{
    public partial class SearchBox : UserControl
    {
        public event EventHandler Searching;
        public event EventHandler StopSearch;

        public new void Focus() 
        {
            textBox1.Select();
            textBox1.Focus();
        }

        public SearchBox()
        {
            InitializeComponent();
            textBox1.TextChanged += searchBox_TextChanged;
        }

        public override string Text
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }

        void searchBox_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
            if (string.IsNullOrWhiteSpace(this.Text))
            {
                if (StopSearch != null) StopSearch(this, null);
            }
            else
            {
                if (Searching != null) Searching(this, null);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
