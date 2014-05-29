using System.Xml.Linq;

namespace WordBank.Utility.Interfaces
{
    public interface IXDocumentParser
    {
        XDocument ParseXDocument(string xml);
    }
}
