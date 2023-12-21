using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    internal interface UserInput
    {
        public int AskForVaule(string param)
        ;

        public int CheckValue(string param, string value);
    }
}
