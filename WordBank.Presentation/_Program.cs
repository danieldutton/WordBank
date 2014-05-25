using System;
using System.Windows.Forms;
using WordBank.Speech;

namespace WordBank.Presentation
{
    static class _Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Results(new SpellingsAnnouncer()));
        }
    }
}
