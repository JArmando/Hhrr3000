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
using Rrhh.Views.Competences;
using TheArtOfDev.HtmlRenderer.WinForms;

namespace Rrhh.Views.Resumes
{
    public partial class NewResume : Form
    {
        public Resume Resume { get; set; }

        public NewResume(Resume resume = null)
        {
            InitializeComponent();
            Resume = resume?? new Resume();
            RefreshData();
        }

        private void NewResume_Load(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            var dialog = new NewCompetence();
            dialog.ShowDialog(this);
            Resume.Competences.Add(dialog.NewBasicCompetence);
            RefreshData();
        }

        private void RefreshData()
        {
            competencesGrid.DataSource = Resume.Competences;
            languagesGrid.DataSource = Resume.Languages;
        }
    }
}
