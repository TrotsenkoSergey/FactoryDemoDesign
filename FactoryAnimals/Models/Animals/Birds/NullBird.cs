using System;

namespace FactoryAnimals.Models.Animals.Birds
{
    internal class NullBird : Bird
    {
        public NullBird(string name, int age, float weight, int numberOfFeathers) :
            base(name, age, weight, numberOfFeathers)
        {
            this.Name = "Not Determined";
        }
    }
}
