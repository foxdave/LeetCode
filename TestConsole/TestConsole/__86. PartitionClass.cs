using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole
{
    public class PartitionClass
    {
        public ListNode Partition(ListNode head, int x)
        {
            ListNode result = new ListNode(int.MinValue);
            ListNode oriPointer = head;
            ListNode newPointer = result;
            ListNode targetNode = null;
            ListNode preTargetNode = null;

            while (oriPointer != null)
            {
                ListNode newNode = new ListNode(oriPointer.val);

                if (targetNode != null && oriPointer.val < x)
                {
                    preTargetNode.next = newNode;
                    newNode.next = targetNode;
                    preTargetNode = newNode;
                }
                else
                {
                    newPointer.next = newNode;
                }

                if (targetNode == null && oriPointer.val >= x)
                {
                    targetNode = newPointer.next;
                    preTargetNode = newPointer;
                }
                if (newPointer.next != null)
                {
                    newPointer = newPointer.next;
                }
                oriPointer = oriPointer.next;
            }

            return result.next;
        }
    }
}
