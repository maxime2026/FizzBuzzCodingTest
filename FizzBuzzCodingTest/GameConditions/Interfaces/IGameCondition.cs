using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzCodingTest.GameConditions.Interfaces
{
    public interface IGameCondition
    {
        string Display();
        bool IsValid(int number);
    }
}
