using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTwo
{
    internal class ExerciseThree
    {
        public ExerciseThree()
        {

            ExThreeDesc();
            float x;
            do
            {
                Console.Clear();
                Console.Write("Please enter a number: ");
            } while(!float.TryParse(Console.ReadLine(), out x));
            Console.WriteLine(x + 0.5);
        }

        private static void ExThreeDesc()
        {
            Discription.DiscriptionCall("Prompt the user to enter a number.\nAfter the user enters a number, add .5 to the number and output it back to the console.");
        }
    }
}
