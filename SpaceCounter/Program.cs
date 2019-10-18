using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string userSentence;
            string IDCode;
            bool idValid;
            

            Console.WriteLine(" Hello! Please enter your IDcode");
            IDCode = Console.ReadLine();
            idValid = CheckIDLength(IDCode);
            if (idValid)
            {
                Console.WriteLine("IDnr is OK");
            }
            else
            {
                Console.WriteLine("IDnr is NOT");
            }
            GetGender(IDCode);
            CalculateAgeFromIDCode(IDCode);
            /*
            Console.WriteLine("Enter your sentence");
            userSentence = Console.ReadLine();
            //CountSpaces(userSentence);
            */

        }
        /*public static void CountSpaces(string sentence)
        {
            int counter = 0;
            foreach (char symbol in sentence)
            {  
                 if (symbol == ' ') {
                    counter++;
                }
            }
            Console.WriteLine($"The sentence contains {counter} of spaces");
            Console.ReadLine();
        }*/

        public static void CalculateAgeFromIDCode(string IDnr)
        {
            string yearOfBirth;
            yearOfBirth = IDnr.ToString().Substring(1, 2);
            
            DateTime birthDay = new DateTime();

            Console.WriteLine($"Your year of birth is {yearOfBirth}");
            Console.ReadLine();




        }
           public static void GetGender ( string idNumber)
        {
            string gender;
            string firstNumber = idNumber[0].ToString();
            if (firstNumber == "3" || firstNumber == "5")
            {
                gender = "male";
                Console.WriteLine("Hello, Sir!");
            }
            else 
            {
                gender = "female";
                Console.WriteLine("Hello, Madam!");
            }
            //Console.ReadLine();
        }
        public static bool  CheckIDLength (string ID)
        {
            bool isValid;
            if (ID.Length == 11) {
                isValid = true;
            } else
            {
                isValid = false;
            }
            return isValid;
        }
    } 
}
