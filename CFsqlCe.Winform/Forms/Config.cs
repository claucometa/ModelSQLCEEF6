using CFSqlCe.Dal;
using System;
using System.Windows.Forms;

namespace CFSqlCe.Winform.Forms
{
    public partial class Config : Base.FLayout
    {
        public Config()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.Servidor;
            textBox2.Text = Properties.Settings.Default.Usuario;
            textBox3.Text = Properties.Settings.Default.Senha;
        }

        protected override void OnClosed(EventArgs e)
        {
            if (DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                Properties.Settings.Default.Servidor = textBox1.Text;
                Properties.Settings.Default.Usuario = textBox2.Text;
                Properties.Settings.Default.Senha = textBox3.Text;
                Properties.Settings.Default.Save();
            }            
            base.OnClosed(e);
        }

        public static bool GrantAccess()
        {
            bool tryAgain;
            do
            {
                try
                {
                    MyContext.ConfigServer(
                        Properties.Settings.Default.Servidor,
                        Properties.Settings.Default.Usuario,
                        Properties.Settings.Default.Senha);
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    tryAgain = new Config().ShowDialog() == DialogResult.OK;
                }
            } while (tryAgain);
            return false;
        }
    }
}
