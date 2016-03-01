using System;
using System.Security.Cryptography;

namespace CFSqlCe.Winform.Forms
{
    public partial class AskPassword : Base.FLayout
    {
        public AskPassword(string Description)
        {
            InitializeComponent();
            label2.Text = Description;
            textBox1.TextChanged += textBox1_TextChanged;
        }

        void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (label3.Visible) label3.Visible = false;
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            base.OnClosing(e);

            if(DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                var cript = new MyLibs.Cript();
                using (var md5 = MD5.Create())
                {
                    e.Cancel = !cript.VerifyMd5Hash(md5, textBox1.Text, "bdfd902c02bf448b770ec4aa350ea937");
                    if(e.Cancel) label3.Visible = true;
                }
            }
        }
    }
}
