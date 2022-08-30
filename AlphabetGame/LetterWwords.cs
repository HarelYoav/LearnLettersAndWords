using System.Collections.Generic;


//This class hold objetc of type Letter and each Letter hold a list of word thta start with the same letter
namespace AlphabetGame
{
    public class LetterWwords
    {
        Letter letter;
        List<Words> letterWordList;

        public Letter Letter { get => letter; set => letter = value; }
        public List<Words> LetterWordList { get => letterWordList; set => letterWordList = value; }

        public LetterWwords(Letter letter)
        {
            Letter = letter;
            letterWordList = new List<Words>();
        }

        public override string ToString()
        {
            string stringToReturn = letter.LetterNum + ";" + letter.LetterSign + ";" + letter.Image;
            foreach(Words word in letterWordList)
            {
                stringToReturn += ";" + word.WordName + ";" + word.Image;
            }
            return stringToReturn;
        }
    }
}
