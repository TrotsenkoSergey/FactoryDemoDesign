using System;

namespace FactoryAnimals.Models.Animals.Amphibians
{
    internal class Frog : Amphibian
    {
        public Frog(string name, int age, float weight, bool poisonousMucus) : 
            base(name, age, weight, poisonousMucus)
        {
        }
    }
}
