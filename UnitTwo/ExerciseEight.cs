using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTwo
{
    internal class ExerciseEight
    {
        public ExerciseEight()
        {
            string response;
            ExEightDesc();
            Console.WriteLine("2 : Add 1 to the number and output it back to the console.");
            Console.WriteLine("\n3 : Add .5 to the number and output it back to the console.");
            Console.WriteLine("\n4 : Add them together and output the sum back to the console.");
            Console.WriteLine("\n5 : Multiply them and output the product back to the console.");
            Console.Write("\nPlease choose an exercise to Loop: ");
            response = Console.ReadLine();


            switch(response)
            {
                case "2":                   
                    do
                    {
                        _ = new ExerciseTwo();
                        response = Loop();
                    } while(response == "y" || response == "yes");
                    break;
                case "3":
                    do
                    {
                        _ = new ExerciseThree();
                        response = Loop();
                    } while(response == "y" || response == "yes");
                    break;
                case "4":
                    do
                    {
                        _ = new ExerciseFour();
                        response = Loop();
                    } while(response == "y" || response == "yes");
                    break;
                case "5":
                    do
                    {
                        _ = new ExerciseFive();
                        response = Loop();
                    } while(response == "y" || response == "yes"); ;
                    break;
                default:
                    _ = new ExerciseEight();
                    break; 
            }
        }

        private static string Loop()
        {
            Console.Write("Would you like to continue (y/n)? ");
            return Console.ReadLine().ToLower().Trim();
        }

        private static void ExEightDesc()
        {
            Discription.DiscriptionCall("Make exercises 2-5 run in a Loop. Use a do-while Loop to run the code in a Loop.\n" +
                "Each time you run the code ask the user whether they would like to continue.");
        }
    }
}
