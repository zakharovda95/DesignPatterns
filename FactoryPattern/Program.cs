using FactoryPattern.FactoryMethod;
using FactoryPattern.FactoryMethod.Enums;
using FactoryPattern.SimpleFactory;
using FactoryPattern.SimpleFactory.Enums;

namespace FactoryPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Простая фабрика (за создание объектов отвечает конкретный класс-фабрика)
            var simplePizzaFactory = new SimplePizzaFactory();
            var cheesePizza = simplePizzaFactory.CreatePizza(PizzaTypeEnum.Cheese);
            cheesePizza.Cook();

            var peperoni = simplePizzaFactory.CreatePizza(PizzaTypeEnum.Pepperoni);
            peperoni.Cook();

            var marinara = simplePizzaFactory.CreatePizza(PizzaTypeEnum.Marinara);
            marinara.Cook();
            
            // Фабричный метод (создание объектов делигируется субклассам)
            var spbGym = new SpbGym();
            var spbSubscription = spbGym.BuySubscription(SubscriptionTypeEnum.Classic);
            spbGym.Visit(spbSubscription);
            spbGym.Visit(spbSubscription);

            var moscowGym = new MoscowGym();
            var moscowSubscription = moscowGym.BuySubscription(SubscriptionTypeEnum.Extra);
            moscowGym.Visit(moscowSubscription);
            moscowGym.Visit(moscowSubscription);
            moscowGym.Visit(moscowSubscription);
            
            // Абстрактная фабрика (создает семейства взаимосвязанных или взаимозаменяемых объектов)
        }
    }
}