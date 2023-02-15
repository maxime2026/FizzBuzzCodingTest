using FizzBuzzCodingTest.GameConditions.Interfaces;

namespace FizzBuzzCodingTest.GameConditions
{
    public class FizzBuzzCondition : IGameCondition
    {
        private const string _display = "FizzBuzz";

        public bool IsValid(int number) => number % 3 == 0 && number % 5 == 0;

        public string Display() => _display;
    }
}
