using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using WordBank.QuestionBank;

namespace WordBank.UnitTests.QuestionBank
{
    [TestFixture]
    public class SpellingsLoader_Should
    {
        [Test]
        public void GetSpellings_AllValuesAreDefaultedToEmptyString()
        {
            var sut = new SpellingsBank();
            SortedDictionary<string, string> spellings = sut.LoadSpellings();

            List<string> values = spellings.Values.ToList();

            Assert.IsTrue(values.TrueForAll(x => x == string.Empty));
        }

        [Test]
        public void GetSpellings_RetrievesTenSpellingsInCorrectOrder()
        {
            var sut = new SpellingsBank();
            SortedDictionary<string, string> spellings = sut.LoadSpellings();

            List<string> expected = Mother.ExpectedSpellingsOrder();
            List<string> actual = spellings.Keys.ToList();

            CollectionAssert.AreEqual(expected, actual);
        }
    }

}
