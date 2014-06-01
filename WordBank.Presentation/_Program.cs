using System;
using System.Speech.Synthesis;
using System.Windows.Forms;
using WordBank.Repository;
using WordBank.Repository.Interfaces;
using WordBank.Utility;
using WordBank.Utility.Interfaces;

namespace WordBank.Presentation
{
    static class _Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

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
    }
}
