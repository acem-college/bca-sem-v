using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopCalculator
{
    
        internal interface Calculator
        {
            public int add(int x, int y);
            public int sub(int x, int y)
           ;
        }
    public class Calc : Calculator
    {
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

