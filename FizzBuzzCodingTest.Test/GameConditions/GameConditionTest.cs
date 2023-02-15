using FizzBuzzCodingTest.GameConditions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
