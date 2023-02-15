using FizzBuzzCodingTest.GameConditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzzCodingTest.Test.GameConditions
{
    public class GameConditionTest
    {
        private readonly FizzCondition _fizzCondition;
        private readonly BuzzCondition _buzzCondition;
        private readonly FizzBuzzCondition _fizzBuzzCondition;

        public GameConditionTest()
        {
            _fizzCondition = new FizzCondition();
            _buzzCondition = new BuzzCondition();
            _fizzBuzzCondition = new FizzBuzzCondition();
        }

        [Theory]
        [InlineData(4)]
        [InlineData(7)]
        public void Should_return_fizzCondition_false_is_not_valid(int number)
        {
            var result = _fizzCondition.IsValid(number);

            Assert.False(result);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        public void Should_return_fizzCondition_true_is_valid(int number)
        {
            var result = _fizzCondition.IsValid(number);

            Assert.True(result);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(7)]
        public void Should_return_buzzCondition_false_is_not_valid(int number)
        {
            var result = _buzzCondition.IsValid(number);

            Assert.False(result);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        public void Should_return_buzzCondition_true_is_valid(int number)
        {
            var result = _buzzCondition.IsValid(number);

            Assert.True(result);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(5)]
        public void Should_return_fizzbuzzCondition_false_is_not_valid(int number)
        {
            var result = _fizzBuzzCondition.IsValid(number);

            Assert.False(result);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        public void Should_return_fizzbuzzCondition_true_is_valid(int number)
        {
            var result = _fizzBuzzCondition.IsValid(number);

            Assert.True(result);
        }
    }
}
