using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TestConsole
{
    public class TaskDispatcher
    {
        public int LeastInterval(char[] tasks, int n)
        {
            if (n == 0)
            {
                return tasks.Length;
            }
            int interval = 0;
            //int[canRunTime, remainCount]
            Dictionary<char, int[]> taskDispacher = new Dictionary<char, int[]>();
            foreach (char task in tasks)
            {
                if (!taskDispacher.ContainsKey(task))
                {
                    taskDispacher[task] = new int[] { 0, 1 };
                }
                else
                {
                    taskDispacher[task][1] += 1;
                }
            }
            int completeTaskCount = 0;
            while (true)
            {
                if (completeTaskCount == tasks.Length)
                {
                    break;
                }
                var targetTask = taskDispacher.Where(t => t.Value[0] <= interval && t.Value[1] > 0).OrderByDescending(t => t.Value[1]).FirstOrDefault();
                if (targetTask.Value != null)
                {
                    targetTask.Value[0] += n + 1;
                    targetTask.Value[1] -= 1;
                    completeTaskCount++;
                    Console.WriteLine("Run task " + targetTask.Key);
                }
                else
                {
                    Console.WriteLine("All tasks in cd, break...");
                }
                interval++;
            }
            return interval;
        }
    }
}