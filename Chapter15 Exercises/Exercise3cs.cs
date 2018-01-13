using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15_Exercises
{
    class Exercise3cs
    {
        public static void Run(string[] args)
        {
            string[] words = { "Nog", "Cat", "Mouse", "Chill", "Netflix", "Mirror", "Black", "Carrot", "Apple", "Zlastic" };
            int minLength;

            Console.WriteLine("Words: ");
            foreach(string word in words)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("\n-------------------------\n");
            Console.WriteLine("Enter minimum number of letters >> ");
            minLength = Convert.ToInt32(Console.ReadLine());

            var selection =
                from w in words
                where w.Length == minLength
                select w;

            Console.WriteLine("\n-------------------------\n");
            Console.WriteLine("Words with {0} letters:", minLength);

            if (!selection.Any())
            {
                Console.WriteLine("No words contain {0} letters.", minLength);
            }
            else
            {
                foreach (string word in selection)
                    Console.WriteLine(word);
            }
        }
    }
}
