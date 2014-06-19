using System;
using System.Speech.Synthesis;
using System.Windows.Forms;
using WordBank.Repository;
using WordBank.Repository.Interfaces;
using WordBank.Utility;
using WordBank.Utility.Interfaces;

namespace WordBank.Presentation
{
    internal static class Program
    {
        [STAThread]
        internal static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += GlobalExceptionHandler;
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            AppDomain.CurrentDomain.UnhandledException += GlobalExceptionHandler;

            IXDocumentParser xDocParser = new XDocumentParser();

            IWordBank<Question> wordBank = new XmlWordBank(xDocParser);
            wordBank.InitialiseWordBank(Repository.Properties.Resources.wordsDefault);
            
            var speechSynthesizer = new SpeechSynthesizer
            {
                Volume = 100,
                Rate = -2,
            };

            Application.Run(new TestConsole(wordBank, speechSynthesizer));
        }

        private static void GlobalExceptionHandler(object sender, System.EventArgs args)
        {
            MessageBox.Show("There was a problem with the application.  Please restart and try again");
            
            Application.Exit();
        }
    }
}
