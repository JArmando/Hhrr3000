using System;
using System.Windows.Forms;
using Rrhh.Models;
using Rrhh.Presenters;
using Rrhh.Views.Candidates;

namespace Rrhh.Views.Shared
{
    public partial class CrudModels : BaseView
    {
        private readonly BindingSource _bindingSource;
        private readonly CrudMethods _crudMethods;

        public CrudModels(ViewContext viewContext, BindingSource source, CrudMethods crudMethods )
        {
            InitializeComponent();
            _crudMethods = crudMethods;
            ViewContext = viewContext;
            _bindingSource = source;
            LoadData();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = ModelsList.SelectedRows[0].DataBoundItem;
            if (selectedItem is PresentedModel)
            {
                _crudMethods.Edit((selectedItem as PresentedModel).UnWrappModel());
            }
            else
            {
                _crudMethods.Edit(selectedItem as BaseModel);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = ModelsList.SelectedRows[0].DataBoundItem;
            if (selectedItem is PresentedModel)
            {
                _crudMethods.Delete((selectedItem as PresentedModel).UnWrappModel());
            }
            else
            {
                _crudMethods.Delete(selectedItem as BaseModel);
            }
            //processResult(result);
        }

        private void createNewButton_Click(object sender, EventArgs e)
        {
            _crudMethods.Create();
        }

        private void LoadData()
        {
            ModelsList.DataSource = _bindingSource;
        }
    }
}
