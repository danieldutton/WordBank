using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace WordBank.QuestionBank
{
    public class SpellingsBank
    {
        public event EventHandler<EventArgs> SpellingsEmpty; 

        private SortedDictionary<string, string> Spellings { get; set; }

        public SpellingsBank()
        {
            
        }

        public SortedDictionary<string, string> LoadSpellings()
        {
            XDocument xDoc = XDocument.Parse(Properties.Resources.words);
            
            //extract all spellings
            IEnumerable<string> questions = xDoc.Descendants("word")
                .Select(x => x.Value);

            //initialise dictionary with words as key - //leave values as string.Empty
            var dic = new SortedDictionary<string, string>();
            
            foreach (string question in questions)
                dic.Add(question, string.Empty);

            //init the spellings property
            Spellings = dic;

            //return the dictionary
            return dic;
        }

        public Spelling GetSpelling(int key)
        {
            //add some boundary checking
            if(key < 0) throw new ArgumentOutOfRangeException("key");

            KeyValuePair<string, string> result = Spellings
                .ElementAt(key);

            var spel = new Spelling
            {
                Id = key,
                Word = result.Key,
                Answer = result.Value,
            };
            return spel;
        }

        public void SubmitAnswer(Spelling spelling)
        {
            var newEntry = new KeyValuePair<string, string>(spelling.Word, spelling.Answer);

            Spellings[spelling.Word] = newEntry;

            actual.Value = spelling.Word;
        }
    }
}
