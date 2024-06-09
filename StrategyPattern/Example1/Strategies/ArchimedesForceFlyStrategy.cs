using System;
using StrategyPattern.Example1.Interfaces;

namespace StrategyPattern.Example1.Strategies
{
    internal sealed class ArchimedesForceFlyStrategy : IFlyStrategy
    {
        public void Fly()
        {
            Console.WriteLine("Полет, на принипе силы Архимеда");
        }
    }
}