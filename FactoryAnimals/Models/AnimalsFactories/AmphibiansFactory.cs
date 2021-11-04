using FactoryAnimals.Models.Animals;
using FactoryAnimals.Models.Animals.Amphibians;
using System;
using System.Collections.Generic;

namespace FactoryAnimals.Models
{
    public static class AmphibiansFactory
    {
        static Random random = new Random();

        public static IAmphibian GetAmphibian(string typeOfAmphibian,
                                        string name,
                                        int age,
                                        float weight,
                                        bool poisonousMucus)
        {
            switch (typeOfAmphibian)
            {
                case "Frog": return new Frog(name, age, weight, poisonousMucus);
                case "Snake": return new Snake(name, age, weight, poisonousMucus);
                case "Lizard": return new Lizard(name, age, weight, poisonousMucus);
                default: return new NullAmphibian(name, age, weight, poisonousMucus);
            }
        }

        public static List<IAmphibian> GetRandomAmphibians(int count)
        {
            var amphibians = new List<IAmphibian>();

            for (int i = 0; i < count; i++)
            {
                switch (random.Next(3))
                {
                    case 0: amphibians.Add(new Frog("Frog", 3, 0.6F, true)); break;
                    case 1: amphibians.Add(new Snake("Snake", 2, 1.4F, false)); break;
                    case 2: amphibians.Add(new Lizard("Lizard", 1, 1.8F, false)); break;
                    default: amphibians.Add(new NullAmphibian("NullAmphibian", default, default, default)); break;
                }
            }

            return amphibians;
        }

    }
}
