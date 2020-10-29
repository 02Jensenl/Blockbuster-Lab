using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Lab
{
    class VHS : Movie
    {
        public int CurrentTime { get; set; } = 0;


        public VHS(string Title, Genre Category, int RunTime, List<string> Scenes)
            : base(Title, Category, RunTime, Scenes)
        {

        }


        public override void Play()
        {
            for (int i = 0; i < Scenes.Count; i++)
            {
                string scene = Scenes[CurrentTime];
                Console.WriteLine(CurrentTime + ":" + scene);
                CurrentTime++;
                
            }
            Console.WriteLine();
            Console.WriteLine("Hope you enjoyed the movie! Would you like to rewind the VHS? y/n");

            string inputRewind = Console.ReadLine();
            if (inputRewind == "y" || inputRewind == "Y")
            {
                Rewind();
                Console.WriteLine("Thanks for rewinding!");
            }
            else
            {
                
                Rewind();
                Console.WriteLine("Since you were uncapable of rewinding, I did it for you. You're welcome.");
            }
        }
    


        public void Rewind()
        {
            CurrentTime = 0;
        }
    }
}
