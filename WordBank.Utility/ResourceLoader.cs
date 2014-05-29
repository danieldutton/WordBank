using System.Reflection;
using System.Resources;

namespace WordBank.Utility
{
    public static class ResourceLoader
    {
        public static ResourceManager GetRepositoryResourceManager()
        {
            Assembly localisationAssembly = Assembly.Load("WordBank.Repository");

            var resMan = new ResourceManager("WordBank.Repository.Properties.Resources"
                , localisationAssembly);

            return resMan;
        }
    }
}
