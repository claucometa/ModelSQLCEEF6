using System;
using System.Windows.Forms;

namespace CFSqlCe.Winform.Base
{
    public partial class NavButton : UserControl
    {
        public new event EventHandler Click;
        public static Button LastClicked;

        string capt;
        public string Caption 
        {
            set 
            {
                capt = value;
                button1.Text = value;
            }
            get
            {
                return capt;
            }
        }

        public NavButton()
        {
            InitializeComponent();
            button1.Click += button1_Click;
            button1.ImageList = MyImages.MenuIcons;            
        }

        public Button Btt
        {
            get
            {
                return button1;
            }
        }

        public static void Activate(Button last)
        {
            if (LastClicked != null) LastClicked.FlatStyle = FlatStyle.Standard;            
            LastClicked = last;
            LastClicked.FlatStyle = FlatStyle.Flat;
            LastClicked.Focus();
        }

        void button1_Click(object sender, EventArgs e)
        {
            Activate(button1);
            if (Click != null) Click(button1, e);
        }
        
        public NavButton(int i) : this()
        {
            button1.ImageIndex = i;
        }

        internal void PerformClick()
        {
            Activate(button1);            
            if (Click != null) Click(button1, null);
        }
    }

    public enum NavIcons
    {
        Patient,
        Lab,
        Graph, 
        Close
    }
}
