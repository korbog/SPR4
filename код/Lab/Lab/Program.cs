using System;
using System.Collections.Generic;

namespace Lab
{
    class Program
    {
        static void Main()
        {
            var animals = new List<Animal>() { 
                new Cow("Noel"), 
                new Chicken("Subaru")
            };

            foreach (var animal in animals)
            {
                animal.AnimalSound();
            }
        }
    }
}
