using FizzBuzzCodingTest.GameConditions.Interfaces;
using FizzBuzzCodingTest.Services;
using Microsoft.Extensions.Logging;
using Moq;
using Xunit;

namespace FizzBuzzCodingTest.Test.Services
{
    public class FizzBuzzServiceTest
    {
        private readonly FizzBuzzService _fizzBuzzService;
        private readonly List<IGameCondition> _fakeGameConditions;
        private readonly Mock<IGameCondition> _mockGameCondition;
        private readonly Mock<ILogger<FizzBuzzService>> _mocklogger;

        public FizzBuzzServiceTest()
        {
            _mocklogger = new Mock<ILogger<FizzBuzzService>>();
            _fakeGameConditions = new List<IGameCondition>();
            _mockGameCondition = new Mock<IGameCondition>();

            _fizzBuzzService = new FizzBuzzService(_fakeGameConditions, _mocklogger.Object);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(101)]
        public void Should_return_fizzBuzzResult_error_if_range_not_valid(int range)
        {
            var result = _fizzBuzzService.GetResult(range);

            Assert.NotNull(result);
            Assert.False(result.SuccessFull);
            Assert.Equal("Invalid range", result.Error_message);
        }

        [Fact]
        public void Should_return_onlynumber_if_no_rules()
        {
            int range = 5;

            var result = _fizzBuzzService.GetResult(range);

            Assert.NotNull(result);
            Assert.True(result.SuccessFull);
            Assert.Equal(range, result.Result.Count);
            Assert.Equal("1", result.Result[0]);
            Assert.Equal("2", result.Result[1]);
            Assert.Equal("3", result.Result[2]);
            Assert.Equal("4", result.Result[3]);
            Assert.Equal("5", result.Result[4]);
        }

        [Fact]
        public void Should_return_condition_display_if_rule_isvalue_is_true()
        {
            _mockGameCondition.Setup(u => u.IsValid(It.Is<int>(v => v == 3))).Returns(true);
            _mockGameCondition.Setup(u => u.Display()).Returns("yolo");
            _fakeGameConditions.Add(_mockGameCondition.Object);
            int range = 5;

            var result = _fizzBuzzService.GetResult(range);

            Assert.NotNull(result);
            Assert.True(result.SuccessFull);
            Assert.Equal(range, result.Result.Count);
            Assert.Equal("1", result.Result[0]);
            Assert.Equal("2", result.Result[1]);
            Assert.Equal("yolo", result.Result[2]);
            Assert.Equal("4", result.Result[3]);
            Assert.Equal("5", result.Result[4]);
        }

        [Fact]
        public void Should_return_onlynumber_if_rule_isvalue_is_false()
        {
            _mockGameCondition.Setup(u => u.IsValid(It.IsAny<int>())).Returns(false);
            _fakeGameConditions.Add(_mockGameCondition.Object);
            int range = 5;

            var result = _fizzBuzzService.GetResult(range);

            Assert.NotNull(result);
            Assert.True(result.SuccessFull);
            Assert.Equal(range, result.Result.Count);
            Assert.Equal("1", result.Result[0]);
            Assert.Equal("2", result.Result[1]);
            Assert.Equal("3", result.Result[2]);
            Assert.Equal("4", result.Result[3]);
            Assert.Equal("5", result.Result[4]);
        }

        /*[Fact]
        public void Should_return_fizzBuzzResult_success()
        {
            int range = 15;

            var result = _fizzBuzzService.GetResult(range);

            Assert.NotNull(result);
            Assert.True(result.SuccessFull);
            Assert.Equal(range, result.Result.Count);
            Assert.Equal("1", result.Result[0]);
            Assert.Equal("2", result.Result[1]);
            Assert.Equal("Fizz", result.Result[2]);
            Assert.Equal("4", result.Result[3]);
            Assert.Equal("Buzz", result.Result[4]);
            Assert.Equal("Fizz", result.Result[5]);
            Assert.Equal("7", result.Result[6]);
            Assert.Equal("8", result.Result[7]);
            Assert.Equal("Fizz", result.Result[8]);
            Assert.Equal("Buzz", result.Result[9]);
            Assert.Equal("11", result.Result[10]);
            Assert.Equal("Fizz", result.Result[11]);
            Assert.Equal("13", result.Result[12]);
            Assert.Equal("14", result.Result[13]);
            Assert.Equal("FizzBuzz", result.Result[14]);
        }*/
    }
}
