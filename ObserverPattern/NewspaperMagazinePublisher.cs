using System.Collections.Generic;
using ObserverPattern.Interfaces;

namespace ObserverPattern
{
    internal sealed class NewspaperMagazinePublisher : IObservable
    {
        private List<IObserver> _observers;
        
        internal string Magazine { get; private set; }
        internal string Newspaper { get; private set; }

        internal NewspaperMagazinePublisher()
        {
            _observers = new List<IObserver>();
            
            // условная инициализация начальными данными
            Magazine = "Журнал: Выпуск 1";
            Newspaper = "Газета: Выпуск 1";
        }
        
        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                // просто отправляем эмит без каких либо данных
                // нужные данные из Субьекта (этого класса) выбираются в конкретном наблюдателе
                
                // в данной реализации уведомляются все подписчики, независимо от того на что подписан (на газету или журнал)
                // для отслеживания обновлений по определенным данным (только газета/только журнал)
                // необходимо реализовать паттерн "Подписка публикация" - более сложный паттерн (см соответсвующий проект)
                observer.Update();
            }
        }

        public void NewIssue(byte issueNumber)
        {
            Magazine = $"Журнал: Выпуск {issueNumber}";
            Newspaper = $"Газета: Выпуск {issueNumber}";
            
            // при каждом новом выпуске уведомляем подписчиков
            NotifyObservers();
        }
    }
}