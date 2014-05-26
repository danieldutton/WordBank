using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using WordBank.Repository;

namespace WordBank.UnitTests.Repository
{
    [TestFixture]
    public class SpellingBank_Should
    {
        [Test]
        public void LoadSpellings_AllValuesAreDefaultedToEmptyString()
        {
            var sut = new XmlWordBank();

            List<Word> values = sut.SpellingsQueue.ToList();

            Assert.IsTrue(values.TrueForAll(x => x.Answer == string.Empty));
        }

        [Test]
        public void LoadSpellings_RetrievesTenSpellingsInCorrectOrder()
        {
            var sut = new XmlWordBank();

            List<string> expected = Mother.ExpectedWordsOrder();
            List<Word> actual = sut.SpellingsQueue.ToList();//to diff types that's why it's failing

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void GetSpelling_GetSpellingOne()
        {
            var sut = new XmlWordBank();

            Word word = sut.GetWord();

            Assert.AreEqual(1, word.Id);
            Assert.AreEqual("Word1", word.Text);
            Assert.AreEqual(string.Empty, string.Empty);
        }

        [Test]
        public void GetSpelling_GetSpellingTwo()
        {
            var sut = new XmlWordBank();

            sut.GetWord();

            Word word = sut.GetWord();

            Assert.AreEqual(2, word.Id);
            Assert.AreEqual("Word2", word.Text);
            Assert.AreEqual(string.Empty, string.Empty);
        }

        [Test]
        public void GetSpelling_GetSpellingThree()
        {
            var sut = new XmlWordBank();

            sut.GetWord();
            sut.GetWord();

            Word word = sut.GetWord();

            Assert.AreEqual(3, word.Id);
            Assert.AreEqual("Word3", word.Text);
            Assert.AreEqual(string.Empty, string.Empty);
        }

        [Test]
        public void GetSpelling_GetSpellingFour()
        {
            var sut = new XmlWordBank();

            sut.GetWord();
            sut.GetWord();
            sut.GetWord();

            Word word = sut.GetWord();

            Assert.AreEqual(4, word.Id);
            Assert.AreEqual("Word4", word.Text);
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

            Word word = sut.GetWord();

            Assert.AreEqual(5, word.Id);
            Assert.AreEqual("Word5", word.Text);
            Assert.AreEqual(string.Empty, string.Empty);
        }
    }

}
