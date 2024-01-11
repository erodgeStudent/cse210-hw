using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        string addMore = "yes";
        List<int> numbers = new List<int>();
        List<int> sorted = new List<int>();
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        do
        {
            Console.Write("Enter number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input == 0)
            {
                addMore = "no";
            }
            else{
               numbers.Add(input); 
            }
        } while (addMore == "yes");

        int sum = numbers.Sum();
        double avg = numbers.Average();
        int mx = numbers.Max();
        int smallPositive = numbers.Where(num => num > 0).Min();
        numbers.Sort();
        Console.WriteLine($"Your list includes {numbers.Count} numbers.");
        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {mx}");
        Console.WriteLine($"The smallest positive number is: {smallPositive}");
        Console.WriteLine($"The sorted list is: ");
        foreach (int n in numbers) 
        {
            Console.WriteLine(n);
        }
        
    }
}