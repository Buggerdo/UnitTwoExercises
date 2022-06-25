using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTwo
{
    internal class Discription
    {
        public static void DiscriptionCall(string discription)
        {
            Console.Clear();
            Console.WriteLine(discription);
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
            Console.Clear(); //
        }
    }
}
