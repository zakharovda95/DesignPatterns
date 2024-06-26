using System;

namespace FactoryPattern.FactoryMethod.GymSubscriptions
{
    public abstract class GymSubscription
    {
        public decimal Price { get; }
        public string Description { get; }
        private int _visitsLeft = 10;

        protected GymSubscription(decimal price, string description)
        {
            Price = price;
            Description = description;
        }

        public void DecreaseVisits()
        {
            _visitsLeft -= 1;
            Console.WriteLine($"Осталось посещений: {_visitsLeft}");
        }
    }
}