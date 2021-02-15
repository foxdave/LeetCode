using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TestConsole
{
    public class CanPlaceFlowersClass
    {
        public bool CanPlaceFlowers(int[] flowerbed, int n)
        {
            int length = flowerbed.Length;
            for (int i = 0; i < length && n > 0;)
            {
                if (flowerbed[i] == 1)
                {
                    i += 2;
                }
                else if (i == length - 1 || flowerbed[i + 1] == 0)
                {
                    n--;
                    i += 2;
                }
                else
                {
                    i += 3;
                }
            }
            return n == 0;
        }
    }
}
