using System;

namespace FactoryAnimals.Models.Animals
{
    public interface IBird : IAnimal
    {
        int NumberOfFeathers { get; set; }

        void Fly();
    }
}
