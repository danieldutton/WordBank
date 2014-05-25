using System.Collections.Generic;

namespace WordBank.QuestionBank.Interfaces
{
    public interface ISpellingsBank
    {
        Dictionary<string, string> GetSpellings();
    }
}
