using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        double average = CalculateAverage(numbers);
        Console.WriteLine($"Average: {average}");
    }

    static double CalculateAverage(int[] nums)
    {
        if (nums == null || nums.Length == 0)
        {
            throw new ArgumentException("Massive should be with numbers.");
        }

        double sumTotal = 0;
        foreach (int num in nums)
        {
            sumTotal += num;
        }
        return sumTotal / nums.Length;
    }
}