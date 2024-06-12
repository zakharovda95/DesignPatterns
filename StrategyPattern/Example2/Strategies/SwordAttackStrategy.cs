using System;
using StrategyPattern.Example2.Interfaces;

namespace StrategyPattern.Example2.Strategies
{
    internal sealed class SwordAttackStrategy : IAttackStrategy
    {
        public int Attack()
        {
            Console.WriteLine("Атакуем мечем!");
            return 200;
        }
    }
}