using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole
{
    public class MakeConnectedClass
    {
        public int MakeConnected(int n, int[][] connections)
        {
            if (connections.Length < n - 1)
            {
                return -1;
            }
            //初始化节点
            int[] parent = new int[n];
            for (int i = 0; i < n; i++)
            {
                parent[i] = -1;
            }
            int[] rank = new int[n];
            for (int i = 0; i < n; i++)
            {
                rank[i] = 0;
            }
            int partCount = n;//初始每个点都当作独立的部分，连接成功-1
            foreach (var conn in connections)
            {
                if (Union(conn[0], conn[1], parent, rank) == 1)
                {
                    partCount--;
                }
            }
            return partCount - 1;
        }

        /// <summary>
        /// 并查集 查找根节点
        /// </summary>
        /// <param name="x"></param>
        /// <param name="parent"></param>
        /// <returns></returns>
        public int FindRoot(int x, int[] parent)
        {
            int root = x;
            while (parent[root] != -1)
            {
                root = parent[root];
            }
            return root;
        }

        /// <summary>
        /// 并查集 合并两个部分
        /// 返回0合并失败，返回1合并成功
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="parent"></param>
        public int Union(int x, int y, int[] parent, int[] rank)
        {
            int rootX = FindRoot(x, parent);
            int rootY = FindRoot(y, parent);
            if (rootX == rootY)
            {
                return 0;
            }
            else
            {
                if (rank[rootX] > rank[rootY])
                {
                    parent[rootY] = rootX;
                }
                else if (rank[rootX] < rank[rootY])
                {
                    parent[rootX] = rootY;
                }
                else
                {
                    rank[rootY]++;
                    parent[rootX] = rootY;
                }
                return 1;
            }
        }
    }
}
