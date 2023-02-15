using FizzBuzzCodingTest.Models;

namespace FizzBuzzCodingTest.Services.Interfaces
{
    public interface IFizzBuzzService
    {
        List<FizzBuzzResult> GetResult(int range);
    }
}