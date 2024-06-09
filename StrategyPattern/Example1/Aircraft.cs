using System;
using StrategyPattern.Example1.Interfaces;

namespace StrategyPattern.Example1
{
    public abstract class Aircraft
    {
        private IFlyStrategy _flyStrategy; // композиция - объект подключается, реализуя правильный интерфейс, гибкость и контроль;
        private readonly string _someProperty;

        internal Aircraft(string someProperty)
        {
            _someProperty = someProperty; // просто произвольное свойства для примера;
        }

        internal void SetFlyStrategy(IFlyStrategy flyStrategy)
        {
            _flyStrategy = flyStrategy; // сеттер для динамичного изменения стратегии (во время выполнения) - взаимозаменяемость
        }

        internal void TakeOff()
        {
            Console.WriteLine("Какая то возможно общая логика не относящаяся к конкретной реализации стратегии");
            _flyStrategy.Fly();
            Console.WriteLine("Еще какая то возможная общая доп логика");
        }
    }
}