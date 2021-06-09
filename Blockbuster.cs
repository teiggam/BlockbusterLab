using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Lab
{
    class Blockbuster
    {
        public List<Movie> Movies { get; set; } = new List<Movie> { };

        public Blockbuster()
        {
            List<string> mgScenes = new List<string> { "Until today, I was homeschooled.", "Your mom's chest hair!", "That is so fetch!", "Omigod, Danny Devito, I love your work!", "Is butter a carb?", "The girls have gone wild!", "She doesn't even go here!", "The limit does not exist!" };
            List<string> mrScenes = new List<string> { "Lady Marmalade", "Your Song", "Elephant Love Medley", "Come What May", "Like a Virgin", "The Show Must Go On", "And in the end, everyone died" };
            List<string> dScenes = new List<string> { "Beatrice takes her aptitude test", "The Choosing Ceremony", "Welcome to Dauntless", "Tris gets beat up by Peter", "Tris visits Caleb", "Tris goes into Four's fear simulation", "Erudie mind controls Dauntless", "Tris saves the day... for now" };
            List<string> tScenes = new List<string> { "Treasure hunters find a mysterious safe from the Titanic in the Atlantic", "Rose and her mom board the Titanic", "Jack stops Rose from jumping", "The ship hits an iceberg", "Rose flees her mother to find an imprisoned Jack", "All the life boats have departed", "Rose climbs onto a wooden panel and leaves Jack in the water", "Rose throws the necklace in the ocean" };
            List<string> sScenes = new List<string> { "Dude wakes up in a bathtub", "Two dudes learn they are in a game by Jigsaw", "Learn about booby traps", "Lawrence saws off his foot", "Game Over" };
            List<string> tfiosScenes = new List<string> { "Hazel is in remission", "Hazel meets Augusts Waters at a cancer support group", "Gus tracks down Peter Van Houten", "Hazel and Gus go to Amsterdam", "Gus' cancer returns", "Gus has a pre-funeral and has his friends give eulogies", "Gus dies from cancer", "This movie is sad" };

            Movies.Add(new DVD("Mean Girls", Genre.Comedy, 97, mgScenes));
            Movies.Add(new VHS("Moulin Rouge", Genre.Romance, 130, mrScenes));
            Movies.Add(new DVD("Divergent", Genre.Action, 139, dScenes));
            Movies.Add(new VHS("Titanic", Genre.Drama, 210, tScenes));
            Movies.Add(new VHS("Saw", Genre.Horror, 103, sScenes));
            Movies.Add(new DVD("The Fault in Our Stars", Genre.Drama, 133, tfiosScenes));

        }

        public virtual void PrintMovies()
        {
            for (int sc = 0; sc < Movies.Count; sc++)
            {
                Console.WriteLine($"{sc}: {Movies[sc].Title}");
            }
            Console.WriteLine();
        }



        public virtual Movie CheckOut()
        {
            bool again;
            do
            {
                PrintMovies();
                Console.WriteLine("\nWhich movie would you like to checkout? (Enter number)\n");
                try
                {
                    string input = Console.ReadLine();
                    int userIn = int.Parse(input);
                    Movie movieChoice = Movies[userIn];
                    movieChoice.PrintInfo();
                    again = false;
                    return movieChoice;

                }
                catch
                {
                    Console.WriteLine("That option is not available.  Please try again.");
                    string input = Console.ReadLine();
                    int userIn = int.Parse(input);
                    Movie movieChoice = Movies[userIn];
                    movieChoice.PrintInfo();
                    again = false;
                    return movieChoice;

                }

            }
            while (again == true);
        }
    }
}




