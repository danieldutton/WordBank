using System.Reflection;
using System.Resources;

namespace WordBank.IntegrationTests
{
    public static class Mother
    {
        public static ResourceManager GetWordBankRepositoryResourceManager()
        {
            Assembly localisationAssembly = Assembly.Load("WordBank.Repository");

            var rm = new ResourceManager("WordBank.Repository.Properties.Resources"
                , localisationAssembly);

            return rm;
        }
    }
}
