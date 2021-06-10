using System;
using System.Collections.Generic;

namespace Blockbuster_Lab
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"Welcome to Digital Blockbuster!");
            Console.WriteLine("We currently have the following movies:\n");
            Blockbuster bb = new Blockbuster();

            bool repeat;
            do
            {
                Movie userMovie = bb.CheckOut();

                Console.WriteLine("Do you want to watch the whole movie or a scene from the movie? (whole/scene)");
                string resp = Console.ReadLine().ToLower();
                Console.WriteLine();

                if (resp == "whole")
                {
                    userMovie.PlayWholeMovie();
                    Console.WriteLine();
                }


                else if (resp == "scene")
                {

                    userMovie.Play();

                    bool goOn;
                    do
                    {
                        Console.WriteLine("Would you like to watch another scene?(y/n)");
                        string anotherScene = Console.ReadLine().ToLower();
                        if (anotherScene == "y")
                        {
                            userMovie.Play();
                            goOn = true;
                        }
                        else
                        {
                            goOn = false;
                        }
                    }
                    while (goOn == true);
                }
                Console.WriteLine();
                Console.WriteLine("Would you like to checkout another movie? (y/n)");
                string anotherMovie1 = Console.ReadLine().ToLower();
                if (anotherMovie1 == "y")
                {
                    repeat = true;
                }
                else
                {
                    repeat = false;
                }
            }
            while (repeat == true);

            Console.WriteLine("Good bye!");
        }

    }
}
