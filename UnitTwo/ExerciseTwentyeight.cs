﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTwo
{
    internal class ExerciseTwentyeight
    {

        public ExerciseTwentyeight()
        {
            Desc();
            do
            {
                Console.Write("Enter some text: ");
                string str = Console.ReadLine().Trim();

                var charsToRemove = new string[] { "a", "e", "i", "o", "u" };
                foreach(var c in charsToRemove)
                {
                    str = str.Replace(c, string.Empty);
                }

                Console.WriteLine(str);
            } while(Tools.IsYes());
        }
        private static void Desc()
        {
            Discription.DiscriptionCall("Prompt the user to enter text.  Remove all the vowels and output the text.");
        }
    }
}