using System;
using System.Collections.Generic;
using System.Text;

namespace Blockbuster_Lab
{
    class BlockBuster
    {
        public List<Movie> Movies { get; set; } = new List<Movie>();

        public BlockBuster()
        {



            List<string> scenesJoeCandle = new List<string>();
            scenesJoeCandle.Add("Bad guys break into Joe's house and destroys his peace lily");
            scenesJoeCandle.Add("Joe goes on a killing spree");
            scenesJoeCandle.Add("Everyone is trying to kill Joe because there is a bounty on his head");
            scenesJoeCandle.Add("Joe gets stabbed but he's fine");
            scenesJoeCandle.Add("Joe gets a new peace lily");
            VHS v1 = new VHS("Joe Candle ", Genre.Action, 123, scenesJoeCandle);

            List<string> scenesSilverMouth = new List<string>();
            scenesSilverMouth.Add("Agent 9997 must save the world from blowing up");
            scenesSilverMouth.Add("9997's friend turns out to be a bad guy");
            scenesSilverMouth.Add("''No, for me.''");
            scenesSilverMouth.Add("Saves the world and gets the girls");
            VHS v2 = new VHS("Silver Mouth", Genre.Action, 150, scenesSilverMouth);

            List<string> scenes4thSense = new List<string>();
            scenes4thSense.Add("A child can communicate with food");
            scenes4thSense.Add("No one believes the child");
            scenes4thSense.Add("The child helps a food in need to unvocer a mystery");
            scenes4thSense.Add("The child was talking to a lollipop the entire time");
            VHS v3 = new VHS("The 4th Sense", Genre.Action, 100, scenes4thSense);

            List<string> scenesLoveVampire = new List<string>();
            scenesLoveVampire.Add("Girl meets guy and they date");
            scenesLoveVampire.Add("Girl finds out that her boyfriend is a vampire");
            scenesLoveVampire.Add("Bad vampires attack the girl, but the vampire boyfriend saves the day");
            scenesLoveVampire.Add("Girl loves her vampire boyfriend, even though he is a vampire");
            DVD d1 = new DVD("I love a Vampire", Genre.Action, 92, scenesLoveVampire);

            List<string> scenesMelancholyGilless = new List<string>();
            scenesMelancholyGilless.Add("Melancholy wanted to be a pro soccer player but he wasn't good enough");
            scenesMelancholyGilless.Add("He kicked a football and it went really far, and someone noticed");
            scenesMelancholyGilless.Add("Reluctantly joined a football kicking contest, but needed to money to keep him from bankruptcy");
            scenesMelancholyGilless.Add("Won the kicking contest and is financially stable for now");
            DVD d2 = new DVD("Melancholy Gilless", Genre.Action, 110, scenesMelancholyGilless);

            List<string> scenesIcarus7 = new List<string>();
            scenesIcarus7.Add("Astronauts launch into space in hopes to land on Mercury");
            scenesIcarus7.Add("Spaceship breaks and they cannot land");
            scenesIcarus7.Add("back on Earth, Mission Control scrambles to find a way to get the astronauts home");
            scenesIcarus7.Add("The astronauts makes it back to Earth safely.");
            DVD d3 = new DVD("Icarus 7", Genre.Action, 92, scenesIcarus7);


            Movies.Add(v1);
            Movies.Add(v2);
            Movies.Add(v3); 
            Movies.Add(d1);
            Movies.Add(d2);
            Movies.Add(d3);



        }

        public void PrintMovieTitles()
        {
            for (int i = 0; i < Movies.Count; i++)
            {
                Movie m = Movies[i];
                Console.WriteLine(i + ":" + m.Title);
            }
        }


        public Movie Checkout()
        {
            Console.WriteLine("Please select a movie from the following list:");
            PrintMovieTitles();
            string input = Console.ReadLine();
            int index = int.Parse(input);

            Movie output = Movies[index];

            return output;
        }
    }
}
