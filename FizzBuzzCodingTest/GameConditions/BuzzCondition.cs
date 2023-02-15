using FizzBuzzCodingTest.GameConditions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzCodingTest.GameConditions
{
    public class BuzzCondition : IGameCondition
    {
        private const string _display = "Buzz";

        public bool IsValid(int number) => number % 5 == 0;

        public string Display() => _display;
    }
}
