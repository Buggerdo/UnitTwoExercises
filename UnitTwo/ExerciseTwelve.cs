using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTwo
{
    internal class ExerciseTwelve
    {
        public ExerciseTwelve()
        {
            ExTwelveDesc();
            do
            {
                Console.Clear();
                for(int i = 9; i >= 0; i--)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("\nPress any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write("Would you like to continue (y/n)? ");

            } while(Console.ReadLine().ToLower().Trim() == "y");
        }

        private static void ExTwelveDesc()
        {
            Discription.DiscriptionCall("Output all the numbers from 9 to 0. Use a for loop to output all the numbers from 9 to 0.");
        }
    }
}
