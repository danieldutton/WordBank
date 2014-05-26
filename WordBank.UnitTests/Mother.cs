using System.Collections.Generic;

namespace WordBank.UnitTests
{
    public static class Mother
    {
        public static List<string> ExpectedWordsOrder()
        {
            var WordsList = new List<string>
            {
                "Word1", "Word2", "Word3", "Word4", "Word5",
                "Word6", "Word7", "Word8", "Word9", "Word10",
            };

            return WordsList;
        } 
    }
}
