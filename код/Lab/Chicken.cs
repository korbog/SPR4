using System;

namespace Lab
{
    public class Chicken : Animal
    {
        public Chicken(string name) : base(name)
        {
            Console.WriteLine($"Chicken constructor ({name})");
        }

        public override void AnimalSound()
        {
            Console.WriteLine("Coo-coo-coo-coo-coo!");
        }

        ~Chicken()
        {
            Console.WriteLine("Chicken destructor");
        }
    }
}
