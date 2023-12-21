using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    internal class Demo : Calculator, UserInput
    {

        public int AskForVaule(string param)
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
                return AskForVaule(param);
            }

            return val;
        }
        public int add(int x, int y)
        {
            return x + y;
        }
        public int sub(int x, int y)
        {
            return x - y;
        }
    }

}


