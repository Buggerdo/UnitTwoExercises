using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTwo
{
    internal class ExerciseSeven
    {
        public ExerciseSeven()
        {
            string response;
            ExSevenDesc();
            do
            {
                Console.Clear();
                _ = new ExerciseOne();
                Console.Write("Would you like to continue (y/n)? ");
                response = Console.ReadLine().ToLower().Trim();
            } while(response == "y" || response == "yes");
        }

        private static void ExSevenDesc()
        {
            Discription.DiscriptionCall("Use a do-while Loop to run exercise 1 in a Loop." +
                "\nEach time you run the code ask the user whether they would like to continue.");
        }

    }
}
