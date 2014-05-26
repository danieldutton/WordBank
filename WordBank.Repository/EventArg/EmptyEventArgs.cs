using System;
using System.Collections.Generic;

namespace WordBank.Repository.EventArg
{
    public class EmptyEventArgs : EventArgs
    {
        public Dictionary<string, string> WordMap { get; private set; }


        public EmptyEventArgs(Dictionary<string, string> wordMap)
        {
            WordMap = wordMap;
        }
    }
}
