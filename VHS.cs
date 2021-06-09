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
