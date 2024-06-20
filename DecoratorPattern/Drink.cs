namespace DecoratorPattern
{
    internal abstract class Drink
    {
        internal Drink(double price, string description)
        {
            Description = description;
            Price = price;
        }
        
        internal string Description { get; private set; }
        internal double Price { get; private set; }
        
        internal abstract string GetDescription();
        internal abstract double GetPrice();
    }
}