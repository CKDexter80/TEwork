namespace Lecture.Farming
{
    /// <summary>
    /// A base farm animal class.
    /// </summary>
    public class FarmAnimal: ISing // also all subclasses will implement
    {
        /// <summary>
        /// The farm animal's name.
        /// </summary>
        public string Name { get; }


        /// <summary>
        /// The farm animal's sound
        /// </summary>
        public string Sound { get; }

        /// <summary>
        /// Creates a new farm animal.
        /// </summary>
        /// <param name="name">The name which the animal goes by.</param>
        public FarmAnimal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }

        public virtual string MakeSound()
        {
            return "animal sounds";
        }

    }
}
