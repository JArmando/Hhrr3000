using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rrhh.Properties;
using Rrhh.Views;
using Rrhh.Views.Candidates;
using Rrhh.Views.JobOffers;
using Rrhh.Views.Resumes;

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
            Application.Run(new NewCandidate());
        }
    }
}
