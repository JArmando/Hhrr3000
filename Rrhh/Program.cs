using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Rrhh.Controllers;
using Rrhh.Migrations;
using Rrhh.Views.Home;
using Rrhh.Views.Shared;

namespace Rrhh
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new NewJobOffer());
            Application.Run(new HomeView(
                new HomeController(new RrhhContext()), 
                new ViewContext
                {
                    Errors = new List<string>(), Notices = new List<string>()
                }));
        }
    }
}
