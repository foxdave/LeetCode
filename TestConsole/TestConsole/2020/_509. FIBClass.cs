using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole
{
    public class FIBClass
    {
        public int FIB(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }
            return FIB(n - 1) + FIB(n - 2);
        }
    }
}
