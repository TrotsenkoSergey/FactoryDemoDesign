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

            presenter.Run();
        }
    }
}
