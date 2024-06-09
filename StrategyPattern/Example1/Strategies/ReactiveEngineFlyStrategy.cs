using System;
using StrategyPattern.Example1.Interfaces;

namespace StrategyPattern.Example1.Strategies
{
    internal sealed class ReactiveEngineFlyStrategy : IFlyStrategy
    {
        public void Fly()
        {
            Console.WriteLine("Полет на реактивной тяге");
        }
    }
}