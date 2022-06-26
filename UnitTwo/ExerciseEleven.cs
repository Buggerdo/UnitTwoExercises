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
            } while(Tools.IsYes());
        }

        private static void ExElevenDesc()
        {
            Discription.DiscriptionCall("Use a for loop to output all the numbers from 0 to 9.");
        }
    }
}
