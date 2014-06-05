using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using WordBank.Presentation.ExtMethods;
using WordBank.Repository;

namespace WordBank.UnitTests.Presentation
{
    [TestFixture]
    public class WordMapExtensions_Should
    {
        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ToQuestionList_ThrowArgumentNullException_IfDictionaryIsNull()
        {
            Dictionary<string, string> dicStub = null;

            dicStub.ToQuestionList();
        }

        [Test]
        public void ToQuestionList_ReturnsAListOfQuestions_WithCorrectCount()
        {
            Dictionary<string, string> dicStub = Mother.GetDictionaryStub();

            List<Question> result = dicStub.ToQuestionList();

            Assert.AreEqual(dicStub.Count, result.Count);
        }

        [Test]
        public void ToQuestionList_ReturnsAListOfQuestions_WithCorrectIdSequence()
        {
            Dictionary<string, string> dicStub = Mother.GetDictionaryStub();

            List<Question> result = dicStub.ToQuestionList();
            
            List<int> actual = result.Select(x => x.Id).ToList();
            List<int> expected = Mother.ExpectedIdSequence();

            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [Test]
        public void ToQuestionList_ReturnsAListOfQuestions_WithCorrectWordSequence()
        {
            Dictionary<string, string> dicStub = Mother.GetDictionaryStub();

            List<Question> result = dicStub.ToQuestionList();

            List<string> actual = result.Select(x => x.Answer).ToList();
            List<string> expected = Mother.ExpectedValueSequence();

            Assert.IsTrue(expected.SequenceEqual(actual));
        }

        [Test]
        public void ToQuestionList_ReturnsAListOfQuestions_WithCorrectAnswerSequence()
        {
            Dictionary<string, string> dicStub = Mother.GetDictionaryStub();

            List<Question> result = dicStub.ToQuestionList();

            List<string> actual = result.Select(x => x.Answer).ToList();
            List<string> expected = Mother.ExpectedValueSequence();

            Assert.IsTrue(expected.SequenceEqual(actual));
        }
    }
}
