using System;

namespace FactoryAnimals.Models.Animals
{
    public class NullAnimal : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public float Weight { get; set; }
    }
}
