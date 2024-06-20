namespace DecoratorPattern
{
    internal sealed class Tea : Drink
    {
        internal Tea(double price, string customDescription) : base(price, customDescription ?? "Кола") {}
        internal override string GetDescription()
        {
            return Description; // корневой элемент - просто возвращаем описание
        }

        internal override double GetPrice()
        {
            return Price; // корневой элемент - просто возвращаем цену
        }
    }
}