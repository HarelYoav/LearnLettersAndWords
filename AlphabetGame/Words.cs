using System;
using System.Text.RegularExpressions;


//this class called Word
//use icomparable interface for compareTo function
//also include toString
//Throw excepstion if word name is not only letters
namespace AlphabetGame
{
    public abstract class Words :IComparable
    {
        int wordNum;
        string wordName;
        string image;
        string voiceFile;
        static int actualWordNum;

        public int WordNum { get => wordNum;}
        public string Image { get => image;}
        public string VoiceFile { get => voiceFile;}

        public string WordName 
        { 
            get => wordName; 

            set
            {
                if(Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                {
                    wordName = value;
                }
                else
                {
                    throw new Exception("Word name can contains only letter and cant be empty");
                }
            }  
        }

        public static int ActualWordNum { get => actualWordNum;}

        public Words (string word, string image, string voiceFile)
        {
            wordNum = ++actualWordNum;
            WordName = word;
            this.image = image;
            this.voiceFile = voiceFile;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Words))
            {
                throw new ArgumentException("This is not Word, cant copmare it");
            }
            return WordName.Length.CompareTo(((Words)obj).WordName.Length);
        }

        public override string ToString()
        {
            return WordNum + ";" + WordName + ";" + Image + ";" + VoiceFile;
        }
    }
}
