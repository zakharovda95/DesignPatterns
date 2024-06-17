using ObserverPattern.Observers;

namespace ObserverPattern
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var publisher = new NewspaperMagazinePublisher();

            var needNewspapper = new WhoNeedNewspapper(publisher); // зарегистрировались автоматически
            var needMagazine = new WhoNeedMagazine(publisher);
            needMagazine.Subscribe(); // использовали метод для регистрации
            
            publisher.NewIssue(2); // Получили второй выпуск журнала
            
            publisher.NewIssue(5); // пятый
        }
    }
}