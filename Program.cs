using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 3, 5, 7, 9 };
        int max = FindMaxValue(numbers);
        Console.WriteLine($"Max: {max}");
    }

    static int FindMaxValue(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            throw new ArgumentException("Should be full.");
        }

        int max = nums[0];
        foreach (int num in nums)
        {
            if (num > max)
            {
                max = num;
            }
        }
        return max;
    }
}