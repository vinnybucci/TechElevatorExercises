﻿namespace Lecture.Farming
{
    public class Pig : FarmAnimal, ISellable
    {
        public decimal Price { get; }

        public Pig() : base("Pig", "oink")
        {
            Price = 300;
        }

        public override string Eat()
        {
            return "slop";
        }
    }
}
