using System.Collections.Generic;
using System.Linq;

namespace TestConsole
{
    public class LargestRectangle
    {
        public int LargestRectangleArea(int[] heights)
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