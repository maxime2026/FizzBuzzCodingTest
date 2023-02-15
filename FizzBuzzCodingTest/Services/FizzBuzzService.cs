using FizzBuzzCodingTest.GameConditions;
using FizzBuzzCodingTest.GameConditions.Interfaces;
using FizzBuzzCodingTest.Models;
using FizzBuzzCodingTest.Services.Interfaces;

namespace FizzBuzzCodingTest.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        private List<IGameCondition> _gameConditions;
        private const int _minRange = 1;

        public FizzBuzzService()
        {
            _gameConditions = new List<IGameCondition> 
            {
                new FizzBuzzCondition(),
                new FizzCondition(),
                new BuzzCondition()
            };
        }

        public FizzBuzzResult GetResult(int range)
        {
            if (range is <0 or >100)
            {
                return new FizzBuzzResult { SuccessFull = false, Error_message = "Invalid range" };
            }

            List<string> resultGameCondition = Enumerable.Range(_minRange, range)
                .Select(number => {
                    foreach (var condition in _gameConditions)
                    {
                        if (condition.IsValid(number))
                        {
                            return condition.Display();
                        }
                    }

                    return number.ToString();
                }).ToList();

            return new FizzBuzzResult { 
                Result = resultGameCondition,
                SuccessFull = true
            };
        }
    }
}
