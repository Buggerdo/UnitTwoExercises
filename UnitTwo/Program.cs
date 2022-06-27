﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTwo
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Please choose an exercise");
            Console.WriteLine("Exercises 1 - 88");
            Console.WriteLine("Exercises 1-6 and 1-7");
            string choice = Console.ReadLine().Trim();
            Console.Clear();
            switch(choice)
            {
                case "1":
                    _ = new ExerciseOne();
                    break;
                case "2":
                    _ = new ExerciseTwo();
                    break;
                case "3":
                    _ = new ExerciseThree();
                    break;
                case "4":
                    _ = new ExerciseFour();
                    break;
                case "5":
                    _ = new ExerciseFive();
                    break;
                case "6":
                    _ = new ExerciseSix();
                    break;
                case "1-6":
                    _ = new ExerciseOneSix();
                    break;
                case "7":
                    _ = new ExerciseSeven();
                    break;
                case "1-7":
                    _ = new ExerciseOneSeven();
                    break;
                case "8":
                    _ = new ExerciseEight();
                    break;
                case "9":
                    _ = new ExerciseNine();
                    break;
                case "10":
                    _ = new ExerciseTen();
                    break;
                case "11":
                    _ = new ExerciseEleven();
                    break;
                case "12":
                    _ = new ExerciseTwelve();
                    break;
                case "13":
                    _ = new ExerciseThirteen();
                    break;
                case "14":
                    _ = new ExerciseFourteen();
                    break;
                case "15":
                    _ = new ExerciseFifteen();
                    break;
                case "16":
                    _ = new ExerciseSixteen();
                    break;
                case "17":
                    _ = new ExerciseSeventeen();
                    break;
                case "18":
                    _ = new ExerciseEightteen();
                    break;
                case "19":
                    _ = new ExerciseNineteen();
                    break;
                case "20":
                    _ = new ExerciseTwenty();
                    break;
                case "21":
                    _ = new ExerciseTwentyone();
                    break;
                case "22":
                    _ = new ExerciseTwentytwo();
                    break;
                case "23":
                    _ = new ExerciseTwentythree();
                    break;
                case "24":
                    _ = new ExerciseTwentyfour();
                    break;
                case "25":
                    _ = new ExerciseTwentyfive();
                    break;
                case "26":
                    _ = new ExerciseTwentysix();
                    break;
                case "27":
                    _ = new ExerciseTwentyseven();
                    break;
                case "28":
                    _ = new ExerciseTwentyeight();
                    break;
                case "29":
                    _ = new ExerciseTwentynine();
                    break;
                default:
                    break;
            }
            Console.WriteLine("Good Bye!");
        }
    }
}









