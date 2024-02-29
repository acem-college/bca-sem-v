using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemV.ConsoleApp
{
    public interface UserInput
    {
       
        public int AskForValue(string param)
        {
            Console.WriteLine($"Enter the value of {param}:");
            var value = Console.ReadLine();

            return CheckValue(param, value);
        }

        public int CheckValue(string param, string value)
        {
            if (!int.TryParse(value, out var val))
            {
                Console.WriteLine("Input string is invalid. It must be number.");
                return AskForValue(param);
            }

            return val;
        }
    }
}
