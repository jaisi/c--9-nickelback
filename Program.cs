using System;
using System.Collections.Generic;


namespace nickleback
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            List<(string band, string song)> goodSongs = new List<(string, string)>();
            HashSet<(string, string)> allSongs = new HashSet<(string, string)>();

            allSongs.Add(("Nickelback", "Song1"));
            allSongs.Add(("band2", "Song2"));
            allSongs.Add(("band3", "Song3"));
            allSongs.Add(("band4", "Song4"));
            allSongs.Add(("band2", "Song5"));
            allSongs.Add(("Nickelback", "Song6"));
            allSongs.Add(("Nickelback", "Song7"));

            Console.WriteLine("All the songs are:");
            foreach(var song in allSongs)
            {
                Console.WriteLine(song.Item1 + " " + song.Item2);
                if(song.Item1 != "Nickelback")
                {
                    goodSongs.Add((song.Item1, song.Item2));
                }
                
            }
            
            Console.WriteLine("The good songs are: ");
            foreach(var g in goodSongs){
                 Console.WriteLine(g.band + " " + g.song);
            }
           



        }
    }
}
