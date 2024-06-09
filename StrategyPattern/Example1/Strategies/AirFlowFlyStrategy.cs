using System;
using StrategyPattern.Example1.Interfaces;

namespace StrategyPattern.Example1.Strategies
{
    internal sealed class AirFlowFlyStrategy : IFlyStrategy
    {
        public void Fly()
        {
            Console.WriteLine("Полет с помощью воздушных потоков");
        }
    }
}