using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTwo
{
    internal class ExerciseOneSeven
    {
        public ExerciseOneSeven()
        {
            ExOneSevenDesc();
            Console.Write("Enter a boolean: ");
            string boolean = Console.ReadLine().ToLower().Trim();
            if(boolean == "true" || boolean == "t")
            {
                Console.WriteLine("You entered: True");
                opp(false);
            }
            else if(boolean == "false" || boolean == "f")
            {
                Console.WriteLine("You entered: False");
                opp(true);
            }
            else
            {
                Console.WriteLine("Not a bool");
            }

            static void opp(bool opp)
            {
                Console.WriteLine($"The opposite of what you entered is : {opp}");
            }

            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
        }

        private static void ExOneSevenDesc()
        {
            Discription.DiscriptionCall("Prompt the user to enter a boolean. Write out the boolean value, and then write out the opposite of the boolean variable.");
        }
    }
}


