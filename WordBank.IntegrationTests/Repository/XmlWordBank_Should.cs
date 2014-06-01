using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using WordBank.Repository;
using WordBank.Utility;

namespace WordBank.IntegrationTests.Repository
{
    [TestFixture]
    public class XmlWordBank_Should
    {
        private string _xmlString;

        private XDocumentParser _xDocumentParser;

        private XmlWordBank _sut;

        [SetUp]
        public void Init()
        {
            _xmlString = Properties.Resources.words_testFile;
            _xDocumentParser = new XDocumentParser();
            _sut = new XmlWordBank(_xDocumentParser);
        }


        [Test]
        public void InitialiseWordBank_InitPropertyWordMap_With10Items()
        {
            _sut.InitialiseWordBank(_xmlString);
            Dictionary<string, string> wordMap = _sut.WordMap;

            Assert.AreEqual(10, wordMap.Count);
        }

        [Test]
        public void InitialiseWordBank_InitPropertyWordMap_WithCorrectKeys()
        {
            _sut.InitialiseWordBank(_xmlString);
            List<string> keyList = _sut.WordMap.Select(x => x.Key).ToList();

            Assert.AreEqual(Mother.ExpectedWordSequence(), keyList);
        }

        [Test]
        public void InitialiseWordBank_InitPropertyWordMap_WithCorrectValues()
        {
            _sut.InitialiseWordBank(_xmlString);
            List<string> valueList = _sut.WordMap.Select(x => x.Value).ToList();

            Assert.IsTrue(valueList.TrueForAll(y => y.Equals(string.Empty)));
        }

        [Test]
        public void InitialiseWordBank_InitPropertyWordQueue_With10Items()
        {
            _sut.InitialiseWordBank(_xmlString);
            Queue<Question> wordQueue = _sut.WordQueue;

            Assert.AreEqual(10, wordQueue.Count);
            CollectionAssert.AllItemsAreInstancesOfType(wordQueue, typeof(Question));
        }

        [Test]
        public void InitialiseWordBank_InitPropertyWordQueue_WithCorrectIdSequence()
        {
            _sut.InitialiseWordBank(_xmlString);
            List<int> idList = _sut.WordQueue.Select(x => x.Id).ToList();

            Assert.AreEqual(Mother.ExpectedIdSequence(), idList);
        }

        [Test]
        public void InitialiseWordBank_InitPropertyWordQueue_WithCorrectWordSequence()
        {
            _sut.InitialiseWordBank(_xmlString);
            List<string> wordList = _sut.WordQueue.Select(x => x.Word).ToList();

            Assert.AreEqual(Mother.ExpectedWordSequence(), wordList);
        }

        [Test]
        public void InitialiseWordBank_InitPropertyWordQueue_WithCorrectAnswerSequence()
        {
            _sut.InitialiseWordBank(_xmlString);
            List<string> answerList = _sut.WordQueue.Select(x => x.Answer).ToList();

            Assert.IsTrue(answerList.All(x => x == "Answer not given"));
        }

        //sample of 5
        [Test]
        public void GetQuestion_ReturnOneQuestion_WithCorrectlyInitialisedProperties_1stWord()
        {
            _sut.InitialiseWordBank(_xmlString);
            Question result = _sut.GetQuestion();

            Assert.AreEqual(1, result.Id);
            Assert.AreEqual("word1", result.Word);
            Assert.AreEqual("Answer not given", result.Answer);
        }

        [Test]
        public void GetQuestion_ReturnOneQuestion_WithCorrectlyInitialisedProperties_2ndWord()
        {
            _sut.InitialiseWordBank(_xmlString);

            _sut.GetQuestion();
            Question result = _sut.GetQuestion();

            Assert.AreEqual(2, result.Id);
            Assert.AreEqual("word2", result.Word);
            Assert.AreEqual("Answer not given", result.Answer);
        }

        [Test]
        public void GetQuestion_ReturnOneQuestion_WithCorrectlyInitialisedProperties_3rdWord()
        {
            _sut.InitialiseWordBank(_xmlString);
            
            _sut.GetQuestion();
            _sut.GetQuestion();
            Question result = _sut.GetQuestion();

            Assert.AreEqual(3, result.Id);
            Assert.AreEqual("word3", result.Word);
            Assert.AreEqual("Answer not given", result.Answer);
        }

        [Test]
        public void GetQuestion_ReturnOneQuestion_WithCorrectlyInitialisedProperties_4thWord()
        {
            _sut.InitialiseWordBank(_xmlString);
            
            _sut.GetQuestion();
            _sut.GetQuestion();
            _sut.GetQuestion();
            Question result = _sut.GetQuestion();

            Assert.AreEqual(4, result.Id);
            Assert.AreEqual("word4", result.Word);
            Assert.AreEqual("Answer not given", result.Answer);
        }

        [Test]
        public void GetQuestion_ReturnOneQuestion_WithCorrectlyInitialisedProperties_5thWord()
        {
            _sut.InitialiseWordBank(_xmlString);
            
            _sut.GetQuestion();
            _sut.GetQuestion();
            _sut.GetQuestion();
            _sut.GetQuestion();
            Question result = _sut.GetQuestion();

            Assert.AreEqual(5, result.Id);
            Assert.AreEqual("word5", result.Word);
            Assert.AreEqual("Answer not given", result.Answer);
        }

        [Test]
        public void GetQuestion_FireIsEmptyEvent_IfQueueIsEmpty()
        {
            bool wasFired = false;
            var emptyQueue = new Queue<Question>();
            _sut.IsEmpty += (o, e) => wasFired = true;

            _sut.WordQueue = emptyQueue;
            _sut.GetQuestion();

            Assert.IsTrue(wasFired);
        }

        [Test]
        public void SubmitAnswer_FailtToUpdateWordMap_IfWordAnswerIsNull()
        {
            _sut.InitialiseWordBank(_xmlString);
            _sut.SubmitAnswer(null);

            Assert.AreEqual(10, _sut.WordMap.Count);
        }

        //sample of 5
        [Test]
        public void SubmitAnswer_UpdateWordMapValue_ForWord1()
        {
            var question = new Question(1, "word1", "answer1");

            _sut.InitialiseWordBank(_xmlString);
            _sut.SubmitAnswer(question);
            Dictionary<string, string> wordMap = _sut.WordMap;

            Assert.AreEqual("answer1", wordMap["word1"]);
        }

        [Test]
        public void SubmitAnswer_UpdateWordMapValue_ForWord2()
        {
            var question = new Question(1, "word2", "answer2");

            _sut.InitialiseWordBank(_xmlString);
            _sut.SubmitAnswer(question);
            Dictionary<string, string> wordMap = _sut.WordMap;

            Assert.AreEqual("answer2", wordMap["word2"]);
        }

        [Test]
        public void SubmitAnswer_UpdateWordMapValue_ForWord3()
        {
            var question = new Question(1, "word3", "answer3");

            _sut.InitialiseWordBank(_xmlString);
            _sut.SubmitAnswer(question);
            Dictionary<string, string> wordMap = _sut.WordMap;

            Assert.AreEqual("answer3", wordMap["word3"]);
        }

        [Test]
        public void SubmitAnswer_UpdateWordMapValue_ForWord4()
        {
            var question = new Question(1, "word4", "answer4");

            _sut.InitialiseWordBank(_xmlString);
            _sut.SubmitAnswer(question);
            Dictionary<string, string> wordMap = _sut.WordMap;

            Assert.AreEqual("answer4", wordMap["word4"]);
        }

        [Test]
        public void SubmitAnswer_UpdateWordMapValue_ForWord5()
        {
            var question = new Question(1, "word5", "answer5");

            _sut.InitialiseWordBank(_xmlString);
            _sut.SubmitAnswer(question);
            Dictionary<string, string> wordMap = _sut.WordMap;

            Assert.AreEqual("answer5", wordMap["word5"]);
        }

        [TearDown]
        public void TearDown()
        {
            _xmlString = null;
            _xDocumentParser = null;
            _sut = null;
        }
    }
}
