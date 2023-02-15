namespace FizzBuzzCodingTest.GameConditions.Interfaces
{
    public interface IGameCondition
    {
        string Display();
        bool IsValid(int number);
    }
}
