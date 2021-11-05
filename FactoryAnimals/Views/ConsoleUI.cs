using FactoryAnimals.Models.Animals.Amphibians;
using FactoryAnimals.Models.Animals.Birds;
using FactoryAnimals.Models.Animals.Mammals;
using System;

namespace FactoryAnimals.Views
{
    public class ConsoleUI : IView
    {
        private const string ERROR = "Invalid value, please enter again: ";

        public void ChoiceOfAnimalSpecies() =>
            Console.WriteLine($"Choose animal you want to create (add to your repository):" +
                $"\n1. {nameof(Mammal)};\n2. {nameof(Amphibian)};\n3. {nameof(Bird)}.");

        public int MenuSelection(int numberOfSelectedElements)
        {
            Console.Write("Choose a value: ");
            return CheckCorrect(numberOfSelectedElements);
        }
        
        public int CountOfAnimals 
        {
            get 
            {
                Console.Write("Choose count of animals: ");
                return CheckCorrect(int.MaxValue);
            } 
        }

        public string Result { set => Console.WriteLine(value); }

        private int CheckCorrect(int numberOfSelectedElements)
        {
            string valueStr;
            int value;
            bool isCorrect;
            do
            {
                valueStr = Console.ReadLine();
                isCorrect = Int32.TryParse(valueStr, out value) 
                    && value > 0 && value <= numberOfSelectedElements;
                if (!isCorrect) Console.Write(ERROR);
            }
            while (!isCorrect);
            return value;
        }

    }
}
