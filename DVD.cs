using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Lab
{
    class DVD : Movie
    {
        public DVD(string _title, Genre _category, int _RunTime, List<string> _scenes) : base(_title, _category, _RunTime, _scenes)
        {

        }
        public override void Play()
        {
            bool again;
            do
            {
                Console.WriteLine($"What scene would you like to watch?");
                PrintScenes();
                try
                {
                    int sceneSelected = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{Scenes[sceneSelected]}\n");
                    again = false;
                }
                catch
                {
                    Console.WriteLine("That is not a valid option, please try again.");
                    again = true;
                }

            }
            while (again == true);

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
