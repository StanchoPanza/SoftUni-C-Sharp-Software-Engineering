using System;
using System.Collections.Generic;

namespace Songs
{
    public class Song
    {
        public string Type { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }
    }
    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] currentSong = Console.ReadLine().Split("_", StringSplitOptions.RemoveEmptyEntries);

                string type = currentSong[0];
                string name = currentSong[1];
                string time = currentSong[2];

                Song newSong = new Song()
                {
                    Type = type,
                    Name = name,
                    Time = time
                };
                songs.Add(newSong);
            }
            string command = Console.ReadLine();

            if (command == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                List<Song> filteredSongs = songs.FindAll(song => song.Type == command);

                foreach (Song song in filteredSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}
