using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Blockbuster_Lab
{
    abstract class Movie
    {
        public string Title { get; set; }
        public Genre Category { get; set; }

        public int RunTime { get; set; }

        public List<string> Scenes { get; set; }

        public Movie(string _title, Genre _category, int _RunTime, List<string> _Scenes)
        {
            this.Title = _title;
            this.Category = _category;
            this.RunTime = _RunTime;
            this.Scenes = _Scenes;
        }


        public void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Title: {Title}\nCategory: {Category}\nRuntime: {RunTime} minutes\n");
        
        }
        public void PrintScenes()
        {
            for (int sc = 0; sc < Scenes.Count; sc++)
            {
                Console.WriteLine($"{sc}: {Scenes[sc]}");
            }

        }

        public abstract void Play();


        public abstract void PlayWholeMovie();


    }
}
