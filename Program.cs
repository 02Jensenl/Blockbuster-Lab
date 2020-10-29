using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace Blockbuster_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BlockBuster!");

            BlockBuster bb = new BlockBuster();
           
            Movie m = bb.Checkout();

            Console.WriteLine("You selected");
            m.PrintInfo();
        

            Console.WriteLine("Do you want to play this movie? y/n");
            string inputPlay = Console.ReadLine();

            if (inputPlay == "y" || inputPlay == "Y")
            {
                m.Play();
            }
            else
            {
                Console.WriteLine("you didn't select y. Okay.....bye...");
                return;
            }
        }
        
    }
}

