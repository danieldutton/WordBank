using System;
using System.Collections.Generic;
using System.Linq;
using WordBank.Repository;

namespace WordBank.Presentation.ExtMethods
{
    public static class WordMapExtensions
    {
        public static List<Question> ToQuestionList(this Dictionary<string, string> dic)
        {
            if(dic == null) throw new ArgumentNullException("dic");

            List<Question> questions = dic
                .Select((word, i) => new Question(i + 1, word.Key, word.Value))
                .ToList();

            return questions;
        }
    }
}
