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

namespace Rrhh.Views.Competences
{
    public partial class NewCompetence : Form
    {
        public BasicCompetence NewBasicCompetence { get; set; }

        public NewCompetence()
        {
            InitializeComponent();
        }

        private void AddCompetenceBtn_Click(object sender, EventArgs e)
        {
            NewBasicCompetence = new BasicCompetence
            {
                Name = NameTxtBox.Text,
                Description = DescriptionTxtBox.Text
            };
            Close();
        }
    }
}
