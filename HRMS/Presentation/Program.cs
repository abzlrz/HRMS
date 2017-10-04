using Presentation.DialogBox;
using Presentation.DialogBox.ExternalApplicationForm;
using Presentation.DialogBox.ExternalApplication;
using System;
using System.Windows.Forms;
using Presentation.Maintenance;
using Presentation.Miscellaneous;
using Presentation.Modules;

namespace Presentation
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
            Application.Run(new FormLogin());
        }
    }
}
