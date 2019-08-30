using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class hmGame : Form
    {
        static List<char> letters = new List<char>();
        static int pos = 0;
        static int wordChosen;
        static int guessLeft;
        static string theWordChosen;
        static List<string> Words = new List<string>();
        public hmGame()
        {
            loadWords();
            InitializeComponent();
        }
        private void loadWords()
        {
            string path = System.IO.Directory.GetCurrentDirectory();
            string wordsFileDirectory = path+"\\words.txt";
            if (System.IO.File.Exists(wordsFileDirectory) && new System.IO.FileInfo(wordsFileDirectory).Length != 0)
            {   
                System.IO.StreamReader wordsLoader = new System.IO.StreamReader(wordsFileDirectory);
                int i = 0;
                while (wordsLoader.Peek() != -1)
                {
                        Words.Insert(i, wordsLoader.ReadLine());
                        i++;    
                }
                wordsLoader.Close();
            }
            else if (!System.IO.File.Exists(wordsFileDirectory))
            {
                MessageBox.Show("Words file was not found! We'll create one for you, already loaded with 5 words!");
                createWordsFile();
            }
            else if (new System.IO.FileInfo(wordsFileDirectory).Length == 0)
            {
                MessageBox.Show("Words file was found but is empty, we'll put some words for you!");
                createWordsFile();
            }
        }
        private void createWordsFile()
        {
            string path = System.IO.Directory.GetCurrentDirectory();
            string wordsFileDirectory = path + "\\words.txt";
            System.IO.StreamWriter wordsFileWriter = new System.IO.StreamWriter(wordsFileDirectory);
            wordsFileWriter.WriteLine("watermelon");
            wordsFileWriter.WriteLine("car");
            wordsFileWriter.WriteLine("mouse");
            wordsFileWriter.WriteLine("computer");
            wordsFileWriter.WriteLine("school");
            wordsFileWriter.Close();
            loadWords();
        }
        private void chooseLetter_Click(object sender, EventArgs e)
        {
            try
            {
                char ltr = char.Parse(letter.Text);
                int letterPos = Words[wordChosen].IndexOf(ltr.ToString().ToLower());
                if (!letters.Contains(ltr))
                {
                    if (letterPos != -1)
                    {
                        while (letterPos != -1)
                        {
                            word.Text = word.Text.Remove(letterPos, 1);
                            word.Text = word.Text.Insert(letterPos, ltr.ToString().ToLower());
                            Words[wordChosen] = Words[wordChosen].Remove(letterPos, 1);
                            Words[wordChosen] = Words[wordChosen].Insert(letterPos, "*");
                            letterPos = Words[wordChosen].IndexOf(ltr.ToString().ToLower());
                            if (!word.Text.Contains('*'))
                                gameOver(true);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Letter wasn't found in the word!");
                        guessLeft -= 1;
                        guessesLeft.Text = guessLeft.ToString();
                        if (guessLeft == 0)
                            gameOver(false);
                    }
                    if (guessLeft != -1)
                    {
                        letter.Text = null;
                        letters.Insert(pos, ltr);
                        pos++;
                    }
                }
                else
                {
                    MessageBox.Show("Letter was already guessed!");
                    letter.Text = null;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid letter, please try again!");
                letter.Text = null;
            }
        }

        private void newWord_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int rnd = r.Next(0, Words.Count);
            string savedWord = Words[rnd];
            for (int i=0; i < Words[rnd].Length; i++)
            {
                Words[rnd] = Words[rnd].Remove(i, 1).Insert(i, "*");
            }
            word.Text = Words[rnd];
            wordChosen = rnd;
            Words[rnd] = savedWord;
            chooseLetter.Enabled = true;
            letter.Visible = true;
            guessLeft = 6;
            guessesLeft.Text = guessLeft.ToString();
            theWordChosen = Words[wordChosen];
            letters.Clear();
        }
        private void gameOver(bool wordGuessed)
        {
            if (!wordGuessed)
                MessageBox.Show("Word was not guessed, the man was hanged D:!");
            else if (wordGuessed)
                MessageBox.Show("Word was guessed correctly, congratulations!");
            chooseLetter.Enabled = false;
            letter.Visible = false;
            letter.Text = null;
            letters.Clear();
            guessLeft = -1;
            guessesLeft.Text = null;
            word.Text = null;
            Words[wordChosen] = theWordChosen;
            theWordChosen = null;
            pos = 0;
        }

        private void letter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) && letter.Text.Length < 1 || e.KeyChar == (char)Keys.Back);
        }
    }
}
