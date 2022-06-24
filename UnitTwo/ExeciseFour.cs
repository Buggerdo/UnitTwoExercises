using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTwo
{
    internal class ExerciseFour
    {
        public ExerciseFour()
        {
            ExFourDesc();
            Console.Write("Please enter the first number: ");
            float numberOne = float.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            float numberTwo = float.Parse(Console.ReadLine());
            Console.WriteLine($"The sum is {numberOne + numberTwo}");
        }

        private static void ExFourDesc()
        {
            Discription.DiscriptionCall("Prompt the user to enter a number.\nAfter the user enters the numbers, add them together and output the sum back to the console.");
        }
    }
}
