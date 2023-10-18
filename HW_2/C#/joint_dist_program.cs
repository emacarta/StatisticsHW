using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Define the data for the columns
        int[] ages = { 22, 22, 22, 23, 23, 21, 23, 23, 24, 24, 23, 21, 25, 22, 22, 22, 25, 21, 21, 21, 23, 22, 21, 23, 24, 25, 23, 22, 22, 27, 23, 24, 22, 25, 39, 26, 23, 22, 22, 22, 23, 27, 23, 25, 22, 22, 22, 22, 21, 23, 23, 26, 27, 23, 23, 23, 27 };
        int[] hardWork = { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 4, 5, 5, 5, 4, 5, 5, 5, 5, 5, 4, 4, 4, 5, 4, 4, 2, 4, 4, 5, 4, 4, 4, 4, 3, 4, 4, 5, 4, 5, 4, 5, 4, 4, 4, 4, 4, 5, 4, 3, 4, 4, 4, 5, 3 };

        // Create a dictionary for the joint distribution
        Dictionary<(int, int), int> jointDistribution = new Dictionary<(int, int), int>();

        // Calculate the joint distribution
        for (int i = 0; i < ages.Length; i++)
        {
            int age = ages[i];
            int work = hardWork[i];
            var key = (age, work);

            if (jointDistribution.ContainsKey(key))
            {
                jointDistribution[key]++;
            }
            else
            {
                jointDistribution[key] = 1;
            }
        }

        // Print the joint distribution
        Console.WriteLine("Joint Distribution:");
        foreach (var entry in jointDistribution)
        {
            Console.WriteLine($"Age: {entry.Key.Item1}, Hard Work: {entry.Key.Item2}, Frequency: {entry.Value}");
        }
    }
}
