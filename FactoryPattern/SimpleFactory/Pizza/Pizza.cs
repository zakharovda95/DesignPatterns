using System;

namespace FactoryPattern.SimpleFactory.Pizza
{
    public abstract class Pizza
    {
        private readonly string _name;
        internal Pizza(string name)
        {
            _name = name;
        }
        
        public void Cook()
        {
            Console.WriteLine($"Готовим пиццу: {_name}");
        }
    }
}