using System;
using System.Collections.Generic;
using WordBank.Repository.EventArg;

namespace WordBank.Repository.Interfaces
{
    public interface IWordBank<TValue>
    {
        event EventHandler<WordBankEmptyEventArgs> IsEmpty;

        Dictionary<string, string> WordMap { get; set; }

        Queue<Question> WordQueue { get; set; }

        void InitialiseWordBank(string resource);

        TValue GetQuestion();

        void SubmitAnswer(TValue question);
    }
}
