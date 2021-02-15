using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole
{
    public class RotateImage
    {
        public void Rotate(int[][] matrix)
        {
            int startIndex = 0;
            int endIndex = matrix.Length - 1;
            int oriEndIndex = endIndex;
            while (true)
            {
                for (int i = startIndex; i < endIndex; i++)
                {
                    int tempVal1 = matrix[startIndex][i];
                    int tempVal2 = matrix[i][endIndex];
                    matrix[startIndex][i] = matrix[oriEndIndex - i][startIndex];

                    matrix[i][endIndex] = tempVal1;
                    tempVal1 = matrix[endIndex][oriEndIndex - i];

                    matrix[endIndex][oriEndIndex - i] = tempVal2;
                    matrix[oriEndIndex - i][startIndex] = tempVal1;
                }
                startIndex += 1;
                endIndex -= 1;
                if (endIndex <= startIndex)
                {
                    break;
                }
            }
        }
    }
}
