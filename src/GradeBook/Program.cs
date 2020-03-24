using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello, World!");
            }

            WorkWithArrays();
        }

        static void WorkWithArrays()
        {
            var numbers = new[] { 1.5, 2, 3, 4, 5 };
            var sum = 0.0;

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine(sum);
        }
    }
}
