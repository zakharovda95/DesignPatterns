using System;
using DecoratorPattern.Decorators;

namespace DecoratorPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var cola = new Cola(12.0, "Кока-кола");
            Console.WriteLine("Чистая кола: " + cola.GetDescription() + " -> " + cola.GetPrice() + "$");

            var ice = new IceDecorator(cola, 0.5, "Лед");
            Console.WriteLine("Кола со льдом: " + ice.GetDescription() + " -> " + ice.GetPrice() + "$");

            var someSyrup = new SomeSyrupDecorator(cola, 1, "Ванильный сироп");
            Console.WriteLine("Кола без льда с ванильным сиропом: " + someSyrup.GetDescription() + " -> " + someSyrup.GetPrice() + "$");

            var someSyrup2 = new SomeSyrupDecorator(
                new IceDecorator(
                    new Cola(
                        12.0, 
                        "Добрый кола"), 
                    0.5, 
                    "Лед"), 
                2, 
                "Вишневый сироп");
            
            Console.WriteLine("Кола со льдом и с вишневым сиропом: " + someSyrup2.GetDescription() + " -> " + someSyrup2.GetPrice() + "$");
        }
    }
}