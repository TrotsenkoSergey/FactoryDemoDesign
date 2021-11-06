using FactoryAnimals.Models.Animals;
using FactoryAnimals.Models.Animals.Amphibians;
using FactoryAnimals.Models.Animals.Birds;
using FactoryAnimals.Models.Animals.Mammals;
using FactoryAnimals.Models.DataAccess;
using System;

namespace FactoryAnimals.Views
{
    public class ConsoleUI : IView
    {
        private const string ERROR = "Invalid value, please enter again: ";

        public int MainMenu()
        {
            Console.WriteLine("\nChoose:\n'1' to create animals,\n'2' - save Data,\n'3' - exit");
            Console.Write("Choose a value: ");
            return CheckCorrect(3);
        }

        public void ExitMenu() 
        {
            Console.WriteLine("\nGood Luck, press Enter key to exit...");
            Console.ReadLine();
        }

        public Type GetData()
        {
            Console.WriteLine($"\nIndicate type of Data in wich you want to save:" +
                    $"\n1. {nameof(DataJson)};\n2. {nameof(DataTxt)};\n3. {nameof(DataXml)}.");

            Console.Write("Choose a value: ");
            switch (CheckCorrect(3))
            {
                case 1: return typeof(DataJson);
                case 2: return typeof(DataTxt);
                case 3: return typeof(DataXml);
                default: return typeof(DataJson);
            }
        }

        public void SaveInfo(string pathToFile) 
        {
            Console.WriteLine($"\nSave successful!\nFile - {pathToFile}");
        }

        public Type ChoiceOfAnimalClass()
        {
            Console.WriteLine($"\nChoose animal you want to create (add to your repository):" +
                $"\n1. {nameof(Mammal)};\n2. {nameof(Amphibian)};\n3. {nameof(Bird)}.");

            Console.Write("Choose a value: ");
            switch (CheckCorrect(3))
            {
                case 1: return typeof(Mammal);
                case 2: return typeof(Amphibian);
                case 3: return typeof(Bird);
                default: return typeof(NullAnimal);
            }
        }

        public string TypeOfSelection(Type animalClass)
        {
            string firstType = "", secondType = "", thirdType = "", defaultType = "";

            if (animalClass == typeof(Mammal))
            {
                firstType = nameof(Bear);
                secondType = nameof(Cow);
                thirdType = nameof(Lion);
            }
            else if (animalClass == typeof(Amphibian))
            {
                firstType = nameof(Frog);
                secondType = nameof(Lizard);
                thirdType = nameof(Snake);
            }
            else if (animalClass == typeof(Bird))
            {
                firstType = nameof(Duck);
                secondType = nameof(Eagle);
                thirdType = nameof(Parrot);
            }

            Console.WriteLine($"\nChoose type of selected animal you want to create " +
                $"(add to your repository):" +
                $"\n1. {firstType};\n2. {secondType};\n3. {thirdType}.");

            Console.Write("Choose a value: ");
            switch (CheckCorrect(3))
            {
                case 1: return firstType;
                case 2: return secondType;
                case 3: return thirdType;
                default: return defaultType;
            }
        }

        public MethodOfCreation MethodOfCreation()
        {
            Console.WriteLine("\nChoose creation method:\n1. Randomly,\n2. Manually.");
            Console.Write("Choose a value: ");
            switch (CheckCorrect(2))
            {
                case 1: return Views.MethodOfCreation.Randomly;
                case 2: return Views.MethodOfCreation.Manually;
            }

            return Views.MethodOfCreation.None;
        }

        public int CountOfAnimals
        {
            get
            {
                Console.Write("\nChoose count of animals: ");
                return CheckCorrect(int.MaxValue);
            }
        }

        public string Name
        {
            get
            {
                Console.Write("\nEnter name of animal: ");
                return Console.ReadLine();
            }
        }

        public int Age
        {
            get
            {
                Console.Write("Enter Age of animal: ");
                return CheckCorrect(100);
            }
        }

        public float Weight
        {
            get
            {
                Console.Write("Enter weight of animal: ");
                float.TryParse(Console.ReadLine(), out float value);
                return value;
            }
        }

        public bool PoisonousMucus
        {
            get
            {
                Console.Write("Choose '1' if amphibian is poisonous mucus or '2' if not: ");
                return CheckCorrect(2) == 1;
            }
        }

        public int NumberOfFeathers
        {
            get
            {
                Console.Write("Enter number of feathers: ");
                return CheckCorrect(1000000);
            }
        }

        public int NumberOfCubsInLitter
        {
            get
            {
                Console.Write("Enter number of cubs in litter: ");
                return CheckCorrect(20);
            }
        }

        public string PrintResult
        {
            set
            {
                Console.WriteLine(value + "\n\nPress any key...");
                Console.ReadLine();
            }

        }

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
