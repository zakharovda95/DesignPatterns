using FactoryPattern.SimpleFactory.Enums;

namespace FactoryPattern.SimpleFactory.Interfaces
{
    public interface ISimplePizzaFactory
    {
        Pizza.Pizza CreatePizza(PizzaTypeEnum type);
    }
}