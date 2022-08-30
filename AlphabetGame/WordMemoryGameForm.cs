using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Media;

//This is Memory Game form
namespace AlphabetGame
{
    public partial class WordMemoryGameForm : Form
    {
        Users user;
        List<WordStruct> wordList;
        object[] wordForMemoryGame = new object[12];
        List<Label> wordLabel = new List<Label>();
        int CounterOpenCards;
        int[] currentOpenCards = new int[2];
        string[] ResultOpenCards = new string[2];
        int rightAnswer;
        int numberOfTrying = 20;

        public WordMemoryGameForm(Users user, List<WordStruct> wordlist)
        {
            InitializeComponent();
            this.BackgroundImage = new Bitmap(Constants.CHOOSE_PICTURE_FORM);
            picMemoryGameMain.Image = new Bitmap(Constants.MEMORY_GAME);
            btnBackToMenu.BackgroundImage = new Bitmap(Constants.BACK_TO_MENU_BTN);
            this.user = user;
            wordList = wordlist;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ImeMode = ImeMode.NoControl;
           
        }

        
        //event for start button
        //set all the cards UpsideDown
        //and shuffle 6 words
        private void btnStart_Click(object sender, EventArgs e)
        {
            lblScore.Text = numberOfTrying.ToString();
            btnStart.Enabled = false;
            btnBackToMenu.Visible = false;
            PictureBox[] MemoryGamePic = { picMemoryGame1, picMemoryGame2, picMemoryGame3, picMemoryGame4, picMemoryGame5, picMemoryGame6,
                                          picMemoryGame7, picMemoryGame8, picMemoryGame9, picMemoryGame10, picMemoryGame11, picMemoryGame12};

            Random rnd = new Random();
            int rndWord;
            picMemoryGameMain.Visible = false;

            foreach (PictureBox pic in MemoryGamePic)
            {
                pic.Image = new Bitmap(Constants.QUESTION_MARK_MEMORY_GAME);
                pic.Visible = true;
            }

            for (int i = 0; i < wordForMemoryGame.Length; i += 2)
            {
                rndWord = rnd.Next(0, wordList.Count);
                wordForMemoryGame[i] =wordList[rndWord];
                wordForMemoryGame[i + 1] = wordList[rndWord].WordName;
            }
            Shuffle(wordForMemoryGame);
        }


        //shuffle the array
        private void Shuffle(object[] arr)
        {
            Random rnd = new Random();
            int size = arr.Length;
            object tmp;

            while (size > 1)
            {
                int rndNum = rnd.Next(size--);
                tmp = arr[size];
                arr[size] = arr[rndNum];
                arr[rndNum] = tmp;
            }
        }


        //This function open the card when the user press on the picture
        //get index (from picture click event - down the code)
        //use the index to open the right card
        //if the card is picture voice will be played
        private async void OpenCards(int indx)
        {
            PictureBox[] MemoryGamePic = { picMemoryGame1, picMemoryGame2, picMemoryGame3, picMemoryGame4, picMemoryGame5, picMemoryGame6,
                                          picMemoryGame7, picMemoryGame8, picMemoryGame9, picMemoryGame10, picMemoryGame11, picMemoryGame12};

            Words tmpWord = wordForMemoryGame[indx] as Words;

            if (tmpWord != null)
            {
                MemoryGamePic[indx].Image = new Bitmap("DIMAGES\\" + tmpWord.Image);
                SoundPlayer sp = new SoundPlayer("VOICE\\" + tmpWord.VoiceFile);
                sp.Play();

                ResultOpenCards[CounterOpenCards] = tmpWord.WordName;
                currentOpenCards[CounterOpenCards] = indx;
            }

            string tmpWordString = wordForMemoryGame[indx] as string;

            if(tmpWordString != null)
            {
                Point pt = MemoryGamePic[indx].Location;
                MemoryGamePic[indx].Visible = false;
                wordLabel.Add(GenerateLabelForWordInGame(pt, tmpWordString));
                ResultOpenCards[CounterOpenCards] = tmpWordString;
                currentOpenCards[CounterOpenCards] = indx;
            }

            CounterOpenCards++;

            if(CounterOpenCards == 2)
            {
                numberOfTrying--;
                lblScore.Text = numberOfTrying.ToString();
                if(numberOfTrying == 0)
                {
                    picMemoryGameMain.Image = new Bitmap(Constants.TRY_AGAIN);
                    picMemoryGameMain.Visible = true;
                    await Task.Delay(Constants.DELAY_FOR_WIN_LOSS_ENDGAME);
                    CleanCards();
                    BackToStart();
                }
                await Task.Delay(Constants.DELAY_FOR_WIN_LOSS_ENDGAME);
                CounterOpenCards = 0;
                CheckMatch();
            }
        }


        //clean all the cards from board
        //use only if the game end without winning
        private void CleanCards()
        {
            PictureBox[] MemoryGamePic = { picMemoryGame1, picMemoryGame2, picMemoryGame3, picMemoryGame4, picMemoryGame5, picMemoryGame6,
                                          picMemoryGame7, picMemoryGame8, picMemoryGame9, picMemoryGame10, picMemoryGame11, picMemoryGame12};

            foreach(PictureBox pic in MemoryGamePic)
            {
                pic.Visible = false;
            }
        }


        //check if the 2 cards that open are match (picture and word)
        //also if there is 6 matches already end the game
        private async void CheckMatch()
        {
            PictureBox[] MemoryGamePic = { picMemoryGame1, picMemoryGame2, picMemoryGame3, picMemoryGame4, picMemoryGame5, picMemoryGame6,
                                          picMemoryGame7, picMemoryGame8, picMemoryGame9, picMemoryGame10, picMemoryGame11, picMemoryGame12};

            if (ResultOpenCards[0] == ResultOpenCards[1])
            {
                foreach (Label lbl in wordLabel)
                {
                    lbl.Dispose();
                }
                wordLabel.Clear();

                MemoryGamePic[currentOpenCards[0]].Visible = false;
                MemoryGamePic[currentOpenCards[1]].Visible = false;

                rightAnswer++;
                if(rightAnswer == 6)
                {
                    if(user.HighestScoreMemoryGame < numberOfTrying)
                    {
                        user.HighestScoreMemoryGame = numberOfTrying;
                        picMemoryGameMain.Image = new Bitmap(Constants.NEW_HIGH_SCORE);
                        picMemoryGameMain.Visible = true;
                        await Task.Delay(Constants.DELAY_FOR_WIN_LOSS_ENDGAME);

                    }
                    picMemoryGameMain.Image = new Bitmap(Constants.GOOD_JOB);
                    picMemoryGameMain.Visible = true;
                    await Task.Delay(Constants.DELAY_FOR_WIN_LOSS_ENDGAME);
                    BackToStart();
                }
            }
            else
            {
                foreach(Label lbl in wordLabel)
                {
                    lbl.Dispose();
                }
                wordLabel.Clear();

                MemoryGamePic[currentOpenCards[0]].Image = new Bitmap(Constants.QUESTION_MARK_MEMORY_GAME);
                MemoryGamePic[currentOpenCards[0]].Visible = true;
                MemoryGamePic[currentOpenCards[1]].Image = new Bitmap(Constants.QUESTION_MARK_MEMORY_GAME);
                MemoryGamePic[currentOpenCards[1]].Visible = true;
            }
        }


        //back controls to start position
        private void BackToStart()
        {
            picMemoryGameMain.Image = new Bitmap(Constants.MEMORY_GAME);
            btnStart.Enabled = true;
            btnBackToMenu.Visible = true;
            CounterOpenCards = 0;
            rightAnswer = 20;
        }


        //generate label for words in the game cards
        private Label GenerateLabelForWordInGame(Point pt, string tmpWord)
        {
            Label tmpLabel = new Label();

            this.Controls.Add(tmpLabel);
            tmpLabel.Location = pt;
            tmpLabel.Text = tmpWord;
            tmpLabel.ForeColor = Color.Blue;
            tmpLabel.Font = new Font("Cooper", 12);

            return tmpLabel;
        }

       
        //open the cards
        private void picMemoryGame1_Click(object sender, EventArgs e)
        {
            if(picMemoryGame1.Visible == true && CounterOpenCards < 2)
            {
                OpenCards(0);
            }
        }

        private void picMemoryGame2_Click(object sender, EventArgs e)
        {
            if (picMemoryGame2.Visible == true && CounterOpenCards < 2)
            {
                OpenCards(1);
            } 
        }

        private void picMemoryGame3_Click(object sender, EventArgs e)
        {
            if (picMemoryGame3.Visible == true && CounterOpenCards < 2)
            {
                OpenCards(2);
            }
        }

       
        private void picMemoryGame4_Click(object sender, EventArgs e)
        {
            if (picMemoryGame4.Visible == true && CounterOpenCards < 2)
            {
                OpenCards(3);
            }
        }

        private void picMemoryGame5_Click(object sender, EventArgs e)
        {
            if (picMemoryGame5.Visible == true && CounterOpenCards < 2)
            {
                OpenCards(4);
            }  
        }

        private void picMemoryGame6_Click(object sender, EventArgs e)
        {
            if (picMemoryGame6.Visible == true && CounterOpenCards < 2)
            {
                OpenCards(5);
            }  
        }

        private void picMemoryGame7_Click(object sender, EventArgs e)
        {
            if (picMemoryGame7.Visible == true && CounterOpenCards < 2)
            {
                OpenCards(6);
            }
        }
               
        private void picMemoryGame8_Click(object sender, EventArgs e)
        {
            if (picMemoryGame8.Visible == true && CounterOpenCards < 2)
            {
                OpenCards(7);
            }   
        }

        private void picMemoryGame9_Click(object sender, EventArgs e)
        {
            if (picMemoryGame9.Visible == true && CounterOpenCards < 2)
            {
                OpenCards(8);
            }   
        }

        private void picMemoryGame10_Click(object sender, EventArgs e)
        {
            if (picMemoryGame10.Visible == true && CounterOpenCards < 2)
            {
                OpenCards(9);
            }   
        }

        private void picMemoryGame11_Click(object sender, EventArgs e)
        {
            if (picMemoryGame11.Visible == true && CounterOpenCards < 2)
            {
                OpenCards(10);
            }  
        }

        private void picMemoryGame12_Click(object sender, EventArgs e)
        {
            if (picMemoryGame12.Visible == true && CounterOpenCards < 2)
            {
                OpenCards(11);
            }   
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
