using System;
using StrategyPattern.Interfaces;

namespace StrategyPattern.Strategies
{
    internal sealed class SwordAttackStrategy : IAttackStrategy
    {
        public void Attack()
        {
            // Логика атаки мечем
            Console.WriteLine("Атакуем мечем!");
        }
    }
}