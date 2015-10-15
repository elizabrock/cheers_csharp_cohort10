using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello there! What's your name?");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Hi, " + name);
            foreach (char letter in name.ToLower())
            {
                if (Char.IsLetter(letter))
                {
                    string mnemonic = "halfnorsemix";
                    string article = "a";
                    if (mnemonic.Contains(letter))
                    {
                        article = "an";
                    }
                    System.Console.WriteLine("Give me " + article + "..." + letter);
                }
            }
            System.Console.WriteLine(name.ToUpper() + " is.. GRAND!");
            BirthdayCheer(name);
            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();
        }

        private static void BirthdayCheer(string name)
        {
            System.Console.WriteLine("Hey, " + name + ", what's your birthday? (MM/DD)");
            DateTime thisYearsBirthday = GetBirthdayFromUser();
            DateTime nextYearsBirthday = thisYearsBirthday.AddYears(1);
            string daysUntilBirthday = nextYearsBirthday.Subtract(DateTime.Today).TotalDays.ToString();
            System.Console.WriteLine("Awesome! Your birthday is in " + daysUntilBirthday + " days! Happy Birthday in advance!");
        }

        private static DateTime GetBirthdayFromUser()
        {
            try
            {
                string birthday = System.Console.ReadLine();
                return DateTime.ParseExact(birthday, "MM/dd", CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                Console.WriteLine("That wasn't a valid birthday. Try again!");
                return GetBirthdayFromUser();
            }
        }
    }
}
