using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeInterviews
{
    class KthToLast
    {

        public static int kthToLast(Node n, int k) {
            Console.WriteLine("\nReceived {0}",n);
            if (n==null)
            return 0;
            int index = kthToLast(n.Next,k)+1;
            if (index == k)
                Console.Write("kth element is {0}",n.Value);
            return index;
        }


        public static int visitNodes(Node n)
        {

            if (n == null)
                return 0;
            else
            {
                Console.WriteLine("\n Visiting {0}", n);
                return visitNodes(n.Next) + 1;
            }
        }

    }
}
