using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Arabic_Keyboard_Tutor.Data;

namespace Arabic_Keyboard_Tutor
{
    public partial class ArabicKeyboardLayoutTrainer : Form
    {
        private List<Letter> letters = new List<Letter>();
        private Dictionary<string, Letter> lettersMap = new Dictionary<string, Letter>();
        private Dictionary<int, Letter> keysMap = new Dictionary<int, Letter>();
        private List<Word> words = new List<Word>();
        private const int LETTERS_COUNT = 155;
        private int errorsCount = 0;
        
        public ArabicKeyboardLayoutTrainer()
        {
//            showLetterCode("ˁ");
            InitializeComponent();
            initializeDictionaries();
        }
        private void showLetterCode(string letter)
        {
            string result = "";
            byte[] bytes = Encoding.Unicode.GetBytes(letter);
            for (int i = bytes.Length - 1; i >= 0;  i--)
            {
                result += String.Format(" {0:X}", bytes[i]);
            }
            MessageBox.Show(result);
        }
        private int[] fingers;
        private enum Stage : int {Letters, Reiteration, Words };
        private Stage currentStage = Stage.Letters;
        private Dictionary<string, Word> dict = new Dictionary<string, Word>();
        private void initializeDictionaries()
        {
            letters.Add(new Letter("ب", 70, 4));
            letters.Add(new Letter("ت", 74, 4));
            letters.Add(new Letter("ي", 68, 3));
            letters.Add(new Letter("ن", 75, 3));
            letters.Add(new Letter("س", 83, 2));
            letters.Add(new Letter("م", 76, 2));
            letters.Add(new Letter("ش", 65, 1));
            letters.Add(new Letter("ك", 186, 1));
            letters.Add(new Letter("ل", 71, 4));
            letters.Add(new Letter("ا", 72, 4));
            letters.Add(new Letter("ق", 82, 4));
            letters.Add(new Letter("ع", 85, 4));
            letters.Add(new Letter("ث", 69, 3));
            letters.Add(new Letter("ه", 73, 3));
            letters.Add(new Letter("ص", 87, 2));
            letters.Add(new Letter("خ", 79, 2));
            letters.Add(new Letter("ض", 81, 1));
            letters.Add(new Letter("ح", 80, 1));
            letters.Add(new Letter("ف", 84, 4));
            letters.Add(new Letter("غ", 89, 4));
            letters.Add(new Letter("ر", 86, 4));
            letters.Add(new Letter("ة", 77, 4));
            letters.Add(new Letter("ؤ", 67, 3));
            letters.Add(new Letter("و", 188, 3));
            letters.Add(new Letter("ء", 88, 2));
            letters.Add(new Letter("ز", 190, 2));
            letters.Add(new Letter("ئ", 90, 1));
            letters.Add(new Letter("ظ", 191, 1));
            letters.Add(new Letter("ى", 78, 4));
            letters.Add(new Letter("ط", 222, 4));
            letters.Add(new Letter("ج", 219, 1));
            letters.Add(new Letter("د", 221, 1));
            letters.Add(new Letter("ذ", 220, 1));

            foreach (Letter letter in letters)
            {
                lettersMap.Add(letter.letter, letter);
                keysMap.Add(letter.keyValue, letter);
            }

            words.Add(new Word("بنت", "une fille", "bint\u032A"));
            words.Add(new Word("ليل", "une nuit", "lajla"));
            words.Add(new Word("مرحبا", "salut!", "mar\u0127aba:"));
            words.Add(new Word("نهار", "un jour", ""));
            words.Add(new Word("مساء", "un soir", "misa\u0294"));
            words.Add(new Word("غابة", "un forêt", "\u0236a:ba"));
            words.Add(new Word("بحر", "une mer", "ba\u0127r"));
            words.Add(new Word("صحراء", "un désert", "s\u02c1a\u0127ra:\u0294"));
            /*
            words.Add(new Word("", "", ""));
            words.Add(new Word("", "", ""));
            words.Add(new Word("", "", ""));
            */

            foreach (Word word in words)
            {
                dict.Add(word.word, word);
            }
            
            /*
            chunkList[] = new string[] { "", "" };
            */

            fingers = new int[] { 4, 3, 2, 1, 4, 4, 3, 2, 1, 4, 4, 3, 2, 1, 4, 4, 3, 2, 1, 4 };
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            initLessonsComboBox();
        }
        private void initLessonsComboBox()
        {
            int lessonsCount = letters.Count / 2 + letters.Count % 2;
            string[] s = new string[lessonsCount];
            for (int i = 0; i < lessonsCount; i++)
            {
                s[i] = "Lesson " + (i+1);
            }
            lessonsComboBox.DataSource = s;
        }

        private void lessonsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentStage = Stage.Letters;
            generateLesson();
        }
        private void generateLesson()
        {
            int lessonNumber = lessonsComboBox.SelectedIndex;
            fromTextBox.Text = generateText(lessonNumber);
            if (fromTextBox.Text == "")
            {
                nextLesson();
            }
            fingerNumberLabel.Text = "Finger: " + fingerNumber(fromTextBox.Text);
            enableDisableNextButton();
            setFirstLetterColor();
        }
        private Random r = new Random();
        string lastChar = null;
        int lastCount = 0;
        private string generateText(int lessonNumber)
        {
            string result = "";
            List<string> chunksList = new List<string>();
            int letterPos = lessonNumber*2;
            int lettersCount = letterPos + 1;
            if (letterPos + 1 < letters.Count)
            {
                lettersCount++;
            }

            if (currentStage == Stage.Letters)
            {
                for (int i = letterPos; i < lettersCount; i++)
                {
                    chunksList.Add(letters[i].letter);
                }
            }
            else
            {
                for (int i = 0; i < lettersCount; i++)
                {
                    chunksList.Add(letters[i].letter);
                }
                 if (currentStage == Stage.Words)
                 {
                     List<string> wordsList = new List<string>();
                     for (int i = 0; i < words.Count; i++)
                     {
                         char[] wordLetters = words[i].word.ToCharArray();
                         Boolean isFine = true;
                         for (int j = 0; j < wordLetters.Length; j++)
                         {
                             if (!chunksList.Contains("" + wordLetters[j]))
                             {
                                 isFine = false;
                                 break;
                             }
                         }
                         if (isFine)
                         {
                             wordsList.Add(words[i].word);
                         }
                     }
                     chunksList = wordsList;
                 }
            }
            if (chunksList.Count > 1)
            {
                for (int i = 0; result.Length < LETTERS_COUNT; i++)
                {
                    string next = null;
                    //We don't want more than three consecutive letters/words
                    do
                    {
                        next = chunksList[r.Next(chunksList.Count)];
                        if (next == lastChar)
                        {
                            lastCount++;
                        }
                        else
                        {
                            lastCount = 0;
                        }
                        lastChar = next;
                    }  while (lastCount >= 3);

                    result += (i == 0 ? "" : " ") + next;
                }
            }
            return result;
        }
        private void keyEntered(object sender, KeyEventArgs e)
        {
            if (e.Alt || e.Shift || e.Control)
            {
                return;
            }
            keyCodeLabel.Text = "" + e.KeyValue;
            if (keysMap.Keys.Contains(e.KeyValue))
            {
                string letter = keysMap[e.KeyValue].letter;
                if (fromTextBox.Text == "")
                {
                    return;
                }
                string[] txt = fromTextBox.Text.Split(' ');
                char[] letters = txt[0].ToCharArray();
                if (letter == letters[0].ToString())
                {
                    string result = "";
                    if (letters.Length > 1)
                    {
                        for (int i = 1; i < letters.Length; i++)
                        {
                            result += letters[i];
                        }
                        result += " ";
                    }
                    for (int i = 1; i < txt.Length; i++)
                    {
                        result += (i == 1 ? "" : " ") + txt[i];
                    }
                    fromTextBox.Text = result;
                    if (fromTextBox.Text == "")
                    {
                        nextLesson();
                    }
                    fingerNumberLabel.Text = "Finger: " + fingerNumber(fromTextBox.Text);
                    setFirstLetterColor();
                    return;
                }
            }
            if ((e.KeyValue >= 65 && e.KeyValue <= 90) 
                || (e.KeyValue >= 186 && e.KeyValue <= 191)
                || (e.KeyValue >= 219 && e.KeyValue <= 222))
            {
                errorsCount++;
                errorsCountLabel.Text = "" + errorsCount;
                fromTextBox.BackColor = Color.Red;
                Timer t = new Timer();
                t.Interval = 200;
                t.Tick += onTimer;
                t.Start();
            }
        }

        private void setFirstLetterColor()
        {
            //First letter should be colored
            fromTextBox.SelectAll();
            fromTextBox.SelectionColor = Color.Black;
            fromTextBox.Select(0, 1);
            fromTextBox.SelectionColor = Color.Blue;
        }
        private int fingerNumber(string result)
        {
            char[] arr = result.ToCharArray();
            string letter = arr[0].ToString();
            if (arr.Length > 0 && lettersMap.Keys.Contains(letter))
            {
                return lettersMap[letter].finger;
            }
            return -1;
        }
        private void onTimer(object source, EventArgs e)
        {
            ((Timer)source).Stop();
            fromTextBox.BackColor = Color.FromName("Control");
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            nextLesson();
        }
        private void nextLesson()
        {
            if (currentStage < Stage.Words)
            {
                currentStage++;
                if (lessonsComboBox.SelectedIndex == 0) currentStage++;
                generateLesson();
            }
            else
            {
                if (lessonsComboBox.SelectedIndex + 1 < lessonsComboBox.Items.Count)
                {
                    lessonsComboBox.SelectedIndex++;
                }
            }
            enableDisableNextButton();
        }
        private void enableDisableNextButton()
        {
            if (lessonsComboBox.SelectedIndex + 1 == ((string[])lessonsComboBox.DataSource).Length && currentStage == Stage.Words)
            {
                nextButton.Enabled = false;
            }
            else
            {
                nextButton.Enabled = true;
            }
        }

        private void keyPressed(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void fromTextBox_MouseMove(object sender, MouseEventArgs e)
        {
            Point pt = new Point(e.X, e.Y);
            int pos = fromTextBox.GetCharIndexFromPosition(pt);
            char c = fromTextBox.Text.ToCharArray()[pos];
            int start = fromTextBox.Text.LastIndexOf(" ", pos, pos);
            if (start < 0) start = 0;
            int end = fromTextBox.Text.IndexOf(" ", pos);
            if (end < 0) end = fromTextBox.Text.Length;
            string word = fromTextBox.Text.Substring(start, end - start);
            word = word.Trim();
            if (word != "")
            {
                if (dict.Keys.Contains(word))
                {
                    currentLetter.Text = word + " (" + dict[word].translation + ") [" + dict[word].transcription + "]";
                }
                else
                {
                    currentLetter.Text = "---";
                }
            }
        }

    }
}
