using System;

namespace FactoryAnimals.Models.Animals
{
    public interface IMammal : IAnimal
    {
        int NumberOfCubsInLitter { get; set; }

        void Think();
    }
}
