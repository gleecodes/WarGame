using System;
using System.Collections.Generic;



// add COMMENTS inside of Turn/Compare/etc to track game flow
// add some sort of LOOP to run the game all the way through
    // ask Tom...
// figure out how to get player input using Console.ReadLine



namespace WAR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lets play WAR!");
            Player Gina = new Player ("Gina");
            System.Console.WriteLine($"Welcome player {Gina.Name}");
            Player Brent = new Player ("Brent");
            System.Console.WriteLine($"Welcome player {Brent.Name}");
            War Game1 = new War(Gina, Brent);
            Game1.StartGame();

            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            Game1.Turn();
            Game1.Compare();
            
            
            
            




            
            // newDeck.shuffle();

            // // Deals out half the deck to each player
            // Program p = new Program();
            // p.StartGame(gina, brent, newDeck);
            


        }

    }
}

