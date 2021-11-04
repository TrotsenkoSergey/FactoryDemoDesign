using System;

namespace FactoryAnimals.Models.Animals.Birds
{
    internal abstract class Bird : IBird
    {
        public virtual string Name { get; set; }
        public virtual int Age { get; set; }
        public virtual float Weight { get; set; }
        public virtual int NumberOfFeathers { get; set; }

        static int counter;

        public Bird(string name, int age, float weight, int numberOfFeathers)
        {
            counter++;
            this.Name = $"{name}_{counter}";
            this.Age = age;
            this.Weight = weight;
            this.NumberOfFeathers = numberOfFeathers;
        }

        public virtual void Fly()
        {
            //to do something
        }

        public override string ToString()
        {
            return $"Type is {this.GetType().Name, 10}, name - {Name, 10}, age - {Age, 3} years, " +
                $"weight - {Weight, 5} kg, number of feathers - {NumberOfFeathers, 5}.";
        }
    }
}
