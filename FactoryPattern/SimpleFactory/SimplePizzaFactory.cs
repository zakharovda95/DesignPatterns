using FactoryPattern.SimpleFactory.Enums;
using FactoryPattern.SimpleFactory.Interfaces;
using FactoryPattern.SimpleFactory.Pizza;

namespace FactoryPattern.SimpleFactory
{
    public class SimplePizzaFactory : ISimplePizzaFactory
    {
        public Pizza.Pizza CreatePizza(PizzaTypeEnum type)
        {
            switch (type)
            {
                case PizzaTypeEnum.Cheese:
                    return new CheesePizza("Сырная пицца");
                case PizzaTypeEnum.Marinara:
                    return new Marinara("Пицца Маринара");
                case PizzaTypeEnum.Pepperoni:
                    return new Pepperoni("Пепперони");
                default: return null;
            }
        }
    }
}