using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryAnimals.Models.Animals.Birds
{
    internal class Eagle : Bird
    {
        public Eagle(string name, int age, float weight, int numberOfFeathers) :
            base(name, age, weight, numberOfFeathers)
        {
        }
    }
}
