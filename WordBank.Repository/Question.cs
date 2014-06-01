using System;

namespace WordBank.Repository
{    
    public sealed class Question
    {
        public int Id { get; private  set; }

        public string Word { get; private  set; }

        public string Answer { get; set; }

        public bool IsCorrect
        {
            get
            {
                return Word.Equals(Answer,
                StringComparison.InvariantCultureIgnoreCase);
            }
        }

        public Question(int id, string word, string answer)
        {
            Id = id;
            Word = word;
            Answer = answer == string.Empty ? "Answer not given" : answer;
        }

        public override string ToString()
        {
            return string.Format("[{0}] Id:{1} Word:{2} Answer:{3}",
                GetType().Name, Id, Word, Answer);
        }
    }
}
