using System;


//This class Called Word Struct
//inherited from Words
//Hold Extra object of type Char Array that holds the letter of the word and the number of letter
namespace AlphabetGame
{
    public class WordStruct :Words
    {
        char[] wordInfo;

        public WordStruct (string word, string image, string voiceFile, char[] wordInfo) :base(word, image, voiceFile)
        {
            this.WordInfo = wordInfo;
        }

        public char[] WordInfo { get => wordInfo; set => wordInfo = value; }

        public override string ToString()
        {
            string stringToReturn = null;
            
            foreach (char str in WordInfo)
            {
                if(Convert.ToInt32(str) >= 10 && Convert.ToInt32(str) <= 20)
                {
                    stringToReturn += ";" + (int)str;
                }
                else
                {
                    stringToReturn += ";" + str;
                }
            }
            return base.ToString() + stringToReturn;
        }
    }
}
