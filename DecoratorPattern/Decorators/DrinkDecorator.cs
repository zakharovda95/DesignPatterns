namespace DecoratorPattern.Decorators
{
    internal abstract class DrinkDecorator : Drink
    {
        protected Drink _drink; // наследуется
        internal DrinkDecorator(Drink drink, double price, string description) : base(price, description)
        {
            _drink = drink;
        }
    }
}