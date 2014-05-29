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

            var rm = ResourceLoader.GetRepositoryResourceManager();

            IWordBank<WordAnswer> wordBank = new XmlWordBank(xDocParser);
            wordBank.InitialiseWordBank(rm.GetString("words"));
            
            var speechSynthesizer = new SpeechSynthesizer
            {
                Volume = 100,
                Rate = -2,
            };

            Application.Run(new Console(wordBank, speechSynthesizer));
        }
    }
}
