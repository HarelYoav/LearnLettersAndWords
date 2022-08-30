using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Threading.Tasks;


//In this class the users can learn letters and words
namespace AlphabetGame
{
    public partial class LearnWordsForm : Form
    {
        List<LetterWwords> letterList;
        int counter = -1;
        int letterCounter;
        List<PictureBox> letterPicList = new List<PictureBox>();
        bool userPressStop = false;

        public LearnWordsForm(List<LetterWwords> list)
        {
            InitializeComponent();
            this.BackgroundImage = new Bitmap(Constants.LEARN_WORD_FORM); ;
            btnBackToMenu.BackgroundImage = new Bitmap(Constants.BACK_TO_MENU_BTN);
            letterList = list;
            start();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ImeMode = ImeMode.NoControl;
        }


        //add all the letter from letter list to the combo box
        void start()
        {
            foreach(LetterWwords letter in letterList)
            {
                cmboxChooseLetter.Items.Add(letter.Letter.LetterSign);
            }
        }


        //when user press start, check if user select letter
        //if user dont choose letter show messgae to user to select letter
        //the letter learn start on manual or autoplay depend on user selection
        private void btnStart_Click(object sender, EventArgs e)
        {
            userPressStop = false;

            if(cmboxChooseLetter.SelectedIndex == -1)
            {
                MessageBox.Show("Choose letter");
                cmboxChooseLetter.Focus();
            }
            else
            {
                btnStop.Visible = true;
                btnStart.Enabled = false;
                picLetterWWord.Visible = true;

                if (chkboxPlayAuto.Checked == true)
                {
                    PlayAuto();
                }
                else
                {
                    btnNext.Visible = true;
                    btnBack.Visible = true;
                    LetterWwords tmp = letterList[cmboxChooseLetter.SelectedIndex];

                    picLetterWWord.Image = new Bitmap("DIMAGES\\" + tmp.Letter.Image);
                    SoundPlayer sp = new SoundPlayer("VOICE\\" + tmp.Letter.LetterSign + ".wav");
                    sp.Play();
                }
            }
        }


        //when user play choose to play auto
        //first the later show, and each 5 second changes to another word that start with the same letter
        private async void PlayAuto()
        {
            picLetterWWord.Image = new Bitmap(Constants.START_LEARN_IMAGE);
            await Task.Delay(Constants.DELAY_FOR_AUTOPLAY);

            LetterWwords tmp = letterList[cmboxChooseLetter.SelectedIndex];

            picLetterWWord.Image = new Bitmap("DIMAGES\\" + tmp.Letter.Image);
            SoundPlayer sp = new SoundPlayer("VOICE\\" + tmp.Letter.LetterSign + ".wav");
            sp.Play();

            await Task.Delay(Constants.DELAY_FOR_AUTOPLAY);
            if (userPressStop)
            {
                return;
            }

            foreach (Words word in tmp.LetterWordList)
            {
                picLetterWWord.Image = new Bitmap("DIMAGES\\" + word.Image);
                SetLettersPic(word.WordName);
                sp = new SoundPlayer("VOICE\\" + word.VoiceFile);
                sp.Play();
                await Task.Delay(Constants.DELAY_FOR_AUTOPLAY);
                if(userPressStop)
                {
                    return;
                }
                CleanLettersPic();
            }

            picLetterWWord.Image = new Bitmap(Constants.THE_END); ;
            picLetterChoose.Visible = true;
            picLetterChoose.Image = new Bitmap("DIMAGES\\OneMore.jpeg");
            await Task.Delay(Constants.DELAY_FOR_WIN_LOSS_ENDGAME);

            BackToStart();
        }


        //set all contros to start position
        private void BackToStart()
        {
            CleanLettersPic();
            picLetterChoose.Visible = false;
            picLetterWWord.Visible = false;
            chkboxPlayAuto.Checked = false;
            btnStart.Enabled = true;
            btnStop.Visible = false;
            btnNext.Visible = false;
            btnBack.Visible = false;
            cmboxChooseLetter.SelectedIndex = -1;
            counter = -1;
        }


        //when user press next button when play manual
        //press next present the next word
        //if the word is the last in the list, process back to menu
        private async void btnNext_Click(object sender, EventArgs e)
        {
            CleanLettersPic();
            LetterWwords tmp = letterList[cmboxChooseLetter.SelectedIndex];
            if(counter < (tmp.LetterWordList.Count - 1) && tmp.LetterWordList.Count > 0)
            {
                counter++;
                picLetterWWord.Image = new Bitmap("DIMAGES\\" + tmp.LetterWordList[counter].Image);
                SetLettersPic(tmp.LetterWordList[counter].WordName);
                SoundPlayer sp = new SoundPlayer("VOICE\\" + tmp.LetterWordList[counter].VoiceFile);
                sp.Play();
            }
            else
            {
                picLetterWWord.Image = new Bitmap(Constants.THE_END);
                picLetterWWord.Update();
                picLetterChoose.Visible = true;
                picLetterChoose.Image = new Bitmap("DIMAGES\\OneMore.jpeg");
                picLetterChoose.Update();
                await Task.Delay(Constants.DELAY_FOR_WIN_LOSS_ENDGAME);
                BackToStart();
            }
        }


        //when user play manual when he press back he go back to previous picture
        //cant go back more than the first picture
        private void btnBack_Click(object sender, EventArgs e)
        {
            CleanLettersPic();
            LetterWwords tmp = letterList[cmboxChooseLetter.SelectedIndex];
            counter--;
            if (counter > -1)
            {
                picLetterWWord.Image = new Bitmap("DIMAGES\\" + tmp.LetterWordList[counter].Image);
                SetLettersPic(tmp.LetterWordList[counter].WordName);
                SoundPlayer sp = new SoundPlayer("VOICE\\" + tmp.LetterWordList[counter].VoiceFile);
                sp.Play();
            }
            else
            {
                picLetterWWord.Image = new Bitmap("DIMAGES\\" + tmp.Letter.Image);
                SoundPlayer sp = new SoundPlayer("VOICE\\" + tmp.Letter.LetterSign + ".wav");
                sp.Play();
            }
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


        //this function send each letter of the word to create the letter a picture box 
        //and present to the user the full word
        private void SetLettersPic(string word)
        {
            for (int i = 0; i <word.Length; i++)
            {
                letterPicList.Add(AddNewPicutreBoxForLetter(Char.ToUpper(word[i])));
            }
        }


        //This function create new picturebox and load it with a letter image
        private PictureBox AddNewPicutreBoxForLetter(Char letter)
        {
            PictureBox picture = new PictureBox();

            this.Controls.Add(picture);
            picture.Top = 351;
            picture.Left = 225 + (50 * letterCounter);
            picture.Image = new Bitmap("DIMAGES\\" + letterList[letter - 65].Letter.Image);
            picture.Size = new Size(50, 60);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            letterCounter++;

            return picture;
        }


        //when user press stop when play manual or auto play 
        private void btnStop_Click(object sender, EventArgs e)
        {
            userPressStop = true;
            BackToStart();
        }

        
        //timer to check counter, if counter == -1
        //back button become disable until user press next button again 
        private void tmrLearnFromWords_Tick(object sender, EventArgs e)
        {
            if(counter == -1)
            {
                btnBack.Enabled = false;
            }
            else
            {
                btnBack.Enabled = true;
            }
        }


        //when user press back to menu this form is closed
        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
