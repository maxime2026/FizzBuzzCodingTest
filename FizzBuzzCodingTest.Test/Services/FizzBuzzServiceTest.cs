using FizzBuzzCodingTest.Services;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzzCodingTest.Test.Services
{
    public class FizzBuzzServiceTest
    {
        private readonly FizzBuzzService _fizzBuzzService;

        public FizzBuzzServiceTest()
        {
            _fizzBuzzService = new FizzBuzzService();
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
        public void Should_return_fizzBuzzResult_success()
        {
            int range = 15;

            var result = _fizzBuzzService.GetResult(range);

            Assert.NotNull(result);
            Assert.True(result.SuccessFull);
            Assert.Equal(range, result.Result.Count);
            Assert.Equal("1", result.Result[0]);
            Assert.Equal("2", result.Result[1]);
            Assert.Equal("Fizz", result.Result[3]);
            Assert.Equal("4", result.Result[4]);
            Assert.Equal("Buzz", result.Result[5]);
            Assert.Equal("7", result.Result[6]);
            Assert.Equal("8", result.Result[7]);
            Assert.Equal("Fizz", result.Result[8]);
            Assert.Equal("Buzz", result.Result[9]);
            Assert.Equal("11", result.Result[10]);
            Assert.Equal("Fizz", result.Result[11]);
            Assert.Equal("13", result.Result[12]);
            Assert.Equal("14", result.Result[13]);
            Assert.Equal("FizzBuzz", result.Result[14]);
        }
    }
}
