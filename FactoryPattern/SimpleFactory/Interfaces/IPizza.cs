namespace FactoryPattern.SimpleFactory.Interfaces
{
    public interface IPizza
    {
        string Name { get; set; }
        void Cook();
    }
}