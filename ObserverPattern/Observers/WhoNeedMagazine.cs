using System;
using ObserverPattern.Interfaces;

namespace ObserverPattern.Observers
{
    internal sealed class WhoNeedMagazine : IObserver
    {
        private NewspaperMagazinePublisher _publisher;
        private string PrevIssue { get; set; } = "Нет данных";
        private string CurrIssue { get; set; }

        internal WhoNeedMagazine(NewspaperMagazinePublisher publisher)
        {
            _publisher = publisher;
        }
        
        public void Update()
        {
            if (!string.IsNullOrEmpty(CurrIssue))
                PrevIssue = CurrIssue;
            CurrIssue = _publisher.Magazine;
            
            Console.WriteLine("Пред. выпуск: " + PrevIssue);
            Console.WriteLine("Новый выпуск: " + CurrIssue);
        }

        public void Subscribe()
        {
            _publisher.RegisterObserver(this); // если нужен контроль за регистрацией выносим в отдельный метод
        }

        public void Unsubscribe()
        {
            _publisher.RemoveObserver(this);
        }
    }
}