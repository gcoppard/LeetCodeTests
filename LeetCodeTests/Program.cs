namespace LeetCodeTests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sample = new int[] { 2, 1, 3};
            Console.WriteLine(IsGood(sample));

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
    }
    }

