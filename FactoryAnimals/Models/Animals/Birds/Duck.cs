using System;

namespace FactoryAnimals.Models.Animals.Birds
{
    internal class Duck : Bird
    {
        public Duck(string name, int age, float weight, int numberOfFeathers) :
            base(name, age, weight, numberOfFeathers)
        {
        }
    }
}
