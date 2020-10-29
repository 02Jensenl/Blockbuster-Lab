using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Blockbuster_Lab
{
    abstract class Movie
    {

        public string Title { get; set; }
        public Genre Category { get; set; }
        //public string Genre { get; set; }
        public int RunTime { get; set; }

        public List<string> Scenes { get; set; }


        public Movie(string Title, Genre Category, int RunTime, List<string> Scenes)
        {
            this.Title = Title;
            this.Category = Category;
            this.RunTime = RunTime;
            this.Scenes = Scenes;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Category: " + Category);
            Console.WriteLine("Runtime: " + RunTime + " minutes");
            //PrintScenes();
        }

        public void PrintScenes()
        {
            for (int i = 0; i < Scenes.Count; i++) 
            {
                string scene = Scenes[i];
                Console.WriteLine($"{i}: {scene}");
            }
        }
        
        public abstract void Play();

    }
}
