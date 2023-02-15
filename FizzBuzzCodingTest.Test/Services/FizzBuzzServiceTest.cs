using FizzBuzzCodingTest.Services;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzCodingTest.Test.Services
{
    public class FizzBuzzServiceTest
    {
        private readonly FizzBuzzService _fizzBuzzService;

        public FizzBuzzServiceTest()
        {
            _fizzBuzzService = new FizzBuzzService();
        }
    }
}
