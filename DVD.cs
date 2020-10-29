using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Lab
{
    class DVD : Movie
    {
        public int CurrentTime { get; set; } = 0;


        public DVD(string Title, Genre Category, int RunTime, List<string> Scenes)
            : base(Title, Category, RunTime, Scenes)
        {

        }

        public override void Play()
        {
            Console.WriteLine("Which scene would you like to watch? Enter the corresponding number.");
            PrintScenes();
            int.Parse(Console.ReadLine());

            for (int i = 0; i < Scenes.Count; i++)
            {
                string scene = Scenes[i];
                Console.WriteLine($"{i}: {scene}");
            }
            Console.WriteLine("Would you like to play another scene? y/n");

            string sceneSelect = Console.ReadLine();
            if (sceneSelect == "y" || sceneSelect == "Y")
            {
                Play();
            }
            else
            {
                Console.WriteLine("okay bye!");
            }
        }
    }
}
