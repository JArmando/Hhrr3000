using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rrhh.Models;
using Rrhh.Views.Shared;

namespace Rrhh.Views.Languages
{
    public partial class NewLanguage : BaseView
    {
        public Language Model = new Language();
        public NewLanguage(ViewContext viewContext) : base(viewContext)
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model.Name = NameTxtBox.Text;
            Model.Level = (int)LevelTxBox.Value;
            Close();
        }
    }
}
