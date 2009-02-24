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
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.errorsCountLabel = new System.Windows.Forms.Label();
            this.keyCodeLabel = new System.Windows.Forms.Label();
            this.ErrorsLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.fingerNumberLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lessonsComboBox
            // 
            this.lessonsComboBox.AllowDrop = true;
            this.lessonsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lessonsComboBox.Location = new System.Drawing.Point(473, 9);
            this.lessonsComboBox.Name = "lessonsComboBox";
            this.lessonsComboBox.Size = new System.Drawing.Size(197, 21);
            this.lessonsComboBox.TabIndex = 0;
            this.lessonsComboBox.SelectedIndexChanged += new System.EventHandler(this.lessonsComboBox_SelectedIndexChanged);
            this.lessonsComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.keyPressed);
            this.lessonsComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyEntered);
            // 
            // fromTextBox
            // 
            this.fromTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.fromTextBox.Font = new System.Drawing.Font("Arabic Transparent", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.fromTextBox.Location = new System.Drawing.Point(12, 12);
            this.fromTextBox.Multiline = true;
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.ReadOnly = true;
            this.fromTextBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fromTextBox.Size = new System.Drawing.Size(454, 262);
            this.fromTextBox.TabIndex = 1;
            this.fromTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyEntered);
            // 
            // errorsCountLabel
            // 
            this.errorsCountLabel.AutoSize = true;
            this.errorsCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.errorsCountLabel.ForeColor = System.Drawing.Color.Red;
            this.errorsCountLabel.Location = new System.Drawing.Point(649, 247);
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
            this.ErrorsLabel.Location = new System.Drawing.Point(577, 247);
            this.ErrorsLabel.Name = "ErrorsLabel";
            this.ErrorsLabel.Size = new System.Drawing.Size(66, 24);
            this.ErrorsLabel.TabIndex = 4;
            this.ErrorsLabel.Text = "Errors:";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(595, 36);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
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
            this.fingerNumberLabel.Location = new System.Drawing.Point(577, 211);
            this.fingerNumberLabel.Name = "fingerNumberLabel";
            this.fingerNumberLabel.Size = new System.Drawing.Size(75, 24);
            this.fingerNumberLabel.TabIndex = 6;
            this.fingerNumberLabel.Text = "Finger: ";
            // 
            // ArabicKeyboardLayoutTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 283);
            this.Controls.Add(this.fingerNumberLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.ErrorsLabel);
            this.Controls.Add(this.keyCodeLabel);
            this.Controls.Add(this.errorsCountLabel);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.lessonsComboBox);
            this.Name = "ArabicKeyboardLayoutTrainer";
            this.Text = "Arabic Keyboard Layout Trainer";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lessonsComboBox;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.Label errorsCountLabel;
        private System.Windows.Forms.Label keyCodeLabel;
        private System.Windows.Forms.Label ErrorsLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label fingerNumberLabel;
    }
}

