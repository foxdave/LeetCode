using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole
{
    public class ReverseKGroupClass
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            int[] tempList = new int[k];
            ListNode currentNode = head;
            ListNode newHead = new ListNode(-1);
            ListNode newCurrentNode = newHead;
            while (true)
            {
                for (int i = 0; i < k; i++)
                {
                    tempList[i] = currentNode.val;
                    currentNode = currentNode.next;
                    if (currentNode == null && i < k - 1)
                    {
                        if (newHead.val == -1)
                        {
                            newCurrentNode.val = tempList[0];
                        }
                        else
                        {
                            newCurrentNode.next = new ListNode(tempList[0]);
                            newCurrentNode = newCurrentNode.next;
                        }
                        for (int j = 1; j <= i; j++)
                        {
                            newCurrentNode.next = new ListNode(tempList[j]);
                            newCurrentNode = newCurrentNode.next;
                        }
                        return newHead;
                    }
                }
                if (newHead.val == -1)
                {
                    newCurrentNode.val = tempList[k - 1];
                }
                else
                {
                    newCurrentNode.next = new ListNode(tempList[k - 1]);
                    newCurrentNode = newCurrentNode.next;
                }
                for (int i = k - 2; i >= 0; i--)
                {
                    newCurrentNode.next = new ListNode(tempList[i]);
                    newCurrentNode = newCurrentNode.next;
                }
                head = currentNode;
                if (head == null)
                {
                    break;
                }
            }
            return newHead;
        }

        public ListNode ReverseKGroupRecursion(ListNode head, int k)
        {
            ListNode[] tempList = new ListNode[k];
            ListNode asNode = head;
            for (int i = 0; i < k; i++)
            {
                if (head == null)
                {
                    return asNode;
                }
                tempList[i] = head;
                head = head.next;
            }
            for (int j = 1; j < k; j++)
            {
                tempList[j].next = tempList[j - 1];
            }
            tempList[0].next = ReverseKGroupRecursion(head, k);
            return tempList[k - 1];
        }
    }
}
