using StrategyPattern.Example2;
using StrategyPattern.Strategies;

namespace StrategyPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var pers = new Character(); // один персонаж, может атаковать разным оружием
            
            var swordStrategy = new SwordAttackStrategy();
            pers.SetAttackStrategy(swordStrategy); // взяли меч
            pers.Attack();
            
            var fbStrategy = new FireballAttackStrategy(); // взяли фаербол
            pers.SetAttackStrategy(fbStrategy);
            pers.Attack();
        }
    }
}