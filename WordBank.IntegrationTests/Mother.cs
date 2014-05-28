using System.Collections.Generic;
using System.Reflection;
using System.Resources;
using WordBank.Repository.Model;

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

        public static List<string> ExpectedWordSequence()
        {
            var WordsList = new List<string>
            {
                "Word1", "Word2", "Word3", "Word4", "Word5",
                "Word6", "Word7", "Word8", "Word9", "Word10",
            };

            return WordsList;
        }

        public static Queue<WordAnswer> ExpectedWordQueue()
        {
            var worddQueue = new Queue<WordAnswer>();

            worddQueue.Enqueue(new WordAnswer(1, "word1", string.Empty));
            worddQueue.Enqueue(new WordAnswer(2, "word2", string.Empty));
            worddQueue.Enqueue(new WordAnswer(3, "word3", string.Empty));
            worddQueue.Enqueue(new WordAnswer(4, "word4", string.Empty));
            worddQueue.Enqueue(new WordAnswer(5, "word5", string.Empty));
            worddQueue.Enqueue(new WordAnswer(6, "word6", string.Empty));
            worddQueue.Enqueue(new WordAnswer(7, "word7", string.Empty));
            worddQueue.Enqueue(new WordAnswer(8, "word8", string.Empty));
            worddQueue.Enqueue(new WordAnswer(9, "word9", string.Empty));
            worddQueue.Enqueue(new WordAnswer(10, "word10", string.Empty));

            return worddQueue;
        }  

        public static Dictionary<string, string> ExpectedWordMap()
        {
            var dic = new Dictionary<string, string>
            {
                {"Word1", string.Empty}, {"Word2", string.Empty},
                {"Word3", string.Empty}, {"Word4", string.Empty},
                {"Word5", string.Empty}, {"Word6", string.Empty},
                {"Word7", string.Empty}, {"Word8", string.Empty},
                {"Word9", string.Empty}, {"Word10", string.Empty},
            };

            return dic;
        } 
    }
}
