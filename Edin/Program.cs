using System;

class Program
{
    public static int[] FindUniqueNumbers(int[] nums)
    {
        int[] unique = new int[nums.Length];
        int[] counts = new int[nums.Length];
        int index = 0;
        foreach (int num in nums)
        {
            bool found = false;
            for (int i = 0; i < index; i++)
            {
                if (unique[i] == num)
                {
                    counts[i]++;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                unique[index] = num;
                counts[index] = 1;
                index++;
            }
        }
        int[] result = new int[2];
        int resultIndex = 0;
        for (int i = 0; i < index; i++)
        {
            if (counts[i] == 1)
            {
                result[resultIndex] = unique[i];
                resultIndex++;
            }
        }
        return result;
    }

    static void Main(string[] args)
    {
        int[] nums = { 1, 2, 1, 3, 2, 5 };
        int[] result = FindUniqueNumbers(nums);
        Console.WriteLine($"Результат: {result[0]} и {result[1]}");
    }
}
