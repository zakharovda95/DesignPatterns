using System;
using StrategyPattern.Interfaces;

namespace StrategyPattern.Strategies
{
    internal sealed class FireballAttackStrategy : IAttackStrategy
    {
        public void Attack()
        {
            // Логика атаки огненным шаром
            Console.WriteLine("Атакуем огненным шаром");
        }
    }
}