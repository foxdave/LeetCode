using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TestConsole
{
    public class IsMonotonicClass
    {
        public bool IsMonotonic(int[] A)
        {
            if (A.Length == 0 || A.Length == 1)
            {
                return true;
            }
            int length = A.Length;
            if (A[0] > A[length - 1])
            {
                for (int i = 0; i < length - 1; i++)
                {
                    if (A[i] < A[i + 1])
                    {
                        return false;
                    }
                }
                return true;
            }
            if (A[0] < A[length - 1])
            {
                for (int i = 0; i < length - 1; i++)
                {
                    if (A[i] > A[i + 1])
                    {
                        return false;
                    }
                }
                return true;
            }
            return A.Distinct().Count() == 1;
        }
    }
}
