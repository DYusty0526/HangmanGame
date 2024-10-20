namespace HangmanGame
{
    public partial class Form1 : Form
    {
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

        }

    }
}