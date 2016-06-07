using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Rrhh.Models;

namespace Rrhh.Views.Shared
{
    public class BaseView : Form
    {
        internal ViewContext ViewContext;

        public BaseView()
        {
        }

        internal BaseView(ViewContext viewContext)
        {
            ViewContext = viewContext?? new ViewContext { Errors = new List<string>(), Notices = new List<string>()};
        }
    }

    public class ViewContext
    {
        public List<string> Errors { get; set; }
        public List<string> Notices { get; set; }
        public Action<List<string>> Notifier;
        public void AddErrors(BaseModel model)
        {
            if (model != null) Errors.AddRange(model.Errors.Select(x => x.ErrorMessage));
            Notifier(Errors);
        }

        public void AddErrors(string message)
        {
            Errors.Add(message);
            Notifier(Errors);
        }

        public string stringyErrors()
        {
            return string.Join("\n", Errors);
        }

        public void Clear()
        {
            Errors = new List<string>();
            Notices = new List<string>();
        }
    }

}
