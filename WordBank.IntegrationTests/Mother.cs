using System.Collections.Generic;
using System.Reflection;
using System.Resources;

namespace WordBank.IntegrationTests
{
    public static class Mother
    {
        public static ResourceManager GetRepositoryResourceManager()
        {
            Assembly localisationAssembly = Assembly.Load("WordBank.Repository");

            var resMan = new ResourceManager("WordBank.Repository.Properties.Resources"
                , localisationAssembly);

            return resMan;
        }

        public static List<string> ExpectedWordKeySequence()
        {
            var WordsList = new List<string>
            {
                "word1", "word2", "word3", "word4", "word5",
                "word6", "word7", "word8", "word9", "word10",
            };

            return WordsList;
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
