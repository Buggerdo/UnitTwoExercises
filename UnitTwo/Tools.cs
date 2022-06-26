﻿using System;
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
            Console.Clear();
            return x;
        }

        public static int GetInt(string disc)
        {
            int x;
            do
            {
                Console.Clear();
                Console.Write(disc);
            } while(!int.TryParse(Console.ReadLine(), out x));
            Console.Clear();
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

        public static float GetFloat(String disc)
        {
            float x;
            do
            {
                Console.Clear();
                Console.Write(disc);
            } while(!float.TryParse(Console.ReadLine(), out x));
            return x;
        }

        public static bool IsYes()
        {
            Console.WriteLine("\nPress any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.Write("Would you like to continue (y/n)? ");
            string awnser = Console.ReadLine().ToLower().Trim();
            if(awnser == "y" || awnser == "yes" || awnser == "yup")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
