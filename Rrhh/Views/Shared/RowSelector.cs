using System;
using System.Windows.Forms;
using Rrhh.Views.Candidates;

namespace Rrhh.Views.Shared
{
    public partial class RowSelector : Form
    {
        private readonly BindingSource BindingSource;
        private readonly CrudViews _crudViews;
        public Object SelectedItem;

        public RowSelector(BindingSource bindingSource, CrudViews crudViews)
        {
            InitializeComponent();
            BindingSource = bindingSource;
            _crudViews = crudViews;
            LoadData();
        }

        private void LoadData()
        {
            dataGridView.DataSource = BindingSource;
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            SelectedItem = dataGridView.SelectedRows[0].DataBoundItem;
            Close();
        }

        private void CreateNewBtn_Click(object sender, EventArgs e)
        {
            SelectedItem = _crudViews.Create();
            Close();
        }
    }
}
