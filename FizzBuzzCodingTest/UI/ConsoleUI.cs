using FizzBuzzCodingTest.Models;
using FizzBuzzCodingTest.Services.Interfaces;
using FizzBuzzCodingTest.UI.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzCodingTest.UI
{
    public class ConsoleUI : IConsoleUI
    {
        private readonly ILogger _logger;
        private readonly IFizzBuzzService _fizzBuzzService;

        public ConsoleUI(IFizzBuzzService fizzBuzzService, ILogger<ConsoleUI> logger)
        {
            _logger = logger;
            _fizzBuzzService = fizzBuzzService;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void Run(string[] args)
        {
            int range;
            if (args == null || args.Count() == 0 || int.TryParse(args[0], out range) == false)
            {
                _logger.LogError("Value missing");
                throw new ArgumentNullException("Value missing");
            }

            try
            {
                FizzBuzzResult fizzBuzzResult = _fizzBuzzService.GetResult(range);

                if (fizzBuzzResult.SuccessFull)
                {
                    Console.WriteLine(string.Join(",", fizzBuzzResult.Result));                    
                }
                else
                {
                    Console.WriteLine(fizzBuzzResult.Error_message);
                }
            }
            catch (Exception ex)
            {
                _logger.LogCritical("Internal application error", ex);
                throw;
            }
        }
    }
}
