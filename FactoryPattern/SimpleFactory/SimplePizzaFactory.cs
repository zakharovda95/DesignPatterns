using FactoryPattern.SimpleFactory.Enums;
using FactoryPattern.SimpleFactory.Interfaces;
using FactoryPattern.SimpleFactory.Pizza;

namespace FactoryPattern.SimpleFactory
{
    public class SimplePizzaFactory : ISimplePizzaFactory
    {
        public IPizza CreatePizza(PizzaTypeEnum type)
        {
            switch (type)
            {
                case PizzaTypeEnum.Cheese:
                    return new CheesePizza();
                case PizzaTypeEnum.Marinara:
                    return new Marinara();
                case PizzaTypeEnum.Pepperoni:
                    return new Pepperoni();
                default: return null;
            }
        }
    }
}