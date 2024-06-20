namespace DecoratorPattern
{
    internal sealed class Cola : Drink
    {
        public Cola(double price, string customDescription) : base(price, customDescription ?? "Кола")
        {
        }

        internal override string GetDescription()
        {
            return Description;
        }

        internal override double GetPrice()
        {
            return Price;
        }
    }
}