using System;

namespace FactoryAnimals.Models.Animals.Mammals
{
    internal abstract class Mammal : IMammal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public float Weight { get; set; }
        public int NumberOfCubsInLitter { get; set; }
        
        static int counter;

        public Mammal(string name, int age, float weight, int numberOfCubsInLitter)
        {
            counter++;
            this.Name = $"{name}_{counter}";
            this.Age = age;
            this.Weight = weight;
            this.NumberOfCubsInLitter = numberOfCubsInLitter;
        }

        public void Think()
        {
            //to do something
        }

        public override string ToString()
        {
            return $"Type is {this.GetType().Name, 10}, name - {Name, 10}, age - {Age, 3} years, " +
                $"weight - {Weight, 5} kg, number of cubs in litter - {NumberOfCubsInLitter, 2}.";
        }
    }
}
