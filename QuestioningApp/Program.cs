using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestioningApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string firstLetter;
            string restOfName; 


            Console.WriteLine("Hi! What's your name?");
            name = Console.ReadLine();
            firstLetter = name[0].ToString().ToUpper();
            restOfName = name.Substring(1).ToLower();
            name = firstLetter + restOfName;
            Console.WriteLine($"Hello {name}! What's your gender- if male, then type:male, if woman, type: female");
            string userAnswer = Console.ReadLine().ToLower();
            UserTreater(userAnswer, name);
        }
        public static void UserTreater(string input, string userName)
        {
            int birthYear;
            int age;
            string comingOrLeaving;
            


            if (input == "male")
            {
                
              
                Console.WriteLine($" Hello Mr {userName}");

            }
            else if (input == "female")
            {
                Console.WriteLine($" Hello Mrs/Ms {userName}");
            }
            else {
                Console.WriteLine("Something  is wrong, please check your input!");
        }

        Console.WriteLine("What's your year of birth?");
            birthYear = int.Parse(Console.ReadLine());
            age = 2019 - birthYear;
        Console.WriteLine($"You are {age} years old. Are you coming or leaving-if coming, then write coming, if leaving, write leaving?");
           comingOrLeaving = Console.ReadLine().ToLower();
            if ( comingOrLeaving == "coming") {
                Console.WriteLine("Welcome to the web page!");
            }
            else if (comingOrLeaving == "leaving") {
                Console.WriteLine("Thanks for using the web page!Goodbye!");
            }
            else {
                Console.WriteLine("Something is wrong, check your input!");
            }
            Console.ReadLine();
           
           
    }

    }
}

