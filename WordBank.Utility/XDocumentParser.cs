using System;
using System.Xml.Linq;
using WordBank.Utility.Exceptions;
using WordBank.Utility.Interfaces;

namespace WordBank.Utility
{
    public class XDocumentParser : IXDocumentParser
    {
        public XDocument ParseXDocument(string xml)
        {
            XDocument xDoc;

            try
            {
                xDoc = XDocument.Parse(xml);
            }
            catch (Exception e)
            {
                throw new XmlParseException("failed to parse xml", e);
            }

            return xDoc;
        }
    }
}
