using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using WordBank.Utility;

namespace WordBank.UnitTests.Utility
{
    [TestFixture]
    public class XmlWordFileBuilder_Should
    {
        private XmlWordFileBuilder _sut;

        private List<string> _testWords;
            
        [SetUp]
        public void Init()
        {
            _sut = new XmlWordFileBuilder();
            _testWords = Mother.ExpectedWordKeySequence();
        }

        [Test]
        public void BuildWordFile_IncludeCorrectXmlHeaderInXDocument()
        {
            XDocument xDoc = _sut.BuildWordFile(_testWords);

            const string expected = @"<?xml version=""1.0"" encoding=""utf-8"" standalone=""yes""?>";
            string actual = xDoc.Declaration.ToString();

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void BuildWordFile_IncludeATotalOf11NodesInXDocument()
        {
            XDocument xDoc = _sut.BuildWordFile(_testWords);

            Assert.AreEqual(11, xDoc.Descendants().Count());
        }

        [Test]
        public void BuildWordFile_IncludeATotalOf10Nodes_DescendingFromRoot()
        {
            XDocument xDoc = _sut.BuildWordFile(_testWords);

            Assert.AreEqual(10, xDoc.Descendants("word").Count());
        }

        [Test]
        public void BuildWordFile_NameRootElementCorrectly()
        {
            XDocument xDoc = _sut.BuildWordFile(_testWords);
            string rootName = xDoc.Root.Name.LocalName;

            Assert.AreEqual("words", rootName);
        }

        [Test]
        public void BuildWordFile_NameRootDescendingNodesCorrectly()
        {
            XDocument xDoc = _sut.BuildWordFile(_testWords);
            
            List<string> result = xDoc.Descendants("word")
                .Select(x => x.Name.LocalName)
                .ToList();

            Assert.IsTrue(result.TrueForAll(x => x == "word"));   
        }

        [Test]
        public void BuildWordFile_RootDescendantNodesContainTheCorrectValues()
        {
            XDocument xDoc = _sut.BuildWordFile(_testWords);
            
            List<string> result = xDoc.Descendants("word")
                .Select(x => x.Value)
                .ToList();

           Assert.IsTrue(result.SequenceEqual(_testWords));
        }

        [Test]
        public void BuildWordFile_InitPropertyXmlString_WithCorrectValue()
        {
            _sut.BuildWordFile(_testWords);

            string actual = _sut.XmlString;

            Assert.AreEqual(Mother.ExpectedXmlString(), actual);
        }

        [Test]
        public void BuildWordFile_PropertyXmlString_ReturnsEmptyStringByDefault()
        {
            string actual = _sut.XmlString;

            Assert.AreEqual(string.Empty, actual);
        }

        [TearDown]
        public void TearDown()
        {
            _sut = null;
            _testWords = null;
        }
    }
}
