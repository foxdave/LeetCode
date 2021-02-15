using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole
{
    public class SwimInWaterClass
    {
        public int SwimInWater(int[][] grid)
        {
            int[][] directions = { new int[] { 0, 1 }, new int[] { 0, -1 }, new int[] { 1, 0 }, new int[] { -1, 0 } };
            int n = grid.Length;
            //初始化并查集，将所有格子平铺按序排列
            int[] coll = new int[n * n];
            for (int i = 0; i < n * n; i++)
            {
                coll[i] = -1;
            }
            //注意提示2，整个点集是0到N*N-1的排列，用heights存储每个高度的格子坐标
            int[][] heights = new int[n * n][];
            for (int i = 0; i < n * n; i++)
            {
                heights[i] = new int[2];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    heights[grid[i][j]][0] = i;
                    heights[grid[i][j]][1] = j;
                }
            }
            //权重
            int[] rank = new int[n * n];
            for (int waterLevel = 0; waterLevel < n * n; waterLevel++)
            {
                //当前高度的格子位置
                int x = heights[waterLevel][0];
                int y = heights[waterLevel][1];
                //当前高度的相邻格子是否可以连接
                foreach (var direction in directions)
                {
                    int newX = heights[waterLevel][0] + direction[0];
                    int newY = heights[waterLevel][1] + direction[1];
                    if (newX >= 0 && newX < n && newY >= 0 && newY < n && grid[newX][newY] <= waterLevel)
                    {
                        Union(coll, x * n + y, newX * n + newY, rank);
                    }
                }
                if (FindRoot(coll, 0) == FindRoot(coll, n * n - 1))
                {
                    return waterLevel;
                }
            }
            return -1;
        }

        /// <summary>
        /// 查找格子的根位置
        /// </summary>
        /// <param name="coll"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        private int FindRoot(int[] coll, int x)
        {
            int root = x;
            while (coll[root] != -1)
            {
                root = coll[root];
            }
            return root;
        }

        /// <summary>
        /// 将两个格子连接
        /// </summary>
        /// <param name="coll"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void Union(int[] coll, int x, int y, int[] rank)
        {
            int rootX = FindRoot(coll, x);
            int rootY = FindRoot(coll, y);
            if (rank[rootX] > rank[rootY])
            {
                coll[rootY] = rootX;
            }
            else if (rank[rootX] < rank[rootY])
            {
                coll[rootX] = rootY;
            }
            else
            {
                rank[rootY]++;
                coll[rootX] = rootY;
            }
        }
    }
}
