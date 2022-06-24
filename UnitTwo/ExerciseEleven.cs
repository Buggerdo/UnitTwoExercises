using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTwo
{
    internal class ExerciseEleven
    {
        public ExerciseEleven()
        {
            ExElevenDesc();
            do
            {
                Console.Clear();
                for(int i = 0; i < 10; i++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write("Would you like to continue (y/n)? ");

            } while(Console.ReadLine().ToLower().Trim() == "y");
        }

        private static void ExElevenDesc()
        {
            Discription.DiscriptionCall("Use a for loop to output all the numbers from 0 to 9.");
        }
    }
}
