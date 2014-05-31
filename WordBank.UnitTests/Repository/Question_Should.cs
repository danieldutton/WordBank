using NUnit.Framework;
using WordBank.Repository;

namespace WordBank.UnitTests.Repository
{
    [TestFixture]
    public class Question_Should
    {
        [Test]
        public void ToString_ReturnTheCorrectStringValue()
        {
            var sut = new Question(id: 1, word: "Word", answer: "Answer");
            
            const string expected = "[Question] Id:1 Word:Word Answer:Answer";
            string actual = sut.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
