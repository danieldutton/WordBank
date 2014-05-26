using System;
using System.Collections.Generic;
using WordBank.Repository.EventArg;

namespace WordBank.Repository.Interfaces
{
    public interface IWordBank<TValue>
    {
        event EventHandler<EmptyEventArgs> IsEmpty;

        Dictionary<string, string> WordMap { get; set; }

        TValue GetWord();

        void Update(TValue value);
    }
}
