using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork.Console
{
    public interface IUserInput
    {
        int AskForValue(string param);
    }

    internal class UserInput : IUserInput
    {
        public int AskForValue(string param)
        {
            System.Console.WriteLine($"Enter the value of {param}:");
            var value = System.Console.ReadLine();

            return CheckValue(param, value);
        }

        public int CheckValue(string param, string value)
        {
            if (!int.TryParse(value, out var val))
            {
                System.Console.WriteLine("Input string is invalid. It must be a number.");
                return AskForValue(param);
            }

            return val;
        }
    }
}
