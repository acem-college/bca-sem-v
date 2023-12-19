using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp
{
    public interface ICalculator
    {
        int Add(int x, int y);
        int Subtract(int x, int y);
    }
    public class Calculator : ICalculator
    {
        public int Add(int x, int y)
        {
            int sum = x + y;
            return sum;
        }
        public int Subtract(int x, int y)
        {
            int diff = x - y;
            return diff;
        }
    }
}
