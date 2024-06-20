namespace DecoratorPattern.Decorators
{
    internal sealed class IceDecorator : DrinkDecorator
    {
        public IceDecorator(Drink drink, double price, string description) : base(drink, price, description)
        {
        }

        internal override string GetDescription()
        {
            return Description + " со льдом"; // добавили новый функционал к старому
        }

        internal override double GetPrice()
        {
            throw new System.NotImplementedException();
        }
    }
}