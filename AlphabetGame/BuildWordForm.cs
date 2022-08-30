using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Media;


//This is build the word form (Complete the word)
namespace AlphabetGame
{
    public partial class BuildWordForm : Form
    {
        Users user;
        List<WordStruct> wordList;
        List<LetterWwords> letterList;
        Random rndmLetter = new Random();
        Random rndmWord = new Random();
        int gamePlayedCounter;
        int answerCounter;
        string wordToBuild;
        int difficulty;
        int score;

        public BuildWordForm(Users user, List<WordStruct> wordlist ,List<LetterWwords> letterlist)
        {
            InitializeComponent();
            this.user = user;
            wordList = wordlist;
            letterList = letterlist;
            this.BackgroundImage = new Bitmap(Constants.BUILD_WORD_FORM);
            picWordToBuild.Image = new Bitmap(Constants.BUILD_THE_WORD_GAME);
            btnBack.BackgroundImage = new Bitmap(Constants.BACK_TO_MENU_BTN);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ImeMode = ImeMode.NoControl;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            gamePlayedCounter = 0;
            btnCheck.Visible = true;
            btnStart.Enabled = false;
            btnBack.Visible = false;
            rbtnlevel1.Visible = false;
            rbtnLevel3.Visible = false;
            StartGame();
        }

        //This function start new game
        private void StartGame()
        {
            int wordToBuildIndex;
            lblScore.Text = "Score: " + score.ToString();

            if (rbtnlevel1.Checked == true)
            {
                difficulty = 1;
            }
            if (rbtnLevel3.Checked == true)
            {
                difficulty = 3;
                btnDelete.Visible = true;
                btnHint.Visible = true;
                btnSkip.Visible = true;
            }
            if (gamePlayedCounter < Constants.GAME_TO_PLAY)
            {
                answerCounter = 0;
                gamePlayedCounter++;

                //game number 2 (out of 3 rounds) and user wrong word list contain words
                //user get word from wrong list word and the word deleted from the list
                if (gamePlayedCounter == 2 && user.WrongWords.Count > 0)
                {
                    wordToBuildIndex = user.WrongWords[0].WordNum - 1;
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
                        wordToBuildIndex = rndmWord.Next(0, wordList.Count);

                        if (user.PlayedWords.Contains(wordToBuildIndex))
                        {
                            for (int i = 0; i < user.PlayedWords.Count; i++)
                            {
                                if (user.PlayedWords[i] == wordToBuildIndex)
                                {
                                    user.PlayedWords.RemoveAt(i);
                                }
                            }
                        }

                    } while (user.PlayedWords.Contains(wordToBuildIndex));

                    user.PlayedWords.Add(wordToBuildIndex);
                    user.PrintPlayedWordToFile(wordList);

                }
                while (wordList[wordToBuildIndex].WordName.Length > 10)
                {
                    wordToBuildIndex = rndmWord.Next(0, wordList.Count);
                }
                picWordToBuild.Image = new Bitmap("DIMAGES\\" + wordList[wordToBuildIndex].Image);
                wordToBuild = wordList[wordToBuildIndex].WordName;
                SetLetter(difficulty, wordToBuildIndex);

                if(difficulty == 3)
                {
                    lblLetterAmountWordToBuild.Visible = true;
                    lblLetterAmountWordToBuild.Text = wordToBuild.Length + " letters word";
                }
            }
        }


        //this function get word and difficulty and set the board
        //put the letter in the bank letter (all the word letter and extra to fill to 10 letter)
        //the letter ar shuffle in string array and then move the the picturebox array
        //to be presented as pictures
        private void SetLetter(int difficulty, int wordToBuildIndex)
        {
            PictureBox[] lettersPicture = {picBuildLetter1, picBuildLetter2, picBuildLetter3, picBuildLetter4, picBuildLetter5, picBuildLetter6,
                                          picBuildLetter7, picBuildLetter8, picBuildLetter9, picBuildLetter10 };

            WordStruct tmpword = wordList[wordToBuildIndex];
            string[] wordletters = new string[10];
            int counter = 0;

            for(int i = 0; i < tmpword.WordInfo.Length; i++)
            {
                if(i != 1)
                {
                    wordletters[counter] = tmpword.WordInfo[i].ToString();
                    counter++;
                }
            }

            if(lettersPicture.Length - tmpword.WordName.Length > 0)
            {
                for(int i = tmpword.WordName.Length; i < wordletters.Length; i++)
                {
                    wordletters[i] = letterList[rndmLetter.Next(0, letterList.Count)].Letter.LetterSign.ToString();
                }
            }

            Shuffle(wordletters);

            for (int i = 0; i < wordletters.Length; i++)
            {
                char c = Char.Parse(wordletters[i].ToUpper());
                lettersPicture[i].Image = new Bitmap("DIMAGES\\" + letterList[(int)c - 65].Letter.Image);
                lettersPicture[i].Visible = true;
                lettersPicture[i].Tag = c;
            }

            if(difficulty == 1)
            {
                FillLetterForDifficulty1(tmpword);
            }
        }


        //This function fill letter for word to build for easy difficulty 
        //in this easy difficulty the user need to complete one letter only
        private void FillLetterForDifficulty1(WordStruct tmpword)
        {
            PictureBox[] answerPicture = {picAnswer1, picAnswer2, picAnswer3, picAnswer4, picAnswer5, picAnswer6,
                                              picAnswer7, picAnswer8, picAnswer9, picAnswer10 };

            int letterToBuild = rndmLetter.Next(0, tmpword.WordName.Length);

            for (int i = 0; i < tmpword.WordName.Length; i++)
            {
                if (i != letterToBuild)
                {
                    answerPicture[answerCounter].Image = new Bitmap("DIMAGES\\" + letterList[Char.ToUpper(tmpword.WordName[i]) - 65].Letter.Image);
                    answerPicture[answerCounter].Visible = true;
                    answerPicture[answerCounter].Tag = letterList[Char.ToUpper(tmpword.WordName[i]) - 65].Letter.LetterSign;
                }
                answerCounter++;
            }
            answerCounter = letterToBuild;
        }


        //when pressin a letter in the letter bank
        //this function write the letter to the word to build
        private void WriteWords(char letter)
        {
            PictureBox[] answerPicture = {picAnswer1, picAnswer2, picAnswer3, picAnswer4, picAnswer5, picAnswer6,
                                         picAnswer7, picAnswer8, picAnswer9, picAnswer10 };

            if(answerCounter == -1)
            {
                answerCounter++;
            }
            answerPicture[answerCounter].Image = new Bitmap("DIMAGES\\" + letterList[letter - 65].Letter.Image);
            answerPicture[answerCounter].Visible = true;
            answerPicture[answerCounter].Tag = letterList[letter - 65].Letter.LetterSign;
            if(difficulty == 3)
            {
                answerCounter++;
            }
        }


        //event for delete button
        //in difficulty high the user can delete letter and change it
        private void btnDelete_Click(object sender, EventArgs e)
        {
            PictureBox[] answerPicture = {picAnswer1, picAnswer2, picAnswer3, picAnswer4, picAnswer5, picAnswer6,
            picAnswer7, picAnswer8, picAnswer9, picAnswer10 };

            if(answerCounter != -1)
            {
                answerCounter--;
            }
            if(answerCounter > -1)
            {
                answerPicture[answerCounter].Image.Dispose();
                answerPicture[answerCounter].Visible = false;
            }
        }


        //event for press check button
        private void btnCheck_Click(object sender, EventArgs e)
        {
            PictureBox[] answerPicture = {picAnswer1, picAnswer2, picAnswer3, picAnswer4, picAnswer5, picAnswer6,
                                          picAnswer7, picAnswer8, picAnswer9, picAnswer10 };
            
            int i;
            for(i = 0; i < answerPicture.Length && answerPicture[i].Image != null; i++)
            {
            }
            if (answerCounter == wordToBuild.Length && difficulty == 3)
            {
                CheckIfUserCorrect();
            }
            else if (i == wordToBuild.Length && difficulty == 1)
            {
                CheckIfUserCorrect();
            }
            else
            {
                MessageBox.Show("choose a letter before check");
            }  
        }


        //in difficulty high the user can listen to the word as a hint
        private void btnHint_Click(object sender, EventArgs e)
        {
            foreach (WordStruct word in wordList)
            {
                if (word.WordName == wordToBuild)
                {
                    SoundPlayer sp = new SoundPlayer("VOICE\\" + word.VoiceFile);
                    sp.Play();
                }
            }
        }


        //in difficulty high the user can skip a word
        private void btnSkip_Click(object sender, EventArgs e)
        {
            gamePlayedCounter--;
            CleanLetters();
            StartGame();

        }


        //the if user is correct after he press check button
        //each picturebox contain a Tag thta hold a letter
        //connect it to one word and check if equals to the word to build
        private async void CheckIfUserCorrect()
        {
            PictureBox[] answerPicture = {picAnswer1, picAnswer2, picAnswer3, picAnswer4, picAnswer5, picAnswer6,
            picAnswer7, picAnswer8, picAnswer9, picAnswer10 };
            string result = null;

            for (int i = 0; i < wordToBuild.Length; i++)
            {
                result += answerPicture[i].Tag.ToString();
            }

            result = char.ToUpper(result[0]) + result.Substring(1).ToLower();

            if (result == wordToBuild)
            {
                if (difficulty == 1)
                {
                    score++;
                }
                else
                {
                    score += wordToBuild.Length;
                }
                lblScore.Text = "Score: " + score;
                picWordToBuild.Image = new Bitmap(Constants.GOOD_JOB);
                picWordToBuild.Update();
                await Task.Delay(Constants.DELAY_FOR_WIN_LOSS_ENDGAME);
                EndGame();
            }
            else
            {
                picWordToBuild.Image = new Bitmap(Constants.WRONG_ANSWER);
                await Task.Delay(Constants.DELAY_FOR_WIN_LOSS_ENDGAME);
                user.UserWrong(wordToBuild, wordList);
                EndGame();
            }
        }


        //check if counter is less then game to play
        //if yes start another game
        //if yes end the game
        private void EndGame()
        {
            if (gamePlayedCounter < Constants.GAME_TO_PLAY)
            {
                CleanLetters();
                StartGame();
            }
            else
            {
                user.UserWrong(wordToBuild, wordList);
                picWordToBuild.Image = new Bitmap(Constants.THE_END);
                Task.Delay(Constants.DELAY_FOR_WIN_LOSS_ENDGAME);
                if(user.HighestScoreBuildWord < score)
                {
                    user.HighestScoreBuildWord = score;
                    picWordToBuild.Image = new Bitmap(Constants.NEW_HIGH_SCORE);
                    Task.Delay(Constants.DELAY_FOR_WIN_LOSS_ENDGAME);
                }
                BackToStart();
            }
        }


        //this function clean from the board all the letters picture
        private void CleanLetters()
        {
            PictureBox[] answerPicture = {picAnswer1, picAnswer2, picAnswer3, picAnswer4, picAnswer5, picAnswer6,
                                          picAnswer7, picAnswer8, picAnswer9, picAnswer10 };

            for(int i = 0; i < wordToBuild.Length; i++)
            {
                answerPicture[i].Image = null;
                answerPicture[i].Visible = false;
            }

            PictureBox[] lettersPicture = {picBuildLetter1, picBuildLetter2, picBuildLetter3, picBuildLetter4, picBuildLetter5, picBuildLetter6,
                                           picBuildLetter7, picBuildLetter8, picBuildLetter9, picBuildLetter10 };

            foreach (PictureBox pic in lettersPicture)
            {
                pic.Image.Dispose();
                pic.Visible = false;
            }
        }


        //reset controls back to start position
        private void BackToStart()
        {
            btnBack.Visible = true;
            btnStart.Enabled = true;
            btnHint.Visible = false;
            lblLetterAmountWordToBuild.Visible = false;
            btnCheck.Visible = false;
            btnDelete.Visible = false;
            btnSkip.Visible = false;
            CleanLetters();
            score = 0;
            picWordToBuild.Image = new Bitmap(Constants.BUILD_THE_WORD_GAME);

            rbtnlevel1.Visible = true;
            rbtnLevel3.Visible = true;
        }


        //shuffle the array
        private void Shuffle(string[] arr)
        {
            int size = arr.Length;
            string tmp;

            while (size > 1)
            {
                int rnd = rndmLetter.Next(size--);
                tmp = arr[size];
                arr[size] = arr[rnd];
                arr[rnd] = tmp;
            }
        }


        //write the letter that in the picturebox
        private void picBuildLetter1_Click(object sender, EventArgs e)
        {
            WriteWords(Char.Parse(picBuildLetter1.Tag.ToString()));
        }

        private void picBuildLetter2_Click(object sender, EventArgs e)
        {
            WriteWords(Char.Parse(picBuildLetter2.Tag.ToString()));
        }

        private void picBuildLetter3_Click(object sender, EventArgs e)
        {
            WriteWords(Char.Parse(picBuildLetter3.Tag.ToString()));
        }

        private void picBuildLetter4_Click(object sender, EventArgs e)
        {
            WriteWords(Char.Parse(picBuildLetter4.Tag.ToString()));
        }

        private void picBuildLetter5_Click(object sender, EventArgs e)
        {
            WriteWords(Char.Parse(picBuildLetter5.Tag.ToString()));
        }

        private void picBuildLetter6_Click(object sender, EventArgs e)
        {
            WriteWords(Char.Parse(picBuildLetter6.Tag.ToString()));
        }

        private void picBuildLetter7_Click(object sender, EventArgs e)
        {
            WriteWords(Char.Parse(picBuildLetter7.Tag.ToString()));
        }

        private void picBuildLetter8_Click(object sender, EventArgs e)
        {
            WriteWords(Char.Parse(picBuildLetter8.Tag.ToString()));
        }

        private void picBuildLetter9_Click(object sender, EventArgs e)
        {
            WriteWords(Char.Parse(picBuildLetter9.Tag.ToString()));
        }

        private void picBuildLetter10_Click(object sender, EventArgs e)
        {
            WriteWords(Char.Parse(picBuildLetter10.Tag.ToString()));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
