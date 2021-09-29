namespace Lecture.Farming
{
    public class Cow : FarmAnimal , IMow
    {
        public Cow() : base("Cow", "moo")
        {
        }

        public string MilkCow()
        {
            return "heres some milk";
        }
        //override
        public override string MakeSound()
        {
            //provides a cow-specific make sound implementation
           return "mooo";
        }

        //overloading
        public string MakeSound(int number)
        {
            string output = "";
            for (int i = 0; i < number; i++)
            {
                output += MakeSound() + " ";
            }

            return output;
        }

        public void Mow()
        {
            System.Console.WriteLine("Chomp, chomp");
        }
    }
}
