namespace HangmanGame
{
    public partial class Form1 : Form
    {
        //This "BONUS" CODE
        private int roundCounter = 1;
        private int winStreak = 0;
        //BONUS ENDS

        public Form1()
        {
            InitializeComponent();
            NewGame();
        }

        private string secretWord;

        private char[] displayWord;

        private int remainingGuesses = 6;

        // Holds the incorrect guesses using a List command.
        private List<char> incorrectGuesses = new List<char>();

        //This is to select a random word
        private Random random = new Random();

        //These are the predetermined words that I used for the game
        private string[] wordList = { "word", "grapefruit", "programming", "syntax", "care", "ocean", "cat", "astronomy", "zombie", "superhero", "dancer" };


        private void NewGame()
        {
            secretWord = wordList[random.Next(wordList.Length)];

            displayWord = new string('_', secretWord.Length).ToCharArray();

            remainingGuesses = 6;

            incorrectGuesses.Clear();

            UpdateGame();
        }
        private void UpdateGame()
        {
            //This Line will display the given word as blanks and will display correct letters
            lbl_Word.Text = string.Join(" ", displayWord);

            lbl_Incorrect.Text = "Incorrect Guesses: " + string.Join(", ", incorrectGuesses);

            lbl_Guesses.Text = "Guesses Left: " + remainingGuesses;

            //BONUS CODE "shows the current round and win streak"
            lbl_Round.Text = "Round: " + roundCounter;
            lbl_WinS.Text = "Win Streak: " + winStreak;

            //BONUS CODE ENDS
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            //This line gets the guessed letter from the input textbox all in lowecase
            char guess = txtBox_Guess.Text.ToLower()[0];
            //clears for next guess
            txtBox_Guess.Clear();

            //Reveals a letter if it is correct
            if (secretWord.Contains(guess))
            {
                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (secretWord[i] == guess)
                    {
                        displayWord[i] = guess;
                    }
                }
            }
            else
            {
                //iff wrong id adds the guess to the incorrect guesses list
                if (!incorrectGuesses.Contains(guess))
                {
                    incorrectGuesses.Add(guess);
                    remainingGuesses--; //Reduces the number of guesses left
                }
            }

            //This updates the display accordingly 
            UpdateGame();
            CheckforEndGame();
        }
        private void CheckforEndGame()
        {
            if (remainingGuesses == 0)
            {
                MessageBox.Show("You have Failed! bro is dead... The correct word was: " + secretWord);
                btn_Submit.Enabled = false; //Button is disabled

                //BONUS CODE "resets win streak and starts new round
                winStreak = 0;
                roundCounter++;
                StartNewRound();
                //BONUS CODE ENDS
            }
            else if (!displayWord.Contains('_'))
            {
                MessageBox.Show("You did it! The man is saved from death, be proud!");
                btn_Submit.Enabled = false;

                //BONUS CODE "win streak goes up
                winStreak++;
                roundCounter++;
                StartNewRound();
                //BONUS ENDS
            }
        }
        private void btn_New_Click(object sender, EventArgs e)
        {
            NewGame(); //Resets the game
            btn_Submit.Enabled = true;
        }

        //BONUS CODE "new method to implement the win streak and round counter
        private void StartNewRound()
        {
            // Start a new game (reset the game state but keep the streak and round info)
            secretWord = wordList[random.Next(wordList.Length)];
            displayWord = new string('_', secretWord.Length).ToCharArray();
            remainingGuesses = 6;
            incorrectGuesses.Clear();

            //Updatres the display with new round and win streak
            UpdateGame();
            btn_Submit.Enabled = true;
        }
        //BONUS CODE ENDS
    }
}