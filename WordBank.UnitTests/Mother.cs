using System.Collections.Generic;

namespace WordBank.UnitTests
{
    public static class Mother
    {
        public static List<string> ExpectedSpellingsOrder()
        {
            var spellingsList = new List<string>
            {
                "Spelling1", "Spelling2", "Spelling3", "Spelling4", "Spelling5",
                "Spelling6", "Spelling7", "Spelling8", "Spelling9", "Spelling10",
            };

            return spellingsList;
        } 
    }
}
