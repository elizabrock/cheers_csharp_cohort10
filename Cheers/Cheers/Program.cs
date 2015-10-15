using System;
using System.Collections.Generic;
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
            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();
            //Get the user's name and print it.
            //Cheer the user on.
            //For example, if name is "Bob", output should be:

            //Give me a...  b
            //Give me an... o
            //Give me a...  b
            //BOB is.. GRAND!
        }
    }
}
