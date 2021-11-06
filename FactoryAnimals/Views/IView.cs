using System;

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
