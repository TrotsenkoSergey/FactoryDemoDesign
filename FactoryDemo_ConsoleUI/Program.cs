using FactoryAnimals;
using FactoryAnimals.Models;
using FactoryAnimals.Models.DataAccess;
using System;

namespace FactoryDemo_ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Animal production factory.-----");
            //Console.WriteLine("Choose animal you want to create:\n1. mammals;\n2. amphibians;\n3. birds");
            
            var repository = new AnimalsRepository(AmphibiansFactory.GetRandomAmphibians(10));

            repository.AddRange(BirdsFactory.GetRandomBirds(10));

            repository.Add(MammalsFactory.GetMammal("Lion", "Лёва", 5, 6.6F, 4));

            repository.PrintRepository();

            var dataAccess = new DataAccess(DataAccessFactories.GetDataTxt(), repository);
            dataAccess.Save();

            Console.ReadLine();
        }
    }
}
