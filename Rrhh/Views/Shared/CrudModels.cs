using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Rrhh.Models;
using Rrhh.Presenters;
using Rrhh.Views.Candidates;

namespace Rrhh.Views.Shared
{
    public partial class CrudModels : BaseView
    {
        private BindingSource _bindingSource;
        private Func<string, IEnumerable<PresentedModel>> Filter { get; }
        private readonly CrudViews _crudViews;

        public CrudModels(ViewContext viewContext, BindingSource source, CrudViews crudViews, Func<string, IEnumerable<PresentedModel>> filter  )
        {
            InitializeComponent();
            _crudViews = crudViews;
            ViewContext = viewContext;
            _bindingSource = source;
            Filter = filter;
            LoadData();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = ModelsList.SelectedRows[0].DataBoundItem;
            if (selectedItem is PresentedModel)
            {
                _crudViews.Edit((selectedItem as PresentedModel).UnWrappModel());
            }
            else
            {
                _crudViews.Edit(selectedItem as BaseModel);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = ModelsList.SelectedRows[0].DataBoundItem;
            if (selectedItem is PresentedModel)
            {
                _crudViews.Delete((selectedItem as PresentedModel).UnWrappModel());
            }
            else
            {
                _crudViews.Delete(selectedItem as BaseModel);
            }
        }

        private void createNewButton_Click(object sender, EventArgs e)
        {
            _crudViews.Create();
        }

        private void LoadData()
        {
            ModelsList.DataSource = _bindingSource;

            if (_crudViews.EspecialActionName != null)
            {
                SpecialActionBtn.Visible = true;
                SpecialActionBtn.Text = _crudViews.EspecialActionName;
            }
        }

        private void SpecialActionBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = ModelsList.SelectedRows[0].DataBoundItem;
            if (selectedItem is PresentedModel)
            {
                _crudViews.EspecialAction((selectedItem as PresentedModel).UnWrappModel());
            }
            else
            {
                _crudViews.EspecialAction(selectedItem as BaseModel);
            }

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (Filter != null)
            {
                _bindingSource = new BindingSource {DataSource = Filter(SearchTxtBox.Text)};
                LoadData();
            }
            else
            {
                ViewContext.AddErrors("Filter not available");
            }
    }
    }
}
