using System.Speech.Synthesis;
using WordBank.Speech.Interfaces;

namespace WordBank.Speech
{
    public class SpellingsAnnouncer : ISpellingsAnnouncer
    {
        private SpeechSynthesizer _speechSynthesizer = new SpeechSynthesizer();

        public void Speak(string spelling)
        {
            var synthesizer = new SpeechSynthesizer {Volume = 100, Rate = -2};

            // Synchronous
            synthesizer.Speak("Hello World");

            // Asynchronous
            synthesizer.SpeakAsync(spelling);    
        }
    }
}
