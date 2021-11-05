using FactoryAnimals;
using FactoryAnimals.Models;
using FactoryAnimals.Models.DataAccess;
using FactoryAnimals.Presenter;
using FactoryAnimals.Views;
using System;

namespace FactoryDemo_ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t-----Animal production factory.-----");

            var presenter = new Presenter(new ConsoleUI());

            presenter.GetAnimals().PrintResult();

            //var repository = new AnimalsRepository(AmphibiansFactory.GetRandomAmphibians(10));
            //repository.AddRange(BirdsFactory.GetRandomBirds(10));
            //repository.Add(MammalsFactory.GetMammal("Lion", "Лёва", 5, 6.6F, 4));

            //var dataAccess = new DataAccess(DataAccessFactories.GetDataJson(), repository);
            //dataAccess.Save();

            Console.ReadLine();
        }
    }
}
