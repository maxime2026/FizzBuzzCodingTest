using FizzBuzzCodingTest.GameConditions.Interfaces;

namespace FizzBuzzCodingTest.GameConditions
{
    public class FizzCondition : IGameCondition
    {
        private const string _display = "Fizz";

        public bool IsValid(int number) => number % 3 == 0;

        public string Display() => _display;
    }
}
