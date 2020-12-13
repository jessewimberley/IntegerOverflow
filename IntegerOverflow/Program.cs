using System;

namespace IntegerOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = int.MaxValue;
            Console.WriteLine("Maximum value for a signed integer: " + i);
            Console.WriteLine("0" + Convert.ToString(i, 2));
            Console.ReadLine();
            Console.WriteLine();
            i += 1;
            Console.WriteLine("Maximum value +1: " + i);
            Console.WriteLine(Convert.ToString(i, 2));
            Console.ReadLine();
            Console.WriteLine();
            i += 1;
            Console.WriteLine("Max vaule + 2: " + i);
            Console.WriteLine(Convert.ToString(i, 2));
            Console.ReadLine();
        }

    }
}
