using System;
using StrategyPattern.Example2.Interfaces;

namespace StrategyPattern.Example2
{
    internal sealed class Character
    {
        internal byte Lvl { get; private set; } = 1;
        internal int HP { get; private set; } = 150;
        internal int Mana { get; private set; } = 75;
        internal int CurrentExp { get; private set; } = 0;
        internal int NeedExpToUpLevel { get; private set; } = 100;

        private IAttackStrategy _attackStrategy;

        internal Character() { }

        internal void SetAttackStrategy(IAttackStrategy attackStrategy)
        {
            _attackStrategy = attackStrategy;
        }

        internal int Attack()
        {
            return _attackStrategy.Attack();
        }

        internal void SetExp(int exp)
        {
            Console.WriteLine("Устанавливаем опыт");
            var expSum = CurrentExp + exp;
            if (expSum >= NeedExpToUpLevel)
                _upLevel(expSum - NeedExpToUpLevel);
            else CurrentExp += exp;
        }

        private void _upLevel(int residualExp)
        {
            Console.WriteLine("Увеличиваем уровень");
            Lvl += 1;
            HP += 10;
            Mana += 10;
            CurrentExp = residualExp;
            NeedExpToUpLevel *= 2;
        }
    }
}