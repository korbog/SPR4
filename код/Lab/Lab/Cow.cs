using System;

namespace Lab
{
    public class Cow : Animal
    {
        public Cow(string name) : base(name) 
        {
            Console.WriteLine($"Cow constructor ({name})");
        }

        public override void AnimalSound()
        {
            Console.WriteLine("Moo!!");
        }

        ~Cow()
        {
            Console.WriteLine("Cow destructor");
        }
    }
}
