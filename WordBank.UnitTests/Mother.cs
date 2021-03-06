﻿using System.Collections.Generic;
using System.Xml.Linq;

namespace WordBank.UnitTests
{
    public static class Mother
    {
        public static XDocument GetTestXDocument()
        {
            var xDoc =
                new XDocument(
                    new XElement("words",
                        new XElement("word", "word1"),
                        new XElement("word", "word2"),
                        new XElement("word", "word3"),
                        new XElement("word", "word4"),
                        new XElement("word", "word5"),
                        new XElement("word", "word6"),
                        new XElement("word", "word7"),
                        new XElement("word", "word8"),
                        new XElement("word", "word9"),
                        new XElement("word", "word10")
                        ));

            return xDoc;
        }

        public static List<string> ExpectedKeySequence()
        {
            var keyList = new List<string>
            {
                "word1", "word2", "word3", "word4", "word5",
                "word6", "word7", "word8", "word9", "word10",
            };

            return keyList;
        }

        public static List<string> ExpectedValueSequence()
        {
            var valueList = new List<string>
            {
                "value1", "value2", "value3", "value4", "value5",
                "value6", "value7", "value8", "value9", "value10",
            };

            return valueList;    
        } 

        public static List<int> ExpectedIdSequence()
        {
            var idList = new List<int>
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            return idList;
        }

        public static Dictionary<string, string> GetDictionaryStub()
        {
            var dictionaryStub = new Dictionary<string, string>
            {
                {"word1", "value1"},
                {"word2", "value2"},
                {"word3", "value3"},
                {"word4", "value4"},
                {"word5", "value5"},
                {"word6", "value6"},
                {"word7", "value7"},
                {"word8", "value8"},
                {"word9", "value9"},
                {"word10","value10"},
            };

            return dictionaryStub;
        } 
    }
}
