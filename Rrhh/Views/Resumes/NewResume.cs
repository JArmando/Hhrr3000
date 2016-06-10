using System;
using System.Linq;
using System.Windows.Forms;
using Rrhh.Migrations;
using Rrhh.Models;
using Rrhh.Views.Competences;
using Rrhh.Views.Languages;
using Rrhh.Views.Shared;

namespace Rrhh.Views.Resumes
{
    public partial class NewResume : BaseView
    {
        public Resume Resume { get; set; }
        private RrhhContext dataContext;
        public NewResume(RrhhContext context, ViewContext viewContext, Resume resume)
        {
            InitializeComponent();
            ViewContext = viewContext;
            dataContext = context;
            Resume = resume ?? new Resume();
            RefreshData();
        }

        private void NewResume_Load(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            //var dialog = new CompetencesCrudViews();
            //dialog.ShowDialog();

           // var CrudViews = new CompetencesCrudViews(DataContext);

            //Resume.Competences.Add(dialog.NewBasicCompetence);
            var source = new BindingSource { DataSource = dataContext.Competences.ToList() };
            var crud = new CompetencesCrudViews(dataContext, ViewContext);
            var dialog = new RowSelector(source, crud);
            dialog.ShowDialog();
            Resume.Competences.Add(dialog.SelectedItem as BasicCompetence);
            RefreshData();
        }

        private void RefreshData()
        {
            competencesGrid.DataSource = new BindingSource {DataSource = Resume.Competences};
            languagesGrid.DataSource = Resume.Languages;
        }

        private void AddLangBtn_Click(object sender, EventArgs e)
        {
            var source = new BindingSource { DataSource = dataContext.Languages.ToList() };
            var crud = new LanguagesCrudViews(dataContext, ViewContext);
            var dialog = new RowSelector(source, crud);
            dialog.ShowDialog();
            Resume.Languages.Add(dialog.SelectedItem as Language);
            RefreshData();
        }
    }
}
