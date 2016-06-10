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

namespace Rrhh.Views.Competences
{
    public partial class EditCompetence : BaseView
    {
        public Competence Model;
        public EditCompetence(Competence competence)
        {
            InitializeComponent();
            Model = competence;
            LoadData();
        }

        private void SaveChangesBtn_Click(object sender, EventArgs e)
        {
            Model.Name = NameTxtBox.Text;
            Model.Description = NameTxtBox.Text;
            Close();
        }

        private void LoadData()
        {
            NameTxtBox.Text = Model.Name;
            DescriptionTxtBox.Text = Model.Description;
        }
    }
}
