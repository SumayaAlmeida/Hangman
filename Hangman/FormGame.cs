using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class FormGame : Form
    {

        private string[] words = {"MEMORY", "COMPUTER", "PRINTER", "TORUSERS", "BUTTERCUP"};
        public static string misteryWord;
        private int guessesRemaining = 8;

        // COUNT HOW MANY TIMES THE USER HAS PLAYED - USED TO ACCESS THE INDEX OF THE WORDS IN WORDS ARRAY
        // AND LIMIT THE NUMBER OF GAMES TO THE NUMBER OF AVAILABLE WORDS

        public int gameNumber = 0; 

        // A LIST OF ASTERIX SAME SIZE AS MISTERYWORD CHARACTERS
        List<char> listOfAsterix = new List<char>();
        //CONVERT LIST TO STRING TO DISPLAY IN TEXTBOX
        string hiddenWord;

        // LIST OF BUTTONS THAT WERE PRESSED TO BE ABLE TO RESTORE ORIGINAL COLORS AT THE END OF THE GAME
        public static Button b = new Button();
        public List<Button> buttonsPressed = new List<Button> {b};

        public FormGame()
        {
            InitializeComponent();
        }

        // TO EXECUTE WHEN BUTTON START IS CLICKED
        internal void Start(int gameNumber)
        {

            misteryWord = words[gameNumber]; 
            string hiddenWord = "";
            listOfAsterix.Clear();
            for (int i = 0; i < misteryWord.Length; i++)
            {
                listOfAsterix.Add('*');
                hiddenWord += listOfAsterix[i];
            }


            textBoxWord.Text = hiddenWord;
            buttonAnswer.Enabled = false;


        }

        //CHECK IF THE CHARACTER CLICKED IS PART OF THE MYSTERYWORD
        internal void CheckGuess(char letter, Button pressed)
        {
            var indexes = new List<int>();
            for (int i = 0; i < misteryWord.Length; i++)
            {
                if(misteryWord[i] == letter) 
                indexes.Add(i);

            }
            
            if (misteryWord.Contains(letter))
            {
                foreach(int i in indexes)
                {
                    listOfAsterix[i] = letter;

                }

                hiddenWord = new string(listOfAsterix.ToArray());
                textBoxWord.Text = hiddenWord;
                if (!hiddenWord.Contains('*'))
                {
                    MessageBox.Show("YOU WIN");
                    if (gameNumber < (words.Length-1))
                    {
                        gameNumber++;
                    }
                    else
                    {
                        gameNumber = 0;
                    }
                       
                }

                pressed.BackColor = Color.Green;
            }
            else
            {
                pressed.BackColor = Color.Red;
                --guessesRemaining;
                textBoxGuesses.Text = guessesRemaining.ToString();
                if (guessesRemaining == 0)
                {
                    MessageBox.Show("YOU LOSE");
                    textBoxWord.Text = "GAME OVER";
                    buttonAnswer.Enabled = true;
                    if (gameNumber < (words.Length - 1))
                    {
                        gameNumber++;
                    }
                    else
                    {
                        gameNumber = 0;
                    }

                }
            }
        }

        public void ClearButtonColor()
        {
            foreach (Button b in buttonsPressed)
            {
                b.UseVisualStyleBackColor = true;
                guessesRemaining = 8;
                textBoxGuesses.Text = guessesRemaining.ToString();
            }

        }

        private void EnableButtons()
        {
            foreach (Control c in this.Controls)
            {
                Button b = c as Button;
                if (b != null)
                {
                    b.Enabled = true;
                }
            }
        }

        private void DisableButtons()
        {
            foreach (Control c in this.Controls)
            {
                Button b = c as Button;
                if (b != null)
                {
                    b.Enabled = false;
                }
            }
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            textBoxGuesses.Text = guessesRemaining.ToString();
            DisableButtons();
            buttonStart.Enabled = true;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            ClearButtonColor();
            EnableButtons();
            Start(gameNumber);
            
        }

        private void buttonLetter_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            buttonsPressed.Add(button);
            CheckGuess(button.Text[0], button);
            button.Enabled = false;
        }

        private void buttonAnswer_Click(object sender, EventArgs e)
        {
            textBoxWord.Text = misteryWord;
        }
    }
}
