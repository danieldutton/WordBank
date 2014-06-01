using NUnit.Framework;
using WordBank.Repository;

namespace WordBank.UnitTests.Repository
{
    [TestFixture]
    public class Question_Should
    {
        [Test]
        public void IsCorrect_TwoEqualStringsOfLowerCase_EqualsTrue()
        {
            var question = new Question(1, "acceptable", "acceptable");

            Assert.IsTrue(question.IsCorrect);
        }

        [Test]
        public void IsCorrect_TwoEqualStringsOfUpperCase_EqualsTrue()
        {
            var question = new Question(1, "ACCEPTABLE", "ACCEPTABLE");

            Assert.IsTrue(question.IsCorrect);
        }

        [Test]
        public void IsCorrect_TwoEqualStringsOfMixedCase_EqualsTrue()
        {
            var question = new Question(1, "AccEPtABle", "aCCePtABLe");

            Assert.IsTrue(question.IsCorrect);
        }

        [Test]
        public void IsCorrect_TwoDifferingStringsOfLowerCase_EqualsFalse()
        {
            var question = new Question(1, "acceptable", "accommodate");

            Assert.IsFalse(question.IsCorrect);
        }

        [Test]
        public void IsCorrect_TwoDifferingStringsOfUpperCase_EqualsFalse()
        {
            var question = new Question(1, "ACCEPTABLE", "ACCOMMODATE");

            Assert.IsFalse(question.IsCorrect);
        }

        [Test]
        public void IsCorrect_TwoDifferingStringsOfMixedCase_EqualsFalse()
        {
            var question = new Question(1, "AccEPtABle", "aCComModatE");

            Assert.IsFalse(question.IsCorrect);
        }

        [Test]
        public void Constructor_SetAnswerValueTo_Skipped_IfAnswerParamIsEmpty()
        {
            var question = new Question(1, "Test", string.Empty);

            Assert.AreEqual("Skipped", question.Answer);
        }

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
