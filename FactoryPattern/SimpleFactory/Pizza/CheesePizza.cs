using System;
using FactoryPattern.SimpleFactory.Interfaces;

namespace FactoryPattern.SimpleFactory.Pizza
{
    public sealed class CheesePizza : IPizza
    {
        public string Name { get; set; } = "Сырная пицца";

        public void Cook()
        {
            Console.WriteLine($"Готовим пиццу: {Name}");
        }
    }
}