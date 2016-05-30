using Rrhh.Migrations;

namespace Rrhh.Controllers
{
    public class HomeController
    {
        public HomePresenter Presenter { get; }
        public RrhhContext Context { get; }

        public HomeController(RrhhContext context = null)
        {
            Context = context?? new RrhhContext();
            Presenter = new HomePresenter(Context);
        }
    }

    public class HomePresenter
    {
        public RrhhContext Context { get; }

        public HomePresenter(RrhhContext context)
        {
            Context = context;
        }
    }
}
