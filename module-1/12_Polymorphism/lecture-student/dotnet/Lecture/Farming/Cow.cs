namespace Lecture.Farming
{
    public class Cow : FarmAnimal, IMow
    {
        public Cow() : base("Cow", "moo")
        {
        }
        //overriding
        public override string MakeSound()
        {
            return "moo";
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
            Console.WriteLine("chomp, chomp");
        }
    }
}
