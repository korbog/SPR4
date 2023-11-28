using System;

namespace Lab
{
    public abstract class Animal
    {
        private string name;

        protected Animal(string name)
        {
            this.name = name;
            Console.WriteLine($"Animal constructor ({name})");
        }

        public abstract void AnimalSound();

        ~Animal()
        {
            Console.WriteLine($"Animal destructor");
        }
    }
}