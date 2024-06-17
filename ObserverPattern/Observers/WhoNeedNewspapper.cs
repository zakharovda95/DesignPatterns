using System;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Observers
{
    internal sealed class WhoNeedNewspapper : IObserver
    {
        private readonly NewspaperMagazinePublisher _publisher;
        
        private string PrevIssue { get;  set; }
        private string CurrIssue { get;  set; }
        
        internal WhoNeedNewspapper(NewspaperMagazinePublisher publisher)
        {
            _publisher = publisher;
            // при создании объекта - подписываемся (можно сделать метод для подписки если нужно по логике)
            _publisher.RegisterObserver(this);
        }
        
        public void Update()
        {
            if (!string.IsNullOrEmpty(CurrIssue))
                PrevIssue = CurrIssue;
            CurrIssue = _publisher.Newspaper; // при обновлении получили газету, журнал не нужен
            DisplayNewIssue(); // условный метод
        }

        private void DisplayNewIssue()
        {
            Console.WriteLine(CurrIssue);
        }

        public void Unsubscribe()
        {
            _publisher.RemoveObserver(this);
        }
    }
}