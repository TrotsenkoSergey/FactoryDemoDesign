using System;

namespace FactoryAnimals.Models.Animals
{
    public interface IAmphibian : IAnimal
    {
        bool PoisonousMucus { get; set; }

        void Swim();
    }
}
