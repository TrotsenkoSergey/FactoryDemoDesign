﻿using System;

namespace FactoryAnimals.Models.Animals.Amphibians
{
    internal class Lizard : Amphibian
    {
        public Lizard(string name, int age, float weight, bool poisonousMucus) : 
            base(name, age, weight, poisonousMucus)
        {
        }
    }
}
