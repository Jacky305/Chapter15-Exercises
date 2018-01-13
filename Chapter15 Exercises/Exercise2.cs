using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15_Exercises
{
    class Exercise2
    {
        public static void Run(string[] args)
        {
            int[] numbers = new int[8];
            int x = 0;

            while (x < 8)
            {
                Console.WriteLine("Enter a number >> ");
                numbers[x] = Convert.ToInt32(Console.ReadLine());
                x++;
            }

            Console.WriteLine("--------------------------\n");
            Console.WriteLine("Before group:");
            foreach (int number in numbers)
                Console.Write(" "+number);

            //Group by even/odd
            var grouped =
                from n in numbers
                where n % 2 == 0
                select n;

            Console.WriteLine("\n");
            Console.WriteLine("Even:");
            foreach (int number in grouped)
                Console.Write(" " + number);

            var oddGroup =
                from n in numbers
                where n % 2 != 0
                select n;

            Console.WriteLine("\n");
            Console.WriteLine("Odd:");
            foreach (int number in oddGroup)
                Console.Write(" " + number);
            Console.WriteLine("\n");
        }
    }
}
