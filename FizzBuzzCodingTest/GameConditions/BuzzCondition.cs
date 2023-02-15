using FizzBuzzCodingTest.GameConditions.Interfaces;

namespace FizzBuzzCodingTest.GameConditions
{
    public class BuzzCondition : IGameCondition
    {
        private const string _display = "Buzz";

        public bool IsValid(int number) => number % 5 == 0;

        public string Display() => _display;
    }
}
