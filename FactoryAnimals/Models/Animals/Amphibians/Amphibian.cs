using System;

namespace FactoryAnimals.Models.Animals.Amphibians
{
    internal abstract class Amphibian : IAmphibian
    {
        public virtual string Name { get; set; }
        public virtual int Age { get; set; }
        public virtual float Weight { get; set; }
        public virtual bool PoisonousMucus { get; set; }

        static int counter;

        public Amphibian(string name, int age, float weight, bool poisonousMucus)
        {
            counter++;
            this.Name = $"{name}_{counter}";
            this.Age = age;
            this.Weight = weight;
            this.PoisonousMucus = poisonousMucus;
        }

        public virtual void Swim()
        {
            //to do something
        }

        public override string ToString()
        {
            return $"Type is {this.GetType().Name, 10}, name - {Name, 10}, age - {Age, 3} years, " +
                $"weight - {Weight, 5} kg, poisonous mucus - {PoisonousMucus, 5}.";
        }
    }
}
