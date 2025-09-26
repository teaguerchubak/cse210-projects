using System;

class Program
{
    static void Main(string[] args)
    {
        int[] dataArray = new int[] { 10, 20, 30 };
        int[] dataReference = dataArray;

        dataReference[2] = 90;

        Console.WriteLine(dataArray[2]);
        Console.WriteLine(dataReference[2]);
    }
}