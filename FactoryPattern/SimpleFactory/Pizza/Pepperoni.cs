using System;
using FactoryPattern.SimpleFactory.Interfaces;

namespace FactoryPattern.SimpleFactory.Pizza
{
    public sealed class Pepperoni : IPizza
    {
        public string Name { get; set; } = "Пепперони";
        public void Cook()
        {
            Console.WriteLine($"Готовим пиццу: {Name}");
        }
    }
}