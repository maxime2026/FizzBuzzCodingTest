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

        public ConsoleUI(ILogger<ConsoleUI> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void Run(string[] args)
        {
            throw new NotImplementedException();
        }
    }
}
