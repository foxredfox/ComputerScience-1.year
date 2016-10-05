using System;

namespace _02_Bottles
{
    internal class Song
    {
        String noBottles = "No more bottles of beer on the wall.";
        String takeDown  = " Take one down and pass it around. ";
        String bottle_A  = "1 bottle of beer on the wall.";
        String bottle_B  = " 1 bottle of beer.";
        String bottles_A = " bottles of beer on the wall. ";
        String bottles_B = " bottles of beer.";
        
        internal string CountBottles(int v)
        {
            switch(v)
            {
                case 0:
                    return " " + noBottles;
                case 1:
                    return CountOneBottle();
                default:
                    return CountToOneBottle(v) + CountOneBottle();
            }
        }

        private string CountOneBottle()
        {
            return bottle_A + bottle_B + takeDown + noBottles;
        }

        private string CountToOneBottle(int v)
        {
            string s = "";

            for(int i = v; i > 1; i--)
            {
                s += i.ToString() + bottles_A + i.ToString() + bottles_B + takeDown;

                if(i != 2)
                    s += (i - 1).ToString() + bottles_A;
            }

            return s + bottle_A + " ";
        }
    }
}