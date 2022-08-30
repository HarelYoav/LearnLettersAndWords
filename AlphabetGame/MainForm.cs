using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

//This is the MainForm (MainMenu)
namespace AlphabetGame
{
    public partial class MainForm : Form
    {
        Users currentuser;
        List<Users> userList = new List<Users>();
        List<WordStruct> wordList = new List<WordStruct>();
        List<LetterWwords> letterList = new List<LetterWwords>();

        public MainForm()
        {
            InitializeComponent();
            Start();
            this.BackgroundImage = new Bitmap(Constants.MAIN_FORM);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.ImeMode = ImeMode.NoControl;
        }


        //this even happed after press on login button
        //check if the user name is already in the system
        //if no open the new login window
        private void btnLogin_Click(object sender, EventArgs e)
        {
            tmrMainForm.Stop();
            btnLogin.Visible = false;
            txtUserName.Visible = false;
            lblUsername.Visible = false;
            txtUserName.Text = txtUserName.Text.ToLower();

            if(userList.Count > 0)
            {
                foreach (Users user in userList)
                {
                    if (txtUserName.Text == user.UserName)
                    {
                        currentuser = user;
                        SetMenu();
                    }
                }
            }
            if(currentuser == null)
            {
                lblWelcomeMessage.Text = "We are always happy to have new users,\n please agree to our terms to learn and have fun";
                gBoxFirstLogin.Visible = true;
            }    
        }


        //this event happend when new user is signup to the system for the first tome
        //after user read the Agreement and enter his name he can login to the system
        //the user is add to the user list
        private void btnOkName_Click(object sender, EventArgs e)
        {
            if (chkboxAgree.Checked && Regex.IsMatch(txtFirstName.Text, @"^[a-zA-Z]+$"))
            {
                currentuser = new Users(txtUserName.Text, txtFirstName.Text);
                userList.Add(currentuser);
                SaveUser();
                gBoxFirstLogin.Visible = false;
                SetMenu();
            }
            if(!chkboxAgree.Checked)
            {
                MessageBox.Show("Agree to our terms and try again");
            }
            if(!Regex.IsMatch(txtFirstName.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Name can contains letters only");
            }
        }


        //set the menu after the user login
        private void SetMenu()
        {
            lblWelcomeName.Text = "Welcome: " + currentuser.Name;
            lblWelcomeName.Visible = true;
            SetUserHighScore();
            btnLearnLetters.Visible = true;
            btnGames.Visible = true;
            btnAddWords.Visible = true;
            btnExit.Visible = true;
            chkSaveData.Visible = true;
        }

        private void SetUserHighScore()
        {
            lblUserScore.Visible = true;
            lblGuessWordScore.Text = "Guess The Word: " + currentuser.HighestScoreGuessWord;
            lblGuessWordScore.Visible = true;
            lblChooseRightPicScore.Text = "ChooseRight Picture: " + currentuser.HighestScoreGuessPicture;
            lblChooseRightPicScore.Visible = true;
            lblBuildWordScore.Text = "Build Word: " + currentuser.HighestScoreBuildWord;
            lblBuildWordScore.Visible = true;
            lblMemoryGameScore.Text = "Memory Game: " + currentuser.HighestScoreMemoryGame;
            lblMemoryGameScore.Visible = true;
        }

        //this timer check if the UserName input name is correct
        //if yes Login button is active, else is not active
        private void tmrMainForm_Tick(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtUserName.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        //open Learn Word and letters
        private void btnLearnLetters_Click(object sender, EventArgs e)
        {
            OpenNewForm(1);
        }

        //open Games form
        private void btnGames_Click(object sender, EventArgs e)
        {
            OpenNewForm(2);
        }

        //open AddWords form
        private void btnAddWords_Click(object sender, EventArgs e)
        {
            OpenNewForm(3);
            SaveNewWord();
        }


        //this function open new form with the same location of this form
        public void OpenNewForm(int option)
        {
            if(option <= 3 && option >= 1)
            {
                Form tmpForm = new Form();
                this.Hide();
                if (option == 1)
                {
                    LearnWordsForm learnWords = new LearnWordsForm(letterList);
                    tmpForm = learnWords;
                }
                if (option == 2)
                {
                    GamesForm gameForm = new GamesForm(currentuser, wordList, letterList);
                    tmpForm = gameForm;
                }
                if (option == 3)
                {
                    AddWordForm addWords = new AddWordForm(wordList, letterList);
                    tmpForm = addWords;
                }
               
                tmpForm.StartPosition = FormStartPosition.Manual;
                tmpForm.Location = this.Location;
                tmpForm.Size = this.Size;
                SetForm(ref tmpForm);
                tmpForm.ShowDialog();

                this.StartPosition = FormStartPosition.Manual;
                this.Location = tmpForm.Location;
                this.Size = tmpForm.Size;
                this.Show();
                SetUserHighScore();
            }
        }


        //this function set forms buttons
        //set to this form and forms that open from this form
        private Form SetForm(ref Form tmpFrm)
        {
            foreach (Control button in tmpFrm.Controls)
            {
                if (button is Button)
                {
                    button.BackColor = Color.White;
                    button.Font = new Font("Cooper", 8);
                    button.ForeColor = Color.Blue;
                    button.Cursor = Cursors.Hand;
                }
            }
            return tmpFrm;
        }


        //this function is been called after closing "AddWordForm"
        //add to the txt file new words the user add
        //add to both firstletterData.txt and wordImageData.txt
        private void SaveNewWord()
        {
            StreamWriter sw = new StreamWriter(Constants.FIRST_LETTER_DATA);
            foreach (LetterWwords letter in letterList)
            {
                sw.WriteLine(letter.ToString());
            }
            sw.Close();

            sw = new StreamWriter(Constants.WORD_IMAGE_DATA);
            foreach (WordStruct word in wordList)
            {
                sw.WriteLine(word.ToString());
            }
            sw.Close();
        }


        //This function is sent from the Form constructor
        //read all txt file and catch an exception if occur
        void Start()
        {
            try
            {
                ReadWords();
                ReadLetterAndWords();
                ReadUsers();
            }
            catch (ArgumentException me)
            {
                MessageBox.Show(me.Message);
            }
        }


        //this function read wordImageData.txt and enter all the word to list
        //throw exception if file not exist
        private void ReadWords()
        {
            if(File.Exists(Constants.WORD_IMAGE_DATA))
            {
                StreamReader sr = new StreamReader(Constants.WORD_IMAGE_DATA);
                string line;
                string[] word;
                char[] wordStruct;
                WordStruct tmpWord;

                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    word = line.Split(';');
                    wordStruct = new char[word.Length - 4];
                    for (int i = 4; i < word.Length; i++)
                    {
                        if(word[i].Length == 2)
                        {
                            wordStruct[i - 4] = Convert.ToChar((char)int.Parse(word[i]));
                        }
                        else
                        {
                            wordStruct[i - 4] = Char.Parse(word[i]);
                        }
                    }
                    tmpWord = new WordStruct(word[1], word[2], word[3], wordStruct);

                    foreach(WordStruct _word in wordList)
                    {
                        if (tmpWord.WordName == _word.WordName)
                        {
                            throw new DuplicateWaitObjectException("Word Data file cotain the word " + tmpWord.WordName + " 2 times");
                        }
                    }
                    wordList.Add(tmpWord);
                }
                sr.Close();
            }
            else
            {
                throw new FileNotFoundException("Word data file not exist");
            }
        }


        //this function read firstletterData.txt 
        //enter all the letter to list and match to each letter the word that start with the ame letter
        //throw exception if file not exist
        private void ReadLetterAndWords()
        {
            if (File.Exists(Constants.WORD_IMAGE_DATA))
            {
                StreamReader sr = new StreamReader(Constants.FIRST_LETTER_DATA);
                string line;
                string[] letterAndWords;
                LetterWwords tmp;
                Letter tmpLetter;

                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();
                    letterAndWords = line.Split(';');
                    tmp = new LetterWwords(tmpLetter = new Letter(int.Parse(letterAndWords[0]), Char.Parse(letterAndWords[1]),
                        letterAndWords[2]));

                    letterList.Add(tmp);

                    for (int i = 3; i < letterAndWords.Length; i += 2)
                    {
                        foreach (Words word in wordList)
                        {
                            if (word.WordName == letterAndWords[i])
                            {
                                tmp.LetterWordList.Add(word);
                            }
                        }
                    }
                }
                sr.Close();
            }
            else
            {
                throw new FileNotFoundException("letter data file not exist");
            }
        }


        //This function read the user list txt file and upload to the user list
        //throw exception if file not exist
        private void ReadUsers()
        {
            if (File.Exists(Constants.WORD_IMAGE_DATA))
            {
                StreamReader usersFile = new StreamReader(Constants.USERS_DATA);

                string line;
                string[] letterAndWords;
                Users tmpUser;

                while (!usersFile.EndOfStream)
                {
                    line = usersFile.ReadLine();
                    letterAndWords = line.Split(';');
                    tmpUser = new Users(letterAndWords[0], letterAndWords[1], int.Parse(letterAndWords[2]), int.Parse(letterAndWords[3]),
                                        int.Parse(letterAndWords[4]), int.Parse(letterAndWords[5]));

                    userList.Add(tmpUser);
                    
                    if (File.Exists("OUTPUT\\" + tmpUser.JustUserName() + "_Wrong.txt"))
                    {
                        LoadUserWrongWords(tmpUser, true);
                    }
                    if (File.Exists("OUTPUT\\" + tmpUser.JustUserName() + "_PlayedWords.txt"))
                    {
                        LoadUserWrongWords(tmpUser, false);
                    }
                }
                usersFile.Close();
            }
            else
            {
                throw new FileNotFoundException("users data file not exist");
            }
        }


        //This function load the user played word and wrong words
        //get Object user and bool to know if need to read WrongWord file if bool is true
        //if bool is false read user PlayedWord file
        //the file will keep in user WrongWords list and PlayedWord list
        private void LoadUserWrongWords(Users user, bool wrongwords)
        {
            StreamReader userWords;
            string line;
            string[] Words;

            if(wrongwords)
            {
                userWords = new StreamReader("OUTPUT\\" + user.JustUserName() + "_Wrong.txt");
            }
            else
            {
                userWords = new StreamReader("OUTPUT\\" + user.JustUserName() + "_PlayedWords.txt");
            }
            
            line = userWords.ReadLine();
            Words = line.Split(';');

            for (int i = 1; i < Words.Length; i++)
            {
                foreach (Words word in wordList)
                {
                    if (word.WordName == Words[i])
                    {
                        user.WrongWords.Add(word);
                    }
                }
            }
            userWords.Close();
        }


        //This event happen when press Exit
        //if user want to save his history the user file list is updated
        //if the user choose not to save his history so the last stats of the user wont save 
        //and the WrongWord file and PlayedWord file will be deleted (the user will stay at the users list)
        private void btnExit_Click(object sender, EventArgs e)
        {
            if(chkSaveData.Checked == true)
            {
                SaveUser();
                this.Close();
            }
            else
            {
                DialogResult dr = MessageBox.Show("All your data will be lost!", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if(dr == DialogResult.OK)
                {
                    currentuser.HighestScoreBuildWord = 0;
                    currentuser.HighestScoreGuessWord = 0;
                  
                    //Delete user data
                    if (File.Exists("OUTPUT\\" + currentuser.JustUserName() + "_Wrong" + ".txt"))
                    {
                        File.Delete("OUTPUT\\" + currentuser.JustUserName() + "_Wrong" + ".txt");
                    }
                    if (File.Exists("OUTPUT\\" + currentuser.JustUserName() + "_PlayedWords" + ".txt"))
                    {
                        File.Delete("OUTPUT\\" + currentuser.JustUserName() + "_PlayedWords" + ".txt");
                    }

                    this.Close();
                }
            }
        }


        //This function save users list to txt file
        private void SaveUser()
        {
            StreamWriter sw = new StreamWriter(Constants.USERS_DATA);
            foreach (Users user in userList)
            {
                sw.WriteLine(user.ToString());
            }
            sw.Close();
        }


        //This event happen when loading the form
        //Paint buttons and set background picture for buttons
        private void MainForm_Load(object sender, EventArgs e)
        {
            Form tmp = this;
            SetForm(ref tmp);

            btnAddWords.BackgroundImage = new Bitmap(Constants.BACKGROUND_ADD_WORD);
            btnAddWords.BackgroundImageLayout = ImageLayout.Stretch;

            btnGames.BackgroundImage = new Bitmap(Constants.BACKGROUND_PLAY_GAME);
            btnGames.BackgroundImageLayout = ImageLayout.Stretch;

            btnLearnLetters.BackgroundImage = new Bitmap(Constants.BACKGROUND_LEARN_LETTER);
            btnLearnLetters.BackgroundImageLayout = ImageLayout.Stretch;
        }

    }
}
