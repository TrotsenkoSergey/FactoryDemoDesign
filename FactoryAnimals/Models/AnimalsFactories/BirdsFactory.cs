using FactoryAnimals.Models.Animals;
using FactoryAnimals.Models.Animals.Birds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAnimals.Models
{
    public class BirdsFactory
    {
        static Random random = new Random();

        public static IBird GetBird(string typeOfBird,
                                    string name,
                                    int age,
                                    float weight,
                                    int numberOfFeathers)
        {
            switch (typeOfBird)
            {
                case "Duck": return new Duck(name, age, weight, numberOfFeathers);
                case "Eagle": return new Eagle(name, age, weight, numberOfFeathers);
                case "Parrot": return new Parrot(name, age, weight, numberOfFeathers);
                default: return new NullBird(name, age, weight, numberOfFeathers);
            }
        }

        public static List<IBird> GetRandomBirds(int count)
        {
            var birds = new List<IBird>();

            for (int i = 0; i < count; i++)
            {
                switch (random.Next(3))
                {
                    case 0: birds.Add(new Duck("Duck", 3, 2.6F, 1250)); break;
                    case 1: birds.Add(new Eagle("Eagle", 8, 7.4F, 2980)); break;
                    case 2: birds.Add(new Parrot("Parrot", 4, 1.8F, 1400)); break;
                    default: birds.Add(new NullBird("NullBird", default, default, default)); break;
                }
            }

            return birds;
        }
    }
}
