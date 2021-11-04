using System;

namespace FactoryAnimals.Models
{
    public interface IAnimal
    {
        string Name { get; set; }

        int Age { get; set; }

        float Weight { get; set; }
    }
}
