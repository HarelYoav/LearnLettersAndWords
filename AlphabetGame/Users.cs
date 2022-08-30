using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;


//This is the users class
//hold each user statics: highscore in games and wrong and played words
//Throw exception if user name is not an email format type
//include 2 costructor: constructor for new users and constructor for old users
namespace AlphabetGame 
{
    public class Users 
    {
        string userName;
        string name;
        int highestScoreBuildWord;
        int highestScoreGuessWord;
        int highestScoreGuessPicture;
        int highestScoreMemoryGame;
        List<Words> wrongWords;
        List<int> playedWords;

        public string UserName 
        { 
            get => userName;
            
            set
            {
                if(CheckUserName(value))
                {
                    userName = value.ToLower();
                }
                else
                {
                    throw new ArgumentException("user name is not valid");
                }
            }
        }

        public string Name 
        { 
            get => name; 
            set => name = value; 
        }

        public int HighestScoreBuildWord 
        { 
            get
            {
                return highestScoreBuildWord;
            }
            set
            {
                highestScoreBuildWord = value;
            }
        }

        public int HighestScoreGuessWord 
        {
            get
            {
                return highestScoreGuessWord;
            }

            set
            {
                highestScoreGuessWord = value;
            }
        }

        public List<Words> WrongWords { get => wrongWords; set => wrongWords = value; }
        public List<int> PlayedWords { get => playedWords; set => playedWords = value; }
        public int HighestScoreGuessPicture { get => highestScoreGuessPicture; set => highestScoreGuessPicture = value; }
        public int HighestScoreMemoryGame { get => highestScoreMemoryGame; set => highestScoreMemoryGame = value; }

        public Users (string userName, string name)
        {
            UserName = userName;
            Name = name;
            highestScoreBuildWord = 0;
            highestScoreGuessWord = 0;
            highestScoreGuessPicture = 0;
            highestScoreMemoryGame = 0;
            WrongWords = new List<Words>();
            PlayedWords = new List<int>();
        }

        public Users(string username, string name, int highestScoreBuildWord, int highestScoreGuessWord, int highestScoreGuessPicture, int highestScoreMemoryGame)
        {
            UserName = username;
            Name = name;
            HighestScoreBuildWord = highestScoreBuildWord;
            HighestScoreGuessWord = highestScoreGuessWord;
            HighestScoreGuessPicture = highestScoreGuessPicture;
            HighestScoreMemoryGame = highestScoreMemoryGame;
            WrongWords = new List<Words>();
            PlayedWords = new List<int>();
        }

        //check if user name is in the correct form as email address
        private bool CheckUserName(string name)
        {
            if (Regex.IsMatch(name, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return UserName + ";" + name + ";" + highestScoreBuildWord + ";" + highestScoreGuessWord + ";" + highestScoreGuessPicture +  ";" + highestScoreMemoryGame;
        }


        //This function return just the user name with out @Email..
        public string JustUserName()
        {
            string[] lines = userName.Split('@');
            string justUserName = lines[0];

            return justUserName;
        }


        //this function print to file the words that the user played
        public void PrintPlayedWordToFile(List<WordStruct> wordList)
        {
            string result = userName;

            foreach (int word in playedWords)
            {
                result += ";" + wordList[word].WordName;
            }
            File.WriteAllText("OUTPUT\\" + JustUserName() + "_PlayedWords" + ".txt", result);
        }


        //This function add wrong words to user words list
        //check if the word is already in the list
        //if the word is already in the list it wont add
        public void UserWrong(string wrongWord, List<WordStruct> list)
        {
            foreach (WordStruct word in list)
            {
                if (word.WordName == wrongWord)
                {
                    if (!WrongWords.Contains(word))
                    {
                        WrongWords.Add((Words)word);
                        PrintWrongWordToFile();
                    }
                }
            }
        }


        //This function print user wrong words to file
        public void PrintWrongWordToFile()
        {
            string result = userName;

            foreach(Words word in WrongWords)
            {
                result += ";" + word.WordName;
            }
            File.WriteAllText("OUTPUT\\" + JustUserName() + "_Wrong" + ".txt", result);
        }
    }
}
