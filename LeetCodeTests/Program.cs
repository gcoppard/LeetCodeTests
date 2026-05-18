using System.Reflection.Metadata.Ecma335;

namespace LeetCodeTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sample = new int[] { 2, 1, 3, 7, 11, 15};
            int target = 4;

            int[] x = TwoSums(sample, target);

            

            foreach (var item in x)
            {
                Console.Write(item);
            }
            
            //Console.WriteLine(IsGood(sample));

        }

     

        public static bool IsGood(int[] nums)
        {
            int n = nums.Max();

            // base[n] should have length n + 1
            if (nums.Length != n + 1)
                return false;

            Array.Sort(nums);

            // Check 1 through n-1
            for (int i = 0; i < n - 1; i++)
            {
                if (nums[i] != i + 1)
                    return false;
            }

            // Last two numbers must both be n
            return nums[n - 1] == n && nums[n] == n;
        }

        public static int[] TwoSums(int[] nums, int target)
        {
            List<int> result = nums.ToList<int>();
            int[] newResults = result.Where( x => x <= target ).ToArray();

            Array.Sort(newResults);

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j && nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
                
            }
            return nums;
        }

    }
    }

