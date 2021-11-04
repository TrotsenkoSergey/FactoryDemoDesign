using System;

namespace FactoryAnimals.Models.Animals.Birds
{
    internal class Parrot : Bird
    {
        public Parrot(string name, int age, float weight, int numberOfFeathers) :
            base(name, age, weight, numberOfFeathers)
        {
        }
    }
}
