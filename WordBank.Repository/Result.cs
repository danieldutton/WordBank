using System.Collections.Generic;

namespace WordBank.Repository
{
    public class Result
    {   
        public Dictionary<string, string> WordMap { get; set; }
 
        public int TotalAnswered { get; set; }

        public int TotalCorrect { get; set; }

        public int TotalWrong { get; set; }
    }
}
