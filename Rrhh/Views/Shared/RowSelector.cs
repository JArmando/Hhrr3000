using System;
using System.Windows.Forms;
using Rrhh.Views.Candidates;

namespace Rrhh.Views.Shared
{
    public partial class RowSelector : Form
    {
        private readonly BindingSource BindingSource;
        private readonly CrudMethods CrudMethods;
        public Object SelectedItem;

        public RowSelector(BindingSource bindingSource, CrudMethods crudMethods)
        {
            InitializeComponent();
            BindingSource = bindingSource;
            CrudMethods = crudMethods;
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
            SelectedItem = CrudMethods.Create();
            Close();
        }
    }
}
