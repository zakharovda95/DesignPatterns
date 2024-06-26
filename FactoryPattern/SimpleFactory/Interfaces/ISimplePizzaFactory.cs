using FactoryPattern.SimpleFactory.Enums;

namespace FactoryPattern.SimpleFactory.Interfaces
{
    public interface ISimplePizzaFactory
    {
        IPizza CreatePizza(PizzaTypeEnum type);
    }
}