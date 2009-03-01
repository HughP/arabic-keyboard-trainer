using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Arabic_Keyboard_Tutor.Data;
using Microsoft.Win32;

namespace Arabic_Keyboard_Tutor.DAO
{
    class SettingsDAO
    {
        private RegistryKey regKey = Registry.CurrentUser.CreateSubKey("Software\\IgorDeruga\\ArabicKeyboardTrainer");
        private const string LETTERS_COUNT_ONE = "lettersCountPartOne";
        private const string LETTERS_COUNT_TWO = "lettersCountPartTwo";
        private const string LETTERS_COUNT_THREE = "lettersCountPartThree";
        private const string LESSON_NUMBER = "lastLessonNumber";

        public void saveSettings(Settings settings)
        {
            regKey.SetValue(LETTERS_COUNT_ONE, settings.lettersCountPartOne);
            regKey.SetValue(LETTERS_COUNT_TWO, settings.lettersCountPartTwo);
            regKey.SetValue(LETTERS_COUNT_THREE, settings.lettersCountPartThree);
            regKey.SetValue(LESSON_NUMBER, settings.currentLessonNumber);
        }
        public Settings loadSettings()
        {
            Settings result = new Settings();
            result.lettersCountPartOne = (int)regKey.GetValue(LETTERS_COUNT_ONE, result.lettersCountPartOne);
            result.lettersCountPartTwo = (int)regKey.GetValue(LETTERS_COUNT_TWO, result.lettersCountPartTwo);
            result.lettersCountPartThree = (int)regKey.GetValue(LETTERS_COUNT_THREE, result.lettersCountPartThree);
            result.currentLessonNumber = (int)regKey.GetValue(LESSON_NUMBER, result.currentLessonNumber);
            return result;
        }
        private object loadRegistryValue(string subKey)
        {
            return regKey.GetValue(subKey);
        }
        private void saveRegistryValue(string subKey, object value)
        {
            regKey.SetValue(subKey, value);
        }
    }
}
