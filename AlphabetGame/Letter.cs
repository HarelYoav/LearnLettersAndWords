

//This is Letter class
//hold each letter information
namespace AlphabetGame
{

    public class Letter
    {
        int letterNum;
        char letterSign;
        string image;
       
        public int LetterNum { get => letterNum; }
        public string Image { get => image;}

        public char LetterSign 
        {
            get
            {
                return letterSign;
            }
        }

        public Letter(int letterNum, char letterSign, string image)
        {
            this.letterNum = letterNum;
            this.letterSign = letterSign;
            this.image = image;
        }
    }
}
