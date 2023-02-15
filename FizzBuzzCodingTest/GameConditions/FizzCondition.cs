using FizzBuzzCodingTest.GameConditions.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzCodingTest.GameConditions
{
    public class FizzCondition : IGameCondition
    {
        private const string _display = "Fizz";

        public bool IsValid(int number) => number % 3 == 0;

        public string Display() => _display;
    }
}
