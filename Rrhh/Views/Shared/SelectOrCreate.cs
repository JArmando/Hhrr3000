using System;
using System.Windows.Forms;

namespace Rrhh.Views.Shared
{
    public partial class SelectOrCreate : BaseView
    {
        public SelectOrCreate(ViewContext viewContext, BindingSource bindingSource, BaseView creationView) : base(viewContext)
        {
            InitializeComponent();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
