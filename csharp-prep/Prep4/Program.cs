using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        int total = 0;
        
        Console.Write("Enter number: ");
        int num = int.Parse(Console.ReadLine());

        while (num != 0)
        {
            numbers.Add(num);
            total += num;
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
        }

        int largest = -100;
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        int len = numbers.Count;
        float average = ((float)total) / len;

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");

    }
}