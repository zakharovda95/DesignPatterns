namespace DecoratorPattern
{
    internal sealed class Coffee : Drink
    {
        public Coffee(double price, string customDescription = null) : base(price, customDescription ?? "Кофе")
        {
            // какие то другие инициализации
        }

        internal override string GetDescription()
        {
            return Description; // корневой класс - возвращаем просто описание
        }

        internal override double GetPrice()
        {
            return Price; // корневой класс возвращаем просто описание
        }
    }
}