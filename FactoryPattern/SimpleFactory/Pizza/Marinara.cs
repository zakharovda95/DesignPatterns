using System;
using FactoryPattern.SimpleFactory.Interfaces;

namespace FactoryPattern.SimpleFactory.Pizza
{
    public sealed class Marinara : IPizza
    {
        public string Name { get; set; } = "Маринара";
        public void Cook()
        {
            Console.WriteLine($"Готовим пиццу: {Name}");
        }
    }
}