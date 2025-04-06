using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class WorldsDumbestFunction
    {
        public string ReturnsSomethingIfZero(int num)
        {
            if (num == 0)
            {
                return "Something";
            }
            else
            {
                return "Nothing";
            }
        }
    }
}
