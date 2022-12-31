using System;

namespace mis221_lab3_lacyrich
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = GetDayOfWeek();
            BirthdayDecision(day);
        }
        static string GetDayOfWeek()
        {
            Console.WriteLine("Enter the day of the week:");
            string userInput = Console.ReadLine();
            return userInput;
        }

        static void BirthdayDecision(string day)
        {
            if(day == "Monday")
            {
                SayHappyBirthday("Joseph");
            } 
            else if (day == "Thursday")
            {
                SayHappyBirthday("Katie");
            }
            else{
                Console.WriteLine("There are no birthdays today :(");
            }
        }

        static void SayHappyBirthday(string name)
        {Console.WriteLine("Happy Birthday, " + name + "!");
        }
    }
}
