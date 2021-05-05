using System;
using System.Collections.Generic;
using System.Text;

namespace GC_Lab_10
{
    class Movie
    {
        //fields
        private string title;
        private string category;
        private string index;

        //properties
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                category = value;
            }
        }

        public string Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
        //constructors
        public Movie()
        {

        }

        public Movie(string _title, string _category, string _index)
        {
            title = _title;
            category = _category;
            index = _index;
        }

        //methods

        public static void PromptUser()
        {

            Movie aladdin = new Movie("Aladdin", "animated", "1");
            Movie brave = new Movie("Brave", "animated", "1");
            Movie lionKing = new Movie("The Lion King", "animated", "1");
            Movie findingNemo = new Movie("Finding Nemo", "animated", "1");
            Movie godfather = new Movie("The Godfather", "drama", "2");
            Movie citizenKane = new Movie("Citizen Kane", "drama", "2");
            Movie halloween = new Movie("Halloween", "horror", "3");
            Movie alien = new Movie("Alien", "horror", "3");
            Movie warWorlds = new Movie("War of the Worlds", "scifi", "4");
            Movie bladeRunner = new Movie("Blade Runner", "scifi", "4");
            var movies = new List<Movie>() { aladdin, brave, godfather, citizenKane, halloween, alien, warWorlds, bladeRunner, lionKing, findingNemo };
            movies.Sort((x, y) => x.Title.CompareTo(y.Title));

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
        }

    }
}
