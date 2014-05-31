using System.Collections.Generic;
using System.Xml.Linq;

namespace WordBank.Utility.Interfaces
{
    public interface IWordFileBuilder
    {
        string XmlString { get; }

        XDocument BuildWordFile(List<string> strings);
    }
}
