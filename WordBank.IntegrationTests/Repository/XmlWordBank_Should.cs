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
        public void InitialiseWordBank_InitPropertyWordMap_With10Items()
        {
            _sut.InitialiseWordBank(_xmlResource);
            Dictionary<string, string> wMap = _sut.WordMap;

            Assert.AreEqual(10, wMap.Count);
        }

        [Test]
        public void InitialiseWordBank_InitPropertyWordMap_WithKeySequence()
        {
            _sut.InitialiseWordBank(_xmlResource);
            List<string> keyList = _sut.WordMap.Select(x => x.Key).ToList();

            Assert.AreEqual(Mother.ExpectedWordKeySequence(), keyList);
        }

        [Test]
        public void InitialiseWordBank_InitPropertyWordMap_WithCorrectValueSequence()
        {
            _sut.InitialiseWordBank(_xmlResource);
            List<string> valueList = _sut.WordMap.Select(x => x.Value).ToList();

            Assert.IsTrue(valueList.TrueForAll(y => y.Equals(string.Empty)));
        }

        [Test]
        public void InitialiseWordBank_InitPropertyWordQueue_With10Items()
        {
            _sut.InitialiseWordBank(_xmlResource);
            Queue<WordAnswer> wordQueue = _sut.WordQueue;

            Assert.AreEqual(10, wordQueue.Count);
            CollectionAssert.AllItemsAreInstancesOfType(wordQueue, typeof(WordAnswer));
        }

        [Test]
        public void InitialiseWordBank_InitPropertyWordQueue_WithCorrectIdSequence()
        {
            _sut.InitialiseWordBank(_xmlResource);
            List<int> idList = _sut.WordQueue.Select(x => x.Id).ToList();

            Assert.AreEqual(Mother.ExpectedIdSequence(), idList);
        }

        [Test]
        public void InitialiseWordBank_InitPropertyWordQueue_WithCorrectTextSequence()
        {
            _sut.InitialiseWordBank(_xmlResource);
            List<string> wordList = _sut.WordQueue.Select(x => x.Word).ToList();

            Assert.AreEqual(Mother.ExpectedWordKeySequence(), wordList);
        }

        [Test]
        public void InitialiseWordBank_InitPropertyWordQueue_WithCorrectAnswerSequence()
        {
            _sut.InitialiseWordBank(_xmlResource);
            List<string> answerList = _sut.WordQueue.Select(x => x.Answer).ToList();

            Assert.IsTrue(answerList.All(x => x == string.Empty));
        }

        //sample of 5
        [Test]
        public void GetWord_ReturnOneWordAnswer_WithCorrectIdFor_FirstWord()
        {
            _sut.InitialiseWordBank(_xmlResource);
            WordAnswer result = _sut.GetWord();

            Assert.AreEqual(1, result.Id);
        }

        [Test]
        public void GetWord_ReturnOneWordAnswer_WithCorrectIdFor_SecondWord()
        {
            _sut.InitialiseWordBank(_xmlResource);

            _sut.GetWord();
            WordAnswer result = _sut.GetWord();

            Assert.AreEqual(2, result.Id);
        }

        [Test]
        public void GetWord_ReturnOneWordAnswer_WithCorrectIdFor_ThirdWord()
        {
            _sut.InitialiseWordBank(_xmlResource);
            _sut.GetWord();
            _sut.GetWord();
            WordAnswer result = _sut.GetWord();

            Assert.AreEqual(3, result.Id);
        }

        [Test]
        public void GetWord_ReturnOneWordAnswer_WithCorrectIdFor_FourthWord()
        {
            _sut.InitialiseWordBank(_xmlResource);
            _sut.GetWord();
            _sut.GetWord();
            _sut.GetWord();
            WordAnswer result = _sut.GetWord();

            Assert.AreEqual(4, result.Id);
        }

        [Test]
        public void GetWord_ReturnOneWordAnswer_WithCorrectIdFor_FifthWord()
        {
            _sut.InitialiseWordBank(_xmlResource);
            _sut.GetWord();
            _sut.GetWord();
            _sut.GetWord();
            _sut.GetWord();
            WordAnswer result = _sut.GetWord();

            Assert.AreEqual(5, result.Id);
        }

        [Test]
        public void GetWord_FireIsEmptyEvent_IfQueueIsEmpty()
        {
            bool wasFired = false;
            var emptyQueue = new Queue<WordAnswer>();
            _sut.IsEmpty += (o, e) => wasFired = true;

            _sut.WordQueue = emptyQueue;
            _sut.GetWord();

            Assert.IsTrue(wasFired);
        }

        [Test]
        public void SubmitAnswer_FailtToUpdateWordMap_IfWordAnswerIsNull()
        {
            _sut.InitialiseWordBank(_xmlResource);
            _sut.SubmitAnswer(null);

            Assert.AreEqual(10, _sut.WordMap.Count);
        }

        //sample of 5
        [Test]
        public void SubmitAnswer_UpdateWordMapAnswer_ForWordAnswer1()
        {
            var wordAnswer = new WordAnswer(1, "word1", "answer1");

            _sut.InitialiseWordBank(_xmlResource);
            _sut.SubmitAnswer(wordAnswer);
            Dictionary<string, string> wMap = _sut.WordMap;

            Assert.AreEqual("answer1", wMap["word1"]);
        }

        [Test]
        public void SubmitAnswer_UpdateWordMapAnswer_ForWordAnswer2()
        {
            var wordAnswer = new WordAnswer(1, "word2", "answer2");

            _sut.InitialiseWordBank(_xmlResource);
            _sut.SubmitAnswer(wordAnswer);
            Dictionary<string, string> wMap = _sut.WordMap;

            Assert.AreEqual("answer2", wMap["word2"]);
        }

        [Test]
        public void SubmitAnswer_UpdateWordMapAnswer_ForWordAnswer3()
        {
            var wordAnswer = new WordAnswer(1, "word3", "answer3");

            _sut.InitialiseWordBank(_xmlResource);
            _sut.SubmitAnswer(wordAnswer);
            Dictionary<string, string> wMap = _sut.WordMap;

            Assert.AreEqual("answer3", wMap["word3"]);
        }

        [Test]
        public void SubmitAnswer_UpdateWordMapAnswer_ForWordAnswer4()
        {
            var wordAnswer = new WordAnswer(1, "word4", "answer4");

            _sut.InitialiseWordBank(_xmlResource);
            _sut.SubmitAnswer(wordAnswer);
            Dictionary<string, string> wMap = _sut.WordMap;

            Assert.AreEqual("answer4", wMap["word4"]);
        }

        [Test]
        public void SubmitAnswer_UpdateWordMapAnswer_ForWordAnswer5()
        {
            var wordAnswer = new WordAnswer(1, "word5", "answer5");

            _sut.InitialiseWordBank(_xmlResource);
            _sut.SubmitAnswer(wordAnswer);
            Dictionary<string, string> wMap = _sut.WordMap;

            Assert.AreEqual("answer5", wMap["word5"]);
        }

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
