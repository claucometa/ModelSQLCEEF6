
using System.Windows.Forms;
namespace ExamPro.Winform.Forms
{
    public partial class About : Base.FLayout
    {
        public About()
        {
            InitializeComponent();
            var superman = 
@"
               .=., 
              ;c =\ 
            __|  _/ 
          .'-'-._/-'-._ 
         /..   ____    \ 
        /' _  [<_->] )  \ 
       (  / \--\_>/-/'._ ) 
        \-;_/\__;__/ _/ _/ 
         '._}|==o==\{_\/ 
          /  /-._.--\  \_ 
         // /   /|   \ \ \ 
        / | |   | \;  |  \ \ 
       / /  | :/   \: \   \_\ 
      /  |  /.'|   /: |    \ \ 
      |  |  |--| . |--|     \_\ 
      / _/   \ | : | /___--._) \ 
     |_(---'-| >-'-| |       '-' 
            /_/     \_\
";

            textBox1.Text = superman;
            ButtonCancel.Visible = false;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (Form.ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}
