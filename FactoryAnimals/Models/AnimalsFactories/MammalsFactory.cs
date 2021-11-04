using FactoryAnimals.Models.Animals;
using FactoryAnimals.Models.Animals.Mammals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAnimals.Models
{
    public class MammalsFactory
    {
        static Random random = new Random();

        public static IMammal GetMammal(string typeOfMammal,
                                        string name,
                                        int age,
                                        float weight,
                                        int numberOfCubsInLitter)
        {
            switch (typeOfMammal)
            {
                case "Bear": return new Bear(name, age, weight, numberOfCubsInLitter);
                case "Cow": return new Cow(name, age, weight, numberOfCubsInLitter);
                case "Lion": return new Lion(name, age, weight, numberOfCubsInLitter);
                default: return new NullMammal(name, age, weight, numberOfCubsInLitter);
            }
        }

        public static List<IMammal> GetRandomMammals(int count)
        {
            var mammals = new List<IMammal>();

            for (int i = 0; i < count; i++)
            {
                switch (random.Next(3))
                {
                    case 0: mammals.Add(new Bear("Bear", 13, 214F, 4)); break;
                    case 1: mammals.Add(new Cow("Cow", 6, 140F, 2)); break;
                    case 2: mammals.Add(new Lion("Lion", 8, 169F, 5)); break;
                    default: mammals.Add(new NullMammal("NullMammal", default, default, default)); break;
                }
            }

            return mammals;
        }
    }
}
