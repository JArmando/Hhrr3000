using System;
using System.Windows.Forms;
using Rrhh.Models;

namespace Rrhh.Views.Competences
{
    public partial class NewCompetence : Form
    {
        public BasicCompetence Model { get; set; }

        public NewCompetence()
        {
            InitializeComponent();
        }

        private void AddCompetenceBtn_Click(object sender, EventArgs e)
        {
            Model = new BasicCompetence
            {
                Name = NameTxtBox.Text,
                Description = DescriptionTxtBox.Text
            };
            Close();
        }
    }
}
