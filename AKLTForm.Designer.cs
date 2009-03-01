namespace Arabic_Keyboard_Tutor
{
    partial class ArabicKeyboardLayoutTrainer
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lessonsComboBox = new System.Windows.Forms.ComboBox();
            this.errorsCountLabel = new System.Windows.Forms.Label();
            this.keyCodeLabel = new System.Windows.Forms.Label();
            this.ErrorsLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.fingerNumberLabel = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.RichTextBox();
            this.wordUnderMouse = new System.Windows.Forms.Label();
            this.fingerPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.currentWordTranslation = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fingerPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lessonsComboBox
            // 
            this.lessonsComboBox.AllowDrop = true;
            this.lessonsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lessonsComboBox.Location = new System.Drawing.Point(473, 35);
            this.lessonsComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lessonsComboBox.Name = "lessonsComboBox";
            this.lessonsComboBox.Size = new System.Drawing.Size(197, 21);
            this.lessonsComboBox.TabIndex = 0;
            this.lessonsComboBox.SelectedIndexChanged += new System.EventHandler(this.lessonsComboBox_SelectedIndexChanged);
            this.lessonsComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed);
            this.lessonsComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyEntered);
            // 
            // errorsCountLabel
            // 
            this.errorsCountLabel.AutoSize = true;
            this.errorsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorsCountLabel.ForeColor = System.Drawing.Color.Red;
            this.errorsCountLabel.Location = new System.Drawing.Point(84, 89);
            this.errorsCountLabel.Name = "errorsCountLabel";
            this.errorsCountLabel.Size = new System.Drawing.Size(21, 24);
            this.errorsCountLabel.TabIndex = 2;
            this.errorsCountLabel.Text = "0";
            // 
            // keyCodeLabel
            // 
            this.keyCodeLabel.AutoSize = true;
            this.keyCodeLabel.Location = new System.Drawing.Point(484, 255);
            this.keyCodeLabel.Name = "keyCodeLabel";
            this.keyCodeLabel.Size = new System.Drawing.Size(0, 13);
            this.keyCodeLabel.TabIndex = 3;
            // 
            // ErrorsLabel
            // 
            this.ErrorsLabel.AutoSize = true;
            this.ErrorsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorsLabel.Location = new System.Drawing.Point(12, 89);
            this.ErrorsLabel.Name = "ErrorsLabel";
            this.ErrorsLabel.Size = new System.Drawing.Size(66, 24);
            this.ErrorsLabel.TabIndex = 4;
            this.ErrorsLabel.Text = "Errors:";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(595, 61);
            this.nextButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 22);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "Next ->";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            this.nextButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyEntered);
            // 
            // fingerNumberLabel
            // 
            this.fingerNumberLabel.AutoSize = true;
            this.fingerNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fingerNumberLabel.Location = new System.Drawing.Point(580, 89);
            this.fingerNumberLabel.Name = "fingerNumberLabel";
            this.fingerNumberLabel.Size = new System.Drawing.Size(75, 24);
            this.fingerNumberLabel.TabIndex = 6;
            this.fingerNumberLabel.Text = "Finger: ";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Font = new System.Drawing.Font("Arabic Transparent", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.fromTextBox.Location = new System.Drawing.Point(12, 148);
            this.fromTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.ReadOnly = true;
            this.fromTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fromTextBox.Size = new System.Drawing.Size(658, 180);
            this.fromTextBox.TabIndex = 7;
            this.fromTextBox.Text = "";
            this.fromTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyEntered);
            this.fromTextBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.fromTextBox_MouseMove);
            this.fromTextBox.MouseLeave += new System.EventHandler(this.fromTextBox_MouseLeave);
            // 
            // wordUnderMouse
            // 
            this.wordUnderMouse.AutoSize = true;
            this.wordUnderMouse.Font = new System.Drawing.Font("Doulos SIL", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.wordUnderMouse.Location = new System.Drawing.Point(12, 36);
            this.wordUnderMouse.Name = "wordUnderMouse";
            this.wordUnderMouse.Size = new System.Drawing.Size(0, 20);
            this.wordUnderMouse.TabIndex = 8;
            // 
            // fingerPictureBox
            // 
            this.fingerPictureBox.Image = global::Arabic_Keyboard_Tutor.Properties.Resources.two_hands;
            this.fingerPictureBox.Location = new System.Drawing.Point(244, 35);
            this.fingerPictureBox.Name = "fingerPictureBox";
            this.fingerPictureBox.Size = new System.Drawing.Size(183, 99);
            this.fingerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fingerPictureBox.TabIndex = 9;
            this.fingerPictureBox.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(682, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(103, 22);
            this.toolStripMenuItem1.Text = "About";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // currentWordTranslation
            // 
            this.currentWordTranslation.AutoSize = true;
            this.currentWordTranslation.Font = new System.Drawing.Font("Doulos SIL", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentWordTranslation.Location = new System.Drawing.Point(12, 63);
            this.currentWordTranslation.Name = "currentWordTranslation";
            this.currentWordTranslation.Size = new System.Drawing.Size(0, 20);
            this.currentWordTranslation.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Doulos SIL", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 8;
            // 
            // ArabicKeyboardLayoutTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 341);
            this.Controls.Add(this.fingerPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentWordTranslation);
            this.Controls.Add(this.wordUnderMouse);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.fingerNumberLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.ErrorsLabel);
            this.Controls.Add(this.keyCodeLabel);
            this.Controls.Add(this.errorsCountLabel);
            this.Controls.Add(this.lessonsComboBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ArabicKeyboardLayoutTrainer";
            this.Text = "Arabic Keyboard Layout Trainer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ArabicKeyboardLayoutTrainer_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.fingerPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lessonsComboBox;
        private System.Windows.Forms.Label errorsCountLabel;
        private System.Windows.Forms.Label keyCodeLabel;
        private System.Windows.Forms.Label ErrorsLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label fingerNumberLabel;
        private System.Windows.Forms.RichTextBox fromTextBox;
        private System.Windows.Forms.Label wordUnderMouse;
        private System.Windows.Forms.PictureBox fingerPictureBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label currentWordTranslation;
        private System.Windows.Forms.Label label2;
    }
}

