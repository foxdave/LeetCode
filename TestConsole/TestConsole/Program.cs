using System;
using System.Collections.Generic;
using TestConsole.StockSeries;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] prices = new int[] { 3, 2, 6, 5, 0, 3 };
            int k = 2;
            int result = new MaxProfitClass().MaxProfit4(k, prices);
            #region old
            //ListNode head = new ListNode(2);
            //ListNode node1 = new ListNode(1);
            //ListNode node2 = new ListNode(3);
            //head.next = node1;
            //node1.next = node2;

            //int x = 2;
            //ListNode result = new PartitionClass().Partition(head, x);
            //int[] result = new MaxSlidingWindowClass().MaxSlidingWindow(new int[] { -7, -8, 7, 5, 7, 1, 6, 0 }, 4);
            //bool result = new CanPlaceFlowersClass().CanPlaceFlowers(new int[] { 1, 0, 0, 0, 0, 1 }, 2);
            //bool result = new IsIsomorphicClass().IsIsomorphic("ab", "aa");
            //char[][] rec = new char[4][];
            //rec[0] = new char[] { '1', '0', '1', '0', '0' };
            //rec[1] = new char[] { '1', '0', '1', '1', '1' };
            //rec[2] = new char[] { '1', '1', '1', '1', '1' };
            //rec[3] = new char[] { '1', '0', '0', '1', '0' };
            //int maxArea = new MaxRectangle().MaximalRectangle(rec);
            //string result = new RemoveKdigits().DoWork("10", 1);
            //int result = new TaskDispatcher().LeastInterval(new char[] { 'A', 'A', 'A', 'B', 'B', 'B' }, 2);
            //bool result = new DuplicatedElements().ContainsDuplicate(new int[] { 1, 2, 3, 1 });
            //int[][] matrix = new int[][]
            //    {
            //        new int[] { 5, 1, 9, 11 },
            //        new int[] { 2, 4, 8, 10 },
            //        new int[] { 13, 3, 6, 7 },
            //        new int[] { 15, 14, 12, 16 }
            //    };
            //new RotateImage().Rotate(matrix);
            #endregion
        }
    }
}
