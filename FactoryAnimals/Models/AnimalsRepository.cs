using FactoryAnimals.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FactoryAnimals
{
    public class AnimalsRepository
    {
        private List<IAnimal> animals;

        public List<IAnimal> Animals { get => animals; }

        public AnimalsRepository()
        {
            animals = new List<IAnimal>();
        }

        public AnimalsRepository(IEnumerable<IAnimal> animals)
        {
            this.animals = animals.ToList();
        }

        public void Add(IAnimal concreteAnimal)
        {
            animals.Add(concreteAnimal);
        }

        public void AddRange(IEnumerable<IAnimal> otherAnimals)
        {
            animals.AddRange(otherAnimals);
        }
    }
}
