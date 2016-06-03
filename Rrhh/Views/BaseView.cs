using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rrhh.Models;

namespace Rrhh.Views
{
    public class BaseView : Form
    {
        public ViewContext ViewContext = new ViewContext {Errors = new List<string>(), Notices = new List<string>()};
    }
    public class ViewContext
    {
        public List<string> Errors { get; set; }
        public List<string> Notices { get; set; }

        public void AddErrors(BaseModel model)
        {
            Errors.AddRange(model.Errors.Select(x => x.ErrorMessage));
        }

        public void Clear()
        {
            Errors = new List<string>();
            Notices = new List<string>();
        }
    }

}
