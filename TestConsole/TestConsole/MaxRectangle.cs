using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestConsole
{
    public class MaxRectangle
    {
        public int MaximalRectangle(char[][] matrix)
        {
            int row = matrix.Length;
            int column = matrix[0].Length;
            if (row == 0 && column == 0)
            {
                return 0;
            }
            int max = 0;
            int[] rectangle = new int[column];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    rectangle[j] = matrix[i][j] == '1' ? rectangle[j] += 1 : 0;
                }
                max = Math.Max(max, LargestRectangleArea(rectangle));
            }
            return max;
        }

        private int LargestRectangleArea(int[] heights)
        {
            if (heights.Length == 0)
            {
                return 0;
            }
            if (heights.Length == 1)
            {
                return heights[0];
            }
            else
            {
                int maxHeight = heights.Max();
                if (maxHeight == 0)
                {
                    return 0;
                }
                IEnumerable<int> diffHeights = heights.Distinct();
                int largestArea = 0;
                foreach (int height in diffHeights)
                {
                    int count = 0;
                    for (int index = 0; index < heights.Length; index++)
                    {
                        if (heights[index] < height)
                        {
                            count = 0;
                        }
                        else
                        {
                            count++;
                            largestArea = (largestArea > height * count) ? largestArea : height * count;
                        }
                    }
                }
                return largestArea;
            }
        }
    }
}
