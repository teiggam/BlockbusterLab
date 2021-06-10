using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Lab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; } = 0;
        public VHS(string _title, Genre _category, int _RunTime, List<string> _scenes)
            : base(_title, _category, _RunTime, _scenes) { }


        public override void Play()
        {
            string scene = Scenes[CurrentTime];
            Console.WriteLine(scene);
            CurrentTime++;
            for (int sc = 0; sc < Scenes.Count; sc++)
                if (CurrentTime == Scenes.Count)
                {
                    Console.WriteLine("That is the end of the movie.  Be kind, rewind.\n");
                    Rewind();
                }
        }
        public void Rewind()
        {
            CurrentTime = 0;
        }
        public override void PlayWholeMovie()
        {
            foreach (string scene in Scenes)
            {
                Console.WriteLine($"{scene}");
            }
        }
    }

}
