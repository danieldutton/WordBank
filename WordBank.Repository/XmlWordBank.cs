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
        public event EventHandler<EmptyEventArgs> IsEmpty;

        public Dictionary<string, string> WordMap { get; set; }

        public Queue<Word> SpellingsQueue { get; set; } 

        public XmlWordBank()
        {
            LoadSpellings();
        }

        public Dictionary<string, string> LoadSpellings()
        {
            XDocument xDoc = XDocument.Parse(Properties.Resources.words);
            
            IEnumerable<string> questions = xDoc.Descendants("word")
                .Select(x => x.Value);

            var dic = questions.ToDictionary(question => question, question => string.Empty);

            WordMap = dic;

            var sl = dic.Keys.Select((x, i) => new Word
            {
                Id = i + 1,
                Text = x,
                Answer = string.Empty,
            });

            SpellingsQueue = new Queue<Word>(sl);

            return dic;
        }

        public void Update(Word word)
        {
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
                OnIsEmpty(new EmptyEventArgs(WordMap));
            }
            return word;
        }

        protected virtual void OnIsEmpty(EmptyEventArgs e)
        {
            EventHandler<EmptyEventArgs> handler = IsEmpty;
            if (handler != null) handler(this, e);
        }

    }
}
