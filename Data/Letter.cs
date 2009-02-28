using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arabic_Keyboard_Tutor.Data
{
    class Letter: ITranslatable
    {
        private string _letter;
        private int _keyValue;
        private int _finger;
        private string _pronunciation;
        private string _transcription;
        public Letter(string letter, int keyValue, int finger, string pronunciation, string transcription)
        {
            this._letter = letter;
            this._keyValue = keyValue;
            this._finger = finger;
            this._pronunciation = pronunciation;
            this._transcription = transcription;
        }

        public string letter
        {
            get { return _letter; }
        }
        
        public int keyValue
        {
            get { return _keyValue; }
        }

        public int finger
        {
            get { return _finger; }
        }

        public string pronunciation
        {
            get { return _pronunciation; }
        }

        #region ITranslatable Membres

        public string word
        {
            get { return _letter; }
        }

        public string translation
        {
            get { return _pronunciation; }
        }

        public string transcription
        {
            get { return _transcription; }
        }

        #endregion
    }
}
