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
        }
    }
}