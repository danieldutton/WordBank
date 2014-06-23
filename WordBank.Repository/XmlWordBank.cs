using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using WordBank.Repository.EventArg;
using WordBank.Repository.Interfaces;
using WordBank.Utility.Interfaces;

namespace WordBank.Repository
{
    public class XmlWordBank : IWordBank<Question>
    {
        public event EventHandler<WordBankEmptyEventArgs> IsEmpty;

        private readonly IXDocumentParser _xDocParser;

        public Dictionary<string, string> WordMap { get; set; }

        public Queue<Question> WordQueue { get;  set; }


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
            IEnumerable<Question> words = WordMap
                .Keys
                .Select((word, i) => new Question
                    (i + 1, word, string.Empty));
            
            WordQueue = new Queue<Question>(words);
    
            if(WordQueue.Count == 0)
                throw new InvalidDataException();                
        }

        public Question GetQuestion()
        {
            Question question = null;

            try
            {
                question = WordQueue.Dequeue();
            }
            catch (InvalidOperationException)
            {
                OnIsEmpty(new WordBankEmptyEventArgs(WordMap));
            }
            return question;
        }

        public void SubmitAnswer(Question question)
        {
            if(question != null && question.Answer != null)
                WordMap[question.Word] = question.Answer;
        }

        protected virtual void OnIsEmpty(WordBankEmptyEventArgs e)
        {
            EventHandler<WordBankEmptyEventArgs> handler = IsEmpty;
            if (handler != null) handler(this, e);
        }
    }
}
