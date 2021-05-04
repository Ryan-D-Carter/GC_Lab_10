using System;
using System.Collections.Generic;
using System.Linq;

namespace GC_Lab_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //movies
            Movie Aladdin = new Movie("Aladdin", "animated", "1");
            Movie Brave = new Movie("Brave", "animated", "1");
            Movie lionKing = new Movie("The Lion King", "animated", "1");
            Movie findingNemo = new Movie("Finding Nemo", "animated", "1");
            Movie godfather = new Movie("The Godfather", "drama", "2");
            Movie citizenKane = new Movie("Citizen Kane", "drama", "2");
            Movie halloween = new Movie("Halloween", "horror", "3");
            Movie alien = new Movie("Alien", "horror", "3");
            Movie warWorlds = new Movie("War of the Worlds", "scifi", "4");
            Movie bladeRunner = new Movie("Blade Runner", "scifi", "4");
            var movies = new List<Movie>() { Aladdin, Brave, godfather, citizenKane, halloween, alien, warWorlds, bladeRunner, lionKing, findingNemo };
            movies.Sort((x, y) => x.Title.CompareTo(y.Title));

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine($"\nThere are 10 movies in this list.");

            bool repeat = true;
            while (repeat)
            {
                Console.WriteLine("What category are you interest in? (1 - Animated, 2 - Drama, 3 - Horror, 4 - Scifi)");
                var input = Console.ReadLine().ToLower();


                switch (input)
                {
                    case "animated":
                    case "drama":
                    case "horror":
                    case "scifi":
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                        foreach (var movie in movies)
                        {
                            if (movie.Category == input || movie.Index == input)
                                Console.WriteLine(movie.Title);
                        }
                        break;

                    default:
                        Console.WriteLine("That is not a valid category");
                        break;
                }

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

