using System;
using System.Collections.Generic;
using WordBank.Repository.EventArg;

namespace WordBank.Repository.Interfaces
{
    public interface IWordBank<TValue>
    {
        event EventHandler<WordBankEmptyEventArgs> IsEmpty;

        Dictionary<string, string> WordMap { get; set; }

        void InitialiseWordBank(string resource);

        TValue GetWord();

        void SubmitAnswer(TValue question);
    }
}
