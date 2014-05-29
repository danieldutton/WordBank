using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using WordBank.Repository;
using WordBank.Utility;

namespace WordBank.IntegrationTests.Repository
{
    [TestFixture]
    public class XmlWordBank_Should
    {
        private ResourceManager _resourceManager;

        private string _xmlResource;

        private XDocumentParser _xDocumentParser;

        private XmlWordBank _sut;

        [SetUp]
        public void Init()
        {
            _resourceManager = Mother.GetRepositoryResourceManager();
            _xmlResource = _resourceManager.GetString("words_test");
            _xDocumentParser = new XDocumentParser();
            _sut = new XmlWordBank(_xDocumentParser);
        }

        [Test]
        public void InitialiseWordBank_GivePropertyWordMap_10KeyValues()
        {
            _sut.InitialiseWordBank(_xmlResource);

            Dictionary<string, string> result = _sut.WordMap;

            Assert.AreEqual(10, result.Count);
        }

        [Test]
        public void InitialiseWordBank_GivePropertyWordMapTheCorrectKeyValues()
        {
            _sut.InitialiseWordBank(_xmlResource);

            Dictionary<string, string> result = _sut.WordMap;

            CollectionAssert.AreEqual(Mother.ExpectedWordMap(), result);
        }

        [Test]
        public void InitialiseWordBank_GivePropertyWordQueue_10WordAnswerItems()
        {
            _sut.InitialiseWordBank(_xmlResource);

            Queue<WordAnswer> result = _sut.WordQueue;

            Assert.AreEqual(10, result.Count);
        }

        [Test]
        public void InitialiseWordBank_WithCorrectSequenceOfWords_Word1()
        {
            _sut.InitialiseWordBank(_xmlResource);

            Queue<WordAnswer> result = _sut.WordQueue;

            CollectionAssert.AreEqual(Mother.ExpectedWordQueue(), result);
        }

        [Test]
        public void InitialiseWordBank_WordAnswerContainTheCorrectId()
        {
            _sut.InitialiseWordBank(_xmlResource);

            var result = _sut.WordQueue.ToList();
        }

        [Test]
        public void InitialiseWordBank_WordAnswerContainTheCorrectText()
        {
            
        }

        [Test]
        public void InitialiseWordBank_WordAnswersAnswerStringEmptyByDefault()
        {
            
        }
        
        //consider not tearing down xmlresource load to save time
        [TearDown]
        public void TearDown()
        {
            _resourceManager = null;
            _xmlResource = null;
            _xDocumentParser = null;
            _sut = null;
        }
    }
}
