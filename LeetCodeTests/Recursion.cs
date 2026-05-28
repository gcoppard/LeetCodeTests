using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests
{
    internal class Recursion
    {
        public static int findFactorialResult(int n)
        {
            if (n == 0)
                return 1;
            return findFactorialResult(n - 1) * n;
        }
        public static int fibonacci(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            return fibonacci(n - 1) + fibonacci(n - 2);
        }

        public string reverseString(string s)
        {
            if (s.Length == 0)
                return s;
            return s.Last() + reverseString(s.Substring(0, s.Length - 1));
        }
    }
}
