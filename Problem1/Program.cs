namespace Sum
{
    class Program


    {
        static void Main(string[] args)

        {
            int[] nums = { 2, 7, 11, 15 };
            int target = 9;
            int[] result = twoSum(nums, target);
            Console.WriteLine(result[0] + ", " + result[1]);
        }

        static int[] twoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                        return new int[] { i, j };
                }
            }
            return new int[] { 0, 1 };
        }

    }
}


