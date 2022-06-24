using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTwo
{
    internal class ExerciseSix
    {
        public ExerciseSix()
        {
            string response;
            ExSixDesc();
            do
            {
                Console.Clear();
                Console.WriteLine("Hello, World!");
                Console.Write("Would you like to continue (y/n)? ");
                response = Console.ReadLine().ToLower().Trim();
            } while(response == "y" || response == "yes");
        }

        private static void ExSixDesc()
        {
            Discription.DiscriptionCall("Use a do-while Loop to output \"Hello, World!\" in a Loop.\nEach time you output" +
                " \"Hello, World!\" ask the user whether they would like to continue.");
        }
    }
}
