using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        while (true)
        {

            Console.Write(@"Enter a number or enter '0 to quit: ");
            string input = Console.ReadLine();
            int value = int.Parse(input);
            if (value == 0)
                break;


            else
                numbers.Add(value);
            Console.WriteLine("Numbers you entered: ");
            foreach (int n in numbers)
            {
                Console.WriteLine(n);
            }
            int sum = numbers.Sum();
            numbers.Count();
            double average = (double)sum / numbers.Count();
            {
                Console.WriteLine($"Sum: {sum}");
                Console.WriteLine($"Average: {average}");
            }
            if (numbers.Count > 0)
            {
                int largest = numbers.Max();
                Console.WriteLine($"The largest number is: {largest}");
            }

        }


    }
}