using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rrhh.Migrations;
using Rrhh.Models;
using Rrhh.Views.Competences;
using Rrhh.Views.Shared;
using TheArtOfDev.HtmlRenderer.WinForms;

namespace Rrhh.Views.Resumes
{
    public partial class NewResume : BaseView
    {
        public Resume Resume { get; set; } = new Resume();

        public NewResume(RrhhContext context, ViewContext view)
        {
            InitializeComponent();
        }

        private void NewResume_Load(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            //var dialog = new CompetencesCrudMethods();
            //dialog.ShowDialog();

           // var crudMethods = new CompetencesCrudMethods(Context);

            //Resume.Competences.Add(dialog.NewBasicCompetence);
            RefreshData();
        }

        private void RefreshData()
        {
            competencesGrid.DataSource = new BindingSource {DataSource = Resume.Competences};
            languagesGrid.DataSource = Resume.Languages;
        }
    }
}
