using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using WordBank.Repository;
using WordBank.Utility.Interfaces;

namespace WordBank.UnitTests.Repository
{
    [TestFixture]
    public class XmlWordBank_Should
    {
        private Mock<IXDocumentParser> _fakeXDocParser;

        private XmlWordBank _sut;

        private XDocument _xDocument;

        [SetUp]
        public void Init()
        {
            _fakeXDocParser = new Mock<IXDocumentParser>();
            _sut = new XmlWordBank(_fakeXDocParser.Object);
            _xDocument = Mother.GetTestXDocument();
        }

        [Test]
        public void InitialiseWordBank_CallParseXDocument_ExactlyOnce()
        {
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());

            _fakeXDocParser.Verify(x => x.ParseXDocument(It.IsAny<string>()),
                Times.Once());
        }

        [Test]
        public void InitialiseWordBank_CallParseXDocument_WithCorrectData()
        {
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank("Resources");

            _fakeXDocParser.Verify(x => x.ParseXDocument(It.Is<string>(
                y => y.Equals("Resources"))));
        }

        [Test]
        public void InitialiseWordBank_InitPropertyWordMap_With10Items()
        {
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            Dictionary<string, string> wordMap = _sut.WordMap;

            Assert.AreEqual(10, wordMap.Count);
        }

        [Test]
        public void InitialiseWordBank_InitPropertyWordMap_WithCorrectKeys()
        {
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            List<string> keyList = _sut.WordMap.Select(x => x.Key).ToList();

            Assert.AreEqual(Mother.ExpectedKeySequence(), keyList);
        }

        [Test]
        public void InitialiseWordBank_InitPropertyWordMap_WithCorrectValues()
        {
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            List<string> valueList = _sut.WordMap.Select(x => x.Value).ToList();

            Assert.IsTrue(valueList.TrueForAll(y => y.Equals(string.Empty)));
        }

        [Test]
        public void InitialiseWordBank_InitPropertyWordQueue_With10Items()
        {
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            Queue<Question> wordQueue = _sut.WordQueue;

            Assert.AreEqual(10, wordQueue.Count);
            CollectionAssert.AllItemsAreInstancesOfType(wordQueue, typeof (Question));
        }

        [Test]
        public void InitialiseWordBank_InitPropertyWordQueue_WithCorrectIdSequence()
        {
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            List<int> idList = _sut.WordQueue.Select(x => x.Id).ToList();

            Assert.AreEqual(Mother.ExpectedIdSequence(), idList);
        }

        [Test]
        public void InitialiseWordBank_InitPropertyWordQueue_WithCorrectKeySequence()
        {
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            List<string> wordList = _sut.WordQueue.Select(x => x.Word).ToList();

            Assert.AreEqual(Mother.ExpectedKeySequence(), wordList);
        }

        [Test]
        public void InitialiseWordBank_InitPropertyWordQueue_WithCorrectValueSequence()
        {
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            List<string> answerList = _sut.WordQueue.Select(x => x.Answer).ToList();

            Assert.IsTrue(answerList.All(x => x == "Answer not given"));
        }

        //sample of 5
        [Test]
        public void GetQuestion_ReturnOneQuestion_WithCorrectlyInitialisedProperties_1stWord()
        {
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            Question question = _sut.GetQuestion();

            Assert.AreEqual(1, question.Id);
            Assert.AreEqual("word1", question.Word);
            Assert.AreEqual("Answer not given", question.Answer);
        }

        [Test]
        public void GetQuestion_ReturnOneQuestion_WithCorrectlyInitialisedProperties_2ndWord()
        {
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            
            _sut.GetQuestion();
            Question question = _sut.GetQuestion();

            Assert.AreEqual(2, question.Id);
            Assert.AreEqual("word2", question.Word);
            Assert.AreEqual("Answer not given", question.Answer);
        }

        [Test]
        public void GetQuestion_ReturnOneQuestion_WithCorrectlyInitialisedProperties_3rdWord()
        {
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            _sut.GetQuestion();
            _sut.GetQuestion();
            Question question = _sut.GetQuestion();

            Assert.AreEqual(3, question.Id);
            Assert.AreEqual("word3", question.Word);
            Assert.AreEqual("Answer not given", question.Answer);
        }

        [Test]
        public void GetQuestion_ReturnOneQuestion_WithCorrectlyInitialisedProperties_4thWord()
        {
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            _sut.GetQuestion();
            _sut.GetQuestion();
            _sut.GetQuestion();
            Question question = _sut.GetQuestion();

            Assert.AreEqual(4, question.Id);
            Assert.AreEqual("word4", question.Word);
            Assert.AreEqual("Answer not given", question.Answer);
        }

        [Test]
        public void GetQuestion_ReturnOneQuestion_WithCorrectlyInitialisedProperties_5thWord()
        {
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            _sut.GetQuestion();
            _sut.GetQuestion();
            _sut.GetQuestion();
            _sut.GetQuestion();
            Question question = _sut.GetQuestion();

            Assert.AreEqual(5, question.Id);
            Assert.AreEqual("word5", question.Word);
            Assert.AreEqual("Answer not given", question.Answer);
        }

        [Test]
        public void GetQuestion_FireIsEmptyEvent_IfQueueIsEmpty()
        {
            bool wasFired = false;
            var emptyQueue = new Queue<Question>();
            _sut.IsEmpty += (o,e) => wasFired = true;
            
            _sut.WordQueue = emptyQueue;
            _sut.GetQuestion();

            Assert.IsTrue(wasFired);
        }

        [Test]
        public void SubmitAnswer_FailtToUpdateWordMap_IfWordAnswerIsNull()
        {
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            _sut.SubmitAnswer(null);

            Assert.AreEqual(10, _sut.WordMap.Count);
        }

        //sample of 5
        [Test]
        public void SubmitAnswer_UpdateWordMapValue_ForWord1()
        {
            var question = new Question(1, "word1", "answer1");
            
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            _sut.SubmitAnswer(question);
            Dictionary<string, string> wordMap = _sut.WordMap;

            Assert.AreEqual("answer1", wordMap["word1"]);
        }

        [Test]
        public void SubmitAnswer_UpdateWordMapValue_ForWord2()
        {
            var question = new Question(1, "word2", "answer2");
            
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            _sut.SubmitAnswer(question);
            Dictionary<string, string> wordMap = _sut.WordMap;

            Assert.AreEqual("answer2", wordMap["word2"]);
        }

        [Test]
        public void SubmitAnswer_UpdateWordMapValue_ForWord3()
        {
            var question = new Question(1, "word3", "answer3");
            
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            _sut.SubmitAnswer(question);
            Dictionary<string, string> wordMap = _sut.WordMap;

            Assert.AreEqual("answer3", wordMap["word3"]);
        }

        [Test]
        public void SubmitAnswer_UpdateWordMapValue_ForWord4()
        {
            var question = new Question(1, "word4", "answer4");
            
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            _sut.SubmitAnswer(question);
            Dictionary<string, string> wordMap = _sut.WordMap;

            Assert.AreEqual("answer4", wordMap["word4"]);
        }

        [Test]
        public void SubmitAnswer_UpdateWordMapValue_ForWord5()
        {
            var question = new Question(1, "word5", "answer5");
            
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            _sut.SubmitAnswer(question);
            Dictionary<string, string> wordMap = _sut.WordMap;

            Assert.AreEqual("answer5", wordMap["word5"]);
        }

        [TearDown]
        public void TearDown()
        {
            _fakeXDocParser = null;
            _sut = null;
            _xDocument = null;
        }
    }
}