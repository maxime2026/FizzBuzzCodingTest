using FizzBuzzCodingTest.UI;
using Microsoft.Extensions.Logging;
using Moq;

namespace FizzBuzzCodingTest.Test.UI
{
    public class ConsoleUITests
    {
        private readonly ConsoleUI _consoleUI;
        private readonly Mock<ILogger<ConsoleUI>> _mocklogger;

        public ConsoleUITests()
        {
            _mocklogger = new Mock<ILogger<ConsoleUI>>();

            _consoleUI = new ConsoleUI(_mocklogger.Object);
        }
    }
}
