using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arabic_Keyboard_Tutor.Data
{
    class Word: ITranslatable
    {
        private string _word;
        private string _translation;
        private string _transcription;

        public Word(string word, string translation, string transcription)
        {
            this._word = word;
            this._translation = translation;
            this._transcription = transcription;
        }

        public string word
        {
            get { return _word; }
        }
        public string translation
        {
            get { return _translation; }
        }
        public string transcription
        {
            get { return _transcription; }
        }

    }
}
