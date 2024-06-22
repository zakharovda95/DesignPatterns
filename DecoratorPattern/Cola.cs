using DecoratorPattern.Interfaces;

namespace DecoratorPattern
{
    internal sealed class Cola : IDrink
    {
        private double _price;
        private string _description;
        public Cola(double price, string desc)
        {
            _price = price;
            _description = desc;
        }

         public string GetDescription()
        {
            return _description; // корневой класс - возвращаем просто описание
        }

        public double GetPrice()
        {
            return _price; // корневой класс - возвращаем просто описание
        }
    }
}