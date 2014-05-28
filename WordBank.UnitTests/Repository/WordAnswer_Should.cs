using NUnit.Framework;
using WordBank.Repository.Model;

namespace WordBank.UnitTests.Repository
{
    [TestFixture]
    public class WordAnswer_Should
    {
        [Test]
        public void ToString_ReturnTheCorrectStringValue()
        {
            var sut = new WordAnswer(id: 1, text: "Text", answer: "Answer");
            
            const string expected = "[WordAnswer] Id:1 Text:Text Answer:Answer";
            string actual = sut.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
