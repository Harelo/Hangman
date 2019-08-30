namespace WindowsFormsApplication1
{
    partial class hmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.word = new System.Windows.Forms.TextBox();
            this.chooseLetter = new System.Windows.Forms.Button();
            this.guessesLeft = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.letter = new System.Windows.Forms.TextBox();
            this.newWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // word
            // 
            this.word.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.word.Location = new System.Drawing.Point(42, 12);
            this.word.Multiline = true;
            this.word.Name = "word";
            this.word.ReadOnly = true;
            this.word.Size = new System.Drawing.Size(138, 44);
            this.word.TabIndex = 0;
            this.word.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chooseLetter
            // 
            this.chooseLetter.Enabled = false;
            this.chooseLetter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.chooseLetter.Location = new System.Drawing.Point(42, 75);
            this.chooseLetter.Name = "chooseLetter";
            this.chooseLetter.Size = new System.Drawing.Size(138, 62);
            this.chooseLetter.TabIndex = 1;
            this.chooseLetter.Text = "Click to guess the letter below";
            this.chooseLetter.UseVisualStyleBackColor = true;
            this.chooseLetter.Click += new System.EventHandler(this.chooseLetter_Click);
            // 
            // guessesLeft
            // 
            this.guessesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.guessesLeft.Location = new System.Drawing.Point(128, 206);
            this.guessesLeft.Multiline = true;
            this.guessesLeft.Name = "guessesLeft";
            this.guessesLeft.ReadOnly = true;
            this.guessesLeft.Size = new System.Drawing.Size(41, 21);
            this.guessesLeft.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Guesses left:";
            // 
            // letter
            // 
            this.letter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.letter.Location = new System.Drawing.Point(101, 143);
            this.letter.Multiline = true;
            this.letter.Name = "letter";
            this.letter.Size = new System.Drawing.Size(30, 28);
            this.letter.TabIndex = 4;
            this.letter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.letter.Visible = false;
            this.letter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letter_KeyPress);
            // 
            // newWord
            // 
            this.newWord.Location = new System.Drawing.Point(57, 273);
            this.newWord.Name = "newWord";
            this.newWord.Size = new System.Drawing.Size(110, 23);
            this.newWord.TabIndex = 5;
            this.newWord.Text = "Generate new word";
            this.newWord.UseVisualStyleBackColor = true;
            this.newWord.Click += new System.EventHandler(this.newWord_Click);
            // 
            // hmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(221, 335);
            this.Controls.Add(this.newWord);
            this.Controls.Add(this.letter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guessesLeft);
            this.Controls.Add(this.chooseLetter);
            this.Controls.Add(this.word);
            this.Name = "hmGame";
            this.Text = "Hangman";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox word;
        private System.Windows.Forms.Button chooseLetter;
        private System.Windows.Forms.TextBox guessesLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox letter;
        private System.Windows.Forms.Button newWord;
    }
}

