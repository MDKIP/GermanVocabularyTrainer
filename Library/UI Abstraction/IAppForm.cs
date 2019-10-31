using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public interface IAppForm
    {
        Dictionary<string, string> Vocabulary { get; }
        string VocabularyPath { get; }
    }
}
