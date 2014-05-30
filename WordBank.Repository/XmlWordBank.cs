using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using WordBank.Repository.EventArg;
using WordBank.Repository.Interfaces;
using WordBank.Utility.Interfaces;

namespace WordBank.Repository
{
    public class XmlWordBank : IWordBank<WordAnswer>
    {
        public event EventHandler<WordBankEmptyEventArgs> IsEmpty;

        private readonly IXDocumentParser _xDocParser;

        public Dictionary<string, string> WordMap { get; set; }

        public Queue<WordAnswer> WordQueue { get;  set; }


        public XmlWordBank(IXDocumentParser xDocParser)
        {
            _xDocParser = xDocParser;
        }

        public void InitialiseWordBank(string resource)
        {
            XDocument xDoc = _xDocParser.ParseXDocument(resource);
            
            IEnumerable<string> wordCollection = QueryXDocForWords(xDoc);

            PopulateWordMap(wordCollection);
            InitialiseWordQueue();
        }

        private IEnumerable<string> QueryXDocForWords(XDocument xDoc)
        {
            IEnumerable<string> words = xDoc
                .Descendants("word")
                .Select(x => x.Value);

            return words;
        }

        private void PopulateWordMap(IEnumerable<string> words)
        {
            Dictionary<string, string> dictionary = words.
                    ToDictionary(q => q, question => string.Empty);

            WordMap = dictionary;
        }

        private void InitialiseWordQueue()
        {
            IEnumerable<WordAnswer> words = WordMap
                .Keys
                .Select((word, i) => new WordAnswer
                    (i + 1, word, string.Empty));
            
            WordQueue = new Queue<WordAnswer>(words);    
        }

        public WordAnswer GetWord()
        {
            WordAnswer wordAnswer = null;

            try
            {
                wordAnswer = WordQueue.Dequeue();
            }
            catch (InvalidOperationException)
            {
                OnIsEmpty(new WordBankEmptyEventArgs(WordMap));
            }
            return wordAnswer;
        }

        public void SubmitAnswer(WordAnswer wordAnswer)
        {
            if(wordAnswer != null && wordAnswer.Answer != null)
                WordMap[wordAnswer.Word] = wordAnswer.Answer;
        }

        protected virtual void OnIsEmpty(WordBankEmptyEventArgs e)
        {
            EventHandler<WordBankEmptyEventArgs> handler = IsEmpty;
            if (handler != null) handler(this, e);
        }
    }
}
