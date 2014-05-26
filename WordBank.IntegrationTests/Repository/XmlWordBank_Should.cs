using NUnit.Framework;
using System.Resources;
using WordBank.Repository;

namespace WordBank.IntegrationTests.Repository
{
    [TestFixture]
    public class XmlWordBank_Should
    {
        private ResourceManager _resourceManager;

        private XmlWordBank _sut;

        [SetUp]
        public void Init()
        {
            _resourceManager = Mother.GetWordBankRepositoryResourceManager();
            _sut = new XmlWordBank();
        }

        [Test]
        public void LoadWords_InitialisePropertyWordMap()
        {

        }

        [TearDown]
        public void TearDown()
        {
            _resourceManager = null;
            _sut = null;
        }
    }
}
