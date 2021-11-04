using System;

namespace FactoryAnimals.Models.Animals.Amphibians
{
    internal class Snake : Amphibian
    {
        public Snake(string name, int age, float weight, bool poisonousMucus) :
            base(name, age, weight, poisonousMucus)
        {
        }
    }
}
