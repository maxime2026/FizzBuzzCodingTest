using FizzBuzzCodingTest.GameConditions;
using FizzBuzzCodingTest.GameConditions.Interfaces;
using FizzBuzzCodingTest.Models;
using FizzBuzzCodingTest.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace FizzBuzzCodingTest.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        private readonly ILogger _logger;
        private List<IGameCondition> _gameConditions;
        private const int _minRange = 1;

        public FizzBuzzService(List<IGameCondition> gameConditions, ILogger<FizzBuzzService> logger)
        {
            _logger = logger;
            _gameConditions = gameConditions;
            //_gameConditions = new List<IGameCondition> 
            //{
            //    new FizzBuzzCondition(),
            //    new FizzCondition(),
            //    new BuzzCondition()
            //};
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
