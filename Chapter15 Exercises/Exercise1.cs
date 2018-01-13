using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15_Exercises
{
    class Exercise1
    {
        public static void Run(string[] args)
        {
            int[] numbers = new int[10];
            int x = 0;

            while(x < 10)
            {
                Console.WriteLine("Enter a number >> ");
                numbers[x] = Convert.ToInt32(Console.ReadLine());
                x++;
            }

            Console.WriteLine("--------------------------\n");
            Console.WriteLine("Before sort:");
            foreach (int number in numbers)
                Console.WriteLine(number);

            //Sort integers in descending order
            var sorted =
                from n in numbers
                orderby n descending
                select n;

            Console.WriteLine("--------------------------\n");
            Console.WriteLine("After sort:");
            foreach (int number in sorted)
                Console.WriteLine(number);
        }
    }
}
