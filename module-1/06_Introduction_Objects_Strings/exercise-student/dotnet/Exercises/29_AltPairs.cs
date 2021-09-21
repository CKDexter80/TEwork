namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a string made of the chars at indexes 0,1, 4,5, 8,9 ... so "kittens" yields "kien".
        AltPairs("kitten") → "kien"
        AltPairs("Chocolate") → "Chole"
        AltPairs("CodingHorror") → "Congrr"
        */
        public string AltPairs(string str)
        {
            string pairsRemovedString = "";
            int letterCounter = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (letterCounter == 2)
                {
                    letterCounter = 0;
                    i++;
                }
                else
                {
                    pairsRemovedString += str[i];
                    letterCounter++;
                }
            }            
            return pairsRemovedString;
        }
    }
}
