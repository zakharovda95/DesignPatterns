using StrategyPattern.Example2.Interfaces;

namespace StrategyPattern
{
    internal sealed class Character
    {
        private IAttackStrategy _attackStrategy; // может быть хоть 1000 разных способов атаки - мы не меняем класс Character

        internal void SetAttackStrategy(IAttackStrategy attackStrategy)
        {
            _attackStrategy = attackStrategy; // устанавливаем любую стратегию, реализующую этот интерфейс
        }

        internal void Attack()
        {
            _attackStrategy.Attack(); // нам все равно чем атаковать, просто атакуем
        }

        internal void SetExp(int exp)
        {
            // логика
        }

        private void _upLevel(int residualExp)
        {
            // логика
        }
    }
}