using FizzBuzzCodingTest.Models;
using FizzBuzzCodingTest.Services.Interfaces;
using FizzBuzzCodingTest.UI;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

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

        [Theory]
        [InlineData(null)]
        [InlineData(new object[] { new string[] { } })]
        [InlineData(new object[] { new string[] { "not_a_number" } })]
        public void Should_raise_argumentNullException_if_args_invalid(string[] args)
        {
            var exception = Assert.Throws<ArgumentNullException>(() => _consoleUI.Run(args));

            Assert.Equal("Value cannot be null. (Parameter 'Value missing')", exception.Message);
        }

        [Theory]
        [InlineData(new object[] { new string[] { "20" } })]
        [InlineData(new object[] { new string[] { "0" } })]
        [InlineData(new object[] { new string[] { "100" } })]
        public void Should_not_raise_argumentNullException_if_args_valid(string[] args)
        {
            var exception = Record.Exception(() => _consoleUI.Run(args));

            Assert.Null(exception);
        }
    }
}
