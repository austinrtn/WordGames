using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class MainFrame : Form

    {
        private string word; // The word needed to be entered by user to win round
        private wordGame mainWord; // WordGame object that holds trigger and also hins

        private Boolean endGame = false; // If true, game has ended 
        private bool hardMode = false; // If true, random letters will be mixed in with scrambled word.

        private ArrayList wordsList = new ArrayList(); // Contains wordGame objects for game.
        private List<string> usedWords = new List<string>(); // Contains wordGame objects that have already been solved.
        private List<char> lettersList = new List<char>(); // Contains scrammbeld chars of the word that needs to be solved
        private ArrayList inputBoxesList = new ArrayList(); // List of all the inputBoxes

        private static int hintCounter = 1; // How many hints the player has used (starts at 1 hint by default).
        private static int pointsCounter = 0; // How many points the player has

        private int pointsPossilble() // How many points the player can earn durring round (based off of how many hints used
        {
            if (hintCounter == 1)
                return 3;
            else if (hintCounter == 2)
                return 2;
            else if (hintCounter >= 3)
                return 1;
            else return 1;
        }

        public void addPoints()
        {
            pointsCounter += pointsPossilble();
            
        }

        public MainFrame()
        {
            InitializeComponent();
            newRound();
        }

        public void newRound()
        {
            // Resets for new round
            textBoxContainer.Controls.Clear();
            inputBoxesList.Clear();
            lettersList.Clear();
            hintCounter = 1;
            lblHint2.Text = "Hint #2";
            lblHint3.Text = "Hint #3";
            lblPointsPos.Text = "Points possible: " + pointsPossilble().ToString();

            addWordsToLIst();
            setWordRandom();
            if (endGame != true)
            {
                addTextBoxes();
                createLetterList();
                centerContorls();
            }
            else
                gameOver();

        }

        // Checks wether hard mode has been changed
        private void cbDifficulty_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDifficulty.Checked == true)
                hardMode = true;
            else
                hardMode = false;
        }

        // Adds wordGame objects to list
        private void addWordsToLIst()
        {
            wordGame DOG = new wordGame("DOG", "I have four legs", "I can do tricks", "I'm a man's best friend");
            wordsList.Add(DOG);

            wordGame TACO = new wordGame("TACO", "I'm latin food", "I'm popular in a northern latin country", "I'm wrapped in a tortilla");
            wordsList.Add(TACO);

            wordGame MONKEY = new wordGame("MONKEY", "I'm a furry mamal", "I live in trees", "I eat bananas");
            wordsList.Add(MONKEY);

            wordGame MOVIE = new wordGame("MOVIE", "People go to see me", "I'm on a screen", "I'm often showcased at theartes");
            wordsList.Add(MOVIE);

            wordGame RING = new wordGame("RING", "You wear me", "I am jewlery", "You put me on your finger");
            wordsList.Add(RING);

            wordGame HAMMER = new wordGame("HAMMER", "I am a tool", "I am used to hit things", "I am similar to a mallot");
            wordsList.Add(HAMMER);
        }

        // Choses random wordGame object from list
        private void setWordRandom()
        {

            bool setWord = true;

            do
            {
                setWord = true;
                if (wordsList.Count == usedWords.Count) // If all words have been used, end game
                {
                    endGame = true;
                    break;
                }
                   
                // Gets a random word from list 
                wordGame wg = (wordGame)wordsList[Program.GetRandomNumber(0, wordsList.Count)];
                mainWord = wg; 
                lblHint1.Text = wg.getHint1();
                word = wg.getWord();

                if (usedWords.Contains(wg.getWord()))
                    setWord = false;          
                
            } while (setWord == false); // Will continue to loop if a word that has already been used is selected
            
        }

        // Creates a list of the scrambled word 
        private void createLetterList()
        {
            bool duplicateLetter = false;
            char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray(); // Alphabet char array to use for random letters if hardMode is enabled
            string addToLabel = "Scrambled Word: ";
            wordLabel.Text = lettersList.Count.ToString();

            for (int i = 0; i < word.Length; i++)
            {
                lettersList.Add(word[i]);

            }

            if (hardMode == true) { 

            for (int i = 0; i < Program.GetRandomNumber(2, 4); i++)
            {
                do
                {
                    duplicateLetter = false;

                    char letter = alpha[Program.GetRandomNumber(0, alpha.Length)];

                    if (lettersList.Contains(letter))
                        duplicateLetter = true;
                    else
                        lettersList.Add(letter);

                } while (duplicateLetter == true);
            }

        }
            // Swaps the letters within the lettersList to make them scrambled 
                for (int i = 0; i < lettersList.Count; i++)
                {
                    int randomSel = Program.GetRandomNumber(0, lettersList.Count);

                    char temp = lettersList[i];
                    lettersList[i] = lettersList[randomSel];
                    lettersList[randomSel] = temp;
                }
            
                // Add it to GUI
            for (int i = 0; i < lettersList.Count; i++)
            {
                addToLabel += lettersList[i] + " ";
            }

            wordLabel.Text = addToLabel;

        }

        // The amount of text boxes needed depends on the length of the word trying to be solved.  This method generates the right amount
        // of texts boxes and adds them to the gui.
        private void addTextBoxes()
        {

            for (int i = 0; i < word.Length; i++)
            {
                lblPointsPos.Text = "Points possible: " + pointsPossilble().ToString();
                lblCurrentPoints.Text = "Current Points: " + pointsCounter.ToString();

                // Initializes textbox and adds it a text box object to list for the length of the word trying to be solved 
                TextBox inputBox = new TextBox();
                inputBox.Name = "inputBox" + i.ToString();
                inputBox.Font = new Font(inputBox.Font.FontFamily, 24);
                inputBox.Size = new Size(58, 58);
                inputBox.MaxLength = 1;
                inputBox.CharacterCasing = CharacterCasing.Upper;
                inputBox.TextAlign = HorizontalAlignment.Center;
                inputBox.Anchor = AnchorStyles.None;


                textBoxContainer.Controls.Add(inputBox);

                inputBoxesList.Add(inputBox);

            }

            textBoxContainer.Left = (this.ClientSize.Width - textBoxContainer.Width) / 2;
        }

        // This method centers all the componets for the GUI
        private void centerContorls()
        {
            List<Control> controlList = new List<Control>();
            controlList.Add(textBoxContainer);
            controlList.Add(lettersContainer);
            controlList.Add(wordLabel);
            controlList.Add(lblHint1);
            controlList.Add(lblHint2);
            controlList.Add(lblHint3);
            controlList.Add(lblCurrentPoints);
            controlList.Add(lblPointsPos);
            controlList.Add(btnGo);

            for (int i = 0; i < controlList.Count; i++)
            {
                controlList[i].Left = (this.ClientSize.Width - controlList[i].Width) / 2;
            }
        }

        // btnGo click event
        private void btnGo_click(object sender, EventArgs e)
        {
            if (endGame == true)
                System.Windows.Forms.Application.Exit();
            else
            {
                bool notEmpty = true;
                // Checks if text boxes are empty
                for (int i = 0; i < inputBoxesList.Count; i++)
                {
                    TextBox tb = (TextBox)inputBoxesList[i];

                    if (String.IsNullOrEmpty(tb.Text))
                        notEmpty = false;
                }

                // Will check each text box to see if it contains the correct letter, only if 
                // all the text boxes are not empty
                if (notEmpty == true)
                {
                    bool isCorrect = true;

                    for (int i = 0; i < word.Length; i++)
                    {
                        TextBox tb = (TextBox)inputBoxesList[i];

                        if (tb.Text[0] != mainWord.getWord()[i])
                            isCorrect = false;
                    }

                    if (isCorrect == true)
                    {
                        usedWords.Add(mainWord.getWord());
                        addPoints();
                        newRound();
                    }
                    else
                        showHint();
                }
                else
                    showHint();

                centerContorls();
            }
     }
     

        private void btnHint_Click(object sender, EventArgs e)
        {
            showHint();
        }

        // This method shows the hints and manages the points/points possible.
        private void showHint()
        {

            if (hintCounter == 1)
            {
                lblHint2.Text = mainWord.getHint2();
                hintCounter++;
            }

            else if (hintCounter == 2)
            {
                lblHint3.Text = mainWord.getHint3();
                hintCounter++;
            }
            centerContorls();

            if (hintCounter <= 3)
            {
                bool letterChanged = true;

                do
                {
                    letterChanged = true;
                    int sel = Program.GetRandomNumber(0, word.Length);

                    char letter = word[sel];
                    TextBox tb = (TextBox)inputBoxesList[sel];

                    if (string.IsNullOrEmpty(tb.Text) || tb.Text[0] != letter)
                        tb.Text = letter.ToString();
                    else
                        letterChanged = false;
                } while (letterChanged == false);

            }
            lblPointsPos.Text = "Points possible:" + pointsPossilble().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPointsPos_Click(object sender, EventArgs e)
        {

        }

        private void gameOver()
        {
            wordLabel.Text = "Game Over";
        }
        
    }
}