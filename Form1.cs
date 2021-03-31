using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Hangman_Lite
{
    public partial class HangmanLite : Form
    {
        string word, displayWord, guess;
        int guessNum,index;
        List<string> guesses = new List<string>();
        static List<string> words = new List<string>() {"ABSURD","BOXCAR","DUPLEX","ICEBOX","INJURY","JIGSAW","JOCKEY","JOYFUL","LARYNX","PSYCHE"};
        static Random rnd = new Random();
        static int rndindex = rnd.Next(words.Count);
        string rndword = words[rndindex];

        
        public HangmanLite()
        {
            InitializeComponent();
        }

        private void HangmanLite_Load(object sender, EventArgs e)
        {
            word = rndword;
            displayWord = "------";
            lblWord.Text = displayWord;
            guessNum = 0;
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            guess = txtGuess.Text.ToUpper();
            
            

            if (word.Contains(guess))
            {
                index = word.IndexOf(guess);
                displayWord = displayWord.Remove(index, 1);
                displayWord = displayWord.Insert(index, guess);
                lblWord.Text = displayWord;
                if (displayWord == word)
                {
                    lblResult.ForeColor = Color.Green;
                    lblResult.Text = "You Win!";
                    SoundPlayer win = new SoundPlayer(Properties.Resources.WinSoundEffect);
                    win.Play();
                }
          
            }
            else
            {
                guesses.Add(guess);
                lstGuessedLetters.DataSource = null;
                lstGuessedLetters.DataSource = guesses;
                guessNum = guessNum + 1;

                if (guessNum == 1)
                {
                    imgHangman.Image = Properties.Resources.Hangman1;
                }
                else if (guessNum == 2)
                {
                    imgHangman.Image = Properties.Resources.Hangman2;
                }
                else if (guessNum == 3)
                {
                    imgHangman.Image = Properties.Resources.Hangman3;
                }
                else if (guessNum == 4)
                {
                    imgHangman.Image = Properties.Resources.Hangman4;
                }
                else if (guessNum == 5)
                {
                    imgHangman.Image = Properties.Resources.Hangman5;
                }
                else
                {
                    imgHangman.Image = Properties.Resources.HangmanFull;
                    btnGuess.Enabled = false;
                    txtGuess.Enabled = false;
                    lblResult.Text = "Game Over";
                    SoundPlayer lose = new SoundPlayer(Properties.Resources.LosingSoundEffect);
                    lose.Play();
                }
            }
        }

        private void imgHangman_Click(object sender, EventArgs e)
        {

        }
    }
}
