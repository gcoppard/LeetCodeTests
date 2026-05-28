using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests
{
    internal class ArrayStuff
    {

        public static int solution(int[] nums)
        {
            
            //nums.OrderBy(x=> x).ToList().ForEach(x => Console.WriteLine(x));

            var dict = new Dictionary<int, int>();

            foreach (var i in nums)
            {
                if (dict.ContainsKey(i))
                    dict[i]++;
                else
                    dict[i] = 1;
    
            }



            foreach(var item in dict.Keys)
            {
                Console.WriteLine(dict[item]);
            }

            return 180;
        }

        public static int MinDeletions(string s)
        {
            if (char.IsDigit (s[0]))
                Console.WriteLine("First character is a digit.");


            int[] freq = new int[26];
           foreach (char c in s)
               freq[c - 'a']++;
  
           var frequencies = freq.Where(f => f > 0).OrderByDescending(f => f).ToList();
  
           var used = new HashSet<int>();
           int deletions = 0;
  
           foreach (int f in frequencies)
           {
               int current = f;
               while (current > 0 && used.Contains(current))
               {
                   current--;
                   deletions++;
               }
               if (current > 0)
                   used.Add(current);
           }

           return deletions;
     }

        public static int deleteUniqueStrings(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            
            foreach (var item in s)
            {
                if (dict.ContainsKey(item))
                    dict[item]++;
                else
                    dict.Add(item, 1);
            }

            HashSet<int> set = new HashSet<int>();
            foreach (var c in dict.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{c.Key} : {c.Value}");
                set.Add(c.Value - 1);
            }

            return 1;

        }

        public void Rotate(int[] nums, int k)
        {

            int [] temp = new int[nums.Length];

            int startingPoint = (nums.Length) - k;

            int ctr = 0;

            for (int i = startingPoint; i < nums.Length; i++)
            {
                temp[ctr] = nums[i];
                ctr++;
            }

            
            for (int i = 0; i < startingPoint; i++)
            {                
                temp[ctr] = nums[i];
                ctr++;
            }

      
            foreach (var item in temp)
            {
                Console.WriteLine(item);
            }
        }
    }
}
