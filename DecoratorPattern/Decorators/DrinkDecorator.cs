using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Decorators
{
    internal abstract class DrinkDecorator : IDrink
    {
        protected IDrink _drink;
        protected double _price;
        protected string _description;

        internal DrinkDecorator(IDrink drink, double price, string description)
        {
            _drink = drink;
            _price = price;
            _description = description;
        }
        
        public abstract string GetDescription();
        public abstract double GetPrice();
    }
}