using StrategyPattern.Example1;
using StrategyPattern.Example1.Strategies;

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

        }
    }
}