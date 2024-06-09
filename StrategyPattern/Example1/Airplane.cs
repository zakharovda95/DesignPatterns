using System;
using StrategyPattern.Example1.Interfaces;

namespace StrategyPattern.Example1
{
    public class Airplane : Aircraft
    {
        public Airplane(string someProperty, IFlyStrategy flyStrategy) : base(someProperty)
        {
            SetFlyStrategy(flyStrategy); // для примера установим стратегию в конструкторе
        }

        public void AirplaneMethod()
        {
            Console.WriteLine("Метод самолета");
        }
        
        // какие то другие действия
    }
}