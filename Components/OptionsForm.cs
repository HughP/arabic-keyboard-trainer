using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Arabic_Keyboard_Tutor.Data;

namespace Arabic_Keyboard_Tutor.Components
{
    public partial class OptionsForm : Form
    {
        private Settings _settings;
        public OptionsForm(Settings settings)
        {
            InitializeComponent();
            this._settings = settings;
            this.FirstPartCountTextBox.Text = _settings.lettersCountPartOne.ToString();
            this.SecondPartCountTextBox.Text = _settings.lettersCountPartTwo.ToString();
            this.ThirdPartCountTextBox.Text = _settings.lettersCountPartThree.ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            _settings = null;
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try 
            {
                _settings.lettersCountPartOne = Int16.Parse(FirstPartCountTextBox.Text);
                _settings.lettersCountPartTwo = Int16.Parse(SecondPartCountTextBox.Text);
                _settings.lettersCountPartThree = Int16.Parse(ThirdPartCountTextBox.Text);
                this.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error converting letter count values to string! Please, use numbers only! " + ex.Message);
            }
        }
        public Settings settings
        {
            get { return _settings; }
        }

    }
}
