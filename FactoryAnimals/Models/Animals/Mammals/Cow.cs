using System;

namespace FactoryAnimals.Models.Animals.Mammals
{
    internal class Cow : Mammal
    {
        public Cow(string name, int age, float weight, int numberOfCubsInLitter) :
          base(name, age, weight, numberOfCubsInLitter)
        {
        }
    }
}
