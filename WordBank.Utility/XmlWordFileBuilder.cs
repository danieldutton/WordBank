using System.Collections.Generic;
using System.Xml.Linq;
using WordBank.Utility.Interfaces;

namespace WordBank.Utility
{
    public class XmlWordFileBuilder : IWordFileBuilder
    {
        public string XmlString { get; private set; }


        public XmlWordFileBuilder()
        {
            XmlString = string.Empty;
        }

        public XDocument BuildWordFile(List<string> strings)
        {
            var xDoc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("words"));
            
            foreach (var s in strings)
                xDoc.Element("words").Add(new XElement("word", s));    

            XmlString = xDoc.ToString();

            return xDoc;
        }
    }
}
