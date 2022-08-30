using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

//This is Choose the right picture game
//the user gets a word and need to choose the right picture
namespace AlphabetGame
{

    public partial class ChoosePicureGameForm : Form
    {
        Users user;
        List<WordStruct> wordList;
        List<LetterWwords> letterList;
        List<PictureBox> letterPicList = new List<PictureBox>();
        int gameCounter;
        string wordToGuess;
        int letterCounter;
        int score;

        public ChoosePicureGameForm(Users user, List<WordStruct> wordlist, List<LetterWwords> letterlist)
        {
            InitializeComponent();
            this.user = user;
            wordList = wordlist;
            letterList = letterlist;
            this.BackgroundImage = new Bitmap(Constants.CHOOSE_PICTURE_FORM);
            btnBackToMenu.BackgroundImage = new Bitmap(Constants.BACK_TO_MENU_BTN);
            picResult.Image = new Bitmap(Constants.CHOOSE_THE_RIGHT_PICTURE_GAME);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ImeMode = ImeMode.NoControl;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            score = 0;
            gameCounter = 0;
            lblScore.Visible = true;
            btnStart.Enabled = false;
            btnBackToMenu.Visible = false;
            StartGame();
        }
        

        //This function start new game (another round)
        private void StartGame()
        {
            gameCounter++;
            
            PictureBox[] wordPictures = { picGuess1, picGuess2, picGuess3, picGuess4 };

            Random rnd = new Random();
            int wordToGuessIndex;
            picResult.Visible = false;

            Shuffle(wordPictures);

            //game number 2 (out of 3 rounds) and user wrong word list contain words
            //user get word from wrong list word and the word deleted from the list
            if (gameCounter == 2 && user.WrongWords.Count > 0)
            {
                wordToGuessIndex = user.WrongWords[0].WordNum - 1;
                user.WrongWords.RemoveAt(0);
                user.PrintWrongWordToFile();
            }
            else
            {
                //if the random number is already in user played words list
                //random again until get diffrent word
                //then delete the last played word from user list
                do
                {
                    wordToGuessIndex = rnd.Next(0, wordList.Count);

                    if(user.PlayedWords.Contains(wordToGuessIndex))
                    {
                        for(int i = 0; i < user.PlayedWords.Count; i++)
                        {
                            if(user.PlayedWords[i] == wordToGuessIndex)
                            {
                                user.PlayedWords.RemoveAt(i);
                            }
                        }
                    }

                } while (user.PlayedWords.Contains(wordToGuessIndex));

                user.PlayedWords.Add(wordToGuessIndex);
                user.PrintPlayedWordToFile(wordList);

            }
            wordPictures[0].Image = new Bitmap("DIMAGES\\" + wordList[wordToGuessIndex].Image);
            wordPictures[0].Tag = wordList[wordToGuessIndex].WordName;
            wordPictures[0].Visible = true;
            wordToGuess = wordList[wordToGuessIndex].WordName;

            for (int i = 1; i < wordPictures.Length; i++)
            {
                wordToGuessIndex = rnd.Next(0, wordList.Count);
                if (wordList[wordToGuessIndex].WordName != wordToGuess)
                {
                    wordPictures[i].Image = new Bitmap("DIMAGES\\" + wordList[wordToGuessIndex].Image);
                    wordPictures[i].Tag = wordList[wordToGuessIndex].WordName;
                    wordPictures[i].Visible = true;
                }
                else
                {
                    i--;
                }
            }
            SetLettersPic(wordToGuess);
        }


        //this function check if the user guess is correct
        private async void CheckIfGuessCorrect(string userAnswer)
        {
            PictureBox[] wordPictures = { picGuess1, picGuess2, picGuess3, picGuess4 };

            foreach (PictureBox picture in wordPictures)
            {
                picture.Visible = false;
            }

            if (userAnswer == wordToGuess)
            {
                picResult.Image = new Bitmap(Constants.GOOD_JOB);
                picResult.Visible = true;
                score++;
                lblScore.Text = "Score: " + score.ToString();
                await Task.Delay(Constants.DELAY_FOR_WIN_LOSS_ENDGAME);
            }
            else
            {
                picResult.Image = new Bitmap(Constants.WRONG_ANSWER);
                picResult.Visible = true;
                await Task.Delay(Constants.DELAY_FOR_WIN_LOSS_ENDGAME);
            }
            CheckIfNewGameOrEnd();
        }


        //This function check if the the game played the number of rounds 
        //if no start another game, if yes back to main game screen
        private async void CheckIfNewGameOrEnd()
        {
            CleanLettersPic();
            if (gameCounter < Constants.GAME_TO_PLAY)
            {
                picResult.Visible = false;
                StartGame();
            }
            else
            {
                if(score == 3)
                {
                    score++;
                    lblScore.Text = "Score: " + score.ToString();
                }
                if(user.HighestScoreGuessPicture < score)
                {
                    user.HighestScoreGuessPicture = score;
                    picResult.Image = new Bitmap(Constants.NEW_HIGH_SCORE);
                    picResult.Visible = true;
                    await Task.Delay(Constants.DELAY_FOR_WIN_LOSS_ENDGAME);
                }
                picResult.Image = new Bitmap(Constants.GOOD_JOB);
                picResult.Visible = true;
                await Task.Delay(Constants.DELAY_FOR_WIN_LOSS_ENDGAME);
                picResult.Visible = false;
                btnStart.Enabled = true;
                btnBackToMenu.Visible = true;
            }
        }


        //this function shuffle the array
        private void Shuffle(PictureBox[] arr)
        {
            Random rndNum = new Random();
            int size = arr.Length;
            PictureBox tmp;

            while (size > 1)
            {
                int rnd = rndNum.Next(size--);
                tmp = arr[size];
                arr[size] = arr[rnd];
                arr[rnd] = tmp;
            }
        }


        //this function send each letter of the word to create the letter a picture box 
        //and present to the user the full word
        private void SetLettersPic(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                letterPicList.Add(AddNewPicutreBoxForLetter(Char.ToUpper(word[i])));
            }
        }


        //This function create new picturebox and load it with a letter image
        private PictureBox AddNewPicutreBoxForLetter(Char letter)
        {
            PictureBox picture = new PictureBox();

            this.Controls.Add(picture);
            picture.Top = 30;
            picture.Left = 200 + (50 * letterCounter);
            picture.Image = new Bitmap("DIMAGES\\" + letterList[letter - 65].Letter.Image);
            picture.Size = new Size(50, 60);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            letterCounter++;

            return picture;
        }


        //clean the letter pictures
        private void CleanLettersPic()
        {
            if (letterPicList.Count > 0)
            {
                foreach (PictureBox pic in letterPicList)
                {
                    pic.Dispose();
                }
                letterPicList.Clear();
                letterCounter = 0;
            }
        }


        //when pressing on picture the user choose as answer
        private void picGuess1_Click(object sender, EventArgs e)
        {
            CheckIfGuessCorrect(picGuess1.Tag.ToString());
        }

        private void picGuess2_Click(object sender, EventArgs e)
        {
            CheckIfGuessCorrect(picGuess2.Tag.ToString());
        }

        private void picGuess3_Click(object sender, EventArgs e)
        {
            CheckIfGuessCorrect(picGuess3.Tag.ToString());
        }

        private void picGuess4_Click(object sender, EventArgs e)
        {
            CheckIfGuessCorrect(picGuess4.Tag.ToString());
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
