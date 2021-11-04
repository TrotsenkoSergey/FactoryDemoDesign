using System;

namespace FactoryAnimals.Models.Animals.Mammals
{
    internal class Bear : Mammal 
    {
        public Bear(string name, int age, float weight, int numberOfCubsInLitter) :
           base(name, age, weight, numberOfCubsInLitter)
        {
        }
    }
}
