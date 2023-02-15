using FizzBuzzCodingTest.Models;

namespace FizzBuzzCodingTest.Services.Interfaces
{
    public interface IFizzBuzzService
    {
        FizzBuzzResult GetResult(int range);
    }
}