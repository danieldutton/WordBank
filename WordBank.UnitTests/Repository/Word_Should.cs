using NUnit.Framework;
using WordBank.Repository;

namespace WordBank.UnitTests.Repository
{
    [TestFixture]
    public class Word_Should
    {
        [Test]
        public void ToString_ReturnTheCorrectStringValue()
        {
            var sut = new Word
            {
                Id = 1, 
                Text = "Text", 
                Answer = "Answer"
            };

            const string expected = "[Word] Id:1 Text:Text Answer:Answer";
            string actual = sut.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
