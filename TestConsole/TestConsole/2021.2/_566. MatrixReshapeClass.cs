using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole
{
    public class MatrixReshapeClass
    {
        public int[][] MatrixReshape(int[][] nums, int r, int c)
        {
            int oriRow = nums.Length;
            int oriColumn = nums[0].Length;
            if (oriRow * oriColumn != r * c)
            {
                return nums;
            }

            //Fill data to a array
            int[] data = new int[r * c];
            for (int i = 0; i < oriRow; i++)
            {
                int[] rowNum = nums[i];
                for (int j = 0; j < oriColumn; j++)
                {
                    data[i * oriColumn + j] = rowNum[j];
                }
            }

            int[][] result = new int[r][];

            for (int i = 0; i < r; i++)
            {
                int[] resRow = new int[c];
                for (int j = 0; j < c; j++)
                {
                    resRow[j] = data[i * c + j];
                }
                result[i] = resRow;
            }
            return result;
        }
    }
}
