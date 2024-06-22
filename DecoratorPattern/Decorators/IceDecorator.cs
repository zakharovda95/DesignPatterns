using DecoratorPattern.Interfaces;

namespace DecoratorPattern.Decorators
{
    internal sealed class IceDecorator : DrinkDecorator
    {
        public IceDecorator(IDrink drink, double price, string desc) : base(drink, price, desc)
        {
        }

        public override string GetDescription()
        {
            return _drink.GetDescription() + " + " + _description; // добавили новый функционал к старому
        }

        public override double GetPrice()
        {
            return _drink.GetPrice() + _price; // добавили новый функционал к старому
        }
    }
}