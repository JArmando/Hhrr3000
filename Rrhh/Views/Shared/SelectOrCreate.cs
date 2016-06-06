using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
