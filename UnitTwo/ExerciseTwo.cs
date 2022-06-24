using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTwo
{
    internal class ExerciseTwo
    {
        public ExerciseTwo()
        {
            ExTwoDesc();
            int x;
            do
            {
                Console.Clear();
                Console.Write("Please enter a number: ");
            } while(!int.TryParse(Console.ReadLine(), out x));
            Console.WriteLine(++x);
        }

        private static void ExTwoDesc()
        {
            Discription.DiscriptionCall("Prompt the user to enter a number.\nAfter the user enters a number, add 1 to the number and output it back to the console.");
        }
    }
}
