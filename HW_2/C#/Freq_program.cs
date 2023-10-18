using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Data definition
        List<object> ages = new List<object>
        {
            22, 22, 22, 23, 23, 21, 23, 23, 24, 24, 23, 21, 25, 22, 22, 22, 25, 21, 21, 21, "23+", 22, 21, 23, 24, 25, 23, 22, 22, 27, 23, 24, 22, 25, 39, 26, 23, 22, 22, 22, 23, 27, 23, 25, 22, 22, 22, 22, 21, 23, 23, 26, 27, 23, 23, 23, 27
        };

        List<int> hardWork = new List<int>
        {
            5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 4, 5, 5, 5, 4, 5, 5, 5, 5, 5, 4, 4, 4, 5, 4, 4, 2, 4, 4, 5, 4, 4, 4, 4, 3, 4, 4, 5, 4, 5, 4, 5, 4, 4, 4, 4, 4, 5, 4, 3, 4, 4, 4, 5, 3
        };

        List<string> mainInterests = new List<string>
        {
            "Cybersecurity", "Cybersecurity", "Vulnerability Research", "Cybersecurity", "Cybersecurity", "Cybersecurity", "Cybersecurity", "Cybersecurity", "Cybersecurity", "Cybersecurity", "Cybersecurity", "Cybersecurity", "Malware Analysis", "Cybersecurity", "Cybersecurity", "Cybersecurity (blue team)", "Cybersecurity", "Cybersecurity", "Cybersecurity", "Privacy", "Cybercrime and Forensics", "Cybersecurity, OS development", "Cybersecurity", "Cybersecurity, Networks", "Cybersecurity, Networks", "Cybersecurity", "Computer Science", "Cybersecurity, AI", "Cybersecurity", "Cybersecurity, IT, international studies", "Cybersecurity", "Cybersecurity, AI, Network", "IT", "Management Of Information Security, Data privacy", "Cybersecurity, AI", "climbing", "Cybersecurity", "Cybersecurity, Software testing", "Cybersecurity, Network", "Cybersecurity", "Cybersecurity", "Cybersecurity, Privacy", "Cybersecurity", "Computer science, Cybserscurity, Exploits, Vulnerabilities", "Cybersecurity", "Cybersecurity", "Cybersecurity, AI", "Cybersecurity, operating systems", "Cybersecurity", "Cybersecurity, OS", "Computer science, physics, philosophy", "Cybersecurity, Networks", "Cybersecurity, Entrepreneurship, Network", "Cybersecurity"
        };

        // Calculate frequencies
        var ageFrequency = ages
            .GroupBy(x => x)
            .Select(g => new
            {
                Value = g.Key,
                Count = g.Count()
            })
            .OrderBy(item => item.Value);

        var hardWorkFrequency = hardWork
            .GroupBy(x => x)
            .Select(g => new
            {
                Value = g.Key,
                Count = g.Count()
            })
            .OrderBy(item => item.Value);

        var mainInterestsFrequency = mainInterests
            .GroupBy(x => x)
            .Select(g => new
            {
                Value = g.Key,
                Count = g.Count()
            })
            .OrderBy(item => item.Value);

        // Calculate relative percentage frequencies
        int totalAges = ages.Count;
        int totalHardWork = hardWork.Count;
        int totalMainInterests = mainInterests.Count;

        Console.WriteLine("Age Frequencies:");
        foreach (var item in ageFrequency)
        {
            double relativeFrequency = (double)item.Count / totalAges * 100;
            Console.WriteLine($"Value: {item.Value}, Absolute Frequency: {item.Count}, Relative Frequency: {relativeFrequency:F2}%");
        }

        Console.WriteLine("\nHard Work Frequencies:");
        foreach (var item in hardWorkFrequency)
        {
            double relativeFrequency = (double)item.Count / totalHardWork * 100;
            Console.WriteLine($"Value: {item.Value}, Absolute Frequency: {item.Count}, Relative Frequency: {relativeFrequency:F2}%");
        }

        Console.WriteLine("\nMain Interests Frequencies:");
        foreach (var item in mainInterestsFrequency)
        {
            double relativeFrequency = (double)item.Count / totalMainInterests * 100;
            Console.WriteLine($"Value: {item.Value}, Absolute Frequency: {item.Count}, Relative Frequency: {relativeFrequency:F2}%");
        }
    }
}
