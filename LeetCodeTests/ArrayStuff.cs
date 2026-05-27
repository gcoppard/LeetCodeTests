using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests
{
    internal class ArrayStuff
    {
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
