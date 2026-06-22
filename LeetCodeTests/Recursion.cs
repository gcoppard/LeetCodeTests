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
        
        static Dictionary<int, int> memo = new Dictionary<int, int>();
        public static int Fib(int n)
        {
            // dynamic programming example
            if (n <= 1)
                return n;

            if (memo.ContainsKey(n))
                return memo[n];

            memo[n] = Fib(n - 1) + Fib(n - 2);
            return memo[n];
        }

        public string reverseString(string s)
        {
            if (s.Length == 0)
                return s;
            return s.Last() + reverseString(s.Substring(0, s.Length - 1));
        }

        public static string reverseString2(string s)
        {
            if (s.Length == 0)
                return s;
           
            return s[s.Length- 1] + reverseString2(s.Substring(0,s.Length-1));
        }

        public static void Permute(string remaining, string current)
        {
            // Base case: no characters left
            if (remaining.Length == 0)
            {
                Console.WriteLine(current);
                return;
            }

            // Choose each character in turn
            for (int i = 0; i < remaining.Length; i++)
            {
                char chosen = remaining[i];
                string rest = remaining.Substring(0, i) +
                              remaining.Substring(i + 1);

                Permute(rest, current + chosen);
            }
        }

    }
}
