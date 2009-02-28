using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arabic_Keyboard_Tutor.Data
{
    interface ITranslatable
    {
        string word { get; }
        string translation { get; }
        string transcription { get; }
    }
}
