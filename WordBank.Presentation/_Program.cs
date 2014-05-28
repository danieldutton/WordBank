using System;
using System.Speech.Synthesis;
using System.Windows.Forms;
using WordBank.Repository;
using WordBank.Repository.Interfaces;
using WordBank.Repository.Model;

namespace WordBank.Presentation
{
    static class _Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            IWordBank<WordAnswer> wordBank = new XmlWordBank();

            var speechSynthesizer = new SpeechSynthesizer
            {
                Volume = 100,
                Rate = -2,
            };

            Application.Run(new Console(wordBank, speechSynthesizer));
        }
    }
}
