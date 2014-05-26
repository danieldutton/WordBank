using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using WordBank.Repository.EventArg;
using WordBank.Repository.Interfaces;

namespace WordBank.Repository
{
    public class XmlWordBank : IWordBank<Word>
    {
        public event EventHandler<WordBankEmptyEventArgs> IsEmpty;

        public Dictionary<string, string> WordMap { get; set; }

        public Queue<Word> SpellingsQueue { get; set; } 

        public XmlWordBank()
        {
            LoadWords(Properties.Resources.words);
        }

        public Dictionary<string, string> LoadWords(string xmlResource)
        {
            XDocument xDoc = XDocument.Parse(Properties.Resources.words);
            
            IEnumerable<string> questions = xDoc.Descendants("word")
                .Select(x => x.Value);

            var dic = questions.ToDictionary(question => question, question => string.Empty);

            WordMap = dic;

            IEnumerable<Word> words = dic.Keys.Select((word, i) => new Word
            {
                Id = i + 1,
                Text = word,
                Answer = string.Empty,
            });

            SpellingsQueue = new Queue<Word>(words);

            return dic;
        }

        public void Update(Word word)
        {
            if(word != null && word.Answer != null)
                WordMap[word.Text] = word.Answer;
        }
        
        public Word GetWord()
        {
            Word word = null;

            try
            {
                word = SpellingsQueue.Dequeue();
            }
            catch (InvalidOperationException)
            {
                OnIsEmpty(new WordBankEmptyEventArgs(WordMap));
            }
            return word;
        }

        protected virtual void OnIsEmpty(WordBankEmptyEventArgs e)
        {
            EventHandler<WordBankEmptyEventArgs> handler = IsEmpty;
            if (handler != null) handler(this, e);
        }
    }
}
