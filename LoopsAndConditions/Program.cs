// if else statements

//int ageOfDog;

//do
//{
//    Console.Clear();
//    Console.Write("How old is your dog? Enter a whole number: ");
//} while(!int.TryParse(Console.ReadLine(), out ageOfDog) || ageOfDog < 0 || ageOfDog > 20);

//if(ageOfDog <= 1)
//{
//    Console.WriteLine("You have a puppy");
//}
//else if(ageOfDog <= 3)
//{
//    Console.WriteLine("You have a young dog");
//}
//else if(ageOfDog <= 7)
//{
//    Console.WriteLine("You have a middle aged dog");
//}
//else
//{
//    Console.WriteLine("You have and old dog");
//}

//switch statement

//int ageOfDog;
//do
//{
//    Console.Clear();
//    Console.Write("How old is your dog? Enter a whole number: ");
//} while(!int.TryParse(Console.ReadLine(), out ageOfDog) || ageOfDog < 0 || ageOfDog > 20);

//switch(ageOfDog)
//{
//    case 0:
//        Console.WriteLine("Your dog is 0 years old");
//        break;
//    case 1:
//        Console.WriteLine("Your dog is 1 years old");
//        break;
//    case 2:
//        Console.WriteLine("Your dog is 2 years old");
//        break;
//    case 3:
//        Console.WriteLine("Your dog is 3 years old");
//        break;
//    case 4:
//        Console.WriteLine("Your dog is 4 years old");
//        break;
//    default:
//        Console.WriteLine("You have an old dog");
//        break;
//}

//ternary statement

//Console.Write("Do you live in Michigan? Y/N ");
//string input = Console.ReadLine().ToLower().Trim();
//Console.WriteLine(input == "y" || input == "yes" ? "Go blue!" : "Go Hawkeyes!");

//**********LOOPS*********
//while loop

//int mpg = 26;
//int gallonsInTank = 16;
//int distanceTraveled = 0;

//Console.WriteLine($"You have {gallonsInTank} gallons left and have traveled {distanceTraveled} miles");

//while(gallonsInTank > 0)
//{
//    gallonsInTank--;
//    distanceTraveled += mpg;
//}

//Console.WriteLine($"You have {gallonsInTank} gallons left and have traveled {distanceTraveled} miles");

// do while

int channelsWatched = 0;
int boredomLevel = 5;
do
{
    channelsWatched++;
    Console.WriteLine(channelsWatched);
    boredomLevel--;
} while(boredomLevel > 0);

