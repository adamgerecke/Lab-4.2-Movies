using System;
using System.Collections.Generic;

namespace Lab_4._2_Movies
{
    class Movie
    {
        private string _title;
        private string _catagory;

        public Movie(string Title, string Catagory)
        {
            _title = Title;
            _catagory = Catagory;  
        }

        public string Title
        {
            get
            {
                return _title;
            }
        }

        public string Catagory
        {
            get
            {
                return _catagory;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Movie List!");

            List<Movie> listMovies = new List<Movie>();
            
            listMovies.Add(new Movie("Toy Story", "Animated"));
            listMovies.Add(new Movie("Fantasia", "Animated"));
            listMovies.Add(new Movie("Wall-E", "Animated"));
            listMovies.Add(new Movie("The Nightmare Before Chrsitmas", "Animated"));
            listMovies.Add(new Movie("Aaddin", "Animated"));
            listMovies.Add(new Movie("Bambi", "Animated"));
            listMovies.Add(new Movie("The Lion King", "Animated"));
            listMovies.Add(new Movie("The Sword in the Stone", "Animated"));
            listMovies.Add(new Movie("Joker", "Drama"));
            listMovies.Add(new Movie("Jarhead", "Drama"));
            listMovies.Add(new Movie("Life of PI", "Drama"));
            listMovies.Add(new Movie("Good Will Hunting", "Drama"));
            listMovies.Add(new Movie("Top Gun", "Drama"));
            listMovies.Add(new Movie("Braveheart", "Drama"));
            listMovies.Add(new Movie("Forest Gump", "Drama"));
            listMovies.Add(new Movie("Valerian and the City of a Thousand Planets", "Scifi"));
            listMovies.Add(new Movie("Ad Astra", "Scifi"));
            listMovies.Add(new Movie("Looper", "Scifi"));
            listMovies.Add(new Movie("Avengers: Infinity War", "Scifi"));
            listMovies.Add(new Movie("Avergers: Endgame", "Scifi"));
            listMovies.Add(new Movie("Independence Day", "Scifi"));
            listMovies.Add(new Movie("The Predator", "Scifi"));
            listMovies.Add(new Movie("Men in Black", "Scifi"));
            listMovies.Add(new Movie("Star Trek into Darkness", "Scifi"));
            listMovies.Add(new Movie("The Hills Have Eyes", "Horror"));
            listMovies.Add(new Movie("The People Under the Stairs", "Horror"));
            listMovies.Add(new Movie("Child's Play", "Horror"));
            listMovies.Add(new Movie("Friday the 13th", "Horror"));
            listMovies.Add(new Movie("A Nightmare on Elm Street", "Horror"));
            listMovies.Add(new Movie("Halloween", "Horror"));
            listMovies.Add(new Movie("House on Haunted Hill", "Horror"));
            listMovies.Add(new Movie("Thirteen Ghosts", "Horror"));
            
            listMovies.Sort((x, y) => x.Title.CompareTo(y.Title)); // Could you please explain this more.. I kinda get it but not 100%

            bool moreMovies = true;

            while (moreMovies)
            {
                Console.WriteLine($"There are {listMovies.Count} movies in the list.");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("What category are you interested in?");
                Console.WriteLine("1.) Animated");
                Console.WriteLine("2.) Drama");
                Console.WriteLine("3.) Horror");
                Console.WriteLine("4.) Scifi");
                Console.WriteLine();
                Console.Write("Make a choice:");

                string choice = Console.ReadLine().ToUpper();

                if (choice == "1" || choice == "AMIMATED")
                {
                    Console.Clear();
                    foreach (var m in listMovies)
                    {
                        if (m.Catagory == "Animated")
                        {
                            Console.WriteLine(m.Title);
                        }
                    }
                }
                else if (choice == "2" || choice == "DRAMA")
                {
                    Console.Clear();
                    foreach (var m in listMovies)
                    {
                        if (m.Catagory == "Drama")
                        {
                            Console.WriteLine(m.Title);
                        }
                    }
                }
                else if (choice == "3" || choice == "HORROR")
                {
                    Console.Clear();
                    foreach (var m in listMovies)
                    {
                        if (m.Catagory == "Horror")
                        {
                            Console.WriteLine(m.Title);
                        }
                    }
                }
                else if (choice == "4" || choice == "SCIFI")
                {
                    Console.Clear();
                    foreach (var m in listMovies)
                    {
                        if (m.Catagory == "Scifi")
                        {
                            Console.WriteLine(m.Title);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("~~~That is not a valid category!~~~");
                    Console.WriteLine("~~~Please make a valid choice.~~~");
                    Console.WriteLine();
                    continue;
                }

                Console.WriteLine();
                Console.Write("Would you like to look up more movies? (y/n):");
                string keepgoing = Console.ReadLine().ToUpper();
                if (keepgoing == "N")
                {
                    moreMovies = false;
                    Console.WriteLine("Thank you for looking at our movies!");
                    Console.WriteLine("Goodbye!");
                }
                else if(keepgoing != "Y")
                {
                    Console.WriteLine("That is not a valid input.Looking up more movies!");
                    continue;
                }
            } // end of while
        }
    }
}
