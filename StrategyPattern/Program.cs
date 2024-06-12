using System;
using StrategyPattern.Example1;
using StrategyPattern.Example1.Strategies;
using StrategyPattern.Example2;
using StrategyPattern.Example2.Strategies;

namespace StrategyPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Пример 1
            var reactiveFlyStrategy = new ReactiveEngineFlyStrategy();
            var airplane = new Airplane("Какое то свойство", reactiveFlyStrategy);
            airplane.TakeOff();

            var archimedesForceFlyStrategy = new ArchimedesForceFlyStrategy();
            var aerostat = new Aerostat("123");
            aerostat.SetFlyStrategy(archimedesForceFlyStrategy);
            aerostat.TakeOff();

            var balloon = new Balloon("321");
            balloon.SetFlyStrategy(archimedesForceFlyStrategy);
            balloon.TakeOff();

            var airFlowsFlyStrategy = new AirFlowFlyStrategy();
            var glider = new Glider("312");
            glider.SetFlyStrategy(airFlowsFlyStrategy);
            glider.TakeOff();

            var paperAirplane = new PaperAirplane("123");
            paperAirplane.SetFlyStrategy(airFlowsFlyStrategy);
            paperAirplane.TakeOff();
            
            airplane.SetFlyStrategy(airFlowsFlyStrategy); // можем поменять стратегию во время выполнения
            airplane.TakeOff();
            
            Console.WriteLine("------------ Example 2 ------------");

            var mobHp = 50;
            var mobExp = 170;

            var pers = new Character();
            var swordStrategy = new SwordAttackStrategy();
            pers.SetAttackStrategy(swordStrategy);
            var damage = pers.Attack();
            if (mobHp <= damage)
            {
                pers.SetExp(mobExp);
            }

            var fbStrategy = new FireballAttackStrategy();
            pers.SetAttackStrategy(fbStrategy);
            pers.Attack();
        }
    }
}