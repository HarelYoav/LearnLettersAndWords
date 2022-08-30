using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


//This form is the menu for games
namespace AlphabetGame
{
    public partial class GamesForm : Form
    {
        Users user;
        List<WordStruct> wordList;
        List<LetterWwords> letterList;

        public GamesForm(Users user, List<WordStruct> wordlist, List<LetterWwords> letterlist)
        {
            InitializeComponent();
            this.BackgroundImage = new Bitmap(Constants.GAME_FORM);
            btnBackToMenu.BackgroundImage = new Bitmap(Constants.BACK_TO_MENU_BTN);
            this.user = user;
            wordList = wordlist;
            letterList = letterlist;
            Start();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ImeMode = ImeMode.NoControl;
        }

        private void Start()
        {
            picBuildGame.Image = new Bitmap(Constants.BUILD_THE_WORD_GAME);
            picGuessGame.Image = new Bitmap(Constants.WHATS_IN_THE_PICTURE_GAME);
            picChoosePictureGame.Image = new Bitmap(Constants.CHOOSE_THE_RIGHT_PICTURE_GAME);
            picWordMemoryGame.Image = new Bitmap(Constants.MEMORY_GAME);
        }

        private void picBuildGame_Click(object sender, EventArgs e)
        {
            OpenNewForm(1);
        }

        private void picGuessGame_Click(object sender, EventArgs e)
        {
            OpenNewForm(2);
        }

        private void picChoosePictureGame_Click(object sender, EventArgs e)
        {
            OpenNewForm(3);
        }

        private void picHearWordGame_Click(object sender, EventArgs e)
        {
            OpenNewForm(4);
        }

        private void OpenNewForm(int option)
        {
            if (option <= 4 && option >= 1)
            {
                Form tmpForm = new Form();
                this.Hide();
                if (option == 1)
                {
                    BuildWordForm buildWord = new BuildWordForm(user, wordList, letterList);
                    tmpForm = buildWord;
                }
                if (option == 2)
                {
                    WhatsInThePictureGameForm guessWord = new WhatsInThePictureGameForm(user, wordList);
                    tmpForm = guessWord;
                }
                if (option == 3)
                {
                    ChoosePicureGameForm choosePicture = new ChoosePicureGameForm(user, wordList, letterList);
                    tmpForm = choosePicture;
                }
                if (option == 4)
                {
                    WordMemoryGameForm memoryGame = new WordMemoryGameForm(user, wordList);
                    tmpForm = memoryGame;
                }
                tmpForm.StartPosition = FormStartPosition.Manual;
                tmpForm.Location = this.Location;
                tmpForm.Size = this.Size;
                foreach (Control button in tmpForm.Controls)
                {
                    if (button is Button)
                    {
                        button.BackColor = Color.White;
                        button.Font = new Font("Cooper", 8);
                        button.ForeColor = Color.Blue;
                        button.Cursor = Cursors.Hand;
                    }
                }
                tmpForm.ShowDialog();

                this.StartPosition = FormStartPosition.Manual;
                this.Location = tmpForm.Location;
                this.Size = tmpForm.Size;
                this.Show();
            }
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
