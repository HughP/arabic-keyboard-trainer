using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Arabic_Keyboard_Tutor.Data
{
    public class Settings
    {
        private int _lettersCountPartOne = 70;
        private int _lettersCountPartTwo = 150;
        private int _lettersCountPartThree = 200;

        private int _currentLessonNumber = 0;
        
        public enum Stage : int {Letters, Reiteration, Words };

        private Dictionary<Stage, int> lettersPerStage = new Dictionary<Stage, int>();

        public Settings()
        {
            lettersPerStage.Add(Stage.Letters, _lettersCountPartOne);
            lettersPerStage.Add(Stage.Reiteration, _lettersCountPartTwo);
            lettersPerStage.Add(Stage.Words, _lettersCountPartThree);
        }

        public int getLettersPerStage(Stage stage)
        {
            return lettersPerStage[stage];
        }

        public int lettersCountPartOne
        {
            get { return _lettersCountPartOne; }
            set { _lettersCountPartOne = value; }
        }
        public int lettersCountPartTwo
        {
            get { return _lettersCountPartTwo; }
            set { _lettersCountPartTwo = value; }
        }
        public int lettersCountPartThree
        {
            get { return _lettersCountPartThree; }
            set { _lettersCountPartThree = value; }
        }
        public int currentLessonNumber
        {
            get { return _currentLessonNumber; }
            set { _currentLessonNumber = value; }
        }
    }
}
