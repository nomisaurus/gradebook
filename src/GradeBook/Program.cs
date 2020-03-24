using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();

            //SayHello(args);

            //WorkWithLists();

            // WorkWithArrays();
        }

        private static void SayHello(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello, World!");
            }
        }

        static void WorkWithLists()
        {
            var grades = new List<double>() { 65, 83, 79, 71 };
            grades.Add(93);

            var averageGrade = 0.0;
            foreach (var grade in grades)
            {
                averageGrade += grade;
            }
            averageGrade /= grades.Count;
            
            Console.WriteLine($"The average grade is {averageGrade:N1}");
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
