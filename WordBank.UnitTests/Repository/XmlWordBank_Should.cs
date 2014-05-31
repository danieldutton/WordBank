﻿using Moq;
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
            Dictionary<string, string> wMap = _sut.WordMap;

            Assert.AreEqual(10, wMap.Count);
        }

        [Test]
        public void InitialiseWordBank_InitPropertyWordMap_WithKeySequence()
        {
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            List<string> keyList = _sut.WordMap.Select(x => x.Key).ToList();

            Assert.AreEqual(Mother.ExpectedWordKeySequence(), keyList);
        }

        [Test]
        public void InitialiseWordBank_InitPropertyWordMap_WithCorrectValueSequence()
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
        public void InitialiseWordBank_InitPropertyWordQueue_WithCorrectTextSequence()
        {
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            List<string> wordList = _sut.WordQueue.Select(x => x.Word).ToList();

            Assert.AreEqual(Mother.ExpectedWordKeySequence(), wordList);
        }

        [Test]
        public void InitialiseWordBank_InitPropertyWordQueue_WithCorrectAnswerSequence()
        {
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            List<string> answerList = _sut.WordQueue.Select(x => x.Answer).ToList();

            Assert.IsTrue(answerList.All(x => x == string.Empty));
        }

        //sample of 5
        [Test]
        public void GetWord_ReturnOneWordAnswer_WithCorrectIdFor_FirstWord()
        {
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            Question result = _sut.GetWord();

            Assert.AreEqual(1, result.Id);
        }

        [Test]
        public void GetWord_ReturnOneWordAnswer_WithCorrectIdFor_SecondWord()
        {
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            
            _sut.GetWord();
            Question result = _sut.GetWord();

            Assert.AreEqual(2, result.Id);
        }

        [Test]
        public void GetWord_ReturnOneWordAnswer_WithCorrectIdFor_ThirdWord()
        {
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            _sut.GetWord();
            _sut.GetWord();
            Question result = _sut.GetWord();

            Assert.AreEqual(3, result.Id);
        }

        [Test]
        public void GetWord_ReturnOneWordAnswer_WithCorrectIdFor_FourthWord()
        {
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            _sut.GetWord();
            _sut.GetWord();
            _sut.GetWord();
            Question result = _sut.GetWord();

            Assert.AreEqual(4, result.Id);
        }

        [Test]
        public void GetWord_ReturnOneWordAnswer_WithCorrectIdFor_FifthWord()
        {
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            _sut.GetWord();
            _sut.GetWord();
            _sut.GetWord();
            _sut.GetWord();
            Question result = _sut.GetWord();

            Assert.AreEqual(5, result.Id);
        }

        [Test]
        public void GetWord_FireIsEmptyEvent_IfQueueIsEmpty()
        {
            bool wasFired = false;
            var emptyQueue = new Queue<Question>();
            _sut.IsEmpty += (o,e) => wasFired = true;
            
            _sut.WordQueue = emptyQueue;
            _sut.GetWord();

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
        public void SubmitAnswer_UpdateWordMapAnswer_ForWordAnswer1()
        {
            var wordAnswer = new Question(1, "word1", "answer1");
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            _sut.SubmitAnswer(wordAnswer);
            Dictionary<string, string> wMap = _sut.WordMap;

            Assert.AreEqual("answer1", wMap["word1"]);
        }

        [Test]
        public void SubmitAnswer_UpdateWordMapAnswer_ForWordAnswer2()
        {
            var wordAnswer = new Question(1, "word2", "answer2");
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            _sut.SubmitAnswer(wordAnswer);
            Dictionary<string, string> wMap = _sut.WordMap;

            Assert.AreEqual("answer2", wMap["word2"]);
        }

        [Test]
        public void SubmitAnswer_UpdateWordMapAnswer_ForWordAnswer3()
        {
            var wordAnswer = new Question(1, "word3", "answer3");
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            _sut.SubmitAnswer(wordAnswer);
            Dictionary<string, string> wMap = _sut.WordMap;

            Assert.AreEqual("answer3", wMap["word3"]);
        }

        [Test]
        public void SubmitAnswer_UpdateWordMapAnswer_ForWordAnswer4()
        {
            var wordAnswer = new Question(1, "word4", "answer4");
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            _sut.SubmitAnswer(wordAnswer);
            Dictionary<string, string> wMap = _sut.WordMap;

            Assert.AreEqual("answer4", wMap["word4"]);
        }

        [Test]
        public void SubmitAnswer_UpdateWordMapAnswer_ForWordAnswer5()
        {
            var wordAnswer = new Question(1, "word5", "answer5");
            _fakeXDocParser.Setup(x => x.ParseXDocument(It.IsAny<string>()))
                .Returns(_xDocument);

            _sut.InitialiseWordBank(It.IsAny<string>());
            _sut.SubmitAnswer(wordAnswer);
            Dictionary<string, string> wMap = _sut.WordMap;

            Assert.AreEqual("answer5", wMap["word5"]);
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