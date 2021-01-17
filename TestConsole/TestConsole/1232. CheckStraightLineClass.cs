using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole
{
    public class CheckStraightLineClass
    {
        public bool CheckStraightLine(int[][] coordinates)
        {
            if (coordinates.Length <= 2)
            {
                return true;
            }
            for (int i = 1; i < coordinates.Length - 1; i++)
            {
                if ((coordinates[i + 1][1] - coordinates[i][1]) * (coordinates[i][0] - coordinates[i - 1][0]) != (coordinates[i + 1][0] - coordinates[i][0]) * (coordinates[i][1] - coordinates[i - 1][1]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
