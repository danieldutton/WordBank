using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using WordBank.Repository;
using WordBank.Repository.Model;

namespace WordBank.UnitTests.Repository
{
    [TestFixture]
    public class XmlWordBank_Should
    {
        [Test]
        public void LoadSpellings_AllValuesAreDefaultedToEmptyString()
        {
            var sut = new XmlWordBank();

            List<WordAnswer> values = sut.WordQueue.ToList();

            Assert.IsTrue(values.TrueForAll(x => x.Answer == string.Empty));
        }

        [Test]
        public void LoadSpellings_RetrievesTenSpellingsInCorrectOrder()
        {
            var sut = new XmlWordBank();

            List<string> expected = Mother.ExpectedWordsOrder();
            List<WordAnswer> actual = sut.WordQueue.ToList();//to diff types that's why it's failing

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSpelling_GetSpellingOne()
        {
            var sut = new XmlWordBank();

            WordAnswer wordAnswer = sut.GetWord();

            Assert.AreEqual(1, wordAnswer.Id);
            Assert.AreEqual("Word1", wordAnswer.Text);
            Assert.AreEqual(string.Empty, string.Empty);
        }

        [Test]
        public void GetSpelling_GetSpellingTwo()
        {
            var sut = new XmlWordBank();

            sut.GetWord();

            WordAnswer wordAnswer = sut.GetWord();

            Assert.AreEqual(2, wordAnswer.Id);
            Assert.AreEqual("Word2", wordAnswer.Text);
            Assert.AreEqual(string.Empty, string.Empty);
        }

        [Test]
        public void GetSpelling_GetSpellingThree()
        {
            var sut = new XmlWordBank();

            sut.GetWord();
            sut.GetWord();

            WordAnswer wordAnswer = sut.GetWord();

            Assert.AreEqual(3, wordAnswer.Id);
            Assert.AreEqual("Word3", wordAnswer.Text);
            Assert.AreEqual(string.Empty, string.Empty);
        }

        [Test]
        public void GetSpelling_GetSpellingFour()
        {
            var sut = new XmlWordBank();

            sut.GetWord();
            sut.GetWord();
            sut.GetWord();

            WordAnswer wordAnswer = sut.GetWord();

            Assert.AreEqual(4, wordAnswer.Id);
            Assert.AreEqual("Word4", wordAnswer.Text);
            Assert.AreEqual(string.Empty, string.Empty);
        }

        [Test]
        public void GetSpelling_GetSpellingFive()
        {
            var sut = new XmlWordBank();

            sut.GetWord();
            sut.GetWord();
            sut.GetWord();
            sut.GetWord();

            WordAnswer wordAnswer = sut.GetWord();

            Assert.AreEqual(5, wordAnswer.Id);
            Assert.AreEqual("Word5", wordAnswer.Text);
            Assert.AreEqual(string.Empty, string.Empty);
        }
    }

}
