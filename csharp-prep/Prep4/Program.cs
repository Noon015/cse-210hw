using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers;
        numbers = new List<int>();

        while (true)
        {
            Console.WriteLine("Add a number! Press 0 to end");
            string entry = Console.ReadLine();
            int entry_int = Convert.ToInt32(entry);
            if (entry_int == 0)
            {
                break;
            }
            numbers.Add(entry_int);
        }

        int total = 0;
        int biggest = 0;

        foreach (int number in numbers)
        {
            total = number + total;

            if (number > biggest)
            {
                biggest = number;
            }
        }

        int average = total / numbers.Count;


        Console.WriteLine($"Total: {total}\nAverage: {average}\nBiggest Number: {biggest}");
    }
}