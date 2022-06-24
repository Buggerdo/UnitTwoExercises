using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTwo
{
    internal class ExerciseFive
    {
        public ExerciseFive()
        {
            ExFiveDesc();
            Console.Write("Please enter the first number: ");
            float multOne = float.Parse(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            float multTwo = float.Parse(Console.ReadLine());
            Console.WriteLine($"The product is {multOne * multTwo}");
        }

        private static void ExFiveDesc()
        {
            Discription.DiscriptionCall("Prompt the user to enter a number.\nAfter the user enters the numbers, multiply them and output the product back to the console.");
        }
    }
}
