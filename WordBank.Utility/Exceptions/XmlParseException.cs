using System;

namespace WordBank.Utility.Exceptions
{
    public sealed class XmlParseException : Exception
    {
        public XmlParseException()
        {            
        }

        public XmlParseException(string message)
            :base(message)
        {            
        }

        public XmlParseException(string message, Exception exception)
            :base(message, exception)
        {            
        }
    }
}
