using System;

namespace FactoryAnimals.Models.Animals.Amphibians
{
    internal class NullAmphibian : Amphibian
    {
        public NullAmphibian(string name, int age, float weight, bool poisonousMucus) :
            base(name, age, weight, poisonousMucus)
        {
            this.Name = "Not Determined";
        }
    }
}
