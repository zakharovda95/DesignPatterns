namespace DecoratorPattern.Decorators
{
    internal class SomeSyrupDecorator : DrinkDecorator
    {
        public SomeSyrupDecorator(Drink drink, double price, string description) : base(drink, price, description)
        {
        }

        internal override string GetDescription()
        {
            throw new System.NotImplementedException();
        }

        internal override double GetPrice()
        {
            throw new System.NotImplementedException();
        }
    }
}