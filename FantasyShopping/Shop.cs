using System;
using System.Collections.Generic;
using System.Text;

namespace FantasyShopping
{
    public class Shop
    {
        public static void Start()
        {
            Inventory Bob = new Inventory();
            Bob.setGold(5);
            Console.WriteLine("Bob has: "+ Bob.getGold() +" gold pieces");
        }
        /*static Inventory createCharacter()
        {
            Console.Clear();
            while ()
            Console.WriteLine("Choose your lineage\n1)Noble\n2)Warrior\n3)Hermit");
            int  Console.ReadLine();
            Console.WriteLine("What is your name.\n");
            Inventory Player = new Inventory();
            Player.setGold(5);
            return Player;
        }*/

        // Might want a UI eventually, to count all the gold and rations left.
    }
}
