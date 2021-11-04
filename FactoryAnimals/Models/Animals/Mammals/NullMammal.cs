using System;

namespace FactoryAnimals.Models.Animals.Mammals
{
    internal class NullMammal : Mammal
    {
        public NullMammal(string name, int age, float weight, int numberOfCubsInLitter) :
            base(name, age, weight, numberOfCubsInLitter)
        {
            this.Name = "Not Determined";
        }
    }
}
