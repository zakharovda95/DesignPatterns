using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Decorators
{
    internal class SomeSyrupDecorator : DrinkDecorator
    {
        public SomeSyrupDecorator(IDrink drink, double price, string desc) : base(drink, price, desc)
        {
        }

        public override string GetDescription()
        {
            return _drink.GetDescription() + " + " + _description; // новый функционал
        }

        public override double GetPrice()
        {
            return _drink.GetPrice() + _price; // новый функционал
        }
    }
}