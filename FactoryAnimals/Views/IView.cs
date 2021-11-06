using FactoryAnimals.Models.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAnimals.Views
{
    public interface IView
    {
        int MainMenu();

        Type GetData();

        void SaveInfo(string pathToFile);

        Type ChoiceOfAnimalClass();

        string TypeOfSelection(Type animalClass);

        MethodOfCreation MethodOfCreation();

        int CountOfAnimals { get; }

        string Name { get; }

        int Age { get; }

        float Weight { get; }

        bool PoisonousMucus { get; }

        int NumberOfFeathers { get; }

        int NumberOfCubsInLitter { get; }

        string PrintResult { set; }

        void ExitMenu();
    }
}
