using System;
using StrategyPattern.Example2.Interfaces;

namespace StrategyPattern.Example2.Strategies
{
    internal sealed class FireballAttackStrategy : IAttackStrategy
    {
        public int Attack()
        {
            Console.WriteLine("Атакуем огненным шаром");
            return 350;
        }
    }
}