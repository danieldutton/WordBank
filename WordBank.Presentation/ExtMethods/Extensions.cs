using System;
using System.Collections.Generic;
using System.Linq;
using WordBank.Repository;

namespace WordBank.Presentation.ExtMethods
{
    public static class Extensions
    {
        public static List<Question> ToQuestionList(this Dictionary<string, string> dic)
        {
            if(dic == null) throw new ArgumentNullException("dic");

            List<Question> questions = dic
                .Select((word, i) => new Question(i, word.Key, word.Value))
                .ToList();

            return questions;
        }
    }
}
