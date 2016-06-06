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
            var selectedItem = ModelsList.SelectedRows[0].DataBoundItem as BaseModel;
            var result = _crudMethods.Edit(selectedItem);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            var selectedItem = ModelsList.SelectedRows[0].DataBoundItem as BaseModel;
            var result = _crudMethods.Delete(selectedItem);
            //processResult(result);
        }

        private void createNewButton_Click(object sender, EventArgs e)
        {
            var result = _crudMethods.Create();
        }

        private void LoadData()
        {
            ModelsList.DataSource = _bindingSource;
        }
    }
}
