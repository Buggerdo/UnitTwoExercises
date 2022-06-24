using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTwo
{
    internal class Tools
    {
        public static int GetInt()
        {
            int x;
            do
            {
                Console.Clear();
                Console.Write("Please enter a number: ");
            } while(!int.TryParse(Console.ReadLine(), out x));
            return x;
        }

        public static float GetFloat()
        {
            float x;
            do
            {
                Console.Clear();
                Console.Write("Please enter a number: ");
            } while(!float.TryParse(Console.ReadLine(), out x));
            return x;
        }
    }
}
