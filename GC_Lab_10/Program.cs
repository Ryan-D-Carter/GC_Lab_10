using System;
using System.Collections.Generic;
using System.Linq;

namespace GC_Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            
            

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine($"\nThere are 10 movies in this list.");

            

            bool repeat = true;
            while (repeat)
            {
                Movie.PromptUser();

                //continue?
                bool conLoop = true;
                while (conLoop)
                {
                    Console.WriteLine("Continue? y/n");
                    string vCon = Console.ReadLine().ToLower();

                    switch (vCon)
                    {
                        case "y":
                            conLoop = false;
                            repeat = true;
                            break;
                        case "n":
                            Console.WriteLine("Goodbye!");
                            conLoop = false;
                            repeat = false;
                            break;
                        default:
                            Console.WriteLine("I didn't catch that");
                            conLoop = true;
                            break;
                    }
                }
            }
        }
    }
}

