using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Media;

//This is whats in the picture game
//the user gets picture and need to choose the right word
namespace AlphabetGame
{
    public partial class WhatsInThePictureGameForm : Form
    {
        Users user;
        List<WordStruct> wordList = new List<WordStruct>();
        Random rdnWord = new Random();
        string wordToGuess;
        int gamePlayed;
        int score;
        int time;

        public WhatsInThePictureGameForm(Users user, List<WordStruct> wordlist)
        {
            InitializeComponent();
            this.user = user;
            wordList = wordlist;
            this.BackgroundImage = new Bitmap(Constants.WHAT_IN_PIC_FORM);
            picWordToGuess.Image = new Bitmap(Constants.WHATS_IN_THE_PICTURE_GAME);
            btnBackToMenu.BackgroundImage = new Bitmap(Constants.BACK_TO_MENU_BTN);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ImeMode = ImeMode.NoControl;
        }

        //when user press start
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnBackToMenu.Visible = false;
            btnStart.Enabled = false;
            gBoxButtons.Visible = true;
            lblTimeLeft.Visible = true;
            SetPictureToGuessWord();
        }


        //random word to guess and present the word picture
        //also update the button with the right text (1 answer  and 3 random word)
        void SetPictureToGuessWord()
        {
            int randomwordIndex;
            time = 10;
            gamePlayed++;


            //game number 2 (out of 3 rounds) and user wrong word list contain words
            //user get word from wrong list word and the word deleted from the list
            if(gamePlayed == 2 && user.WrongWords.Count > 0)
            {
                randomwordIndex = user.WrongWords[0].WordNum - 1;
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
                    randomwordIndex = rdnWord.Next(0, wordList.Count);

                    if (user.PlayedWords.Contains(randomwordIndex))
                    {
                        for (int i = 0; i < user.PlayedWords.Count; i++)
                        {
                            if (user.PlayedWords[i] == randomwordIndex)
                            {
                                user.PlayedWords.RemoveAt(i);
                            }
                        }
                    }

                } while (user.PlayedWords.Contains(randomwordIndex));

                user.PlayedWords.Add(randomwordIndex);
                user.PrintPlayedWordToFile(wordList);
               
            }
            wordToGuess = wordList[randomwordIndex].WordName;
            picWordToGuess.Image = new Bitmap("DIMAGES\\" + wordList[randomwordIndex].Image);
            SoundPlayer sp = new SoundPlayer("VOICE\\" + wordList[randomwordIndex].VoiceFile);
            sp.Play();

            Button[] choiceButton = { btnOption1, btnOption2, btnOption3, btnOption4 };

            //shuffle the button so each time the the right word will be in diffrent button
            Shuffle(choiceButton);

            choiceButton[0].Text = wordList[randomwordIndex].WordName;

            for (int i = 1; i < choiceButton.Length; i++)
            {
                randomwordIndex = rdnWord.Next(0, wordList.Count);
                if (wordList[randomwordIndex].WordName != wordToGuess)
                {
                    choiceButton[i].Text = wordList[randomwordIndex].WordName;
                }
                else
                {
                    i--;
                }
            }
            tmrGuessWordForm.Start();
        }


        //shuffle array of buttons
        private void Shuffle(Button[] arr)
        {
            int size = arr.Length;
            Button tmp;
            while (size > 1)
            {
                int rnd = rdnWord.Next(size--);
                tmp = arr[size];
                arr[size] = arr[rnd];
                arr[rnd] = tmp;
            }
        }


        //check if user correct with his choice or not
        private async void ChecklIfChoiceCorrect(Button btn)
        {
            if(btn.Text == wordToGuess)
            {
                score += time;
                
                picWordToGuess.Image = new Bitmap(Constants.GOOD_JOB);
                picWordToGuess.Update();
                await Task.Delay(Constants.DELAY_FOR_WIN_LOSS_ENDGAME);
                if(gamePlayed < Constants.GAME_TO_PLAY)
                {
                    SetPictureToGuessWord();
                }
                else
                {
                    picWordToGuess.Image = new Bitmap(Constants.THE_END);
                    picWordToGuess.Update();
                    await Task.Delay(Constants.DELAY_FOR_WIN_LOSS_ENDGAME);
                    BackToStart();
                }
            }
            else
            {
                user.UserWrong(wordToGuess, wordList);

                picWordToGuess.Image = new Bitmap(Constants.WRONG_ANSWER);
                picWordToGuess.Update();
                await Task.Delay(Constants.DELAY_FOR_WIN_LOSS_ENDGAME);
                if (gamePlayed < 3)
                {
                    SetPictureToGuessWord();
                }
                else
                {
                    picWordToGuess.Image = new Bitmap(Constants.THE_END);
                    picWordToGuess.Update();
                    await Task.Delay(Constants.DELAY_FOR_WIN_LOSS_ENDGAME);
                    BackToStart();
                }
            }
        }


        //set all controls back to start
        //if score greater than user highscore
        //update new highscore for user and oresent picutre "new high score"
        private async void BackToStart()
        {
            if (score > user.HighestScoreGuessWord)
            {
                user.HighestScoreGuessWord = score;
                picWordToGuess.Image = new Bitmap(Constants.NEW_HIGH_SCORE);
                picWordToGuess.Update();
                await Task.Delay(Constants.DELAY_FOR_WIN_LOSS_ENDGAME);
            }
            btnBackToMenu.Visible = true;
            btnStart.Enabled = true;
            gBoxButtons.Visible = false;
            picWordToGuess.Image = new Bitmap(Constants.WHATS_IN_THE_PICTURE_GAME);
            gamePlayed = 0;
            score = 0;
            tmrGuessWordForm.Stop();
            lblTimeLeft.Visible = false;
        }


        //present timer to the user
        //user get score from timer
        //score is the time left on timer
        private async void tmrGuessWordForm_Tick(object sender, EventArgs e)
        {
            lblTimeLeft.Text = "Time left: " + time;
            if (time == 0)
            {
                tmrGuessWordForm.Stop();
                picWordToGuess.Image = new Bitmap(Constants.WRONG_ANSWER);
                picWordToGuess.Update();
                await Task.Delay(Constants.DELAY_FOR_WIN_LOSS_ENDGAME);
                if (gamePlayed < 3)
                {
                    SetPictureToGuessWord();
                }
                lblScore.Text = "Score: " + score;
            }
            time--;
            lblScore.Text = "Score: " + score;
        }


        //when press on one of the answer buttons
        private void btnOption1_Click(object sender, EventArgs e)
        {
            ChecklIfChoiceCorrect(btnOption1);
        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
            ChecklIfChoiceCorrect(btnOption2);
        }

        private void btnOption3_Click(object sender, EventArgs e)
        {
            ChecklIfChoiceCorrect(btnOption3);
        }

        private void btnOption4_Click(object sender, EventArgs e)
        {
            ChecklIfChoiceCorrect(btnOption4);
        }

        //back to last form
        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
