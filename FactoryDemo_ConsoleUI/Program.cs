using FactoryAnimals;
using FactoryAnimals.Models;
using System;

namespace FactoryDemo_ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new AnimalsRepository(AmphibiansFactory.GetRandomAmphibians(10));

            repository.AddRange(BirdsFactory.GetRandomBirds(10));

            repository.Add(MammalsFactory.GetMammal("Lion", "Лёва", 5, 6.6F, 4));

            repository.PrintRepository();

            Console.ReadLine();
        }
    }
}
