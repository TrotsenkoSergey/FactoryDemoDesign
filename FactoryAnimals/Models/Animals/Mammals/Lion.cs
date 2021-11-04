using System;

namespace FactoryAnimals.Models.Animals.Mammals
{
    internal class Lion : Mammal
    {
        public Lion(string name, int age, float weight, int numberOfCubsInLitter) :
          base(name, age, weight, numberOfCubsInLitter)
        {
        }
    }
}
