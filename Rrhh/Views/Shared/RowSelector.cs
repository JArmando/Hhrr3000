using System;
using System.Windows.Forms;

namespace Rrhh.Views.Shared
{
    public partial class RowSelector : Form
    {
        private readonly BindingSource BindingSource;
        public Object SelectedItem;
        public RowSelector(BindingSource bindingSource)
        {
            InitializeComponent();
            BindingSource = bindingSource;
            LoadData();
        }

        private void LoadData()
        {
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.DataSource = BindingSource;
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
            SelectedItem = dataGridView.SelectedRows[0].DataBoundItem;
        }
    }
}
