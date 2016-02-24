using System.ComponentModel;

namespace CFSqlCe.Winform.Base
{
    public partial class Repository : Component
    {
        public Repository()
        {
            InitializeComponent();
        }

        public Repository(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
