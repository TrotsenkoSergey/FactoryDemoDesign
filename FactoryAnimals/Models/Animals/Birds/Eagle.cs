using System;

namespace FactoryAnimals.Models.Animals.Birds
{
    internal class Eagle : Bird
    {
        public Eagle(string name, int age, float weight, int numberOfFeathers) :
            base(name, age, weight, numberOfFeathers)
        {
        }
    }
}
