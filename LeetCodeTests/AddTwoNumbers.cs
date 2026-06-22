using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests
{
    public class ListTests 
    {
        LinkedList<int> lst1 = new LinkedList<int>();
        LinkedList<int> lst2 = new LinkedList<int>();


        public void CallIt()
        {
            ListNode l1 = new ListNode(2);
            l1.next = new ListNode(4);
            l1.next.next = new ListNode(3);

            ListNode l2 = new ListNode(5);
            l2.next = new ListNode(6);
            l2.next.next = new ListNode(4);

            var result = AddTwoNumbers(l1, l2);

            while (result != null)
            {
                Console.Write(result.val);

                if (result.next != null)
                    Console.Write(" -> ");

                result = result.next;
            }

            Console.WriteLine("Testing");
            
        }


        public class ListNode
        {
            public int val;
            public ListNode next;
             public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode tmp = l1;
            ListNode tmp2 = l2;

            StringBuilder sum1 = new StringBuilder();
            StringBuilder sum2 = new StringBuilder();

            // Build the numbers in correct order
            while (tmp != null)
            {
                sum1.Insert(0, tmp.val);
                tmp = tmp.next;
            }

            while (tmp2 != null)
            {
                sum2.Insert(0, tmp2.val);
                tmp2 = tmp2.next;
            }

            BigInteger total =
                BigInteger.Parse(sum1.ToString()) +
                BigInteger.Parse(sum2.ToString());

            // Convert total back into reversed linked list
            ListNode dummy = new ListNode(0);
            ListNode current = dummy;

            foreach (char c in total.ToString().Reverse())
            {
                current.next = new ListNode(c - '0');
                current = current.next;
            }

            return dummy.next;
        }
    }
}
