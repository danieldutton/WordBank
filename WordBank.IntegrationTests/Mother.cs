using System.Collections.Generic;

namespace WordBank.IntegrationTests
{
    public static class Mother
    {
        public static List<string> ExpectedWordKeySequence()
        {
            var wordList = new List<string>
            {
                "word1", "word2", "word3", "word4", "word5",
                "word6", "word7", "word8", "word9", "word10",
            };

            return wordList;
        }

        public static List<int> ExpectedIdSequence()
        {
            var idList = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            return idList;
        }
    }
}
