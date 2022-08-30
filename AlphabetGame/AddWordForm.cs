using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Text.RegularExpressions;


//This class let the user to upload new words
namespace AlphabetGame
{
    public partial class AddWordForm : Form
    {
        List<WordStruct> wordList = new List<WordStruct>();
        List<LetterWwords> letterList = new List<LetterWwords>();
        OpenFileDialog voice = new OpenFileDialog();
        OpenFileDialog picture = new OpenFileDialog();
        int AddedWordCount;

        public AddWordForm(List<WordStruct> worldList, List<LetterWwords> letterList)
        {
            InitializeComponent();
            this.wordList = worldList;
            this.letterList = letterList;
            this.BackgroundImage = new Bitmap(Constants.ADD_WORD_FORM);
           this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ImeMode = ImeMode.NoControl;
            btnBackToMenu.BackgroundImage = new Bitmap(Constants.BACK_TO_MENU_BTN);
        }


        //upload image file
        private void btnPhotoUpload_Click(object sender, EventArgs e)
        {
            picture.Filter = "Image Files(*.jpg; *jpeg; *.bmp; *.png;)| *.jpg; *jpeg; *.bmp; *.png;";
            if(picture.ShowDialog() == DialogResult.OK)
            {
                picBoxUpload.Image = new Bitmap(picture.FileName);
            }
        }


        //upload wav file
        private void btnVoiceUpload_Click(object sender, EventArgs e)
        {
            voice.Filter = "Wav Files(*.wav;) | *.wav";
            if (voice.ShowDialog() == DialogResult.OK)
            {
                string[] fileName = voice.FileName.Split('\\');
                lblVoiceFile.Text = fileName[fileName.Length - 1];
                btnPlaySound.Enabled = true;
            }
        }


        //This even happens aftre the user press on add to add new word
        //check if the word is exist if the word already in database show message to the user
        //if word no in database save the picture and voice file
        //and add word to the word list and letter list
        //the new words are saved to file once this form is closed or the user press back to menu 
        private void btnAddWord_Click(object sender, EventArgs e)
        {
            string wordToAdd = char.ToUpper(txtAddWord.Text[0]) + txtAddWord.Text.Substring(1).ToLower();

            if (CheckIfWordExist(wordToAdd))
            {
                File.Copy(voice.FileName, "VOICE\\" + wordToAdd + ".wav");
                File.Copy(picture.FileName, "DIMAGES\\" + wordToAdd + ".jpg");

                char[] wordInLetter = new char[wordToAdd.Length + 1];
                wordInLetter[0] = char.Parse(wordToAdd[0].ToString());
                wordInLetter[1] = char.Parse(wordToAdd.Length.ToString());
                for(int i = 2; i < wordInLetter.Length; i++)
                {
                    wordInLetter[i] = Char.Parse(wordToAdd[i - 1].ToString());
                }

                WordStruct tmp = new WordStruct(wordToAdd, wordToAdd + ".jpg", wordToAdd + ".wav", wordInLetter);
                wordList.Add(tmp);
                
                foreach(LetterWwords letter in letterList)
                {
                    if(tmp.WordName[0] == letter.Letter.LetterSign)
                    {
                        letter.LetterWordList.Add(tmp);
                        letter.LetterWordList.Sort();
                    }
                }
                txtAddWord.Clear();
                btnPlaySound.Enabled = false;
                MessageBox.Show("Word added successfully");
                AddedWordCount++;
            }
            else
            {
                MessageBox.Show("This word is already exist");
            }
        }


        //This function check if the word the user want to add is already in the data base
        //return true if word is not in data base and return false if word is already in data base
        private bool CheckIfWordExist(string wordToCheck)
        {
            foreach(WordStruct word in wordList)
            {
                if(wordToCheck == word.WordName)
                {
                    return false;
                }
            }
            return true;
        }

        //this timer check if the files was uploaded and the word contains only letters
        private void AddWordFormTimer_Tick(object sender, EventArgs e)
        {
            if(picture.FileName != "" && voice.FileName != "" && Regex.IsMatch(txtAddWord.Text, @"^[a-zA-Z]+$"))
            {
                btnAddWord.Enabled = true;
            }
            else
            {
                btnAddWord.Enabled = false;
            }
        }

        //back to Main Form
        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            if(AddedWordCount > 0)
            {
                MessageBox.Show("New words will be saved now");
            }
            this.Close();
        }

        //play the sound if user press the button
        //button active after the user choose the wav file
        private void btnPlaySound_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(voice.FileName);
            sp.Play();
        }
    }
}
