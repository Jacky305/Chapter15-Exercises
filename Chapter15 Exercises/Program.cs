using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise3cs.Run(args);
            return;

            //EXERCISE 4
            string[] words = { "Nog", "Cat", "Mouse", "Chill", "Netflix", "Mirror", "Black", "Carrot", "Apple", "Zlastic" };

            //Split words starting with A-M and N-Z
            var aToM =
                from w in words
                where w[0] <= 'M'
                select w;
            var nToZ =
                from w in words
                where w[0] > 'M'
                select w;

            Console.WriteLine("There are {0} words starting with A-M.", aToM.Count());
            Console.WriteLine("There are {0} words starting with N-Z.", nToZ.Count());
        }
    }
}
