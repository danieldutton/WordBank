using System;
using System.Collections.Generic;

namespace WordBank.Repository.EventArg
{
    public sealed class WordBankEmptyEventArgs : EventArgs
    {
        public Dictionary<string, string> WordMap { get; private set; }

        public WordBankEmptyEventArgs(Dictionary<string, string> wordMap)
        {
            WordMap = wordMap;
        }
    }
}
