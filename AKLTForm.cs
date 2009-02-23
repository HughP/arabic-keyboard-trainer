using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Arabic_Keyboard_Tutor
{
    public partial class ArabicKeyboardLayoutTrainer : Form
    {
        private Dictionary<int, char> arabic = new Dictionary<int, char>();
        private const int LETTERS_COUNT = 15;
        private int errorsCount = 0;
        
        public ArabicKeyboardLayoutTrainer()
        {
            InitializeComponent();
            initializeDictionaries();
        }
        private int[] fingers;
        private string[][] chunkList = new string[17][];
        private void initializeDictionaries()
        {
            arabic.Add(74, 'ت');
            arabic.Add(70, 'ب');
            arabic.Add(75, 'ن');
            arabic.Add(68, 'ي');
            arabic.Add(76, 'م');
            arabic.Add(83, 'س');
            arabic.Add(186, 'ك');
            arabic.Add(65, 'ش');
            arabic.Add(71, 'ل');
            arabic.Add(72, 'ا');
            arabic.Add(82, 'ق');
            arabic.Add(85, 'ع');
            arabic.Add(69, 'ث');
            arabic.Add(73, 'ه');
            arabic.Add(87, 'ص');
            arabic.Add(79, 'خ');
            arabic.Add(81, 'ض');
            arabic.Add(80, 'ح');
            arabic.Add(84, 'ف');
            arabic.Add(89, 'غ');
            arabic.Add(86, 'ر');
            arabic.Add(77, 'ة');
            arabic.Add(67, 'ؤ');
            arabic.Add(188, 'و');
            arabic.Add(88, 'ء');
            arabic.Add(190, 'ز');
            arabic.Add(90, 'ئ');
            arabic.Add(191, 'ظ');
//            arabic.Add(66, 'لا');
            arabic.Add(78, 'ى');
            arabic.Add(222, 'ط');
            arabic.Add(219, 'ج');
            arabic.Add(221, 'د');
            arabic.Add(220, 'ذ');

            chunkList[0] = new string[] { "ب", "ت" };
            chunkList[1] = new string[] { "ي", "ن" };
            chunkList[2] = new string[] { "س", "م" };
            chunkList[3] = new string[] { "ش", "ك" };
            chunkList[4] = new string[] { "ل", "ا" };
            chunkList[5] = new string[] { "ق", "ع" };
            chunkList[6] = new string[] { "ث", "ه" };
            chunkList[7] = new string[] { "ص", "خ" };
            chunkList[8] = new string[] { "ض", "ح" };
            chunkList[9] = new string[] { "ف", "غ" };
            chunkList[10] = new string[] { "ر", "ة" };
            chunkList[11] = new string[] { "ؤ", "و" };
            chunkList[12] = new string[] { "ء", "ز" };
            chunkList[13] = new string[] { "ئ", "ظ" };
            chunkList[14] = new string[] { "ى" }; //{ "لا", "ى" };
            chunkList[15] = new string[] { "ط", "ج" };
            chunkList[16] = new string[] { "د", "ذ"};
            
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
            string[] s = new string[chunkList.Length];
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = "Lesson " + (i+1);
            }
            lessonsComboBox.DataSource = s;
        }

        private void lessonsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            generateLesson(((ComboBox)sender).SelectedIndex + 1);
        }
        private void generateLesson(int lessonNumber)
        {

            fromTextBox.Text = generateText(lessonNumber);
            fingerNumberLabel.Text = "Finger: " + fingers[lessonNumber - 1];
            enableDisableNextButton();
        }
        private Random r;
        private string generateText(int lessonNumber)
        {
            string result = "";
            string[] chunks = chunkList[lessonNumber-1];
            List<string> allChunksList = new List<string>();
            for (int i = 0; i < lessonNumber; i++) {
                string[] c = chunkList[i];
                for (int j = 0; j < c.Length; j++) {
                    allChunksList.Add(c[j]);
                }
            }

            string[] allChunks = allChunksList.ToArray();
            r = new Random();

            for (int i = 0; result.Length < LETTERS_COUNT; i++)
            {
                if (result.Length < LETTERS_COUNT / 2 && chunks.Length > 1)
                {
                    result += getChunk(chunks, i);
                }
                else
                {
                    result += getChunk(allChunks, i);
                }
            }
            return result;
        }

        private string getChunk(string[] chunks, int i)
        {
            if (chunks != null)
            {
                return (i == 0 ? "" : " ") + chunks[r.Next(chunks.Length)]; ;
            }
            else
            {
                return "";
            }
        }

        private void keyEntered(object sender, KeyEventArgs e)
        {
            if (e.Alt || e.Shift || e.Control)
            {
                return;
            }
            keyCodeLabel.Text = "" + e.KeyValue;
            if (arabic.Keys.Contains(e.KeyValue))
            {
                char letter = arabic[e.KeyValue];
                if (fromTextBox.Text == "")
                {
                    return;
                }
                string[] txt = fromTextBox.Text.Split(' ');
                char[] letters = txt[0].ToCharArray();
                if (letter == letters[0])
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

        private int fingerNumber(string result)
        {
            char[] arr = result.ToCharArray();
            if (arr.Length > 0)
            {
                for (int i = 0; i < chunkList.Length; i++)
                {
                    if (chunkList[i].Contains("" + arr[0]))
                    {
                        return fingers[i];
                    }
                }
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
            if (lessonsComboBox.SelectedIndex+1 < ((string[])lessonsComboBox.DataSource).Length)
            {
                lessonsComboBox.SelectedIndex++;
            }
            enableDisableNextButton();
        }
        private void enableDisableNextButton()
        {
            if (lessonsComboBox.SelectedIndex + 1 >= ((string[])lessonsComboBox.DataSource).Length)
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

    }
}
